using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramBot_v2
{
    public partial class AddButton : UserControl
    {
        Form1 Form;
        public AddButton(Form1 form)
        {
            Form = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                var testDialog = new AddCategoryDialog();
                if (testDialog.ShowDialog(this) != DialogResult.OK)
                {
                    ChanelsRepository.Create(testDialog.Name);
                }
                testDialog.Dispose();
                Form.UpdatePanel();
        }
    }
}
