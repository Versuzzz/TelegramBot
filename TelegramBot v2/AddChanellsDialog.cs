using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramBot_v2
{
    public partial class AddChanellsDialog : Form
    {
        public string Name;
        public AddChanellsDialog()
        {
            InitializeComponent();
        }
        private void AddChanell_Click(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            this.Close();
        }
    }
}
