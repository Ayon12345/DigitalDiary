
namespace Diary.Presentation
{
    partial class SigninForm
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
            this.Name = new System.Windows.Forms.TextBox();
            this.Conbox = new System.Windows.Forms.TextBox();
            this.Passbox = new System.Windows.Forms.TextBox();
            this.SigninButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(193, 139);
            this.Name.Margin = new System.Windows.Forms.Padding(4);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(214, 37);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Conbox
            // 
            this.Conbox.Location = new System.Drawing.Point(193, 221);
            this.Conbox.Margin = new System.Windows.Forms.Padding(4);
            this.Conbox.Multiline = true;
            this.Conbox.Name = "Conbox";
            this.Conbox.Size = new System.Drawing.Size(214, 41);
            this.Conbox.TabIndex = 2;
            this.Conbox.Text = "Password";
            // 
            // Passbox
            // 
            this.Passbox.Location = new System.Drawing.Point(193, 298);
            this.Passbox.Margin = new System.Windows.Forms.Padding(4);
            this.Passbox.Multiline = true;
            this.Passbox.Name = "Passbox";
            this.Passbox.Size = new System.Drawing.Size(214, 36);
            this.Passbox.TabIndex = 3;
            this.Passbox.Text = "Confarm Password";
            // 
            // SigninButton
            // 
            this.SigninButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SigninButton.Location = new System.Drawing.Point(146, 379);
            this.SigninButton.Margin = new System.Windows.Forms.Padding(4);
            this.SigninButton.Name = "SigninButton";
            this.SigninButton.Size = new System.Drawing.Size(119, 55);
            this.SigninButton.TabIndex = 6;
            this.SigninButton.Text = "Signin";
            this.SigninButton.UseVisualStyleBackColor = false;
            this.SigninButton.UseWaitCursor = true;
            this.SigninButton.Click += new System.EventHandler(this.SigninButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(329, 379);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(122, 55);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.UseWaitCursor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SigninForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(619, 578);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SigninButton);
            this.Controls.Add(this.Passbox);
            this.Controls.Add(this.Conbox);
            this.Controls.Add(this.Name);
            //this.Name = "SigninForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SigninForm_FormClosing);
            this.Load += new System.EventHandler(this.SigninForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Conbox;
        private System.Windows.Forms.TextBox Passbox;
        private System.Windows.Forms.Button SigninButton;
        private System.Windows.Forms.Button CloseButton;
    }
}