using System;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Dialogs : Form
    {       
        public Dialogs(DialogType type)
        {
            InitializeComponent();

            switch (type)
            {
                case DialogType.savePass:
                    lblDialog.Text = "Подтвердить сохранение пароля?";
                    break;
                case DialogType.saveData:
                    lblDialog.Text = "Подтвердить сохранение данных?";
                    break;
                case DialogType.confEdit:
                    lblDialog.Text = "Подтвердить редактирование?";
                    break;
                case DialogType.confBuy:
                    lblDialog.Text = "Подтвердить покупку?";
                    break;
                case DialogType.confAdd:
                    lblDialog.Text = "Подтвердить добавление?";
                    break;
                case DialogType.confExit:
                    lblDialog.Text = "Вы действительно хотите выйти?";
                    break;
                case DialogType.confDel:
                    lblDialog.Text = "Подтвердить удаление?";
                    break;
                default:
                    break;
            }
        }

        public static void ShowDlg(DialogType type)
        {
            new Dialogs(type).ShowDialog();
        }

        public enum DialogType
        {
            savePass, saveData, confEdit, confBuy, confAdd, confExit, confDel
        }

        private void btnOkExit_Click(object sender, EventArgs e)
        {            
            FormMain.isConf = true;
            this.Close();
        }

        private void btnCancelExit_Click(object sender, EventArgs e)
        {
            FormMain.isConf = false;            
            this.Close();
        }
    }
}
