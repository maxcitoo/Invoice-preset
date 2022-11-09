namespace BPTest
{
    partial class Form2
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.richTextBoxWarning = new System.Windows.Forms.RichTextBox();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.richTextBox1Warning = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(68, 183);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(99, 26);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(0, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            // 
            // richTextBoxWarning
            // 
            this.richTextBoxWarning.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxWarning.Name = "richTextBoxWarning";
            this.richTextBoxWarning.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxWarning.TabIndex = 0;
            this.richTextBoxWarning.Text = "";
            // 
            // buttonK
            // 
            this.buttonK.Location = new System.Drawing.Point(46, 150);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(75, 23);
            this.buttonK.TabIndex = 0;
            this.buttonK.Text = "OK";
            this.buttonK.UseVisualStyleBackColor = true;
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(275, 150);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 23);
            this.buttonC.TabIndex = 1;
            this.buttonC.Text = "Cancel";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // richTextBox1Warning
            // 
            this.richTextBox1Warning.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1Warning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1Warning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1Warning.Location = new System.Drawing.Point(46, 65);
            this.richTextBox1Warning.Name = "richTextBox1Warning";
            this.richTextBox1Warning.Size = new System.Drawing.Size(304, 34);
            this.richTextBox1Warning.TabIndex = 2;
            this.richTextBox1Warning.Text = "Bitte stellen sie sicher das sie alle Änderungen gespeichert haben!!!\n";
            this.richTextBox1Warning.TextChanged += new System.EventHandler(this.richTextBox1Warning_TextChanged);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(399, 213);
            this.Controls.Add(this.richTextBox1Warning);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonK);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonOk;
        private Button buttonCancel;
        private RichTextBox richTextBoxWarning;
        private Button buttonK;
        private Button buttonC;
        private RichTextBox richTextBox1Warning;
    }
}