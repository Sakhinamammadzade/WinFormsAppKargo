namespace WinFormsAppKargo
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCountry = new System.Windows.Forms.ComboBox();
            this.CmbPackages = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnprice = new System.Windows.Forms.Button();
            this.lblprice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country";
            // 
            // CmbCountry
            // 
            this.CmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCountry.FormattingEnabled = true;
            this.CmbCountry.Location = new System.Drawing.Point(1, 65);
            this.CmbCountry.Name = "CmbCountry";
            this.CmbCountry.Size = new System.Drawing.Size(182, 33);
            this.CmbCountry.TabIndex = 1;
            this.CmbCountry.SelectedIndexChanged += new System.EventHandler(this.CmbCountry_SelectedIndexChanged);
            // 
            // CmbPackages
            // 
            this.CmbPackages.FormattingEnabled = true;
            this.CmbPackages.Location = new System.Drawing.Point(3, 173);
            this.CmbPackages.Name = "CmbPackages";
            this.CmbPackages.Size = new System.Drawing.Size(182, 33);
            this.CmbPackages.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Packages";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(1, 291);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(180, 31);
            this.numericUpDown.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weight";
            // 
            // btnprice
            // 
            this.btnprice.Location = new System.Drawing.Point(1, 354);
            this.btnprice.Name = "btnprice";
            this.btnprice.Size = new System.Drawing.Size(112, 34);
            this.btnprice.TabIndex = 6;
            this.btnprice.Text = "GetPrice";
            this.btnprice.UseVisualStyleBackColor = true;
            this.btnprice.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblprice.Location = new System.Drawing.Point(12, 409);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(27, 32);
            this.lblprice.TabIndex = 7;
            this.lblprice.Text = "0";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.btnprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.CmbPackages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbCountry);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox CmbCountry;
        private ComboBox CmbPackages;
        private Label label2;
        private NumericUpDown numericUpDown;
        private Label label3;
        private Button btnprice;
        private Label lblprice;
    }
}