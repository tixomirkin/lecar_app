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
    public partial class AddConMed : Form
    {

        public List<Illness> con_ill;
        public void reload_list()
        {
            ill_list_box.Items.Clear();
            using var db = new LecarAppContext();
            var ills = db.Illnesses.ToList();
            foreach (var ill in ills)
            {
                ill_list_box.Items.Add(ill);
            }
        }
        public AddConMed()
        {
            con_ill = new List<Illness>();
            InitializeComponent();
            reload_list();
        }

        private void add_illness_btn_Click(object sender, EventArgs e)
        {
            var ill_list = ill_list_box.SelectedItems;

            foreach (var ill_obj in ill_list)
            {
                var ill = (Illness)ill_obj;
                con_ill.Add(ill);
            }
            this.Close();
        }

        public List<Illness> show_form()
        {
            this.ShowDialog();
            return con_ill;
        }
    }
}
