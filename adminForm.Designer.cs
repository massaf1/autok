using System.ComponentModel;

namespace autok
{
    partial class adminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.masodikButton = new System.Windows.Forms.Button();
            this.harmadikButton = new System.Windows.Forms.Button();
            this.negyedikButton = new System.Windows.Forms.Button();
            this.otodikButton = new System.Windows.Forms.Button();
            this.hatodikButton = new System.Windows.Forms.Button();
            this.hetedikButton = new System.Windows.Forms.Button();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // masodikButton
            // 
            this.masodikButton.Location = new System.Drawing.Point(32, 30);
            this.masodikButton.Name = "masodikButton";
            this.masodikButton.Size = new System.Drawing.Size(79, 71);
            this.masodikButton.TabIndex = 0;
            this.masodikButton.Text = "2. feladat";
            this.masodikButton.UseVisualStyleBackColor = true;
            this.masodikButton.Click += new System.EventHandler(this.masodikButton_Click);
            // 
            // harmadikButton
            // 
            this.harmadikButton.Location = new System.Drawing.Point(117, 30);
            this.harmadikButton.Name = "harmadikButton";
            this.harmadikButton.Size = new System.Drawing.Size(79, 71);
            this.harmadikButton.TabIndex = 1;
            this.harmadikButton.Text = "3. feladat";
            this.harmadikButton.UseVisualStyleBackColor = true;
            this.harmadikButton.Click += new System.EventHandler(this.harmadikButton_Click);
            // 
            // negyedikButton
            // 
            this.negyedikButton.Location = new System.Drawing.Point(202, 30);
            this.negyedikButton.Name = "negyedikButton";
            this.negyedikButton.Size = new System.Drawing.Size(79, 71);
            this.negyedikButton.TabIndex = 2;
            this.negyedikButton.Text = "4. feladat";
            this.negyedikButton.UseVisualStyleBackColor = true;
            this.negyedikButton.Click += new System.EventHandler(this.negyedikButton_Click);
            // 
            // otodikButton
            // 
            this.otodikButton.Location = new System.Drawing.Point(287, 30);
            this.otodikButton.Name = "otodikButton";
            this.otodikButton.Size = new System.Drawing.Size(79, 71);
            this.otodikButton.TabIndex = 3;
            this.otodikButton.Text = "5. feladat";
            this.otodikButton.UseVisualStyleBackColor = true;
            this.otodikButton.Click += new System.EventHandler(this.otodikButton_Click);
            // 
            // hatodikButton
            // 
            this.hatodikButton.Location = new System.Drawing.Point(372, 30);
            this.hatodikButton.Name = "hatodikButton";
            this.hatodikButton.Size = new System.Drawing.Size(79, 71);
            this.hatodikButton.TabIndex = 4;
            this.hatodikButton.Text = "6. feladat";
            this.hatodikButton.UseVisualStyleBackColor = true;
            this.hatodikButton.Click += new System.EventHandler(this.hatodikButton_Click);
            // 
            // hetedikButton
            // 
            this.hetedikButton.Location = new System.Drawing.Point(457, 30);
            this.hetedikButton.Name = "hetedikButton";
            this.hetedikButton.Size = new System.Drawing.Size(79, 71);
            this.hetedikButton.TabIndex = 5;
            this.hetedikButton.Text = "7. feladat";
            this.hetedikButton.UseVisualStyleBackColor = true;
            this.hetedikButton.Click += new System.EventHandler(this.hetedikButton_Click);
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(32, 131);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(504, 22);
            this.inputTextbox.TabIndex = 6;
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Location = new System.Drawing.Point(32, 191);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(503, 232);
            this.outputRichTextBox.TabIndex = 7;
            this.outputRichTextBox.Text = "";
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.hetedikButton);
            this.Controls.Add(this.hatodikButton);
            this.Controls.Add(this.otodikButton);
            this.Controls.Add(this.negyedikButton);
            this.Controls.Add(this.harmadikButton);
            this.Controls.Add(this.masodikButton);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button harmadikButton;
        private System.Windows.Forms.Button hatodikButton;
        private System.Windows.Forms.Button hetedikButton;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Button negyedikButton;
        private System.Windows.Forms.Button otodikButton;
        private System.Windows.Forms.RichTextBox outputRichTextBox;

        private System.Windows.Forms.Button masodikButton;

        #endregion
    }
}