using System.Windows.Forms;
using System.Threading.Tasks;

namespace Cinema
{
    public partial class FormLoad : Form
    {
        static FormLoad fl = null;
        public FormLoad()
        {
            InitializeComponent();
        }

        static private void ShowFormAsync()
        {
            fl = new FormLoad();
            fl.ShowDialog();
        }
        static public void CloseFormAsync()
        {
            fl.Close();
        }

        static public async void ShowLoadingScreen()
        {
            await Task.Run(() => ShowFormAsync());
        }

        static public async void CloseLoadingScreen()
        {
            await Task.Run(() => CloseFormAsync());
        }
    }
}
