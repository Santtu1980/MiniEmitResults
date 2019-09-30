using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using MiniEmitResults.UI;
using MTRSerial;
using MTRSerial.Enumerations;
using MTRSerial.ValueObjects;

namespace MiniEmitResults
{
    public partial class MainForm : Form
    {
        private readonly MTRSerialPort _serialPort;
        private MTRResponse _emitData;
        private int _lastReadEmitCardNumber = 0;

        public MainForm()
        {
            InitializeComponent();
            _serialPort = new MTRSerialPort();
            _serialPort.EmitDataReceived += GetData;
            _serialPort.SerialPortOpened += SerialPortOpened;
            _serialPort.SerialPortClosed += SerialPortClosed;
            _serialPort.MTRCommunication += SerialCommunication;
        }

        public void GetData(object sender, EventArgs e)
        {
            _emitData = _serialPort.EmitDataMtrResponse;


            if(_emitData.EmitCardNumber.Equals(_lastReadEmitCardNumber)) return;

            BeginInvoke(new MethodInvoker(delegate
            {
                //TODO check here that all check point found
                //CheckCourses(_emitData);
                var time = GetTime(_emitData.CheckPoints);
                time =_emitData.FinalResult;
                var ranking = GetRanking(time);
                var name = "";
                using (var form = new NewResult(time, ranking))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        name = form.returnName;
                    }
                }

                if (name != null)
                {
                    WriteToFile(time, name, _emitData.EmitCardNumber);
                }

                ReadResultsToDataGridView();
            }));
            _lastReadEmitCardNumber = _emitData.EmitCardNumber;
        }

        private void WriteToFile(int time, string name, int emitCardNumber)
        {
            using(System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Temp\Results.txt", true))
            {
                file.WriteLine(DateTime.Now.ToString("YYYY-MM-dd HH:mm:ss") + ";"+ time + ";" + name + ";" + emitCardNumber);
            }
        }

        private int GetTime(List<MTRDataCheckPoint> emitDataCheckPoints)
        {
            var finishTime = 0;
            foreach (var checkCheckPoint in emitDataCheckPoints)
            {
                if (checkCheckPoint.CodeN != 0)
                {
                    finishTime = checkCheckPoint.TimeN_s;
                }
                else
                {
                    break;
                }
            }

            return finishTime;
        }

        public void SerialPortOpened(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate { label1.BackColor = Color.LawnGreen; }));
            BeginInvoke(new MethodInvoker(delegate { label1.Text = _serialPort.GetComPortName; }));
        }

        public void SerialPortClosed(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate { label1.BackColor = Color.Red; }));
            BeginInvoke(new MethodInvoker(delegate { label1.Text = "PORT CLOSED"; }));
        }

        public void SerialCommunication(object sender, EventArgs e)
        {
            var command = (MTRCommandEventArgs) e;
            BeginInvoke(new MethodInvoker(delegate { richTextBox2.Text = command.Command + " " + command.Data; }));
        }
        
        private void btn_OpenSerialPort_Click(object sender, EventArgs e)
        {
            _serialPort.OpenSerialPort();
        }

        private void btn_closeSerialPort_Click(object sender, EventArgs e)
        {
            _serialPort.CloseSerialPort();
        }

        private void btn_readStatus_Click(object sender, EventArgs e)
        {
            ReadResultsToDataGridView();
        }

        private int GetRanking(int time)
        {
            var results = ReadResultsFromFile();
            var tempResult = new Result();
            tempResult.EmitCardNumber = 999999;
            tempResult.Name = "Temp";
            tempResult.Time = time;
            results.Add(tempResult);

            var orderedResults = results.OrderBy(x => x.Time);
            var ranking = 0;
            foreach (var result in orderedResults)
            {
                ranking++;
                if (result.Time.Equals(time))
                    return ranking;
            }

            return -1;
        }

        public List<Result> ReadResultsFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Temp\Results.txt");
            var results = new List<Result>();

            foreach(string line in lines)
            {
                string[] resultRow = line.Split(';');
                if(resultRow.Length != 4) continue;
                
                try
                {
                    results.Add(new Result()
                    {
                        Time = int.Parse(resultRow[1]),
                        Name = resultRow[2],
                        EmitCardNumber = int.Parse(resultRow[3])
                    });


                }
                catch (Exception e)
                {
                    richTextBox2.Text = e.Message;
                }
            }

            return results;
        }

        public void ReadResultsToDataGridView()
        {
            // TODO Check this
            if(!dgv_Results.Columns.Contains("Sija"))
                dgv_Results.Columns.Add("Sija", "Sija");
            var results = ReadResultsFromFile();

            var orderedResults = results.OrderBy(x => x.Time);
            var binding = new BindingSource
            {
                DataSource = orderedResults
            };
            try
            {
                dgv_Results.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgv_Results.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv_Results.DataSource = binding;

                dgv_Results.ClearSelection();
                dgv_Results.Columns["Time"].HeaderText = "Aika (s)";
                dgv_Results.Columns["Name"].HeaderText = "Nimi";
                dgv_Results.Columns["EmitCardNumber"].HeaderText = "Emit numero";
                foreach(DataGridViewRow row in dgv_Results.Rows)
                {
                    row.Cells["Sija"].Value = String.Format("{0}", row.Index + 1);
                }
            }
            catch (Exception e)
            {
                richTextBox2.Text = e.Message;
            }

        }

        private void btn_readPorts_Click(object sender, EventArgs e)
        {
            //show list of valid com ports
            foreach(string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
        }

        private void Tab_course1_MouseClick(object sender, MouseEventArgs e)
        {
                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Add("Item 1");
                cm.MenuItems.Add("Item 2");

                tabControl_Courses.ContextMenu = cm;
        }

        private void Form1_Click(object sender, EventArgs e)
        {


        }

        private void TabControl_Courses_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Item 1");
            cm.MenuItems.Add("Item 2");
            tabControl_Courses.ContextMenu = cm;
            cm.Show(this, this.PointToClient(Cursor.Position));
        }

        private void Btn_createCourse_Click(object sender, EventArgs e)
        {
            var course = new NewCourse();
            course.ShowDialog();
        }
    }
    public class Result
    {
        public int Time { get; set; }
        public string Name { get; set; }
        public int EmitCardNumber { get; set; }
    }
}
