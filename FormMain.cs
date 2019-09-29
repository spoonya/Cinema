using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.IO;

namespace Cinema
{
    public partial class FormMain : Form
    {
        private Bitmap image;
        private BunifuCheckBox[,] seats;
        private int count = 0;
        private double cost = 0, price = 0;
        private List<string[]> seanceAdd = new List<string[]>();
        private List<string[]> seanceEdit = new List<string[]>();
        private List<string[]> seanceDelete = new List<string[]>();
        private List<string[]> selectedSeats = new List<string[]>();
        public static bool isConf = false;
        private int idProf = FormLogIn.idProfile;            
        private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Cinema.mdf;Integrated Security=True;";
        private SqlConnection con;
        public FormMain()
        {
            FormLoad.ShowLoadingScreen();
            InitializeComponent();
            flowLayoutPanel1.MouseWheel += flowLayoutPanel1_MouseWheel;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (idProf != 1)
            {
                lblFilmAdd.Visible = false;
                lblFilmEdit.Visible = false;
            }

            RenameSeats();
            AfishaFill();
            ProfileFill();
            MyTicketsFill();
            OptionsFill();
            btnScroll.IconVisible = true;
            pnlFilm.Width = 970;
            lblSynopsisText.Width = 910;
            pnlTicketsSeats.Width = 910;
            pnlSeparator1.Width = 1000;
            pnlSeparator2.Width = 1000;
            pnlSeparator3.Width = 1000;
            flowLayoutPanel1.Size = new Size(1041, 445);
            pageMenu.SetPage("Афиша");
            FormLoad.CloseLoadingScreen();
        }

