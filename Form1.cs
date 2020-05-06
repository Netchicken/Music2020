using System.Windows.Forms;

namespace Music2020
{
    public partial class Form1 : Form
    {
        Database myDatabase = new Database();

        public Form1()
        {
            InitializeComponent();
            LoadDB();
        }

        public void LoadDB()
        {
            DGVOwner.DataSource = myDatabase.FillDGVOwnerWithOwner();
        }
    }
}
