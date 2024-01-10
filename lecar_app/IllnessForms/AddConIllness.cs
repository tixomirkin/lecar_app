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
    public partial class AddConIllness : Form
    {

        public List<Medicament> rec_med;
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
        public AddConIllness()
        {
            rec_med = new List<Medicament>();
            InitializeComponent();
            reload_list();
        }

        private void add_illness_btn_Click(object sender, EventArgs e)
        {
            var med_list = med_list_box.SelectedItems;

            foreach (var med_obj in med_list)
            {
                var med = (Medicament)med_obj;
                rec_med.Add(med);
            }
            this.Close();

        }
        public List<Medicament> get_list_med()
        {
            med_list_box.SelectionMode = SelectionMode.MultiSimple;
            this.ShowDialog();
            return rec_med;
        }

        public Medicament get_med()
        {
            med_list_box.SelectionMode = SelectionMode.One;
            this.ShowDialog();
            return rec_med.First();
        }

        private void search_text_box_TextChanged(object sender, EventArgs e)
        {
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
    }
}
