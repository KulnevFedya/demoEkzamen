using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportShop
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        int errors = 0;
        string answer;
        bool blockentry = true;

        private void Authorization_Load(object sender, EventArgs e)
        {
            pictureBoxCapcha.Visible = false;
            textBoxCapcha.Visible=false;
            btnCapcha.Visible=false;
        }

        private void btnEnterAsGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalog_Form form = new Catalog_Form();
            form.Show();
        }
        /// <summary>
        /// Действия по нажатию на кнопку "Войти"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "Доброго времени суток";
                DateTime dateTime = DateTime.Now;
                if (dateTime.Hour >= 0 && dateTime.Hour <= 6)
                    msg = "Доброй ночи";

                else if (dateTime.Hour >= 7 && dateTime.Hour <= 12)
                    msg = "Доброе утро";

                else if (dateTime.Hour >= 13 && dateTime.Hour <= 18)
                    msg = "Добрый день";

                else if (dateTime.Hour >= 19 && dateTime.Hour <= 23)
                    msg = "Добрый вечер";

                else
                    msg = "Доброго времени суток";

                if (blockentry == true)
                {
                    string login, password;
                    login = txtBox_Login.Text;
                    password = txtBox_Password.Text;
                    SqlConnection con = new SqlConnection(Program_class.connection);
                    con.Open();
                    SqlCommand logrequest = new SqlCommand();

                    logrequest.CommandType = CommandType.StoredProcedure;
                    logrequest.CommandText = "checkpassword";
                    logrequest.Parameters.AddWithValue("@UserLogin", login);
                    logrequest.Parameters.AddWithValue("@UserPassword", password);
                    logrequest.Connection = con;
                    SqlDataReader sqlDataReader = logrequest.ExecuteReader();
                    sqlDataReader.Read();
                    if (sqlDataReader.HasRows)
                    {
                        Program_class.user_id = (int)sqlDataReader.GetInt32(0);
                        Program_class.role = (int)sqlDataReader.GetInt32(6);

                        string goodTime = $@"{msg}, {sqlDataReader.GetString(1)} {sqlDataReader.GetString(2)}!";
                        MessageBox.Show(goodTime, "Здравствуйте!");

                        this.Hide();
                        Catalog_Form form = new Catalog_Form();
                        form.Show();

                        errors = 0;
                    }
                    else
                    {
                        errors++;
                        MessageBox.Show("Ошибка. Неправильно введён логин или пароль");
                        blockentry = false;
                        textBoxCapcha.Visible = true;
                        pictureBoxCapcha.Visible = true;
                        btnCapcha.Visible = true;

                        fillcapcha();

                        if (errors > 1)
                        {
                            btnEnter.Enabled = false;
                            timerForBlocking.Start();
                        }

                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("сначала введите капчу");
                }
            } catch
            {
                MessageBox.Show("Ошибка со входом в аккаунт!", "Ошибка!");
            }
           

          
        }
        /// <summary>
        /// Капча выбирается наугад и вставляется в место для картинки
        /// </summary>
        private void fillcapcha()
        {
            Random random = new Random();
            int value = random.Next(0, 2);
            switch (value)
            {
                case 0:
                    answer = "6ne3";
                    break;
                case 1:
                    answer = "e5hb";
                    break;
                case 2:
                    answer = "xdhyn";
                    break;
            }
            pictureBoxCapcha.Image = imageListCapcha.Images[value];
        }

        private void timerForBlocking_Tick(object sender, EventArgs e)
        {
            btnEnter.Enabled = true;
            timerForBlocking.Stop();
        }
        /// <summary>
        /// Действия по кнопке "Ввод"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapcha_Click(object sender, EventArgs e)
        {
            string txt = textBoxCapcha.Text.Trim();
            while (true)
            {
                if (txt == answer)
                {
                    textBoxCapcha.Visible = false;
                    pictureBoxCapcha.Visible = false;
                    btnCapcha.Visible = false;
                    blockentry = true;
                }
                else
                {
                    MessageBox.Show("Неверный ввод");
                    fillcapcha();

                }
            }
        }
    }
}
