namespace ilerinesnetaban
{
    partial class Form4
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
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chyap = new System.Windows.Forms.CheckBox();
            this.chiptal = new System.Windows.Forms.CheckBox();
            this.btnkayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsifre.Location = new System.Drawing.Point(130, 69);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(176, 28);
            this.txtsifre.TabIndex = 9;
            // 
            // txtkullanici
            // 
            this.txtkullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkullanici.Location = new System.Drawing.Point(130, 35);
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(176, 28);
            this.txtkullanici.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // chyap
            // 
            this.chyap.AutoSize = true;
            this.chyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chyap.Location = new System.Drawing.Point(130, 125);
            this.chyap.Name = "chyap";
            this.chyap.Size = new System.Drawing.Size(115, 24);
            this.chyap.TabIndex = 10;
            this.chyap.Text = "SATIŞ YAP";
            this.chyap.UseVisualStyleBackColor = true;
            // 
            // chiptal
            // 
            this.chiptal.AutoSize = true;
            this.chiptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiptal.Location = new System.Drawing.Point(130, 167);
            this.chiptal.Name = "chiptal";
            this.chiptal.Size = new System.Drawing.Size(155, 24);
            this.chiptal.TabIndex = 11;
            this.chiptal.Text = "SATIŞ İPTAL ET";
            this.chiptal.UseVisualStyleBackColor = true;
            // 
            // btnkayit
            // 
            this.btnkayit.Location = new System.Drawing.Point(93, 216);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(168, 35);
            this.btnkayit.TabIndex = 12;
            this.btnkayit.Text = "KAYIT OL";
            this.btnkayit.UseVisualStyleBackColor = true;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(339, 271);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.chiptal);
            this.Controls.Add(this.chyap);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullanici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkullanici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chyap;
        private System.Windows.Forms.CheckBox chiptal;
        private System.Windows.Forms.Button btnkayit;
    }
}