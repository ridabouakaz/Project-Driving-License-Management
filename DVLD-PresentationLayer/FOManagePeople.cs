﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class FOManagePeople : Form
    {
        public FOManagePeople()
        {
            InitializeComponent();
        }

        private void FOManagePeople_Load(object sender, EventArgs e)
        {
            CBFilterBy.SelectedIndex = 0;
        }
    }
}
