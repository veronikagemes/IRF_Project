﻿
namespace IRF_Project
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uticelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.datumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buszulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uticelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buszulesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.uticelBindingSource;
            this.comboBox1.DisplayMember = "Varos";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Varos";
            // 
            // uticelBindingSource
            // 
            this.uticelBindingSource.DataSource = typeof(IRF_Project.Uticel);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.datumBindingSource;
            this.comboBox2.DisplayMember = "Datum1";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(81, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(202, 24);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "DatumID";
            // 
            // datumBindingSource
            // 
            this.datumBindingSource.DataSource = typeof(IRF_Project.Datum);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Úticél: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dátum: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Helyfoglalás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Utaslista letöltése";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ulesBindingSource
            // 
            this.ulesBindingSource.DataSource = typeof(IRF_Project.Ules);
            // 
            // buszulesBindingSource
            // 
            this.buszulesBindingSource.DataSource = typeof(IRF_Project.Buszules);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 22);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.uticelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buszulesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource uticelBindingSource;
        private System.Windows.Forms.BindingSource ulesBindingSource;
        private System.Windows.Forms.BindingSource datumBindingSource;
        private System.Windows.Forms.BindingSource buszulesBindingSource;
        private System.Windows.Forms.TextBox textBox1;
    }
}

