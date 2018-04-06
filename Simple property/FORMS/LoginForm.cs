using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PropertyApp.FORMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
            static private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PROPERTY.accdb; Persist Security Info=False;");
            static private OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            static private OleDbCommand command = new OleDbCommand();

            public void Check(string _txtB_login, string _txtB_password)
            {
                try
                {
                    if (connection != null)
                        connection.Close();
                    connection.Open();
                    string com = "SELECT * FROM [registration] WHERE [login]=@login AND [password]=@password";

                    OleDbCommand _command = new OleDbCommand(com, connection);
                    _command.Parameters.AddWithValue("@login", _txtB_login);
                    _command.Parameters.AddWithValue("@password", _txtB_password);
                    OleDbDataReader reader = _command.ExecuteReader();

                    int count = 0;

                    while (reader.Read())
                    {
                        count++;
                    }

                    if (count == 1)
                    {
                        if (MessageBox.Show("Добро пожаловать!", "Welcome!!!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            OtherForm _form = new OtherForm();
                            _form.Show(); 
                            this.Hide();
                        }
                    }
                    else if (count > 1)
                    {
                        MessageBox.Show("???-???-???-???-???-???!", "Welcome!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Извините не правильно введены данные!\n" + "Для просмотра предложений о недвижимости зайдите через гостевой режим.", "Welcome!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = null;
                        textBox2.Text = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Welcome Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Check(textBox1.Text, textBox2.Text);           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLclassInsert.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormF().Show();
            this.Hide();
        }

        Point last;

        void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;

            }

        }

        void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point cur = MousePosition;
                int dx = cur.X - last.X;
                int dy = cur.Y - last.Y;
                Point loc = new Point(Location.X + dx, Location.Y + dy);
                Location = loc;
                last = cur;
            }
        }
    }
}
