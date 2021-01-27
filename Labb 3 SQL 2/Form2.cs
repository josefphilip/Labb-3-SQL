using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Labb_3_SQL_2
{
    public partial class Form2 : Form
    {
        private readonly List<Böcker> bookList;
        private readonly JosefPhilipBokHandelContext db;
        private readonly Form1 parentForm;

        public Form2(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            ButtonSpara.Enabled = false;
            TextBoxAntal.Enabled = false;
            ComboBoxButik.Enabled = false;
            db = JosefPhilipBokHandelContext.GetInstance();
            bookList = db.Böckers.ToList();
            foreach (var item in bookList) ListBoxBöckerTotal.Items.Add(item.Titel);
            var storeList = db.Butikers.ToList();
            foreach (var item in storeList) ComboBoxButik.Items.Add(item.Butiknamn);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxAntal_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxAntal.Text) || string.IsNullOrWhiteSpace(ComboBoxButik.Text))
                ButtonSpara.Enabled = false;
            else
                ButtonSpara.Enabled = true;
        }

        private void TextBoxAntal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            TextBoxAntal.MaxLength = 2;
        }

        private void ListBoxBöckerTotal_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxAntal.Enabled = true;
            ComboBoxButik.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void ButtonSpara_Click(object sender, EventArgs e)
        {
            int textBoxToINT;
            int.TryParse(TextBoxAntal.Text, out textBoxToINT);

            var bookTitle = ListBoxBöckerTotal.SelectedItem.ToString();
            var bookStoreName = ComboBoxButik.SelectedItem.ToString();
            var bookToSave = bookList.Where(x => x.Titel == bookTitle).FirstOrDefault();
            var bookStore = db.Butikers.Where(x => x.Butiknamn == bookStoreName)
                .FirstOrDefault();
            var bookExisting = db.LagerSaldos.Where(x => x.ButikId == bookStore.ButikId && x.Isbn == bookToSave.Isbn)
                .FirstOrDefault();

            if (bookExisting == null)
            {
                var saldoToAdd = new LagerSaldo
                {
                    Isbn = bookToSave.Isbn,
                    ButikId = bookStore.ButikId,
                    Antal = textBoxToINT
                };
                db.LagerSaldos.Add(saldoToAdd);
            }
            else
            {
                bookExisting.Antal += textBoxToINT;
            }

            db.SaveChanges();
            parentForm.DataGrid.Update();
            Close();
        }

        private void ComboBoxAffär_SelectedIndexChanged(object? sender, EventArgs e)
        {
        }
    }
}