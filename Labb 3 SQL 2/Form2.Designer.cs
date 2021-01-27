
namespace Labb_3_SQL_2
{
    partial class Form2
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
            this.ComboBoxButik = new System.Windows.Forms.ComboBox();
            this.ListBoxBöckerTotal = new System.Windows.Forms.ListBox();
            this.labelBöcker = new System.Windows.Forms.Label();
            this.labelButik = new System.Windows.Forms.Label();
            this.TextBoxAntal = new System.Windows.Forms.TextBox();
            this.labelAntal = new System.Windows.Forms.Label();
            this.buttonAvbryt = new System.Windows.Forms.Button();
            this.ButtonSpara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxButik
            // 
            this.ComboBoxButik.FormattingEnabled = true;
            this.ComboBoxButik.Location = new System.Drawing.Point(254, 71);
            this.ComboBoxButik.Name = "ComboBoxButik";
            this.ComboBoxButik.Size = new System.Drawing.Size(121, 23);
            this.ComboBoxButik.TabIndex = 0;
            this.ComboBoxButik.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAffär_SelectedIndexChanged);
            // 
            // ListBoxBöckerTotal
            // 
            this.ListBoxBöckerTotal.FormattingEnabled = true;
            this.ListBoxBöckerTotal.ItemHeight = 15;
            this.ListBoxBöckerTotal.Location = new System.Drawing.Point(12, 28);
            this.ListBoxBöckerTotal.Name = "ListBoxBöckerTotal";
            this.ListBoxBöckerTotal.Size = new System.Drawing.Size(219, 214);
            this.ListBoxBöckerTotal.TabIndex = 1;
            this.ListBoxBöckerTotal.SelectedIndexChanged += new System.EventHandler(this.ListBoxBöckerTotal_SelectedIndexChanged);
            // 
            // labelBöcker
            // 
            this.labelBöcker.AutoSize = true;
            this.labelBöcker.Location = new System.Drawing.Point(12, 9);
            this.labelBöcker.Name = "labelBöcker";
            this.labelBöcker.Size = new System.Drawing.Size(43, 15);
            this.labelBöcker.TabIndex = 2;
            this.labelBöcker.Text = "Böcker";
            // 
            // labelButik
            // 
            this.labelButik.AutoSize = true;
            this.labelButik.Location = new System.Drawing.Point(254, 53);
            this.labelButik.Name = "labelButik";
            this.labelButik.Size = new System.Drawing.Size(34, 15);
            this.labelButik.TabIndex = 3;
            this.labelButik.Text = "Butik";
            // 
            // TextBoxAntal
            // 
            this.TextBoxAntal.Location = new System.Drawing.Point(254, 151);
            this.TextBoxAntal.Name = "TextBoxAntal";
            this.TextBoxAntal.Size = new System.Drawing.Size(121, 23);
            this.TextBoxAntal.TabIndex = 4;
            this.TextBoxAntal.TextChanged += new System.EventHandler(this.TextBoxAntal_TextChanged);
            this.TextBoxAntal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAntal_KeyPress);
            // 
            // labelAntal
            // 
            this.labelAntal.AutoSize = true;
            this.labelAntal.Location = new System.Drawing.Point(254, 133);
            this.labelAntal.Name = "labelAntal";
            this.labelAntal.Size = new System.Drawing.Size(35, 15);
            this.labelAntal.TabIndex = 5;
            this.labelAntal.Text = "Antal";
            // 
            // buttonAvbryt
            // 
            this.buttonAvbryt.Location = new System.Drawing.Point(237, 219);
            this.buttonAvbryt.Name = "buttonAvbryt";
            this.buttonAvbryt.Size = new System.Drawing.Size(75, 23);
            this.buttonAvbryt.TabIndex = 6;
            this.buttonAvbryt.Text = "Avbryt";
            this.buttonAvbryt.UseVisualStyleBackColor = true;
            this.buttonAvbryt.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ButtonSpara
            // 
            this.ButtonSpara.Location = new System.Drawing.Point(328, 219);
            this.ButtonSpara.Name = "ButtonSpara";
            this.ButtonSpara.Size = new System.Drawing.Size(75, 23);
            this.ButtonSpara.TabIndex = 7;
            this.ButtonSpara.Text = "Spara";
            this.ButtonSpara.UseVisualStyleBackColor = true;
            this.ButtonSpara.Click += new System.EventHandler(this.ButtonSpara_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(415, 258);
            this.Controls.Add(this.ButtonSpara);
            this.Controls.Add(this.buttonAvbryt);
            this.Controls.Add(this.labelAntal);
            this.Controls.Add(this.TextBoxAntal);
            this.Controls.Add(this.labelButik);
            this.Controls.Add(this.labelBöcker);
            this.Controls.Add(this.ListBoxBöckerTotal);
            this.Controls.Add(this.ComboBoxButik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxButik;
        private System.Windows.Forms.ListBox listBoxBöcker;
        private System.Windows.Forms.Label labelBöcker;
        private System.Windows.Forms.Label labelButik;
        private System.Windows.Forms.TextBox TextBoxAntal;
        private System.Windows.Forms.Label labelAntal;
        private System.Windows.Forms.ListBox ListBoxBöckerTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ButtonSpara;
        private System.Windows.Forms.Button buttonAvbryt;
    }
}

