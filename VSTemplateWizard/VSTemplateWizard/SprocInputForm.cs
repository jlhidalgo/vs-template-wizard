using System;
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
        #region properties
        private static string _dbname;

        public static string DatabaseName
        {
            get { return _dbname; }
            set { _dbname = value; }
        }

        private static string _sprocname;

        public static string SprocName
        {
            get { return _sprocname; }
            set { _sprocname = value; }
        }

        private static string _rollback;

        public static string Rollback
        {
            get { return _rollback; }
            set { _rollback = value; }
        }

        private static string _action;

        public static string Action
        {
            get { return _action; }
            set { _action = value; }
        }

        private static string _item;

        public static string Item
        {
            get { return _item; }
            set { _item = value; }
        }

        private static string _revision;

        public static string Revision
        {
            get { return _revision; }
            set { _revision = value; }
        }

        private static string _username;

        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private static string _task;

        public static string Task
        {
            get { return _task; }
            set { _task = value; }
        }

        private static string _comments;

        public static string Comments
        {
            get { return _comments; }
            set { _comments = value; }
        }

        private static string _date;

        public static string Date
        {
            get { return _date; }
            set { _date = value; }
        }


        #endregion properties


        public SprocInputForm()
        {
            InitializeComponent();
            rollbackCmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            _dbname = dbnameTxt.Text;
            _sprocname = sprocnameTxt.Text;
            _rollback = rollbackCmb.Text;
            _action = actionCmb.Text;
            _item = itemTxt.Text;
            _revision = revisionTxt.Text;
            _username = usernameTxt.Text;
            _date = DateTime.Now.ToString("MM/dd/yyyy");
            _task = taskTxt.Text;
            _comments = commentsTxt.Text;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
