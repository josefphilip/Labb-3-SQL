using System;
using System.Linq;
using System.Windows.Forms;

namespace Labb_3_SQL_2
{
    public partial class Form1 : Form
    {
        private readonly JosefPhilipBokHandelContext db;
        private DataGridView dt;

        public Form1()
        {
            InitializeComponent();
            BtnRemove.Enabled = false;
            BtnSave.Enabled = false;

            db = JosefPhilipBokHandelContext.GetInstance();
            if (db.Database.CanConnect())
            {
                var storeList = db.Butikers.ToList();
                foreach (var item in storeList) ListBox.Items.Add(item.Butiknamn);
            }
            else
            {
                MessageBox.Show("Misslyckades med att få åtkomst till servern!", "Misslyckande");
            }
        }

        public ListBox ListBox { get; private set; }

        public DataGridView DataGrid { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ListBoxButiker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox.SelectedItem != null)
            {
                BtnRemove.Enabled = true;
                BtnSave.Enabled = true;
                LoadData();
            }
        }


        private void DataGridLagerSaldo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var dtISBN = dt.SelectedCells[2].Value.ToString();
            var dialogResult = MessageBox.Show("Är du säker på att du vill ta bort boken?", "Ta bort",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dt.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow item in dt.SelectedRows)
                    {
                        var booktoRemove = db.LagerSaldos.Where(x => x.Isbn == dtISBN)
                            .FirstOrDefault();
                        db.LagerSaldos.RemoveRange(booktoRemove);
                        dt.Rows.RemoveAt(item.Index);
                    }

                    dt.Update();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Är du säker på att du vill Spara? Alla ändringar du gör är permanenta.",
                "Spara", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.SaveChanges();
                dt.Update();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var f2 = new Form2(this);
            f2.FormClosed += Form2_Closing;
            f2.ShowDialog();
        }

        private void Form2_Closing(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var storeLoad = db.Butikers.Where(x => x.Butiknamn == ListBox.SelectedItem.ToString()).FirstOrDefault();

            dt = DataGrid;
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.Columns.Add("Böcker", "Böcker");
            dt.Columns.Add("Antal", "Antal");
            dt.Columns.Add("ISBN", "ISBN");

            var bookList = db.Böckers.ToList();

            foreach (var item in db.LagerSaldos.Where(x => x.ButikId == storeLoad.ButikId).ToList())
            {
                var book = bookList.Where(x => x.Isbn == item.Isbn).FirstOrDefault();
                var rowIndex = dt.Rows.Add();
                dt.Rows[rowIndex].Cells["ISBN"].Value = item.Isbn;
                dt.Rows[rowIndex].Cells["Antal"].Value = item.Antal;
                if (book != null) dt.Rows[rowIndex].Cells["Böcker"].Value = book.Titel;
            }
        }
    }
}