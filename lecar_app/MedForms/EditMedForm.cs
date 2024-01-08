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

namespace lecar_app.MedForms
{
    public partial class EditMedForm : Form
    {
        public Medicament edit_med;
        public void reload_list()
        {
            illness_list_box.Items.Clear();
            using var db = new LecarAppContext();
            var cons_list = db.Cons.Where(c => c.IdMedicament == edit_med.Id).ToList();
            foreach (var cons in cons_list)
            {
                var ill = db.Illnesses.Find(cons.IdIllnes);
                if (ill != null)
                {
                    illness_list_box.Items.Add(ill);
                }
            }
        }
        public EditMedForm(Medicament med)
        {
            InitializeComponent();
            edit_med = med;
            reload_list();

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
            db.Cons.Where(c => c.IdMedicament == edit_med.Id).ExecuteDelete();

            foreach (var temp in illness_list_box.Items)
            {
                Con med_con_ill = new Con();
                var ill = (Illness)temp;
                med_con_ill.IdIllnes = ill.Id;
                med_con_ill.IdMedicament = edit_med.Id;
                db.Cons.Add(med_con_ill);
                db.SaveChanges();
            }

            Close();
        }

        private void add_med_btn_Click(object sender, EventArgs e)
        {
            using var db = new LecarAppContext();
            var add_con_form = new AddConMed();
            var ill_list = add_con_form.show_form();
            List<int> old_ill_list = new List<int>();
            foreach (var temp in illness_list_box.Items)
            {
                var ill = (Illness)temp;
                old_ill_list.Add(ill.Id);
            }
            foreach (var ill in ill_list)
            {
                if (!old_ill_list.Contains(ill.Id))
                {
                    illness_list_box.Items.Add(ill);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(illness_list_box.SelectedItem != null)
            {
                var ill_to_del = illness_list_box.SelectedItem;
                illness_list_box.Items.Remove(ill_to_del);
            }
        }
    }
}
