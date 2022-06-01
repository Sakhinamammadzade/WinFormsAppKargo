namespace WinFormsAppKargo
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmbPackages = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrCountry = new System.Windows.Forms.NumericUpDown();
            this.nmrPackages = new System.Windows.Forms.NumericUpDown();
            this.btnqiymet = new System.Windows.Forms.Button();
            this.btnqiymet2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbPackages
            // 
            this.CmbPackages.FormattingEnabled = true;
            this.CmbPackages.Location = new System.Drawing.Point(459, 81);
            this.CmbPackages.Name = "CmbPackages";
            this.CmbPackages.Size = new System.Drawing.Size(182, 33);
            this.CmbPackages.TabIndex = 9;
            this.CmbPackages.SelectedIndexChanged += new System.EventHandler(this.CmbPackages_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Packages";
           
            // 
            // CmbCountry
            // 
            this.CmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCountry.FormattingEnabled = true;
            this.CmbCountry.Location = new System.Drawing.Point(10, 81);
            this.CmbCountry.Name = "CmbCountry";
            this.CmbCountry.Size = new System.Drawing.Size(182, 33);
            this.CmbCountry.TabIndex = 7;
            this.CmbCountry.SelectedIndexChanged += new System.EventHandler(this.CmbCountry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Country";
          
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price";
            // 
            // nmrCountry
            // 
            this.nmrCountry.Enabled = false;
            this.nmrCountry.Location = new System.Drawing.Point(10, 204);
            this.nmrCountry.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.nmrCountry.Name = "nmrCountry";
            this.nmrCountry.Size = new System.Drawing.Size(180, 31);
            this.nmrCountry.TabIndex = 12;
            // 
            // nmrPackages
            // 
            this.nmrPackages.Enabled = false;
            this.nmrPackages.Location = new System.Drawing.Point(474, 204);
            this.nmrPackages.Name = "nmrPackages";
            this.nmrPackages.Size = new System.Drawing.Size(180, 31);
            this.nmrPackages.TabIndex = 13;
            // 
            // btnqiymet
            // 
            this.btnqiymet.Location = new System.Drawing.Point(0, 285);
            this.btnqiymet.Name = "btnqiymet";
            this.btnqiymet.Size = new System.Drawing.Size(212, 39);
            this.btnqiymet.TabIndex = 14;
            this.btnqiymet.Text = "Qiymet deyish";
            this.btnqiymet.UseVisualStyleBackColor = true;
            this.btnqiymet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnqiymet2
            // 
            this.btnqiymet2.Location = new System.Drawing.Point(474, 285);
            this.btnqiymet2.Name = "btnqiymet2";
            this.btnqiymet2.Size = new System.Drawing.Size(212, 39);
            this.btnqiymet2.TabIndex = 15;
            this.btnqiymet2.Text = "Qiymet deyish";
            this.btnqiymet2.UseVisualStyleBackColor = true;
            this.btnqiymet2.Click += new System.EventHandler(this.btnqiymet2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 16;
            this.button3.Text = "girish";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnqiymet2);
            this.Controls.Add(this.btnqiymet);
            this.Controls.Add(this.nmrPackages);
            this.Controls.Add(this.nmrCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbPackages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbCountry);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPackages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox CmbPackages;
        private Label label2;
        private ComboBox CmbCountry;
        private Label label1;
        private Label label3;
        private Label label4;
        private NumericUpDown nmrCountry;
        private NumericUpDown nmrPackages;
        private Button btnqiymet;
        private Button btnqiymet2;
        private Button button3;
    }
}