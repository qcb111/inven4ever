using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WellInfoManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            connectServer_Form loginForm = new connectServer_Form();
            loginForm.Show();
            loginForm.Activate();
        }

        private void deleteResults_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
