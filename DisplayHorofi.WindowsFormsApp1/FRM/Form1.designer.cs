namespace WindowsFormsAppNumberInWords
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnDisplayHorofi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(193, 48);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(132, 22);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "1";
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyUp);
            // 
            // btnDisplayHorofi
            // 
            this.btnDisplayHorofi.Location = new System.Drawing.Point(349, 41);
            this.btnDisplayHorofi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayHorofi.Name = "btnDisplayHorofi";
            this.btnDisplayHorofi.Size = new System.Drawing.Size(120, 59);
            this.btnDisplayHorofi.TabIndex = 1;
            this.btnDisplayHorofi.Text = "Display Letters";
            this.btnDisplayHorofi.UseVisualStyleBackColor = true;
            this.btnDisplayHorofi.Click += new System.EventHandler(this.btnDisplayHorofi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Number 0-99";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplayHorofi);
            this.Controls.Add(this.txtInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnDisplayHorofi;
        private System.Windows.Forms.Label label1;
    }
}

