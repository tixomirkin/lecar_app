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

namespace lecar_app.IllnessForms
{
    public partial class AddIllnessForm : Form
    {
        public AddIllnessForm()
        {
            InitializeComponent();
        }

        private void add_med_btn_Click(object sender, EventArgs e)
        {
            using var db = new LecarAppContext();
            var add_con_form = new AddConIllness();
            var med_list = add_con_form.get_list_med();
            List<int> old_med_list = new List<int>();
            foreach(var temp in illness_list_box.Items)
            {
                var med = (Medicament)temp;
                old_med_list.Add(med.Id);
            }
            foreach(var med in med_list)
            {
                if (!old_med_list.Contains(med.Id))
                {
                    illness_list_box.Items.Add(med);
                }
            }
            
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_illness_btn_Click(object sender, EventArgs e)
        {
            using var db = new LecarAppContext();
            
            Illness new_ill = new Illness();
            
            new_ill.Name = name_text.Text;
            new_ill.Symptoms = symptoms_text.Text;
            new_ill.Recommendations = rec_text.Text;
            
            db.Illnesses.Add(new_ill);
            db.SaveChanges();


            foreach (var temp in illness_list_box.Items)
            {
                Con ill_con_med = new Con();
                var med = (Medicament)temp;
                ill_con_med.IdMedicament = med.Id;
                ill_con_med.IdIllnes = new_ill.Id;
                db.Cons.Add(ill_con_med);
                db.SaveChanges();
            }

            this.Close();
        }
    }
}
