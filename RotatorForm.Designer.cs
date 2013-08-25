﻿namespace DisplayRotator
{
    partial class RotatorForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rot180Button = new System.Windows.Forms.Button();
            this.rot90cwButton = new System.Windows.Forms.Button();
            this.rot90ccwButton = new System.Windows.Forms.Button();
            this.doNothingButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.rot180Button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rot90cwButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rot90ccwButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.doNothingButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 298);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rot180Button
            // 
            this.rot180Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rot180Button.Location = new System.Drawing.Point(102, 3);
            this.rot180Button.Name = "rot180Button";
            this.rot180Button.Size = new System.Drawing.Size(93, 93);
            this.rot180Button.TabIndex = 1;
            this.rot180Button.UseVisualStyleBackColor = true;
            this.rot180Button.Click += new System.EventHandler(this.rotButton_Click);
            // 
            // rot90cwButton
            // 
            this.rot90cwButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rot90cwButton.Location = new System.Drawing.Point(3, 102);
            this.rot90cwButton.Name = "rot90cwButton";
            this.rot90cwButton.Size = new System.Drawing.Size(93, 93);
            this.rot90cwButton.TabIndex = 3;
            this.rot90cwButton.UseVisualStyleBackColor = true;
            this.rot90cwButton.Click += new System.EventHandler(this.rotButton_Click);
            // 
            // rot90ccwButton
            // 
            this.rot90ccwButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rot90ccwButton.Location = new System.Drawing.Point(201, 102);
            this.rot90ccwButton.Name = "rot90ccwButton";
            this.rot90ccwButton.Size = new System.Drawing.Size(94, 93);
            this.rot90ccwButton.TabIndex = 5;
            this.rot90ccwButton.UseVisualStyleBackColor = true;
            this.rot90ccwButton.Click += new System.EventHandler(this.rotButton_Click);
            // 
            // doNothingButton
            // 
            this.doNothingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doNothingButton.Location = new System.Drawing.Point(102, 201);
            this.doNothingButton.Name = "doNothingButton";
            this.doNothingButton.Size = new System.Drawing.Size(93, 94);
            this.doNothingButton.TabIndex = 7;
            this.doNothingButton.UseVisualStyleBackColor = true;
            this.doNothingButton.Click += new System.EventHandler(this.doNothingButton_Click);
            // 
            // RotatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 298);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RotatorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Deactivate += new System.EventHandler(this.form_Deactivate);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button rot180Button;
        private System.Windows.Forms.Button rot90cwButton;
        private System.Windows.Forms.Button rot90ccwButton;
        private System.Windows.Forms.Button doNothingButton;
    }
}