        private void OptionsFill()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("SELECT Autostart, Tray FROM Profile WHERE CodeClient = @id", con))
            {
                SqlDataReader reader = null;
                cmd.Parameters.AddWithValue("@id", idProf);
                try
                {
                    con.Open();
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            switchAutoStart.Value = Convert.ToBoolean(reader[0].ToString());
                            switchWorkClose.Value = Convert.ToBoolean(reader[1].ToString());
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void flowLayoutPanel1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (flowLayoutPanel1.VerticalScroll.Value == 0)
            {
                btnScroll.Visible = true;
            }
            else
            {
                btnScroll.Visible = false;
            }
        }

        private const int CS_DROPSHADOW = 0x30000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void AfishaFill()
        {
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("SELECT CodeFilm, Name, Age, Genre FROM Afisha ORDER BY CodeFilm DESC", con))
            {
                SqlDataReader reader = null;
                try
                {
                    con.Open();
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Panel p = new Panel();
                            p.Size = new Size(263, 398);
                            p.BorderStyle = BorderStyle.None;
                            p.Name = "p" + reader["CodeFilm"].ToString();
                            flowLayoutPanel1.Controls.Add(p);

                            Bunifu.UI.WinForms.BunifuImageButton poster = new Bunifu.UI.WinForms.BunifuImageButton();
                            poster.Cursor = Cursors.Arrow;
                            poster.Location = new Point(43, 4);
                            poster.Size = new Size(184, 255);
                            poster.Name = "ps" + reader["CodeFilm"].ToString();
                            poster.ImageMargin = 20;
                            poster.AllowZooming = true;
                            poster.Click += new EventHandler(imgButtonBuy_Click);
                            poster.Image = Image.FromStream(ReadPosterFromDB(Convert.ToInt32(reader["CodeFilm"].ToString())));
                            p.Controls.Add(poster);

                            Label age = new Label();
                            age.AutoSize = false;
                            age.Size = new Size(263, 21);
                            age.TextAlign = ContentAlignment.MiddleCenter;
                            age.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                            age.ForeColor = Color.LightGray;
                            age.Text = reader["Age"].ToString();
                            age.Location = new Point(3, 257);
                            p.Controls.Add(age);

                            Label film = new Label();
                            film.AutoSize = false;
                            film.Size = new Size(263, 45);
                            film.TextAlign = ContentAlignment.MiddleCenter;
                            film.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                            film.ForeColor = Color.White;
                            film.Text = reader["Name"].ToString();
                            film.Location = new Point(3, 279);
                            p.Controls.Add(film);

                            Label genre = new Label();
                            genre.AutoSize = false;
                            genre.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                            genre.ForeColor = Color.LightGray;
                            genre.Text = reader["Genre"].ToString();
                            genre.Location = new Point(3, 329);
                            genre.TextAlign = ContentAlignment.MiddleCenter;
                            genre.Size = new Size(263, 21);
                            p.Controls.Add(genre);

                            BunifuButton bb = new BunifuButton();
                            bb.Size = new Size(156, 40);
                            bb.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                            bb.ForeColor = Color.White;
                            bb.ButtonText = "Купить билет";
                            bb.Cursor = Cursors.Hand;
                            bb.IdleBorderColor = Color.FromArgb(102, 102, 102);
                            bb.IdleFillColor = Color.FromArgb(102, 102, 102);
                            bb.onHoverState.BorderColor = Color.FromArgb(229, 9, 20);
                            bb.onHoverState.FillColor = Color.FromArgb(229, 9, 20);
                            bb.Location = new Point(57, 358);
                            bb.Name = reader["CodeFilm"].ToString();
                            bb.Click += new EventHandler(buttonBuy_Click);
                            p.Controls.Add(bb);
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void ProfileFill()
        {
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Profile WHERE CodeClient = @id", con))
            {
                SqlDataReader reader = null;
                cmd.Parameters.AddWithValue("@id", idProf);
                try
                {
                    con.Open();
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tbLogin.Text = reader[1].ToString();
                            tbName.Text = reader[3].ToString();
                            tbSecName.Text = reader[4].ToString();
                            if (!reader[5].ToString().Equals(""))
                            {
                                ddSex.Text = reader[5].ToString();
                            }
                            else
                            {
                                ddSex.Text = "Пол";
                            }

                            ddBirthday.Text = reader[6].ToString();
                            tbPhone.Text = reader[7].ToString();
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private async void MyTicketsFill()
        {
            int countRows = 0;
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM MyTickets WHERE CodeClient = @id", con))
            {
                cmdCount.Parameters.AddWithValue("@id", idProf);
                try
                {
                    await con.OpenAsync();
                    countRows = (int)cmdCount.ExecuteScalar();
                }
                catch (SqlException)
                {
                    throw;
                }
            }
            string[,] data = new string[countRows, 5];
            dgvTickets.RowCount = countRows;
            dgvTickets.ColumnCount = 5;
            int row = 0;

            using (con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader reader = null;
                    cmd.Parameters.AddWithValue("@id", idProf);
                    string query1 = "SELECT Name FROM [Afisha] WHERE CodeFilm in (SELECT CodeFilm FROM [Seance] WHERE CodeSeance in " +
                                        "(SELECT CodeSeance FROM [MyTickets] WHERE CodeClient = @id))";
                    string query2 = "SELECT Date, Price FROM [Seance] WHERE CodeSeance in (SELECT CodeSeance FROM [MyTickets] WHERE CodeClient = @id)";
                    string query3 = "SELECT Row, Seat FROM MyTickets WHERE CodeClient = @id";
                    try
                    {
                        await con.OpenAsync();
                        cmd.CommandText = query1;
                        cmd.Connection = con;
                        using (reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                data[row, 0] = reader[0].ToString();
                                row++;
                            }
                            row = 0;
                        }
                        cmd.CommandText = query2;
                        using (reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                data[row, 1] = reader[0].ToString();
                                data[row, 4] = reader[1].ToString();
                                row++;
                            }
                            row = 0;
                        }
                        cmd.CommandText = query3;
                        using (reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                data[row, 2] = reader[0].ToString();
                                data[row, 3] = reader[1].ToString();
                                row++;
                            }
                            row = 0;
                        }
                        for (int i = 0; i < countRows; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                dgvTickets.Rows[i].Cells[j].Value = data[i, j];
                            }
                        }
                    }
                    catch (SqlException)
                    {
                        throw;
                    }
                }
            }
        }

        private void BuyTicketFill(int codeFilm)
        {
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Afisha WHERE CodeFilm = @codeFilm", con))
            {
                SqlDataReader reader = null;
                cmd.Parameters.AddWithValue("@codeFilm", codeFilm);
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 19; j++)
                    {
                        seats[i, j].Enabled = false;
                        seats[i, j].Refresh();
                    }
                }
                try
                {
                    con.Open();
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TrailerURL(reader[7].ToString());
                            lblNameFilm.Text = reader[5].ToString();
                            lblGenre.Text = reader[1].ToString();
                            lblAge.Text = reader[4].ToString();
                            lblDuration.Text = reader[3].ToString();
                            lblSynopsisText.Text = reader[6].ToString();
                            lblDirector.Text = reader[8].ToString();
                            imgPoster.Image = Image.FromStream(ReadPosterFromDB(codeFilm));
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
            }

            ddSeance.Items.Clear();
            ddSeance.Text = "Сеансы";
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("SELECT Date, Price FROM Seance WHERE CodeFilm = @codeFilm", con))
            {
                SqlDataReader reader = null;
                cmd.Parameters.AddWithValue("@codeFilm", codeFilm);
                try
                {
                    con.Open();
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ddSeance.Items.Add(reader[0].ToString());
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void cb_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (((BunifuCheckBox)sender).Checked == true)
            {
                char[] row;
                char[] seat;
                count += 1;
                cost += Convert.ToDouble(price);
                selectedSeats.Add(new string[5]);
                selectedSeats[selectedSeats.Count - 1][0] = lblNameFilm.Text;
                selectedSeats[selectedSeats.Count - 1][1] = ddSeance.SelectedItem.ToString();
                selectedSeats[selectedSeats.Count - 1][4] = price.ToString();
                if (Convert.ToInt32(((BunifuCheckBox)sender).Name) <= 919 && !((BunifuCheckBox)sender).Name[1].ToString().Equals("0"))
                {
                    switch (((BunifuCheckBox)sender).Name.Length)
                    {
                        case 2:
                            row = new char[1];
                            seat = new char[1];
                            row[0] = ((BunifuCheckBox)sender).Name[0];
                            seat[0] = ((BunifuCheckBox)sender).Name[1];
                            selectedSeats[selectedSeats.Count - 1][2] = row[0].ToString();
                            selectedSeats[selectedSeats.Count - 1][3] = seat[0].ToString(); ;
                            break;
                        case 3:
                            row = new char[1];
                            seat = new char[2];
                            row[0] = ((BunifuCheckBox)sender).Name[0];
                            seat[0] = ((BunifuCheckBox)sender).Name[1];
                            seat[1] = ((BunifuCheckBox)sender).Name[2];
                            selectedSeats[selectedSeats.Count - 1][2] = row[0].ToString();
                            selectedSeats[selectedSeats.Count - 1][3] = seat[0].ToString() + seat[1].ToString();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (((BunifuCheckBox)sender).Name.Length)
                    {
                        case 3:
                            row = new char[2];
                            seat = new char[1];
                            row[0] = ((BunifuCheckBox)sender).Name[0];
                            row[1] = ((BunifuCheckBox)sender).Name[1];
                            seat[0] = ((BunifuCheckBox)sender).Name[2];
                            selectedSeats[selectedSeats.Count - 1][2] = row[0].ToString() + row[1].ToString();
                            selectedSeats[selectedSeats.Count - 1][3] = seat[0].ToString();
                            break;
                        case 4:
                            row = new char[2];
                            seat = new char[2];
                            row[0] = ((BunifuCheckBox)sender).Name[0];
                            row[1] = ((BunifuCheckBox)sender).Name[1];
                            seat[0] = ((BunifuCheckBox)sender).Name[2];
                            seat[1] = ((BunifuCheckBox)sender).Name[3];
                            selectedSeats[selectedSeats.Count - 1][2] = row[0].ToString() + row[1].ToString();
                            selectedSeats[selectedSeats.Count - 1][3] = seat[0].ToString() + seat[1].ToString();
                            break;
                        default: break;
                    }
                }
                lblTicketsCount.Text = "ВСЕГО БИЛЕТОВ: " + Convert.ToString(count);
                lblTicketsCost.Text = "К ОПЛАТЕ: " + Convert.ToDouble(cost) + " руб.";
            }
            else
            {
                count -= 1;
                cost -= Convert.ToDouble(price);
                selectedSeats.RemoveAt(selectedSeats.Count - 1);
                lblTicketsCount.Text = "ВСЕГО БИЛЕТОВ: " + Convert.ToString(count);
                lblTicketsCost.Text = "К ОПЛАТЕ: " + Convert.ToDouble(cost) + " руб.";
            }
        }

        private void BuyTickets()
        {
            int codeSeance = SelectCodeSeanceFromDate(ddSeance.SelectedItem.ToString());
            using (SqlConnection con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO MyTickets (CodeClient, Row, Seat, CodeSeance) VALUES (@codeClient, @row, @seat, @codeSeance)", con))
            {
                try
                {
                    con.Open();
                    for (int i = 0; i < selectedSeats.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@codeClient", idProf);
                        cmd.Parameters.AddWithValue("@row", selectedSeats[i][2].ToString());
                        cmd.Parameters.AddWithValue("@seat", selectedSeats[i][3].ToString());
                        cmd.Parameters.AddWithValue("@codeSeance", SelectCodeSeanceFromDate(ddSeance.SelectedItem.ToString()));
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                    cmd.CommandText = "UPDATE Seats SET Engaged = 1 WHERE CodeSeance = @codeSeance and Seat = @seat";
                    for (int i = 0; i < selectedSeats.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@seat", selectedSeats[i][2].ToString() + selectedSeats[i][3].ToString());
                        cmd.Parameters.AddWithValue("@codeSeance", codeSeance);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 19; j++)
                        {
                            if (seats[i, j].Checked)
                            {
                                seats[i, j].Checked = false;
                                seats[i, j].Enabled = false;
                                seats[i, j].Refresh();
                            }
                        }
                    }
                    Alerts.ShowDlg(Alerts.AlertType.success);
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void ddChooseEditFilmFill()
        {
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("SELECT Name FROM Afisha", con))
            {
                SqlDataReader reader = null;
                try
                {
                    con.Open();
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ddEditChooseFilm.Items.Add(reader[0].ToString());
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private async void EditAfishaFill()
        {
            int codeFilm = SelectCodeFilmFromName();
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("SELECT Afisha.*, Seance.Date, Seance.Price FROM Afisha, Seance " +
                " WHERE Afisha.CodeFilm = @codeFilm and Seance.CodeFilm = @codeFilm", con))
            {
                SqlDataReader reader = null;
                cmd.Parameters.AddWithValue("@codeFilm", codeFilm);
                try
                {
                    await con.OpenAsync();
                    using (reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            imgEditPoster.Image = Image.FromStream(ReadPosterFromDB(codeFilm));
                            tbEditFilmName.Text = reader[5].ToString();
                            tbEditAge.Text = reader[4].ToString();
                            rtbEditSynopsis.Text = reader[6].ToString();
                            tbEditDuration.Text = reader[3].ToString();
                            tbEditDirector.Text = reader[8].ToString();
                            tbEditGenre.Text = reader[1].ToString();
                            tbEditLinkTrailer.Text = reader[7].ToString();
                            ddEditSeance.Items.Add(reader["Date"].ToString());
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void AddFilmToFlowLayoutPanel(int codeFilm, string Age, string Name, string Genre)
        {
            Panel p = new Panel();
            p.Size = new Size(263, 398);
            p.BorderStyle = BorderStyle.None;
            p.Name = "p" + Convert.ToString(codeFilm);
            flowLayoutPanel1.Controls.Add(p);
            this.flowLayoutPanel1.Controls.SetChildIndex(p, 1);

            Bunifu.UI.WinForms.BunifuImageButton poster = new Bunifu.UI.WinForms.BunifuImageButton();
            poster.Location = new Point(43, 4);
            poster.Size = new Size(184, 255);
            poster.ImageMargin = 20;
            poster.Name = "ps" + Convert.ToString(codeFilm);
            poster.AllowZooming = true;
            poster.Click += new EventHandler(imgButtonBuy_Click);
            poster.Image = Image.FromStream(ReadPosterFromDB(codeFilm));
            p.Controls.Add(poster);

            Label age = new Label();
            age.AutoSize = false;
            age.Size = new Size(263, 21);
            age.TextAlign = ContentAlignment.MiddleCenter;
            age.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            age.ForeColor = Color.LightGray;
            age.Text = Age;
            age.Location = new Point(3, 257);
            p.Controls.Add(age);

            Label film = new Label();
            film.AutoSize = false;
            film.Size = new Size(263, 45);
            film.TextAlign = ContentAlignment.MiddleCenter;
            film.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            film.ForeColor = Color.White;
            film.Text = Name;
            film.Location = new Point(3, 279);
            p.Controls.Add(film);

            Label genre = new Label();
            genre.AutoSize = false;
            genre.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            genre.ForeColor = Color.LightGray;
            genre.Text = Genre;
            genre.Location = new Point(3, 329);
            genre.TextAlign = ContentAlignment.MiddleCenter;
            genre.Size = new Size(263, 21);
            p.Controls.Add(genre);

            BunifuButton bb = new BunifuButton();
            bb.Size = new Size(156, 40);
            bb.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            bb.ForeColor = Color.White;
            bb.ButtonText = "Купить билет";
            bb.Cursor = Cursors.Hand;
            bb.IdleBorderColor = Color.FromArgb(102, 102, 102);
            bb.IdleFillColor = Color.FromArgb(102, 102, 102);
            bb.onHoverState.BorderColor = Color.FromArgb(229, 9, 20);
            bb.onHoverState.FillColor = Color.FromArgb(229, 9, 20);
            bb.Location = new Point(57, 358);
            bb.Name = Convert.ToString(codeFilm);
            bb.Click += new EventHandler(buttonBuy_Click);
            p.Controls.Add(bb);
        }

        private void UpdateProfileData()
        {
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("UPDATE Profile SET Name = @name, SecName = @sName, Sex = @sex, " +
                "Login = @login, Phone = @phone WHERE CodeClient = @id", con))
            {
                SqlDataReader reader = null;
                cmd.Parameters.AddWithValue("@name", tbName.Text);
                cmd.Parameters.AddWithValue("@sName", tbSecName.Text);
                cmd.Parameters.AddWithValue("@sex", ddSex.Text);
                cmd.Parameters.AddWithValue("@login", tbLogin.Text);
                cmd.Parameters.AddWithValue("@phone", tbPhone.Text);
                cmd.Parameters.AddWithValue("@bDay", ddBirthday.Text);
                cmd.Parameters.AddWithValue("@id", idProf);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT BDay From Profile WHERE CodeClient = @id";
                    reader = cmd.ExecuteReader();                
                    reader.Read();
                    if (!reader[0].ToString().Equals(""))
                    {
                        ddBirthday.Value = Convert.ToDateTime(reader[0].ToString());
                        reader.Close();                     
                    }
                    else
                    {
                        reader.Close();
                        cmd.CommandText = "UPDATE Profile SET BDay = @bDay WHERE CodeClient = @id";
                        cmd.ExecuteNonQuery();
                    }
                    
                    Alerts.ShowDlg(Alerts.AlertType.success);
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void UpdatePassword()
        {
            bool success = false;
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("UPDATE Profile SET Password = @pass WHERE CodeClient = @id", con))
            {
                using (SqlCommand cmdCheck = new SqlCommand("SELECT Password FROM Profile WHERE CodeClient = @id and Password = @passCur", con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;

                        cmdCheck.Parameters.AddWithValue("@passCur", tbCurrentPassword.Text);
                        cmd.Parameters.AddWithValue("@pass", tbChoosePass.Text);
                        cmd.Parameters.AddWithValue("@id", idProf);
                        cmdCheck.Parameters.AddWithValue("@id", idProf);

                        using (reader = cmdCheck.ExecuteReader())
                        {
                            success = reader.Read();
                        }
                    }
                    catch (SqlException)
                    {
                        throw;
                    }
                    if (success)
                    {
                        if (tbChoosePass.Text.Equals(tbRepeatePass.Text) && tbChoosePass.Text.Length >= 8)
                        {
                            try
                            {
                                cmd.ExecuteNonQuery();
                                lblAlert.Visible = false;
                                Alerts.ShowDlg(Alerts.AlertType.success);
                            }
                            catch (SqlException)
                            {
                                throw;
                            }
                        }
                        else if (!tbChoosePass.Text.Equals(tbRepeatePass.Text))
                        {
                            lblAlert.Text = "Выбранные пароли не совпадают!";
                            lblAlert.Visible = true;
                        }
                        else if (tbChoosePass.Text.Length < 8)
                        {
                            lblAlert.Text = "Длина пароля не менее восьми символов!";
                            lblAlert.Visible = true;
                        }
                    }
                    else
                    {
                        lblAlert.Visible = true;
                        lblAlert.Text = "Неверный пароль!";
                    }
                }
            }
        }

        private void UpdateSeance()
        {
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("UPDATE Seance SET Price = @price, Date = @date WHERE CodeSeance = @codeSeance", con))
            {
                try
                {
                    con.Open();

                    for (int i = 0; i < seanceEdit.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@date", seanceEdit[i][0].ToString());
                        cmd.Parameters.AddWithValue("@price", seanceEdit[i][1].ToString());
                        cmd.Parameters.AddWithValue("@codeSeance", Convert.ToInt32(seanceEdit[i][2]));
                        cmd.ExecuteNonQuery();

                        cmd.Parameters.Clear();
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void UpdateAfisha()
        {
            int codeFilm = SelectCodeFilmFromName();
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("UPDATE Afisha SET Genre = @genre, Name = @name, Synopsis = @syn, Duration = @dur, " +
                "Age = @age, Director = @director, Link = @link WHERE CodeFilm = @codeFilm", con))
            {
                cmd.Parameters.AddWithValue("@codeFilm", codeFilm);
                cmd.Parameters.AddWithValue("@genre", tbEditGenre.Text);
                cmd.Parameters.AddWithValue("@name", tbEditFilmName.Text);
                cmd.Parameters.AddWithValue("@syn", rtbEditSynopsis.Text);
                cmd.Parameters.AddWithValue("@director", tbEditDirector.Text);
                cmd.Parameters.AddWithValue("@dur", tbEditDuration.Text);
                cmd.Parameters.AddWithValue("@age", tbEditAge.Text);
                cmd.Parameters.AddWithValue("@link", tbEditLinkTrailer.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    if (imgEditPoster.ImageLocation != null)
                    {
                        FileStream fs = new FileStream(imgEditPoster.ImageLocation, FileMode.Open);
                        byte[] imageData = null;
                        imageData = new byte[fs.Length];
                        fs.Read(imageData, 0, imageData.Length);
                        fs.Dispose();

                        cmd.CommandText = "UPDATE Afisha SET Poster = @poster WHERE CodeFilm = @codeFilm";
                        cmd.Parameters.AddWithValue("@poster", imageData);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "UPDATE Seance SET Date = @poster, Price =  WHERE CodeFilm = @codeFilm";
                    }

                    DeleteFilmFromFlowLayoutPanel(codeFilm);
                    AddFilmToFlowLayoutPanel(codeFilm, tbEditAge.Text, tbEditFilmName.Text, tbEditGenre.Text);
                    Alerts.ShowDlg(Alerts.AlertType.success);
                    ResetEditPage();
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void DeleteSeance()
        {
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Seats WHERE CodeSeance = @codeSeance", con))
            {
                try
                {
                    con.Open();

                    for (int i = 0; i < seanceDelete.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@codeSeance", Convert.ToInt32(seanceDelete[i][0]));
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    cmd.CommandText = "DELETE Seance WHERE CodeSeance = @codeSeance";
                    for (int i = 0; i < seanceDelete.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@codeSeance", Convert.ToInt32(seanceDelete[i][0]));
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void DeleteFilm()
        {
            int codeFilm = SelectCodeFilmFromName();
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM MyTickets WHERE CodeSeance in (SELECT CodeSeance FROM Seance WHERE CodeFilm = @codeFilm)", con))
            {
                cmd.Parameters.AddWithValue("@codeFilm", codeFilm);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM Seats WHERE CodeSeance in (SELECT CodeSeance FROM Seance WHERE CodeFilm = @codeFilm)";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM Seance WHERE CodeFilm = @codeFilm";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM Afisha WHERE CodeFilm = @codeFilm";
                    cmd.ExecuteNonQuery();                  

                    DeleteFilmFromFlowLayoutPanel(codeFilm);
                    Alerts.ShowDlg(Alerts.AlertType.success);
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void DeleteTickets()
        {
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM MyTickets WHERE CodeSeance = @codeSeance", con))
            {
                try
                {
                    con.Open();

                    for (int i = 0; i < seanceDelete.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@codeSeance", seanceDelete[i][0]);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }                   
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void DeleteFilmFromFlowLayoutPanel(int codeFilm)
        {
            foreach (Control item in flowLayoutPanel1.Controls.OfType<Panel>())
            {
                if (item.Name == "p" + Convert.ToString(codeFilm))
                    flowLayoutPanel1.Controls.Remove(item);
            }
        }

        private void InsertFilm()
        {
            int idF = 0;
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("INSERT into Afisha (Name, Genre, Duration, Age, Link, Synopsis, Poster, Director) " +
                " VALUES (@name, @genre, @duration, @age, @link, @synopsis, @poster, @director); SELECT SCOPE_IDENTITY();", con))
            {
                byte[] imageData;
                FileStream fs = new FileStream(imgAddPoster.ImageLocation, FileMode.Open);
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, imageData.Length);
                fs.Dispose();

                cmd.Parameters.AddWithValue("@name", tbEnterFilmName.Text);
                cmd.Parameters.AddWithValue("@genre", tbEnterGenre.Text);
                cmd.Parameters.AddWithValue("@duration", tbEnterDuration.Text);
                cmd.Parameters.AddWithValue("@director", tbDirector.Text);
                cmd.Parameters.AddWithValue("@age", tbEnterAge.Text);
                cmd.Parameters.AddWithValue("@link", tbEnterLinkTrailer.Text);
                cmd.Parameters.AddWithValue("@synopsis", rtbEnterSynopsis.Text);
                cmd.Parameters.AddWithValue("@poster", imageData);
                try
                {
                    con.Open();
                    idF = Convert.ToInt32(cmd.ExecuteScalar());
                    InsertSeance(idF);
                    AddFilmToFlowLayoutPanel(idF, tbEnterAge.Text, tbEnterFilmName.Text, tbEnterGenre.Text);
                    Alerts.ShowDlg(Alerts.AlertType.success);
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void InsertSeance(int idF)
        {
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("INSERT into Seance (CodeFilm, Price, Date) VALUES (@codeFilm, @price, @date)", con))
            {
                try
                {
                    con.Open();
                    for (int i = 0; i < seanceAdd.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@date", seanceAdd[i][0].ToCharArray());
                        cmd.Parameters.AddWithValue("@price", seanceAdd[i][1].ToCharArray());
                        cmd.Parameters.AddWithValue("@codeFilm", idF);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private async void InsertCodeSeanceAndSeatInSeats()
        {
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("INSERT into Seats (CodeSeance, Seat) VALUES (@codeSeance, @seat)", con))
            {
                int row = 0, col = 0;
                try
                {
                    await con.OpenAsync();

                    for (int i = 0; i < seanceAdd.Count; i++)
                    {
                        int code = SelectCodeSeanceFromDate(seanceAdd[i][0].ToString());
                        for (int j = 0; j < 190; j++)
                        {
                            cmd.Parameters.AddWithValue("@codeSeance", code);
                            cmd.Parameters.AddWithValue("@seat", seats[row, col].Name);
                            await cmd.ExecuteNonQueryAsync();
                            cmd.Parameters.Clear();
                            if (col <= 17)
                            {
                                col++;
                            }
                            else
                            {
                                col = 0;
                                if (row < 9)
                                {
                                    row++;
                                }
                            }
                        }
                    }
                    ResetAddPage();
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private MemoryStream ReadPosterFromDB(int id)
        {
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("SELECT Poster FROM Afisha WHERE CodeFilm = @codeFilm", con))
            {
                MemoryStream mstream = null;
                SqlDataReader reader = null;
                cmd.Parameters.AddWithValue("@codeFilm", id);
                try
                {
                    con.Open();
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["Poster"] != null)
                            {
                                byte[] data = reader["Poster"] as byte[] ?? null;
                                mstream = new MemoryStream(data);
                            }
                        }
                    }
                    return mstream;
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void OpenPoster(Bunifu.UI.WinForms.BunifuImageButton imgBtn)
        {
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(openFileDialog1.FileName);
                    imgBtn.Image = new Bitmap(image);
                    imgBtn.ImageLocation = openFileDialog1.FileName;
                    imgBtn.Invalidate();
                    openFileDialog1.Dispose();
                }
                catch
                {
                    DialogResult result = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetAddPage()
        {
            tbEnterAge.Clear();
            tbEnterDuration.Clear();
            tbEnterFilmName.Clear();
            tbEnterGenre.Clear();
            tbEnterLinkTrailer.Clear();
            tbEnterPrice.Clear();
            tbEnterSeance.Clear();
            tbDirector.Clear();
            ddEnterSeance.Items.Clear();
            rtbEnterSynopsis.Clear();
            if (imgAddPoster.Image != null)
            {
                imgAddPoster.Image.Dispose();
            }

            cbPoster.AutoCheck = true;
            cbPoster.Checked = false;
            separator1.LineColor = Color.FromArgb(64, 64, 64);

            cbInfo.AutoCheck = true;
            cbInfo.Checked = false;
            separator2.LineColor = Color.FromArgb(64, 64, 64);

            cbFinish.AutoCheck = true;
            cbFinish.Checked = false;
            cbSeance.AutoCheck = true;
            cbSeance.Checked = false;
            separator3.LineColor = Color.FromArgb(64, 64, 64);

            seanceAdd.Clear();
            ddEnterSeance.Items.Clear();
            lblFieldsFillAlert.Visible = false;
            lblAddSeanceAlert.Visible = false;
            lblAddSeanceAlert2.Visible = false;
            ddEnterSeance.Text = "Сеансы";

            pageAddFilm.SetPage("Постер");
        }

        private void ResetEditPage()
        {
            tbEditAge.Clear();
            tbEditDuration.Clear();
            tbEditFilmName.Clear();
            tbEditGenre.Clear();
            tbEditLinkTrailer.Clear();
            tbEditPrice.Clear();
            tbEditSeance.Clear();
            tbEditDirector.Clear();
            ddEditSeance.Items.Clear();
            rtbEditSynopsis.Clear();
            imgEditPoster.Image.Dispose();

            cbEditPoster.AutoCheck = true;
            cbEditPoster.Checked = false;
            separatorEdit1.LineColor = Color.FromArgb(64, 64, 64);

            cbEditInfo.AutoCheck = true;
            cbEditInfo.Checked = false;
            separatorEdit2.LineColor = Color.FromArgb(64, 64, 64);

            cbEditFinish.AutoCheck = true;
            cbEditFinish.Checked = false;
            cbEditSeance.AutoCheck = true;
            cbEditSeance.Checked = false;
            separatorEdit3.LineColor = Color.FromArgb(64, 64, 64);

            cbEditFilm.AutoCheck = true;
            cbEditFilm.Checked = false;
            separatorEdit4.LineColor = Color.FromArgb(64, 64, 64);

            ddEditChooseFilm.Text = "Выберите фильм";
            ddEditSeance.Items.Clear();
            ddEditSeance.Text = "Сеансы";
            seanceEdit.Clear();
            seanceAdd.Clear();
            seanceDelete.Clear();
            lblFieldsFillAlert2.Visible = false;
            lblChooseSeanceAlert.Visible = false;
            pageEditFilm.SetPage("Фильм");
        }

        private void ResetSeats()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (seats[i, j].Checked)
                    {
                        seats[i, j].Checked = false;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    seats[i, j].Enabled = false;
                    seats[i, j].Refresh();
                }
            }
        }

        private void TrailerURL(string url)
        {
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\"/>" +
            "</head><body>" +
            "<iframe width=\"600\"  height = \"300\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; picture-in-picture\"; encrypted-media\" ></iframe>" +
            "</body></html>";
            webBrowser1.DocumentText = string.Format(embed, url);
            webBrowser1.Visible = true;
        }

        private async void SaveSettings()
        {

            using (SqlConnection con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("UPDATE Profile SET Autostart = @autostart, Tray = @tray WHERE CodeClient = @id", con))
            {
                cmd.Parameters.AddWithValue("@autostart", switchAutoStart.Value);
                cmd.Parameters.AddWithValue("@tray", switchWorkClose.Value);
                cmd.Parameters.AddWithValue("@id", idProf);
                try
                {
                    await con.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
                catch (SqlException)
                {

                    throw;
                }
            }
        }

        public void Autorun(bool autorun)
        {
            string Path = Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                {
                    reg.SetValue("Cinema", Path);
                }
                else
                {
                    reg.DeleteValue("Cinema");
                }
                reg.Close();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void MinimizeTray(bool min)
        {
            if (min)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
            else
            {
                if (con != null)
                {
                    con.Close();
                }
                Application.Exit();
            }
        }

        private int SelectCodeFilmFromName()
        {
            int codeFilm = 0;
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("SELECT CodeFilm FROM Afisha WHERE Name = @name", con))
            {
                SqlDataReader reader = null;
                cmd.Parameters.AddWithValue("@name", ddEditChooseFilm.SelectedItem);
                try
                {
                    con.OpenAsync();
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            codeFilm = Convert.ToInt32(reader[0].ToString());
                        }
                    }
                    return codeFilm;
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private int SelectCodeSeanceFromDate(string date)
        {
            int codeSeance = 0;
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("SELECT CodeSeance FROM Seance WHERE Date = @date", con))
            {
                SqlDataReader reader = null;
                cmd.Parameters.AddWithValue("@date", date);
                try
                {
                    con.OpenAsync();
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            codeSeance = Convert.ToInt32(reader[0].ToString());
                        }
                    }
                    return codeSeance;
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private void GetSeats()
        {
            int row = 1, col = 1;
            int code = SelectCodeSeanceFromDate(ddSeance.SelectedItem.ToString());
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("SELECT (Price), (Engaged) FROM [Seance], [Seats] WHERE Seance.CodeSeance = @codeSeance and " +
                " Seats.CodeSeance = @codeSeance", con))
            {
                SqlDataReader reader = null;
                cmd.Parameters.AddWithValue("@codeSeance", code);
                try
                {
                   con.Open();
                    using (reader = cmd.ExecuteReader())
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 19; j++)
                            {
                                reader.Read();
                                price = Convert.ToDouble(reader[0].ToString());
                                seats[i, j].ToolTipText = "Ряд: " + Convert.ToString(row) + ", Место: " + Convert.ToString(col++) + 
                                    "\nЦена: " + price.ToString() + " р.";
                                if (!Convert.ToBoolean(reader[1].ToString()))
                                {
                                    seats[i, j].Enabled = true;
                                    seats[i, j].Refresh();
                                }
                            }
                            row++;
                            col = 1;
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
            }          
        }

        private void RenameSeats()
        {
            int ind = 0;
            seats = new BunifuCheckBox[10, 19];
            BunifuCheckBox[] unsortedSeats = new BunifuCheckBox[190];
            BunifuCheckBox buf = new BunifuCheckBox();
            foreach (Control cb in pnlTicketsSeats.Controls)
            {
                if (cb is BunifuCheckBox && Convert.ToString(cb.Tag) != "ex")
                {
                    if (ind <= 189)
                    {
                        unsortedSeats[ind] = (BunifuCheckBox)cb;
                        unsortedSeats[ind].Name = unsortedSeats[ind].Name.Remove(0, 14);
                    }
                    ind += 1;
                }           
            }
            ind = 0;
          
            for (int i = 0; i < 190; i++)
            {
                for (int j = 0; j < 190 - i - 1; j++)
                {
                    if (Convert.ToInt32(unsortedSeats[j].Name) > Convert.ToInt32(unsortedSeats[j + 1].Name))
                    {
                        buf = unsortedSeats[j];
                        unsortedSeats[j] = unsortedSeats[j + 1];
                        unsortedSeats[j + 1] = buf;
                    }
                }
            }
            int row = 1, col = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    seats[i, j] = unsortedSeats[ind++];
                    seats[i, j].Name = Convert.ToString(row) + Convert.ToString(col++);
                }
                row++;
                col = 1;
            }
        }

        private bool CheckSeance(string seance)
        {
            using (con = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("SELECT Date FROM Seance WHERE Date = @date", con))
            {
                SqlDataReader reader = null;
                cmd.Parameters.AddWithValue("date", seance);

                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    return reader.Read();                 
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }

        private string CorrectPrice(string price)
        {
            if (price.Contains("."))
            {
                price = price.Replace(".", ",");
            }
            return price;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            BuyTicketFill(Convert.ToInt32(((BunifuButton)sender).Name));
            pageSubMenuAfisha.Visible = false;
            pageSubMenuAfisha.SetPage("Купить билет");
            pageSubMenuAfisha.Visible = true;
            pnlFilm.VerticalScroll.Value = pnlFilm.VerticalScroll.Maximum;
        }

        private void imgButtonBuy_Click(object sender, EventArgs e)
        {
            BuyTicketFill(Convert.ToInt32(((Bunifu.UI.WinForms.BunifuImageButton)sender).Name.TrimStart('p', 's')));
            pnlFilm.VerticalScroll.Value = 0;
            pageSubMenuAfisha.Visible = false;
            pageSubMenuAfisha.SetPage("Купить билет");
            pageSubMenuAfisha.Visible = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            bButton_Click(sender, e);
            Dialogs.ShowDlg(Dialogs.DialogType.confAdd);
            if (isConf)
            {
                InsertFilm();
                InsertCodeSeanceAndSeatInSeats();
            }
        }

        private void btnDeleteSeance_Click(object sender, EventArgs e)
        {
            bButton_Click(sender, e);

            if (ddEnterSeance.SelectedIndex != -1)
            {
                seanceAdd.RemoveAt(ddEnterSeance.SelectedIndex);
                ddEnterSeance.Items.RemoveAt(ddEnterSeance.SelectedIndex);
                ddEnterSeance.Text = "Сеансы";
            }
        }
        private void label_Enter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.LightGray;
        }

        private void label_Leave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.White;
        }

        private void button_Click(object sender, EventArgs e)
        {
            ((BunifuFlatButton)sender).Visible = false;
            transButton.ShowSync(((BunifuFlatButton)sender));
        }

        private void bButton_Click(object sender, EventArgs e)
        {
            ((BunifuButton)sender).Visible = false;
            transButton.ShowSync(((BunifuButton)sender));
            ((BunifuButton)sender).Focus();
        }

        private void btnMinMenu_Click(object sender, EventArgs e)
        {
            pageSubMenuAfisha.Visible = false;
            lblLogo.Visible = false;
            panelMenu.Visible = false;
            pageSubMenuProfile.Visible = false;
            btnScroll.IconMarginLeft = 530;
            panelMenu.Width = 46;
            btnMaxMenu.Visible = true;
            flowLayoutPanel1.Location = new Point(0, 0);
            btnAfisha.Width = 44;
            btnProfile.Width = 44;
            btnOptions.Width = 44;
            btnReports.Width = 44;
            transMenu.ShowSync(panelMenu);
            pageSubMenuAfisha.Visible = true;
            pageSubMenuProfile.Visible = true;
            btnScroll.IconMarginLeft = 530;
        }

        private void btnMaxMenu_Click(object sender, EventArgs e)
        {
            pageSubMenuAfisha.Visible = false;
            panelMenu.Visible = false;
            panelMenu.Width = 173;
            btnMaxMenu.Visible = false;
            pageSubMenuProfile.Visible = false;
            btnScroll.IconMarginLeft = 472;
            flowLayoutPanel1.Location = new Point(62, 0);
            btnAfisha.Width = 171;
            btnProfile.Width = 171;
            btnOptions.Width = 171;
            btnReports.Width = 171;
            transMenu.ShowSync(panelMenu);
            pageSubMenuAfisha.Visible = true;
            transLogo.ShowSync(lblLogo);
            pageSubMenuProfile.Visible = true;
            
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            MinimizeTray(switchWorkClose.Value);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            pageMenu.SetPage("Профиль");
        }

        private void btnFilms_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            pageMenu.SetPage("Афиша");
        }

        private void btnSeats_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            pageMenu.SetPage("Отчёты");
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            pageMenu.SetPage("Настройки");
        }

        private void lblProfile_Click(object sender, EventArgs e)
        {
            selectorProfile.Visible = false;
            ddSex.Focus();
            selectorProfile.Left = ((Control)sender).Left;
            selectorProfile.Width = ((Control)sender).Width;
            transSelector.ShowSync(selectorProfile);
            pageSubMenuProfile.SetPage("Настройки профиля");
        }

        private void lblTickets_Click(object sender, EventArgs e)
        {
            selectorProfile.Visible = false;
            selectorProfile.Left = ((Control)sender).Left;
            selectorProfile.Width = ((Control)sender).Width;
            transSelector.ShowSync(selectorProfile);
            MyTicketsFill();
            pageSubMenuProfile.SetPage("Активные билеты");
        }

        private void lblOptions_Click(object sender, EventArgs e)
        {
            selectorOptions.Visible = false;
            selectorOptions.Left = ((Control)sender).Left;
            selectorOptions.Width = ((Control)sender).Width;
            transSelector.ShowSync(selectorOptions);
            pageMenu.SetPage("Настройки");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            bButton_Click(sender, e);
            Dialogs.ShowDlg(Dialogs.DialogType.confExit);
            if (isConf)
            {
                Properties.Settings.Default.Id = 0;
                FormLogIn fs = new FormLogIn();
                this.Close();
                fs.Show();
            }
        }

        private void lblFilmToday_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            webBrowser1.DocumentText = null;
            selectorFilms.Visible = false;
            ddSex.Focus();
            selectorFilms.Left = ((Control)sender).Left;
            selectorFilms.Width = ((Control)sender).Width;
            transSelector.ShowSync(selectorFilms);
            ResetSeats();
            pageSubMenuAfisha.SetPage("Сейчас в кино");
        }

        private void btnSaveData_Click_1(object sender, EventArgs e)
        {
            bButton_Click(sender, e);
            Dialogs.ShowDlg(Dialogs.DialogType.saveData);
            if (isConf)
                UpdateProfileData();
        }

        private void btnSavePass_Click_1(object sender, EventArgs e)
        {
            bButton_Click(sender, e);
            Dialogs.ShowDlg(Dialogs.DialogType.savePass);
            if (isConf)
                UpdatePassword();
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            pageSubMenuAfisha.Visible = false;
            pageSubMenuAfisha.SetPage("Купить билет");
            pageSubMenuAfisha.Visible = true;
        }

        private void lblFilmAdd_Click(object sender, EventArgs e)
        {
            selectorFilms.Visible = false;
            selectorFilms.Left = ((Control)sender).Left;
            selectorFilms.Width = ((Control)sender).Width;
            transSelector.ShowSync(selectorFilms);
            pageSubMenuAfisha.SetPage("Добавить фильм");
        }

        private void lblFilmEdit_Click(object sender, EventArgs e)
        {
            ddEditChooseFilm.SelectedIndex = -1;
            ddEditChooseFilm.Text = "Выберите фильм";          
            selectorFilms.Visible = false;
            ddSex.Focus();
            selectorFilms.Left = ((Control)sender).Left;
            selectorFilms.Width = ((Control)sender).Width;
            transSelector.ShowSync(selectorFilms);
            pageSubMenuAfisha.SetPage("Редактировать фильм");
        }

        private void btnNextInfo_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                pageAddFilm.SetPage("Информация");
                lblProgressInfo.Focus();
                image.Dispose();
            }
        }

        private void pageAddFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (pageAddFilm.SelectedIndex)
            {
                case 1:
                    cbPoster.Checked = cbPoster.Enabled = true;
                    cbPoster.AutoCheck = false;
                    separator1.LineColor = Color.White;
                    break;
                case 3:
                    cbInfo.Checked = cbInfo.Enabled = true;
                    cbInfo.AutoCheck = false;
                    separator2.LineColor = Color.White;
                    break;
                case 4:
                    cbSeance.Checked = cbSeance.Enabled = true;
                    cbSeance.AutoCheck = false;
                    cbFinish.Checked = cbFinish.Enabled = true;
                    cbFinish.AutoCheck = false;
                    separator3.LineColor = Color.White;
                    break;
            }
        }

        private void btnPrevPoster_Click(object sender, EventArgs e)
        {           
            pageAddFilm.SetPage("Постер");
            cbPoster.AutoCheck = true;
            cbPoster.Checked = false;
            separator1.LineColor = Color.FromArgb(64, 64, 64);
        }

        private void imgAddPoster_Click(object sender, EventArgs e)
        {
            OpenPoster(imgAddPoster);
        }

        private void btnNextInfo2_Click(object sender, EventArgs e)
        {
            pageAddFilm.SetPage("Описание");
        }

        private void btnPrevInfo2_Click(object sender, EventArgs e)
        {
            pageAddFilm.SetPage("Информация");
            lblProgressInfo.Focus();
        }

        private void btnNextSeance_Click(object sender, EventArgs e)
        {
            pageAddFilm.SetPage("Сеансы");
        }

        private void btnPrevSinopsis_Click(object sender, EventArgs e)
        {
            pageAddFilm.SetPage("Описание");
            cbInfo.AutoCheck = true;
            cbInfo.Checked = false;
            separator2.LineColor = Color.FromArgb(64, 64, 64);
        }

        private void btnPrevSeance_Click(object sender, EventArgs e)
        {
            pageAddFilm.SetPage("Сеансы");
            cbFinish.AutoCheck = true;
            cbFinish.Checked = false;
            cbSeance.AutoCheck = true;
            cbSeance.Checked = false;
            separator3.LineColor = Color.FromArgb(64, 64, 64);
        }

        private void btnNextFinish_Click(object sender, EventArgs e)
        {
            if (seanceAdd.Count != 0)
            {
                pageAddFilm.SetPage("Готово");
                lblAddSeanceAlert.Visible = false;
            }
            else
            {
                lblAddSeanceAlert.Visible = true;
            }
        }

        private void btnAddSeance_Click_2(object sender, EventArgs e)
        {
            bButton_Click(sender, e);
            if (tbEnterPrice.Text != "" && tbEnterSeance.Text != "")
            {
                if (!CheckSeance(tbEnterSeance.Text))
                {
                    ddEnterSeance.Items.Add(tbEnterSeance.Text);
                    seanceAdd.Add(new string[2]);
                    seanceAdd[seanceAdd.Count - 1][0] = tbEnterSeance.Text;
                    seanceAdd[seanceAdd.Count - 1][1] = CorrectPrice(tbEnterPrice.Text);
                    ddEnterSeance.SelectedItem = tbEnterSeance.Text;
                    tbEnterPrice.Clear();
                    tbEnterSeance.Clear();
                    lblFieldsFillAlert.Visible = false;
                    lblAddSeanceAlert.Visible = false;
                    lblEngagedSeanceAlert.Visible = false;
                }
                else
                {
                    lblEngagedSeanceAlert.Visible = true;
                }
            }
            else
            {
                lblFieldsFillAlert.Visible = true;
            }

        }

        private void btnEditNextPoster_Click(object sender, EventArgs e)
        {
            if (ddEditChooseFilm.SelectedItem != null)
            {
                EditAfishaFill();
                pageEditFilm.SetPage("Постер");
                lblEditProgressInfo.Focus();
                ddEditSeance.Items.Clear();
                tbEditSeance.Clear();
                ddEditSeance.Text = "Сеансы";
                seanceEdit.Clear();
            }
        }

        private void btnEditNextInfo_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                image.Dispose();
            }
            pageEditFilm.SetPage("Информация");
            lblEditProgressInfo.Focus();
        }

        private void btnEditNextInfo2_Click(object sender, EventArgs e)
        {
            pageEditFilm.SetPage("Описание");
        }

        private void btnEditNextSeance_Click(object sender, EventArgs e)
        {
            pageEditFilm.SetPage("Сеансы");
        }

        private void btnEditNextFinish_Click(object sender, EventArgs e)
        {
            if (ddEditSeance.Items.Count != 0)
            {
                pageEditFilm.SetPage("Готово");
                lblAddSeanceAlert2.Visible = false;
            }
            else
            {
                lblAddSeanceAlert2.Visible = true;
            }
        }

        private void btnEditPrevSeance_Click(object sender, EventArgs e)
        {
            pageEditFilm.SetPage("Сеансы");
            cbEditFinish.AutoCheck = true;
            cbEditFinish.Checked = false;
            cbEditSeance.AutoCheck = true;
            cbEditSeance.Checked = false;
            separatorEdit4.LineColor = Color.FromArgb(64, 64, 64);
        }

        private void btnEditPrevDescribtion_Click(object sender, EventArgs e)
        {
            pageEditFilm.SetPage("Описание");
            cbEditInfo.AutoCheck = true;
            cbEditInfo.Checked = false;
            separatorEdit3.LineColor = Color.FromArgb(64, 64, 64);
        }

        private void btnEditPrevInfo2_Click(object sender, EventArgs e)
        {
            pageEditFilm.SetPage("Информация");
            lblEditProgressInfo.Focus();
        }

        private void btnEditPrevPoster_Click(object sender, EventArgs e)
        {
            pageEditFilm.SetPage("Постер");
            cbEditPoster.AutoCheck = true;
            cbEditPoster.Checked = false;
            separatorEdit2.LineColor = Color.FromArgb(64, 64, 64);
        }

        private void btnEditPrevFilm_Click(object sender, EventArgs e)
        {
            pageEditFilm.SetPage("Фильм");
            cbEditFilm.AutoCheck = true;
            cbEditFilm.Checked = false;
            separatorEdit1.LineColor = Color.FromArgb(64, 64, 64);
        }

        private void pageEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (pageEditFilm.SelectedIndex)
            {
                case 1:
                    cbEditFilm.Checked = cbEditFilm.Enabled = true;
                    cbEditFilm.AutoCheck = false;
                    separatorEdit1.LineColor = Color.White;
                    break;
                case 2:
                    cbEditPoster.Checked = cbEditPoster.Enabled = true;
                    cbEditPoster.AutoCheck = false;
                    separatorEdit2.LineColor = Color.White;
                    break;
                case 4:
                    cbEditInfo.Checked = cbEditInfo.Enabled = true;
                    cbEditInfo.AutoCheck = false;
                    separatorEdit3.LineColor = Color.White;
                    break;
                case 5:
                    cbEditSeance.Checked = cbEditSeance.Enabled = true;
                    cbEditSeance.AutoCheck = false;
                    cbEditFinish.Checked = cbEditFinish.Enabled = true;
                    cbEditFinish.AutoCheck = false;
                    separatorEdit4.LineColor = Color.White;
                    break;
            }
        }

        private void lblHall1_Click(object sender, EventArgs e)
        {
            selectorHall1.Left = ((Control)sender).Left;
            selectorHall1.Width = ((Control)sender).Width;
            selectorHall1.Visible = false;
            transSelector.ShowSync(selectorHall1);
            pageMenu.SetPage("Места");
        }

        private void btnConfirmBuy_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count != 0)
            {
                bButton_Click(sender, e);
                Dialogs.ShowDlg(Dialogs.DialogType.confBuy);
                if (isConf)
                {
                    BuyTickets();
                    dgvTickets.Rows.Clear();
                    MyTicketsFill();
                }
            }
        }

        private void btnEditConfirm_Click(object sender, EventArgs e)
        {
            bButton_Click(sender, e);
            Dialogs.ShowDlg(Dialogs.DialogType.confEdit);
            if (isConf)
            {
                if (seanceAdd.Count != 0)
                {
                    InsertSeance(SelectCodeFilmFromName());
                    InsertCodeSeanceAndSeatInSeats();
                }
                if (seanceEdit.Count != 0)
                {
                    UpdateSeance();
                }
                if (seanceDelete.Count != 0)
                {
                    DeleteTickets();
                    DeleteSeance();
                    MyTicketsFill();
                }
                UpdateAfisha();
            }
        }

        private void switchAutoStart_OnValuechange(object sender, EventArgs e)
        {
            SaveSettings();
            Autorun(switchAutoStart.Value);
        }

        private void switchWorkClose_OnValuechange(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }

        private void сменитьАккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Id = 0;
            FormLogIn fs = new FormLogIn();
            this.Close();
            fs.Show();
        }

        private void imgEditPoster_Click(object sender, EventArgs e)
        {
            OpenPoster(imgEditPoster);
        }

        private void btnEditDeleteFilm_Click(object sender, EventArgs e)
        {
            if (ddEditChooseFilm.SelectedItem != null)
            {
                bButton_Click(sender, e);
                Dialogs.ShowDlg(Dialogs.DialogType.confDel);
                if (isConf)
                {
                    DeleteFilm();
                    MyTicketsFill();
                    ddEditChooseFilm.Text = "Выберите фильм";
                    ddEditChooseFilm.Items.Clear();
                    ddChooseEditFilmFill();
                }
            }
        }

        private void btnEditAddSeance_Click(object sender, EventArgs e)
        {
            bButton_Click(sender, e);
            if (tbEditPrice.Text != "" && tbEditSeance.Text != "")
            {
                if (!CheckSeance(tbEditSeance.Text))
                {
                    ddEditSeance.Items.Add(tbEditSeance.Text);
                    seanceAdd.Add(new string[2]);
                    seanceAdd[seanceAdd.Count - 1][0] = tbEditSeance.Text;
                    seanceAdd[seanceAdd.Count - 1][1] = CorrectPrice(tbEditPrice.Text);
                    ddEditSeance.SelectedItem = seanceAdd[seanceAdd.Count - 1][0];
                    tbEditSeance.Clear();
                    tbEditPrice.Clear();
                    lblFieldsFillAlert2.Visible = false;
                    lblAddSeanceAlert2.Visible = false;
                    lblEngagedSeanceAlert2.Visible = false;
                    lblChooseSeanceAlert.Visible = false;
                }
                else
                {
                    lblEngagedSeanceAlert2.Visible = true;
                    lblChooseSeanceAlert.Visible = false;
                }
            }
            else
            {
                lblFieldsFillAlert2.Visible = true;
                lblChooseSeanceAlert.Visible = false;
            }
        }

        private void btnEditDeleteSeance_Click(object sender, EventArgs e)
        {
            bButton_Click(sender, e);
            if (ddEditSeance.SelectedIndex != -1)
            {
                seanceDelete.Add(new string[1]);
                seanceDelete[seanceDelete.Count - 1][0] = Convert.ToString(SelectCodeSeanceFromDate(ddEditSeance.SelectedItem.ToString()));
                ddEditSeance.Items.Remove(ddEditSeance.SelectedItem);
                ddEditSeance.Text = "Сеансы";
                tbEditSeance.Clear();
                tbEditPrice.Clear();
                lblFieldsFillAlert2.Visible = false;
                lblAddSeanceAlert2.Visible = false;
                lblChooseSeanceAlert.Visible = false;
            }
            else
            {
                lblChooseSeanceAlert.Visible = true;
            }
        }

        private void btnUpdateSeance_Click(object sender, EventArgs e)
        {
            bButton_Click(sender, e);
            if (ddEditSeance.SelectedIndex != -1)
            {
                if (tbEditSeance.Text != "" && tbEditPrice.Text != "")
                {
                    if (!CheckSeance(tbEditSeance.Text))
                    {
                        for (int i = 0; i < seanceAdd.Count; i++)
                        {
                            if (seanceAdd[i][0].Equals(tbEditSeance.Text))
                            {
                                seanceAdd[i][0] = tbEditSeance.Text;
                                seanceAdd[i][1] = tbEditPrice.Text;
                                tbEditPrice.Clear();
                                tbEditSeance.Clear();
                                return;
                            }
                        }

                        seanceEdit.Add(new string[3]);
                        seanceEdit[seanceEdit.Count - 1][2] = Convert.ToString(SelectCodeSeanceFromDate(ddEditSeance.SelectedItem.ToString()));
                        ddEditSeance.Items.Remove(ddEditSeance.SelectedItem);
                        ddEditSeance.Items.Add(tbEditSeance.Text);
                        ddEditSeance.SelectedItem = tbEditSeance.Text;
                        seanceEdit[seanceEdit.Count - 1][0] = tbEditSeance.Text;
                        seanceEdit[seanceEdit.Count - 1][1] = CorrectPrice(tbEditPrice.Text);

                        tbEditPrice.Clear();
                        tbEditSeance.Clear();
                        lblFieldsFillAlert2.Visible = false;
                        lblChooseSeanceAlert.Visible = false;
                        lblEngagedSeanceAlert2.Visible = false;
                    }
                    else
                    {
                        lblEngagedSeanceAlert2.Visible = true;
                    }
                }
                else
                {
                    lblChooseSeanceAlert.Visible = false;
                    lblFieldsFillAlert2.Visible = true;
                }
            }
            else
            {
                lblChooseSeanceAlert.Visible = true;
                lblFieldsFillAlert2.Visible = false;
            }
        }

        private void ddSeance_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetSeats();
            GetSeats();
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            btnScroll.Visible = true;
            if (flowLayoutPanel1.Location == new Point(0, 0))
            {
                flowLayoutPanel1.Size = new Size(1090, 413);
            }
            else
            {
                flowLayoutPanel1.Size = new Size(1041, 413);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.VerticalScroll.Value = flowLayoutPanel1.VerticalScroll.Maximum;
            btnScroll.Visible = false;       
        }

        private void flowLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
            flowLayoutPanel1.Focus();       
        }

        private void ddEditSeance_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbEditSeance.Text = ddEditSeance.SelectedItem.ToString();
        }

        private void ddEditChooseFilm_Click(object sender, EventArgs e)
        {
            ddEditChooseFilm.Text = "Выберите фильм";
            ddEditChooseFilm.Items.Clear();
            ddChooseEditFilmFill();
        }
    }
}

