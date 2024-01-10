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
    public partial class MedListForms : Form
    {
        public void reload_list()
        {
            med_list_box.Items.Clear();
            using var db = new LecarAppContext();
            var ills = db.Medicaments.ToList();
            foreach (var ill in ills)
            {
                med_list_box.Items.Add(ill);
            }
        }

        public MedListForms()
        {
            InitializeComponent();
            reload_list();
        }
        private void add_med_btn_Click(object sender, EventArgs e)
        {
            var add_form = new AddMedForm();
            this.Hide();
            add_form.ShowDialog();
            this.Show();
            panel_med.Visible = false;
            reload_list();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void med_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (med_list_box.SelectedItem != null)
            {
                using var db = new LecarAppContext();
                Medicament med = (Medicament)med_list_box.SelectedItem;

                panel_med.Visible = true;
                name_text.Text = med.Name;
                active_substance_text.Text = med.ActiveSubstance;
                med_counter.Text = med.Count.ToString();

                var cons_list = db.Cons.Where(c => c.IdMedicament == med.Id).ToList();
                String con_ills = "";
                foreach (var cons in cons_list)
                {
                    var ill = db.Illnesses.Find(cons.IdIllnes);
                    if (ill != null)
                    {
                        con_ills += ill.Name + "\n";
                    }
                }
                illness_text.Text = con_ills;
            }
        }

        private void del_med_btn_Click(object sender, EventArgs e)
        {
            if (med_list_box.SelectedItem != null)
            {
                Medicament med = (Medicament)med_list_box.SelectedItem;
                using var db = new LecarAppContext();
                db.Medicaments.Remove(med);
                panel_med.Visible = false;
                db.SaveChanges();
                reload_list();
            }
        }

        private void edit_med_btn_Click(object sender, EventArgs e)
        {
            if (med_list_box.SelectedItem != null)
            {
                Medicament med = (Medicament)med_list_box.SelectedItem;

                this.Hide();
                var edit_form = new EditMedForm(med);
                edit_form.ShowDialog();
                this.Show();

                int old_index = med_list_box.SelectedIndex;
                search_text_box_TextChanged(sender, EventArgs.Empty);
                //reload_list();
                med_list_box.SelectedIndex = old_index;
                med_list_box_SelectedIndexChanged(sender, EventArgs.Empty);
            }
        }

        private void search_text_box_TextChanged(object sender, EventArgs e)
        {
            panel_med.Visible = false;
            med_list_box.ClearSelected();
            reload_list();
            var findlist = new List<Object>();
            var find = med_list_box.FindString(search_text_box.Text);

            while (find != -1)
            {
                findlist.Add(med_list_box.Items[find]);
                med_list_box.Items.RemoveAt(find);
                find = med_list_box.FindString(search_text_box.Text);
            }

            med_list_box.Items.Clear();

            foreach (var item in findlist)
            {
                med_list_box.Items.Add(item);
            }
        }

        private void analog_btn_Click(object sender, EventArgs e)
        {
            string analog_str = "";

            if (med_list_box.SelectedItem != null)
            {
                Medicament sel_med = (Medicament)med_list_box.SelectedItem;


                using var db = new LecarAppContext();
                var list_med = db.Medicaments.ToList();
                foreach (var med in list_med)
                {
                    if (med.ActiveSubstance.ToLower().Contains(sel_med.ActiveSubstance.ToLower()) && med.Id != sel_med.Id) 
                    {
                        analog_str += "- " + med.Name + "\n";
                    }
                }

                if (analog_str == "")
                {
                    MessageBox.Show("Аналоги не найденны!");
                }
                else
                {
                    MessageBox.Show("Список аналогов на основе активного вещества:\n" + analog_str);
                }
            }
        }
    }
}
