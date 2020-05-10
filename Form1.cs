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
            DisplayListBox();

        }

        public void LoadDB()
        {
            try
            {
                DGVOwner.DataSource = myDatabase.FillDGVs("Owner");
                DGVOwner.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

                DGVCD.DataSource = myDatabase.FillDGVs("CD");
                DGVTracks.DataSource = myDatabase.FillDGVs("CDTracks");
            }
            catch (System.Exception ex)
            {

                MessageBox.Show("It didn't work!  " + ex.Message);
            }

        }







        private void DisplayListBox()
        {
            lbxGenre.DataSource = null;

            try
            {
                lbxGenre.DataSource = myDatabase.FillListBoxWithGenre();
            }
            catch (System.Exception ex)
            {

                MessageBox.Show("It didn't work!  " + ex.Message);
            }


        }

        private void lbxGenre_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtCDGenre.Text = lbxGenre.SelectedItem.ToString();
        }


        private void DGVOwner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //get the ID field of the owner. 
                int OwnerID = (int)DGVOwner.Rows[e.RowIndex].Cells[0].Value;
                DGVCD.DataSource = myDatabase.FillOtherDGVs("CD", "OwnerIDFK", OwnerID);

            }
            catch (System.Exception)
            {

                // don't want a message here
            }





        }

        private void DGVCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = (int)DGVCD.Rows[e.RowIndex].Cells[0].Value;
            DGVTracks.DataSource = myDatabase.FillOtherDGVs("CDTracks", "CDIDFK", ID);
        }

        private void DGVTracks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
