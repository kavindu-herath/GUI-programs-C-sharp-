using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class FrmGreet : Form
    {
        public FrmGreet()
        {
            InitializeComponent();
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            string Username = textUsername.Text;
            //Displaying a message box
            MessageBox.Show($"Hello {Username}, from Desktop Appilications");
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
