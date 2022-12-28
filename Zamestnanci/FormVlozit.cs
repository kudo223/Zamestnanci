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
    public partial class FormVlozit : Form
    {
        SqlRepository sqlRepository = new SqlRepository();
        public FormVlozit()
        {
            InitializeComponent();
        }

        private void buttonVlozitData_Click(object sender, EventArgs e)
        {
            sqlRepository.VlozitZamestnance(textBoxFirstName.Text, textBoxLastName.Text, textBoxPhone.Text, textBoxEmail.Text, dateTimePicker1.Value);
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
