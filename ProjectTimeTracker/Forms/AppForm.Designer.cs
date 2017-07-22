﻿namespace ProjectTimeTracker.Forms
{
    partial class AppForm
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
            this.components = new System.ComponentModel.Container();
            this.btnToggle = new System.Windows.Forms.Button();
            this.tbNewProject = new System.Windows.Forms.TextBox();
            this.lbProjects = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmsProjects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteProject = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEntries = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1.SuspendLayout();
            this.cmsProjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToggle
            // 
            this.btnToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(50)))));
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnToggle.Location = new System.Drawing.Point(2, 356);
            this.btnToggle.Margin = new System.Windows.Forms.Padding(2);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(311, 46);
            this.btnToggle.TabIndex = 36;
            this.btnToggle.Text = "START";
            this.btnToggle.UseVisualStyleBackColor = false;
            // 
            // tbNewProject
            // 
            this.tbNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(22)))), ((int)(((byte)(9)))));
            this.tbNewProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNewProject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbNewProject.Location = new System.Drawing.Point(2, 2);
            this.tbNewProject.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewProject.Name = "tbNewProject";
            this.tbNewProject.Size = new System.Drawing.Size(311, 26);
            this.tbNewProject.TabIndex = 37;
            // 
            // lbProjects
            // 
            this.lbProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(22)))), ((int)(((byte)(9)))));
            this.lbProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbProjects.ContextMenuStrip = this.cmsProjects;
            this.lbProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbProjects.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbProjects.FormattingEnabled = true;
            this.lbProjects.ItemHeight = 20;
            this.lbProjects.Location = new System.Drawing.Point(2, 32);
            this.lbProjects.Margin = new System.Windows.Forms.Padding(2);
            this.lbProjects.Name = "lbProjects";
            this.lbProjects.Size = new System.Drawing.Size(311, 302);
            this.lbProjects.TabIndex = 38;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbNewProject, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbProjects, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnToggle, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 404);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // cmsProjects
            // 
            this.cmsProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cmsProjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReport,
            this.btnEntries,
            this.toolStripSeparator1,
            this.btnDeleteProject});
            this.cmsProjects.Name = "cmsProjects";
            this.cmsProjects.ShowImageMargin = false;
            this.cmsProjects.Size = new System.Drawing.Size(85, 76);
            // 
            // btnReport
            // 
            this.btnReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(84, 22);
            this.btnReport.Text = "Raport";
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(84, 22);
            this.btnDeleteProject.Text = "Usuń";
            // 
            // btnEntries
            // 
            this.btnEntries.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEntries.Name = "btnEntries";
            this.btnEntries.Size = new System.Drawing.Size(84, 22);
            this.btnEntries.Text = "Wpisy";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(81, 6);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(319, 408);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AppForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Project time tracker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.cmsProjects.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.TextBox tbNewProject;
        private System.Windows.Forms.ListBox lbProjects;
        private System.Windows.Forms.ContextMenuStrip cmsProjects;
        private System.Windows.Forms.ToolStripMenuItem btnReport;
        private System.Windows.Forms.ToolStripMenuItem btnEntries;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteProject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

