using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sql;

namespace WellInfoManagement
{
    public partial class searchItems_Form : Form
    {
        connectServer_Form mainForm;
        Query_Form queryForm;

        public searchItems_Form()
        {
            InitializeComponent();
            AddOneLine();
        }
        public searchItems_Form(connectServer_Form _mainForm, Query_Form _queryForm):this()
        {
            mainForm = _mainForm;
            queryForm = _queryForm;
        }

        //2 group of + and - button;
        //3 group of comboBoxes: and/or, item, operator
        //1 group of textBox: value
        private static int maxLineCount = 8;
        private int effectiveLineCount = 0;

        private int horizontalGapOfControls = 20;
        private int verticalGapOfLines = 30;
        private int heightOfLines = 20;
        public Button[,] addAndCutLines = new Button[maxLineCount, 2];
        public ComboBox[,] comboBoxesInLines = new ComboBox[maxLineCount, 3];
        public TextBox[] valueOfSearch = new TextBox[maxLineCount];

        public int EffectiveLineCount
        {
            get
            {
                return effectiveLineCount;
            }

            set
            {
                effectiveLineCount = value;
            }
        }

        //public int EffectiveLineCount { get => effectiveLineCount; set => effectiveLineCount = value; }

        private void AddOneLine()
        {
            int i = EffectiveLineCount;
            for (int j = 0; j < 2; j++)
            {
                addAndCutLines[i, j] = new Button
                {
                    Height = heightOfLines,
                    Width = heightOfLines
                };
                if (j == 0 && i< maxLineCount)
                {
                    addAndCutLines[i, j].Text = "+";
                    addAndCutLines[i, j].Click += new EventHandler(this.addLineButton_Click);
                }
                if(j==1 && i>0)
                {
                    addAndCutLines[i, j].Text = "-";
                    addAndCutLines[i, j].Click += new EventHandler(this.cutLineButton_Click);
                }                    
                addAndCutLines[i, j].Location = new Point(20 + (addAndCutLines[i, j].Width+ horizontalGapOfControls) * j, i * verticalGapOfLines + 10);
                this.Controls.Add(addAndCutLines[i, j]);
            }

            for (int j = 0; j < 3; j++)
            {
                comboBoxesInLines[i, j] = new ComboBox
                {
                    Height = heightOfLines,
                    Width = 3 * heightOfLines
                };
                if (j == 0)
                    AddComboboxItemsAndOr(i,j);
                else if (j == 1)
                    AddComboboxItemsTableItems(i, j);
                else
                    AddComboboxItemsOperator(i, j);

                comboBoxesInLines[i, j].Location =
                    new Point(addAndCutLines[0, 1].Location.X + addAndCutLines[0, 1].Width + horizontalGapOfControls + (comboBoxesInLines[i, j].Width + horizontalGapOfControls) * j
                    , i * verticalGapOfLines + 10);
                this.Controls.Add(comboBoxesInLines[i, j]);
            }
            valueOfSearch[i] = new TextBox
            {
                Height = heightOfLines,
                Width = 3 * heightOfLines,
                Location =
                    new Point(comboBoxesInLines[0, 2].Location.X + comboBoxesInLines[0, 2].Width + horizontalGapOfControls
                    , i * verticalGapOfLines + 10)
            };
            this.Controls.Add(valueOfSearch[i]);

            if (i == 0)
            {
                addAndCutLines[0, 1].Enabled = false;
                comboBoxesInLines[0, 0].Enabled = false;
            }
            if (i == maxLineCount - 1)
            {
                addAndCutLines[i, 0].Enabled = false;
            }
        }

        private void cutLineButton_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(addAndCutLines[EffectiveLineCount, 0]);
            this.Controls.Remove(addAndCutLines[EffectiveLineCount, 0]);
            this.Controls.Remove(addAndCutLines[EffectiveLineCount, 1]);
            this.Controls.Remove(comboBoxesInLines[EffectiveLineCount, 0]);
            this.Controls.Remove(comboBoxesInLines[EffectiveLineCount, 1]);
            this.Controls.Remove(comboBoxesInLines[EffectiveLineCount, 2]);
            this.Controls.Remove(valueOfSearch[EffectiveLineCount]);
            EffectiveLineCount--;
            addAndCutLines[EffectiveLineCount, 0].Enabled = true;
            addAndCutLines[EffectiveLineCount, 1].Enabled = true;
        }

        private void addLineButton_Click(object sender, EventArgs e)
        {
            addAndCutLines[EffectiveLineCount, 0].Enabled = false;
            addAndCutLines[EffectiveLineCount, 1].Enabled = false;
            EffectiveLineCount++;            
            AddOneLine();
        }

        private void AddComboboxItemsOperator(int i, int j)
        {
            comboBoxesInLines[i, j].Items.Add(">");
            comboBoxesInLines[i, j].Items.Add("<");
            comboBoxesInLines[i, j].Items.Add("=");
        }

        private void AddComboboxItemsTableItems(int i, int j)
        {
            //add items of the tabel in database
        }

        private void AddComboboxItemsAndOr(int i, int j)
        {
            comboBoxesInLines[i, j].Items.Add("and");
            comboBoxesInLines[i, j].Items.Add("or");
        }

        private void sendRequest_btn_Click(object sender, EventArgs e)
        {
            string sqlCmd = GenerateSqlSearchCommand();
            MessageBox.Show(sqlCmd);
            queryForm.Show();
            DataSet set = new DataSet();
            this.mainForm.sqlServer.Query(sqlCmd, ref set);
            //((connectServer_Form)Parent).sqlServer.Query(sqlCmd, ref set);
            queryForm.queryResult_dgv.DataSource = set.Tables[0];
            if(set.Tables[0].Rows.Count>0)
            {
                queryForm.queryResult_dgv.Columns[0].ReadOnly = true;
            }
            this.Close();
        }



        private string GenerateSqlSearchCommand()
        {
            string tabelName = "Well_Info";
            string sqlCmd = "select * from " + tabelName + " where ";
            for (int i = 0; i <= EffectiveLineCount; i++)
            {
                if(i>0)
                {
                    sqlCmd += comboBoxesInLines[i, 0].Text;
                    sqlCmd += " ";
                }
                sqlCmd += comboBoxesInLines[i, 1].Text;
                sqlCmd += " ";
                sqlCmd += comboBoxesInLines[i, 2].Text;
                sqlCmd += " ";
                sqlCmd += valueOfSearch[i].Text;
                sqlCmd += " ";
            }
            return sqlCmd;
        }
    }


}
