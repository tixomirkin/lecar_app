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

namespace lecar_app.IllnessForms
{
    public partial class EditIllnessForm : Form
    {
        int edit_id;
        public Illness edit_ill;
        public void reload_list()
        {
            illness_list_box.Items.Clear();
            using var db = new LecarAppContext();
            var cons_list = db.Cons.Where(c => c.IdIllnes == edit_ill.Id).ToList();
            foreach (var cons in cons_list)
            {
                var med = db.Medicaments.Find(cons.IdMedicament);
                if (med != null)
                {
                    illness_list_box.Items.Add(med);
                }
            }
        }
        public EditIllnessForm(Illness ill)
        {
            InitializeComponent();

            edit_ill = ill;
            reload_list();
            name_text.Text = edit_ill.Name;
            symptoms_text.Text = edit_ill.Symptoms;
            rec_text.Text = edit_ill.Recommendations;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_illness_btn_Click(object sender, EventArgs e)
        {
            using var db = new LecarAppContext();
            edit_ill.Name = name_text.Text;
            edit_ill.Recommendations = rec_text.Text;
            edit_ill.Symptoms = symptoms_text.Text;
            db.Illnesses.Update(edit_ill);
            db.SaveChanges();
            db.Cons.Where(c => c.IdIllnes == edit_ill.Id).ExecuteDelete();

            foreach (var temp in illness_list_box.Items)
            {
                Con ill_con_med = new Con();
                var med = (Medicament)temp;
                ill_con_med.IdMedicament = med.Id;
                ill_con_med.IdIllnes = edit_ill.Id;
                db.Cons.Add(ill_con_med);
                db.SaveChanges();
            }

            Close();
        }

        private void add_med_btn_Click(object sender, EventArgs e)
        {
            using var db = new LecarAppContext();
            var add_con_form = new AddConIllness();
            var med_list = add_con_form.get_list_med();
            List<int> old_med_list = new List<int>();
            foreach (var temp in illness_list_box.Items)
            {
                var med = (Medicament)temp;
                old_med_list.Add(med.Id);
            }
            foreach (var med in med_list)
            {
                if (!old_med_list.Contains(med.Id))
                {
                    illness_list_box.Items.Add(med);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (illness_list_box.SelectedItem != null)
            {
                var ill_to_del = illness_list_box.SelectedItem;
                illness_list_box.Items.Remove(ill_to_del);
            }
        }
    }
}
