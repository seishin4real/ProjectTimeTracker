namespace ProjectTimeTracker.Forms
{
    partial class ArchivesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivesForm));
            this.lbEntries = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEntries
            // 
            this.lbEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(22)))), ((int)(((byte)(9)))));
            this.lbEntries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbEntries.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbEntries.FormattingEnabled = true;
            this.lbEntries.ItemHeight = 20;
            this.lbEntries.Location = new System.Drawing.Point(7, 7);
            this.lbEntries.Margin = new System.Windows.Forms.Padding(2);
            this.lbEntries.Name = "lbEntries";
            this.lbEntries.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbEntries.Size = new System.Drawing.Size(895, 374);
            this.lbEntries.TabIndex = 39;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(417, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "button1";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ArchivesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(909, 388);
            this.Controls.Add(this.lbEntries);
            this.Controls.Add(this.btnCancel);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ArchivesForm";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Archives";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbEntries;
        private System.Windows.Forms.Button btnCancel;
    }
}