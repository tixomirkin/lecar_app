using lecar_app.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecar_app.MedForms
{
    public partial class EditMedForm : Form
    {
        public Medicament edit_med;
        public EditMedForm(Medicament med)
        {
            InitializeComponent();
            edit_med = med;

            name_text.Text = edit_med.Name;
            active_substance_text.Text = edit_med.ActiveSubstance;
            med_counter.Value = Convert.ToDecimal(edit_med.Count);
        }

        private void save_illness_btn_Click(object sender, EventArgs e)
        {
            using var db = new LecarAppContext();
            edit_med.Name = name_text.Text;
            edit_med.ActiveSubstance = active_substance_text.Text;
            edit_med.Count = Convert.ToInt32(med_counter.Value);
            db.Medicaments.Update(edit_med);
            db.SaveChanges();
            Close();
        }
    }
}
