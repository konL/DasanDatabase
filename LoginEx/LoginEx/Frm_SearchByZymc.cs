using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginEx
{
    public partial class Frm_SearchByZymc : Form
    {
        public Frm_SearchByZymc()
        {
            InitializeComponent();
        }

        private void fillByZymcToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.searchByZymcTableTableAdapter.FillByZymc(this.zgzyDataSet.SearchByZymcTable, 专业名称ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
