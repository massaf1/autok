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
            this.rogzitButton = new System.Windows.Forms.Button();
            this.testRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.idTextBox.Enter += new System.EventHandler(this.idTextBox_Enter);
            this.idTextBox.Leave += new System.EventHandler(this.idTextBox_Leave);
            // 
            // rendszamTextBox
            // 
            this.rendszamTextBox.Location = new System.Drawing.Point(154, 104);
            this.rendszamTextBox.Name = "rendszamTextBox";
            this.rendszamTextBox.Size = new System.Drawing.Size(346, 22);
            this.rendszamTextBox.TabIndex = 1;
            this.rendszamTextBox.Text = "Rendszam:";
            this.rendszamTextBox.Enter += new System.EventHandler(this.rendszamTextBox_Enter);
            this.rendszamTextBox.Leave += new System.EventHandler(this.rendszamTextBox_Leave);
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
            this.hozRadioButton.Click += new System.EventHandler(this.hozRadioButton_Click);
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
            this.viszRadioButton.Click += new System.EventHandler(this.viszRadioButton_Click);
            // 
            // kmTextBox
            // 
            this.kmTextBox.Location = new System.Drawing.Point(154, 271);
            this.kmTextBox.Name = "kmTextBox";
            this.kmTextBox.Size = new System.Drawing.Size(346, 22);
            this.kmTextBox.TabIndex = 4;
            this.kmTextBox.Text = "Mennyi a kilometerora?";
            this.kmTextBox.Visible = false;
            this.kmTextBox.Enter += new System.EventHandler(this.kmTextBox_Enter);
            this.kmTextBox.Leave += new System.EventHandler(this.kmTextBox_Leave);
            // 
            // rogzitButton
            // 
            this.rogzitButton.Location = new System.Drawing.Point(236, 374);
            this.rogzitButton.Name = "rogzitButton";
            this.rogzitButton.Size = new System.Drawing.Size(164, 64);
            this.rogzitButton.TabIndex = 7;
            this.rogzitButton.Text = "Rogzites";
            this.rogzitButton.UseVisualStyleBackColor = true;
            this.rogzitButton.Click += new System.EventHandler(this.rogzitButton_Click);
            // 
            // testRichTextBox
            // 
            this.testRichTextBox.Location = new System.Drawing.Point(569, 47);
            this.testRichTextBox.Name = "testRichTextBox";
            this.testRichTextBox.Size = new System.Drawing.Size(188, 245);
            this.testRichTextBox.TabIndex = 8;
            this.testRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(154, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mit csinalsz az autoval?";
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(593, 374);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(164, 64);
            this.adminButton.TabIndex = 10;
            this.adminButton.Text = "Adminisztracio";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testRichTextBox);
            this.Controls.Add(this.rogzitButton);
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

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.RichTextBox testRichTextBox;

        private System.Windows.Forms.Button rogzitButton;

        private System.Windows.Forms.Button adminButton;

        private System.Windows.Forms.RadioButton hozRadioButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox kmTextBox;
        private System.Windows.Forms.TextBox rendszamTextBox;
        private System.Windows.Forms.RadioButton viszRadioButton;

        #endregion
    }
}