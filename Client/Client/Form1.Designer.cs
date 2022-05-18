
namespace Client
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
            this.SendButton = new System.Windows.Forms.Button();
            this.OutInfo = new System.Windows.Forms.RichTextBox();
            this.InputInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(477, 404);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(311, 34);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Отправить сообщение в чат";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // OutInfo
            // 
            this.OutInfo.Location = new System.Drawing.Point(12, 12);
            this.OutInfo.Name = "OutInfo";
            this.OutInfo.ReadOnly = true;
            this.OutInfo.Size = new System.Drawing.Size(776, 315);
            this.OutInfo.TabIndex = 3;
            this.OutInfo.Text = "";
            // 
            // InputInfo
            // 
            this.InputInfo.Location = new System.Drawing.Point(12, 333);
            this.InputInfo.Name = "InputInfo";
            this.InputInfo.Size = new System.Drawing.Size(776, 65);
            this.InputInfo.TabIndex = 4;
            this.InputInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputInfo);
            this.Controls.Add(this.OutInfo);
            this.Controls.Add(this.SendButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SendButton;
        public System.Windows.Forms.RichTextBox OutInfo;
        public System.Windows.Forms.RichTextBox InputInfo;
    }
}

