using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Alerts : Form
    {
        public Alerts(AlertType type)
        {
            InitializeComponent();

            switch (type)
            {
                case AlertType.success:
                    lblAlert.Text = "Операция выполнена";
                    this.BackColor = Color.FromArgb(0, 166, 95);
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    break;
                case AlertType.error:
                    lblAlert.Text = "Ошибка выполнения";
                    this.BackColor = Color.FromArgb(229, 9, 20);
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;
                    break;
                default:
                    break;
            }
        }

        public static void ShowDlg(AlertType type)
        {
            new Alerts(type).ShowDialog();
        }

        public enum AlertType
        {
            success, error
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }   
    }
}
