namespace Zamestnanci
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonVlozit = new System.Windows.Forms.Button();
            this.buttonEditovat = new System.Windows.Forms.Button();
            this.buttonMazat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 450);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FirstName";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "LastName";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "BirthDate";
            this.columnHeader5.Width = 85;
            // 
            // buttonVlozit
            // 
            this.buttonVlozit.Location = new System.Drawing.Point(363, 12);
            this.buttonVlozit.Name = "buttonVlozit";
            this.buttonVlozit.Size = new System.Drawing.Size(75, 23);
            this.buttonVlozit.TabIndex = 1;
            this.buttonVlozit.Text = "Vložit";
            this.buttonVlozit.UseVisualStyleBackColor = true;
            this.buttonVlozit.Click += new System.EventHandler(this.buttonVlozit_Click);
            // 
            // buttonEditovat
            // 
            this.buttonEditovat.Location = new System.Drawing.Point(444, 12);
            this.buttonEditovat.Name = "buttonEditovat";
            this.buttonEditovat.Size = new System.Drawing.Size(75, 23);
            this.buttonEditovat.TabIndex = 2;
            this.buttonEditovat.Text = "Editovat";
            this.buttonEditovat.UseVisualStyleBackColor = true;
            this.buttonEditovat.Click += new System.EventHandler(this.buttonEditovat_Click);
            // 
            // buttonMazat
            // 
            this.buttonMazat.Location = new System.Drawing.Point(525, 12);
            this.buttonMazat.Name = "buttonMazat";
            this.buttonMazat.Size = new System.Drawing.Size(75, 23);
            this.buttonMazat.TabIndex = 3;
            this.buttonMazat.Text = "Mazat";
            this.buttonMazat.UseVisualStyleBackColor = true;
            this.buttonMazat.Click += new System.EventHandler(this.buttonMazat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMazat);
            this.Controls.Add(this.buttonEditovat);
            this.Controls.Add(this.buttonVlozit);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonVlozit;
        private System.Windows.Forms.Button buttonEditovat;
        private System.Windows.Forms.Button buttonMazat;
    }
}

