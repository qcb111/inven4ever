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
    public partial class Import_Form : Form
    {
        public Import_Form()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string filePath = tbFilePathName.Text;
            if (@filePath != "")
            {
                if (@filePath.Contains("xls"))//判断文件是否存在
                {
                    ImportDB importDB = new ImportDB();
                    if (importDB.ReadExcel(@filePath))
                    {
                        MessageBox.Show("Successful import !");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Import failed !");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid file path!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid file path!");
            }
        }
    }
}
