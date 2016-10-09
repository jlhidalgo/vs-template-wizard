﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSTemplateWizard
{
    public partial class SprocInputForm : Form
    {
        private static string _customMessage;

        public static string CustomMessage {
            get { return _customMessage; }
            set { _customMessage = value; }
        }

        public SprocInputForm()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            _customMessage = CustomMessageTxt.Text;
            this.Close();
        }
    }
}
