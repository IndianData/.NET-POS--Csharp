﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPoject
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            FormAddEditProducts addEditProducts = new FormAddEditProducts();
            addEditProducts.Show();
        }
    }
}