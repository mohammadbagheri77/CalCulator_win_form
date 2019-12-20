using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalCulator_win
{
    public partial class data : Form
    {
        public data()
        {
            InitializeComponent();
        }
        public string _show { get; set; }
        public Form2 fnOj { get; set; }
        private void Btn_2_Click(object sender, EventArgs e)
        {
// string authors = "1*x^2+1*z^3+2*t^4=0";     1*x^1+2*z^1=0        2*x^2+1*z^3=0

            /////////////////////////////////////////////////////////
            ///بررسی خالی بودن 
            check da_chki = new check();
            List<check> list_chki = new List<check>();
            List<string> list_data = new List<string>();
            for (int i = 0; i < dvg_2.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dvg_2.Columns.Count; j++)
                {
                    if (string.IsNullOrWhiteSpace(dvg_2.Rows[i].Cells[j].Value.ToString()))
                    {
                        da_chki.get_One(dvg_2.Columns[j].HeaderText.ToString(), dvg_2.Rows[i].Cells[j].Value.ToString(), false);
                    }
                    else
                    {
                        da_chki.get_One(dvg_2.Columns[j].HeaderText.ToString(), dvg_2.Rows[i].Cells[j].Value.ToString(), true);
                    }
                }
            }
            //////////////////////////////////////////////////////////////////////////
            /////یک مجهولی
            ///نمایش جدول دوم
            fnOj.dvg_3.Columns.Clear();
            fnOj.dvg_3.Rows.Clear();
            fnOj.dvg_3.Columns.Add("جواب", "جواب");

            int aa = 0;
            int cc = 0;
            int fs = dvg_2.Columns.Count;
            cc = fs;
            for (int i = 0; i < dvg_2.Rows.Count - 1; i++)
            {
                int num = 0;

                for (int j = aa; j < cc; j++)
                {
                    if (string.IsNullOrWhiteSpace(dvg_2.Rows[i].Cells[j].Value.ToString()))
                    {
                        num++;
                    }

                }
                if (num == 1)
                {
                    fnOj.dvg_3.Rows.Add(da_chki.out_One(aa, cc, _show));
                }
                else
                {
                    fnOj.dvg_3.Rows.Add(da_chki.out_two(aa, cc, _show));
                }
                aa = cc;
                cc = cc + fs;
            }

            ////////////////////////////////////////////////////////////////////////////
            ///نمایش جدول اول

            DataGridView sourceGrid = this.dvg_2;
            DataGridView targetGrid = this.fnOj.dvg_1;

            var targetRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow sourceRow in sourceGrid.Rows)
            {
                if (!sourceRow.IsNewRow)
                {
                    var targetRow = (DataGridViewRow)sourceRow.Clone();
                    foreach (DataGridViewCell cell in sourceRow.Cells)
                    {
                        targetRow.Cells[cell.ColumnIndex].Value = cell.Value;
                    }
                    targetRows.Add(targetRow);
                }
            }
            targetGrid.Columns.Clear();
            foreach (DataGridViewColumn column in sourceGrid.Columns)
            {
                targetGrid.Columns.Add((DataGridViewColumn)column.Clone());
            }
            targetGrid.Rows.AddRange(targetRows.ToArray());
            ///////////////////////////////////////////////////////////////////////////


            Close();
        }
    }
}
