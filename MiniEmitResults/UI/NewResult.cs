using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniEmitResults
{
    public partial class NewResult : Form
    {
        public string returnName { get; set; }

        public NewResult(int time, int ranking)
        {
            InitializeComponent();
            label1.Text = $@"Tuloksesi oli {time} sekuntia. Sijoitus tällä hetkellä {ranking}.
                            Kirjoita nimi alle ja paina OK.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            returnName = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            returnName = null;
            this.Close();
        }
    }
}
