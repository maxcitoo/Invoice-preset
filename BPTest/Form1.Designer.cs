namespace BPTest
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.comboBoxCount = new System.Windows.Forms.ComboBox();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.contentOutput = new System.Windows.Forms.RichTextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSubmit.Location = new System.Drawing.Point(622, 39);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(133, 28);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Hinzufügen";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // comboBoxCount
            // 
            this.comboBoxCount.FormattingEnabled = true;
            this.comboBoxCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxCount.Location = new System.Drawing.Point(360, 43);
            this.comboBoxCount.Name = "comboBoxCount";
            this.comboBoxCount.Size = new System.Drawing.Size(81, 23);
            this.comboBoxCount.TabIndex = 1;
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.Location = new System.Drawing.Point(25, 43);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(192, 23);
            this.textBoxProduct.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPrice.Location = new System.Drawing.Point(240, 43);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrice.TabIndex = 3;
            // 
            // contentOutput
            // 
            this.contentOutput.Location = new System.Drawing.Point(25, 105);
            this.contentOutput.Name = "contentOutput";
            this.contentOutput.ReadOnly = true;
            this.contentOutput.Size = new System.Drawing.Size(1155, 459);
            this.contentOutput.TabIndex = 4;
            this.contentOutput.Text = "";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonReset.Location = new System.Drawing.Point(770, 43);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(102, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Zurücksetzen";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 576);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.contentOutput);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxProduct);
            this.Controls.Add(this.comboBoxCount);
            this.Controls.Add(this.buttonSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSubmit;
        private ComboBox comboBoxCount;
        private TextBox textBoxProduct;
        private TextBox textBoxPrice;
        private RichTextBox contentOutput;
        private Button buttonReset;
    }
}