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
    public partial class FormEditovat : Form
    {
        SqlRepository sqlRepository = new SqlRepository();
        public FormEditovat()
        {
            InitializeComponent();
        }
        public void Data(string firstname, string lastname, string phone, string email, DateTime birthdate)
        {
            textBoxFirstName.Text = firstname;
            textBoxLastName.Text = lastname;
            textBoxPhone.Text = phone;
            textBoxEmail.Text = email;
            dateTimePicker1.Value = birthdate;
        }

        private void buttonUlozitData_Click(object sender, EventArgs e)
        {
            sqlRepository.EditovatZamestnance(textBoxFirstName.Text, textBoxLastName.Text, textBoxPhone.Text, textBoxEmail.Text, Convert.ToDateTime(dateTimePicker1.Value));
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
