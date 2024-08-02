using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reseter2
{
    public partial class FormHistory : Form
    {
        private DataTable dataTable;
        private DataSet ds;
        private DataRow row;
        public FormHistory()
        { 
           
           InitializeComponent();
            ds = new DataSet();
            dataTable = new DataTable();
            TableHistory.DataSource = dataTable;
            dataTable.Columns.Add("Время");
            dataTable.Columns.Add("Имя");
            dataTable.Columns.Add("Статус");
            ds.Tables.Add(dataTable);
            row = dataTable.NewRow();
            row[0] = "12";
            row[1] = "123";
            row[2] = "12444";
            dataTable.Rows.Add(row);
        }
    }
}
