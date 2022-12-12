﻿using System;
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
    }
}