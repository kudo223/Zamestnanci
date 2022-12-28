using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zamestnanci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vypisy = sqlRepository.GetZamestnance();
            RefreshGUI();
        }
        List<Vypis> vypisy;
        SqlRepository sqlRepository = new SqlRepository();

        private void RefreshGUI()
        {
            listView1.Items.Clear();
            foreach (Vypis vypis in vypisy)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { vypis.FirstName, vypis.LastName, vypis.Phone, vypis.Email, vypis.BirthDate.ToString("dd.MM.yyyy") });
                listView1.Items.Add(listViewItem);
            }
        }

        private void buttonVlozit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVlozit formVlozit = new FormVlozit();
            formVlozit.Show();
        }

        private void buttonEditovat_Click(object sender, EventArgs e)
        {

            
                this.Hide();
                FormEditovat formEdit = new FormEditovat();
                formEdit.Show();
                var selectedRow = listView1.SelectedItems[0];
                var firstname = selectedRow.SubItems[0].Text;
                var lastname = selectedRow.SubItems[1].Text;
                var phone = selectedRow.SubItems[2].Text;
                var email = selectedRow.SubItems[3].Text;
                var birthday = selectedRow.SubItems[4].Text;
                formEdit.Data(firstname, lastname, phone, email, Convert.ToDateTime(birthday));
            
        }

        private void buttonMazat_Click(object sender, EventArgs e)
        {
            var selectedRow = listView1.SelectedItems[0];
            var jmenoMazani = selectedRow.SubItems[0].Text;
            sqlRepository.VymazatZamestnance(jmenoMazani);
            listView1.SelectedItems[0].Remove();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
