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
    public partial class AddMedForm : Form
    {
        public AddMedForm()
        {
            InitializeComponent();
        }

        private void save_illness_btn_Click(object sender, EventArgs e)
        {
            using var db = new LecarAppContext();

            Medicament new_med = new Medicament();
            new_med.Name = name_text.Text;
            new_med.ActiveSubstance = active_substance_text.Text;
            new_med.Count = Convert.ToInt32(med_counter.Value);

            db.Medicaments.Add(new_med);
            db.SaveChanges();

            this.Close();
        }
    }
}
