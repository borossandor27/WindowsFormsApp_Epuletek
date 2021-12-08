
namespace WindowsFormsApp_Epuletek
{
    partial class Form_Nyito
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
            this.listBox_Epuletek = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_uj_tombhaz = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Epuletek
            // 
            this.listBox_Epuletek.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Epuletek.FormattingEnabled = true;
            this.listBox_Epuletek.Location = new System.Drawing.Point(0, 0);
            this.listBox_Epuletek.Name = "listBox_Epuletek";
            this.listBox_Epuletek.Size = new System.Drawing.Size(210, 450);
            this.listBox_Epuletek.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Új családiház";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_uj_csaladi_Click);
            // 
            // button_uj_tombhaz
            // 
            this.button_uj_tombhaz.Location = new System.Drawing.Point(228, 75);
            this.button_uj_tombhaz.Name = "button_uj_tombhaz";
            this.button_uj_tombhaz.Size = new System.Drawing.Size(130, 26);
            this.button_uj_tombhaz.TabIndex = 1;
            this.button_uj_tombhaz.Text = "Új tömbház";
            this.button_uj_tombhaz.UseVisualStyleBackColor = true;
            this.button_uj_tombhaz.Click += new System.EventHandler(this.button_uj_tombhaz_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(228, 127);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(130, 32);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Épület törlése";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(228, 177);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(130, 34);
            this.button_Update.TabIndex = 3;
            this.button_Update.Text = "Módosítás";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // Form_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_uj_tombhaz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_Epuletek);
            this.Name = "Form_Nyito";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Nyito_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox listBox_Epuletek;
        private System.Windows.Forms.Button button_uj_tombhaz;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
    }
}

