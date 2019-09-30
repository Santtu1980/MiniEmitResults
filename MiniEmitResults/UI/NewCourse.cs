using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniEmitResults.UI
{
    public partial class NewCourse : Form
    {
        public NewCourse()
        {
            InitializeComponent();
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            var inputCourseName = txt_courseName.Text;
            var inputCourseLength = txt_courseLength.Text;
            var inputCheckPoints = txt_checkPoints.Text.Replace(" ", "");
            var inputErrorString = string.Empty;
            var inputError = false;
            // check inputs
            if(inputCourseName.Length <= 0)
            {
                inputErrorString = "Check course name." + Environment.NewLine;
                inputError = true;
            }
            if(!Int32.TryParse(inputCourseLength, out int courseLength_m))
            {
                inputErrorString += $"Could not parse '{txt_courseLength.Text}' to a number." + Environment.NewLine;
                inputError = true;
            }
            if(!inputCheckPoints.Contains(','))
            {
                inputErrorString += "Check checkpoints" + Environment.NewLine;
                inputError = true;
            }
            if(!IsDigitsOrDotsOnly(inputCheckPoints))
            {
                inputErrorString += "Checkpoints contains unaccepted chars" + Environment.NewLine;
                inputError = true;
            }
            if(inputError) return;

            var checkPoints = inputCheckPoints.Split(',').Select(Int32.Parse).ToList();


            //Create XML file
            var foo = 1;
        }

        private bool IsDigitsOrDotsOnly(string str)
        {
            foreach(char c in str)
            {
                if(c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || c == ',')
                    continue;

                return false;
            }

            return true;
        }
    }
}
