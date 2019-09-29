using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bunifu.UI.WinForms.BunifuButton;

namespace Cinema
{
    public partial class FormLogIn : Form
    {
        private SqlConnection con;
        private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Cinema.mdf;Integrated Security=True";
        static public int idProfile = 0;

        private void button_Click(object sender, EventArgs e)
        {
            ((BunifuButton)sender).Visible = false;
            transButton.ShowSync(((BunifuButton)sender));
            ((BunifuButton)sender).Focus();
        }

        private void RememberMe(bool val)
        {
            if (val)
            {
                Properties.Settings.Default.IsRemember = val;
                Properties.Settings.Default.Id = idProfile;
            }
            Properties.Settings.Default.Save();
        }
        private void Auth()
        {
            bool success = false;
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmdAuth = new SqlCommand("SELECT CodeClient, Login, Password FROM Profile WHERE Login = @login and Password = @password", con))
            {
                SqlDataReader reader = null;
                cmdAuth.Parameters.AddWithValue("@login", tbLogin.Text);
                cmdAuth.Parameters.AddWithValue("@password", tbPassword.Text);
                try
                {
                    con.Open();
                    using (reader = cmdAuth.ExecuteReader())
                    {
                        success = reader.Read();
                        if (success)
                        {
                            idProfile = Convert.ToInt32(reader[0].ToString());
                            RememberMe(cbRememberMe.Checked);
                            this.Hide();
                            FormMain fm = new FormMain();
                            fm.Show();
                        }
                        else
                        {
                            lblAlert.Text = "Неверный логин или пароль";
                            lblAlert.ForeColor = Color.FromArgb(255, 38, 38);
                            lblAlert.Visible = true;
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void Registr()
        {
            bool success = false;

            using (con = new SqlConnection(conStr))
            {
                using (SqlCommand cmdCheck = new SqlCommand("SELECT Login FROM Profile WHERE Login = @login", con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        cmdCheck.Parameters.AddWithValue("@login", tbLoginSignUp.Text);
                        using (reader = cmdCheck.ExecuteReader())
                        {
                            success = reader.Read();
                        }
                    }
                    catch (SqlException)
                    {
                        throw;
                    }
                }
                if (!success)
                {
                    if (tbPasswordSignUp.Text != "" && tbName.Text != "" && tbSecName.Text != ""
                        && tbPasswordRepeatSignUp.Text.Equals(tbPasswordSignUp.Text) && tbPasswordSignUp.Text.Length >= 8)
                    {
                        using (SqlCommand cmdReg = new SqlCommand("INSERT into Profile(Login, Password, Name, SecName) VALUES(@login, @password, @name, @secName)", con))
                        {
                            cmdReg.Parameters.AddWithValue("@login", tbLoginSignUp.Text);
                            cmdReg.Parameters.AddWithValue("@password", tbPasswordSignUp.Text);
                            cmdReg.Parameters.AddWithValue("@name", tbName.Text);
                            cmdReg.Parameters.AddWithValue("@secName", tbSecName.Text);
                            cmdReg.ExecuteNonQuery();
                        }
                        lblAlert.Text = "Регистрация прошла успешно";
                        btnSignIn.Active = true;
                        btnSignUp.Active = false;
                        pageSign.SetPage("Вход");
                        lblAlert.ForeColor = Color.FromArgb(0, 166, 95);
                        lblAlert.Visible = true;
                        lblSignUpAlert.Visible = false;
                    }
                    else
                    {
                        if (!tbPasswordRepeatSignUp.Text.Equals(tbPasswordSignUp.Text))
                        {
                            lblSignUpAlert.Text = "Заполните все поля. Пароли не совпадают";
                            lblPassLen.Visible = false;
                        }
                        else
                        {
                            lblSignUpAlert.Text = "Заполните все поля";
                            lblPassLen.Visible = false;
                        }
                        if (tbPasswordSignUp.Text.Length < 8)
                        {
                            lblPassLen.Visible = true;
                        }
                        lblSignUpAlert.ForeColor = Color.FromArgb(255, 38, 38);
                        lblSignUpAlert.Visible = true;
                    }
                }

                else
                {
                    lblSignUpAlert.Text = "Данный логин уже зарегистрирован";
                    lblSignUpAlert.Visible = true;
                    lblSignUpAlert.ForeColor = Color.FromArgb(255, 38, 38);
                }
            }
        }

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnSignInConfirm_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            Auth();
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            pageSign.SetPage("Регистрация");
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            pageSign.SetPage("Вход");
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (con != null)
            {
                con.Close();
            }
            Application.Exit();
        }

        private void btnSignUpConfirm_Click_1(object sender, EventArgs e)
        {
            button_Click(sender, e);
            Registr();
        }

        private void cbRememberMe_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            Properties.Settings.Default.IsRemember = cbRememberMe.Checked;

            if (cbRememberMe.Checked == false)
            {
                Properties.Settings.Default.Id = 0;
                lblRememberMe.ForeColor = Color.Gray;
            }
            else
            {
                lblRememberMe.ForeColor = Color.White;
            }
            Properties.Settings.Default.Save();
        }

        private void FormSign_Load(object sender, EventArgs e)
        {
            try
            {
                cbRememberMe.Checked = Properties.Settings.Default.IsRemember;
                idProfile = Properties.Settings.Default.Id;
            }
            catch (Exception)
            { }
        }

        private void FormSign_Shown(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.IsRemember == true && idProfile != 0)
                {
                    this.Hide();
                    FormMain fm = new FormMain();
                    fm.Show();
                }
            }
            catch (Exception)
            { }
        }
    }
}
