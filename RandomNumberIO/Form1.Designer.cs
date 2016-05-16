namespace RandomNumberIO
{
    partial class RandomNumberIOForm
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
            this.txtQuantityInput = new System.Windows.Forms.TextBox();
            this.lblQuantityInput = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstFileOutput = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuantityInput
            // 
            this.txtQuantityInput.Location = new System.Drawing.Point(154, 25);
            this.txtQuantityInput.Name = "txtQuantityInput";
            this.txtQuantityInput.Size = new System.Drawing.Size(100, 20);
            this.txtQuantityInput.TabIndex = 0;
            this.txtQuantityInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantityInput_KeyPress);
            // 
            // lblQuantityInput
            // 
            this.lblQuantityInput.AutoSize = true;
            this.lblQuantityInput.Location = new System.Drawing.Point(74, 9);
            this.lblQuantityInput.Name = "lblQuantityInput";
            this.lblQuantityInput.Size = new System.Drawing.Size(265, 13);
            this.lblQuantityInput.TabIndex = 1;
            this.lblQuantityInput.Text = "How many random numbers would you like generated?";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(92, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Location = new System.Drawing.Point(173, 51);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstFileOutput
            // 
            this.lstFileOutput.FormattingEnabled = true;
            this.lstFileOutput.Location = new System.Drawing.Point(15, 88);
            this.lstFileOutput.Name = "lstFileOutput";
            this.lstFileOutput.Size = new System.Drawing.Size(381, 160);
            this.lstFileOutput.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(255, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // RandomNumberIOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 264);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstFileOutput);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblQuantityInput);
            this.Controls.Add(this.txtQuantityInput);
            this.Name = "RandomNumberIOForm";
            this.Text = "Random Number Reader/Writer v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantityInput;
        private System.Windows.Forms.Label lblQuantityInput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lstFileOutput;
        private System.Windows.Forms.Button btnClear;
    }
}

