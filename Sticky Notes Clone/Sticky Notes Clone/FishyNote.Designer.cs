namespace Sticky_Notes_Clone
{
    partial class FishyNote
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
            this.Inser_Text_Box = new System.Windows.Forms.TextBox();
            this.Close_Enter_Note_Box = new System.Windows.Forms.Button();
            this.Expand_Colapse_Note = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inser_Text_Box
            // 
            this.Inser_Text_Box.Location = new System.Drawing.Point(22, 87);
            this.Inser_Text_Box.Multiline = true;
            this.Inser_Text_Box.Name = "Inser_Text_Box";
            this.Inser_Text_Box.Size = new System.Drawing.Size(354, 300);
            this.Inser_Text_Box.TabIndex = 0;
            this.Inser_Text_Box.Text = "Enter your note text here...";
            // 
            // Close_Enter_Note_Box
            // 
            this.Close_Enter_Note_Box.BackColor = System.Drawing.Color.Red;
            this.Close_Enter_Note_Box.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Close_Enter_Note_Box.Location = new System.Drawing.Point(379, 0);
            this.Close_Enter_Note_Box.Name = "Close_Enter_Note_Box";
            this.Close_Enter_Note_Box.Size = new System.Drawing.Size(19, 19);
            this.Close_Enter_Note_Box.TabIndex = 1;
            this.Close_Enter_Note_Box.Text = "X";
            this.Close_Enter_Note_Box.UseVisualStyleBackColor = false;
            this.Close_Enter_Note_Box.Click += new System.EventHandler(this.Close_Enter_Note_Box_Click);
            // 
            // Expand_Colapse_Note
            // 
            this.Expand_Colapse_Note.Location = new System.Drawing.Point(22, 13);
            this.Expand_Colapse_Note.Name = "Expand_Colapse_Note";
            this.Expand_Colapse_Note.Size = new System.Drawing.Size(179, 34);
            this.Expand_Colapse_Note.TabIndex = 2;
            this.Expand_Colapse_Note.UseVisualStyleBackColor = true;
            this.Expand_Colapse_Note.Click += new System.EventHandler(this.Expand_Colapse_Note_Click);
            // 
            // FishyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.Expand_Colapse_Note);
            this.Controls.Add(this.Close_Enter_Note_Box);
            this.Controls.Add(this.Inser_Text_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FishyNote";
            this.Text = "FishyNote";
            this.Load += new System.EventHandler(this.FishyNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Inser_Text_Box;
        private System.Windows.Forms.Button Close_Enter_Note_Box;
        private System.Windows.Forms.Button Expand_Colapse_Note;
    }
}