namespace ProjectTimeTracker.Forms
{
    partial class EntriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntriesForm));
            this.lbEntries = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.output = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectLastMonth = new System.Windows.Forms.Button();
            this.btnSelectThisMonth = new System.Windows.Forms.Button();
            this.btnSelectLastWeek = new System.Windows.Forms.Button();
            this.btnSelectThisWeek = new System.Windows.Forms.Button();
            this.btnSelectToday = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.pnMenu.SuspendLayout();
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
            this.lbEntries.Location = new System.Drawing.Point(7, 37);
            this.lbEntries.Margin = new System.Windows.Forms.Padding(2);
            this.lbEntries.Name = "lbEntries";
            this.lbEntries.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbEntries.Size = new System.Drawing.Size(786, 434);
            this.lbEntries.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.output);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(7, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 281);
            this.panel1.TabIndex = 1;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(22)))), ((int)(((byte)(9)))));
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.DetectUrls = false;
            this.output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.output.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.output.Location = new System.Drawing.Point(0, 0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(784, 279);
            this.output.TabIndex = 1;
            this.output.Text = "";
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
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.btnSelectAll);
            this.pnMenu.Controls.Add(this.btnSelectLastMonth);
            this.pnMenu.Controls.Add(this.btnSelectThisMonth);
            this.pnMenu.Controls.Add(this.btnSelectLastWeek);
            this.pnMenu.Controls.Add(this.btnSelectThisWeek);
            this.pnMenu.Controls.Add(this.btnSelectToday);
            this.pnMenu.Controls.Add(this.label1);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(7, 7);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Padding = new System.Windows.Forms.Padding(3);
            this.pnMenu.Size = new System.Drawing.Size(786, 30);
            this.pnMenu.TabIndex = 40;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.AutoSize = true;
            this.btnSelectAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelectAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(50)))));
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectAll.Location = new System.Drawing.Point(448, 3);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(38, 24);
            this.btnSelectAll.TabIndex = 37;
            this.btnSelectAll.Text = "ALL";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            // 
            // btnSelectLastMonth
            // 
            this.btnSelectLastMonth.AutoSize = true;
            this.btnSelectLastMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectLastMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnSelectLastMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelectLastMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(50)))));
            this.btnSelectLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectLastMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectLastMonth.Location = new System.Drawing.Point(359, 3);
            this.btnSelectLastMonth.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectLastMonth.Name = "btnSelectLastMonth";
            this.btnSelectLastMonth.Size = new System.Drawing.Size(89, 24);
            this.btnSelectLastMonth.TabIndex = 42;
            this.btnSelectLastMonth.Text = "LAST MONTH";
            this.btnSelectLastMonth.UseVisualStyleBackColor = false;
            // 
            // btnSelectThisMonth
            // 
            this.btnSelectThisMonth.AutoSize = true;
            this.btnSelectThisMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectThisMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnSelectThisMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelectThisMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(50)))));
            this.btnSelectThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectThisMonth.Location = new System.Drawing.Point(272, 3);
            this.btnSelectThisMonth.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectThisMonth.Name = "btnSelectThisMonth";
            this.btnSelectThisMonth.Size = new System.Drawing.Size(87, 24);
            this.btnSelectThisMonth.TabIndex = 41;
            this.btnSelectThisMonth.Text = "THIS MONTH";
            this.btnSelectThisMonth.UseVisualStyleBackColor = false;
            // 
            // btnSelectLastWeek
            // 
            this.btnSelectLastWeek.AutoSize = true;
            this.btnSelectLastWeek.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectLastWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnSelectLastWeek.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelectLastWeek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(50)))));
            this.btnSelectLastWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectLastWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectLastWeek.Location = new System.Drawing.Point(191, 3);
            this.btnSelectLastWeek.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectLastWeek.Name = "btnSelectLastWeek";
            this.btnSelectLastWeek.Size = new System.Drawing.Size(81, 24);
            this.btnSelectLastWeek.TabIndex = 40;
            this.btnSelectLastWeek.Text = "LAST WEEK";
            this.btnSelectLastWeek.UseVisualStyleBackColor = false;
            // 
            // btnSelectThisWeek
            // 
            this.btnSelectThisWeek.AutoSize = true;
            this.btnSelectThisWeek.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectThisWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnSelectThisWeek.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelectThisWeek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(50)))));
            this.btnSelectThisWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectThisWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectThisWeek.Location = new System.Drawing.Point(112, 3);
            this.btnSelectThisWeek.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectThisWeek.Name = "btnSelectThisWeek";
            this.btnSelectThisWeek.Size = new System.Drawing.Size(79, 24);
            this.btnSelectThisWeek.TabIndex = 38;
            this.btnSelectThisWeek.Text = "THIS WEEK";
            this.btnSelectThisWeek.UseVisualStyleBackColor = false;
            // 
            // btnSelectToday
            // 
            this.btnSelectToday.AutoSize = true;
            this.btnSelectToday.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnSelectToday.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelectToday.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(50)))));
            this.btnSelectToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectToday.Location = new System.Drawing.Point(56, 3);
            this.btnSelectToday.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectToday.Name = "btnSelectToday";
            this.btnSelectToday.Size = new System.Drawing.Size(56, 24);
            this.btnSelectToday.TabIndex = 39;
            this.btnSelectToday.Text = "TODAY";
            this.btnSelectToday.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "SELECT:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(7, 471);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(786, 10);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // EntriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 769);
            this.Controls.Add(this.lbEntries);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "EntriesForm";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entries";
            this.panel1.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.ListBox lbEntries;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectLastWeek;
        private System.Windows.Forms.Button btnSelectThisWeek;
        private System.Windows.Forms.Button btnSelectToday;
        private System.Windows.Forms.Button btnSelectLastMonth;
        private System.Windows.Forms.Button btnSelectThisMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
    }
}