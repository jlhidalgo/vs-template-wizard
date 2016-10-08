using System;
using System.Windows.Forms;

namespace VSTemplateWizard
{
    public partial class UserInputForm : Form
    {
        private TextBox _textBox1;
        private Button _button1;

        private static string _customMessage;
        public static string CustomMessage
        {
            get { return _customMessage; }
            set { _customMessage = value; }
        }

        public UserInputForm()
        {
            this.Size = new System.Drawing.Size(155, 265);

            _button1 = new Button();
            _button1.Text = "OK";
            _button1.Location = new System.Drawing.Point(90, 25);
            _button1.Size = new System.Drawing.Size(50, 25);
            _button1.Click += _button1_Click;
            this.Controls.Add(_button1);

            _textBox1 = new TextBox();
            _textBox1.Location = new System.Drawing.Point(10, 25);
            _textBox1.Size = new System.Drawing.Size(70, 20);
            this.Controls.Add(_textBox1);
        }

        private void _button1_Click(object sender, EventArgs e)
        {
            _customMessage = _textBox1.Text;
            this.Close();
        }
    }
}
