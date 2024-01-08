using lecar_app.database;
using lecar_app.IllnessForms;
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

            foreach (var temp in ill_list_box.Items)
            {
                Con med_con_ill = new Con();
                var ill = (Illness)temp;
                med_con_ill.IdIllnes = ill.Id;
                med_con_ill.IdMedicament = new_med.Id;
                db.Cons.Add(med_con_ill);
                db.SaveChanges();
            }

            this.Close();
        }

        private void add_med_btn_Click(object sender, EventArgs e)
        {
            using var db = new LecarAppContext();
            var add_con_form = new AddConMed();
            var ill_list = add_con_form.show_form();
            List<int> old_ill_list = new List<int>();
            foreach (var temp in ill_list_box.Items)
            {
                var med = (Medicament)temp;
                old_ill_list.Add(med.Id);
            }
            foreach (var med in ill_list)
            {
                if (!old_ill_list.Contains(med.Id))
                {
                    ill_list_box.Items.Add(med);
                }
            }
        }
    }
}
