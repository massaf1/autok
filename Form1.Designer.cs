namespace autok
{
    partial class Form1
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.rendszamTextBox = new System.Windows.Forms.TextBox();
            this.hozRadioButton = new System.Windows.Forms.RadioButton();
            this.viszRadioButton = new System.Windows.Forms.RadioButton();
            this.kmTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.adminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(154, 40);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(346, 22);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.Text = "Id:";
            this.idTextBox.Click += new System.EventHandler(this.idTextBox_Click);
            // 
            // rendszamTextBox
            // 
            this.rendszamTextBox.Location = new System.Drawing.Point(154, 104);
            this.rendszamTextBox.Name = "rendszamTextBox";
            this.rendszamTextBox.Size = new System.Drawing.Size(346, 22);
            this.rendszamTextBox.TabIndex = 1;
            this.rendszamTextBox.Text = "Rendszam:";
            // 
            // hozRadioButton
            // 
            this.hozRadioButton.Location = new System.Drawing.Point(154, 194);
            this.hozRadioButton.Name = "hozRadioButton";
            this.hozRadioButton.Size = new System.Drawing.Size(104, 24);
            this.hozRadioButton.TabIndex = 2;
            this.hozRadioButton.TabStop = true;
            this.hozRadioButton.Text = "Hozom";
            this.hozRadioButton.UseVisualStyleBackColor = true;
            // 
            // viszRadioButton
            // 
            this.viszRadioButton.Location = new System.Drawing.Point(396, 194);
            this.viszRadioButton.Name = "viszRadioButton";
            this.viszRadioButton.Size = new System.Drawing.Size(104, 24);
            this.viszRadioButton.TabIndex = 3;
            this.viszRadioButton.TabStop = true;
            this.viszRadioButton.Text = "Viszem";
            this.viszRadioButton.UseVisualStyleBackColor = true;
            // 
            // kmTextBox
            // 
            this.kmTextBox.Location = new System.Drawing.Point(154, 271);
            this.kmTextBox.Name = "kmTextBox";
            this.kmTextBox.Size = new System.Drawing.Size(346, 22);
            this.kmTextBox.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(154, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(215, 22);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Mit csinalsz az autoval?";
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(624, 374);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(164, 64);
            this.adminButton.TabIndex = 6;
            this.adminButton.Text = "Adminisztacio";
            this.adminButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.kmTextBox);
            this.Controls.Add(this.viszRadioButton);
            this.Controls.Add(this.hozRadioButton);
            this.Controls.Add(this.rendszamTextBox);
            this.Controls.Add(this.idTextBox);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button adminButton;

        private System.Windows.Forms.RadioButton hozRadioButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox kmTextBox;
        private System.Windows.Forms.TextBox rendszamTextBox;
        private System.Windows.Forms.RadioButton viszRadioButton;

        private System.Windows.Forms.TextBox textBox4;

        #endregion
    }
}