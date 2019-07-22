using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.findNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmbBox1 = new System.Windows.Forms.ComboBox();
            this.cmbBox2 = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Snow;
            this.lblName.Location = new System.Drawing.Point(61, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(124, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Şəxsin adı";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(66, 150);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 38);
            this.txtName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Snow;
            this.btnAdd.Location = new System.Drawing.Point(628, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 53);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Əlavə et";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lstContacts
            // 
            this.lstContacts.Font = new System.Drawing.Font("Sofia Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.ItemHeight = 21;
            this.lstContacts.Location = new System.Drawing.Point(66, 329);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(761, 193);
            this.lstContacts.TabIndex = 6;
            // 
            // findNumbersToolStripMenuItem
            // 
            this.findNumbersToolStripMenuItem.Name = "findNumbersToolStripMenuItem";
            this.findNumbersToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.findNumbersToolStripMenuItem.Text = "Sil";
            this.findNumbersToolStripMenuItem.Click += new System.EventHandler(this.FindNumbersToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findNumbersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cmbBox1
            // 
            this.cmbBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox1.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox1.FormattingEnabled = true;
            this.cmbBox1.Items.AddRange(new object[] {
            "+994"});
            this.cmbBox1.Location = new System.Drawing.Point(373, 151);
            this.cmbBox1.Name = "cmbBox1";
            this.cmbBox1.Size = new System.Drawing.Size(85, 32);
            this.cmbBox1.TabIndex = 2;
            // 
            // cmbBox2
            // 
            this.cmbBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox2.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox2.FormattingEnabled = true;
            this.cmbBox2.Items.AddRange(new object[] {
            "50",
            "51",
            "55",
            "70",
            "77"});
            this.cmbBox2.Location = new System.Drawing.Point(487, 150);
            this.cmbBox2.Name = "cmbBox2";
            this.cmbBox2.Size = new System.Drawing.Size(85, 32);
            this.cmbBox2.TabIndex = 3;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Sofia Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(619, 150);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(208, 38);
            this.txtNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(368, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Telefon nömrəsi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(976, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.cmbBox2);
            this.Controls.Add(this.cmbBox1);
            this.Controls.Add(this.lstContacts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mənim telefon kitabçam";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //---Class way---

            if (txtName.Text.Trim() != "" && txtNumber.Text.Replace(" ", "") != "")
            {
                if (CheckContactName(txtName.Text.Trim()) && CheckContactNumber(txtNumber.Text.Trim()))
                {
                    PhoneBook.AddContact(txtName.Text, txtNumber.Text);
                }
                else
                {
                    MessageBox.Show("Zəhmət olmasa, düzgün ad və nömrə daxil edin.", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa, boşluqları doldurun.", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            foreach (KeyValuePair<string, string> contact in PhoneBook.GetContact())
            {
                if (contact.Key == txtName.Text && contact.Value == txtNumber.Text)
                {
                    lstContacts.Items.Add(contact.Key + " :     " + cmbBox1.SelectedItem.ToString() + " " + cmbBox2.SelectedItem.ToString() + " " + contact.Value);
                    txtName.Text = txtNumber.Text = "";

                    //    //---DataSource(ERROR)---
                    //    //lstContacts.DataSource = null;
                    //    //lstContacts.DataSource = PhoneBook.GetContact();
                    //    //lstContacts.DisplayMember = "key";
                    //    //}
                    //    //}
                    //}
                }
            }
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.ToolStripMenuItem findNumbersToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cmbBox1;
        private System.Windows.Forms.ComboBox cmbBox2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
    }
}

