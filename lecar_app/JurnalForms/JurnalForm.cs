using lecar_app.database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecar_app.JurnalForms
{
    public partial class JurnalForm : Form
    {
        public JurnalForm()
        {
            InitializeComponent();

            using var db = new LecarAppContext();
            var jur_list = db.Jurnals.ToList();
            foreach (var jur in jur_list)
            {
                jurnal_grid.Rows.Add(jur.Id, jur.Date.ToString(), jur.Name, jur.IllnesName, jur.Symtoms, jur.Recomends, jur.OtherText);
            }
        }

        private void jurnal_grid_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(jurnal_grid.SelectedRows[0].Cells[1].Value.ToString());
            symtoms_text.Text = jurnal_grid.SelectedRows[0].Cells[4].Value.ToString();
            rect_text.Text = jurnal_grid.SelectedRows[0].Cells[5].Value.ToString();
            other_text.Text = jurnal_grid.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void del_med_btn_Click(object sender, EventArgs e)
        {
            using var db = new LecarAppContext();
            db.Jurnals.Remove(db.Jurnals.Find(jurnal_grid.SelectedRows[0].Cells[0].Value));
            db.SaveChanges();
            jurnal_grid.Rows.Remove(jurnal_grid.SelectedRows[0]);
        }
    }
}
