
namespace Labb_3_SQL_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox = new System.Windows.Forms.ListBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.labelButik = new System.Windows.Forms.Label();
            this.labelLagerSaldo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxButiker
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 15;
            this.ListBox.Location = new System.Drawing.Point(13, 27);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(195, 289);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBoxButiker_SelectedIndexChanged);
            // 
            // dataGridLagerSaldo
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(214, 27);
            this.DataGrid.Name = "dataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowTemplate.Height = 25;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(349, 259);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridLagerSaldo_CellContentClick);
            // 
            // labelButik
            // 
            this.labelButik.AutoSize = true;
            this.labelButik.Location = new System.Drawing.Point(13, 9);
            this.labelButik.Name = "labelButik";
            this.labelButik.Size = new System.Drawing.Size(34, 15);
            this.labelButik.TabIndex = 2;
            this.labelButik.Text = "Butik";
            // 
            // labelLagerSaldo
            // 
            this.labelLagerSaldo.AutoSize = true;
            this.labelLagerSaldo.Location = new System.Drawing.Point(214, 9);
            this.labelLagerSaldo.Name = "labelLagerSaldo";
            this.labelLagerSaldo.Size = new System.Drawing.Size(36, 15);
            this.labelLagerSaldo.TabIndex = 3;
            this.labelLagerSaldo.Text = "Lager";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(224, 293);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(488, 293);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Spara";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(305, 293);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 6;
            this.BtnRemove.Text = "Ta bort";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 328);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelLagerSaldo);
            this.Controls.Add(this.labelButik);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.ListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Josef Philip Databas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelButik;
        private System.Windows.Forms.Label labelLagerSaldo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnRemove;
    }
}

