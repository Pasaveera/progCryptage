
namespace ProgrammeCryptage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCryptagePerso = new System.Windows.Forms.Button();
            this.btnCryptageNet = new System.Windows.Forms.Button();
            this.txtCryptMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDecrptResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.btnDecryptNet = new System.Windows.Forms.Button();
            this.btnDecryptPerso = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCryptagePerso
            // 
            this.btnCryptagePerso.BackColor = System.Drawing.Color.LightGray;
            this.btnCryptagePerso.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCryptagePerso.Location = new System.Drawing.Point(49, 159);
            this.btnCryptagePerso.Name = "btnCryptagePerso";
            this.btnCryptagePerso.Size = new System.Drawing.Size(164, 31);
            this.btnCryptagePerso.TabIndex = 0;
            this.btnCryptagePerso.Text = "Cryptage Personnel";
            this.btnCryptagePerso.UseVisualStyleBackColor = false;
            this.btnCryptagePerso.Click += new System.EventHandler(this.btnCryptagePerso_Click);
            // 
            // btnCryptageNet
            // 
            this.btnCryptageNet.BackColor = System.Drawing.Color.LightGray;
            this.btnCryptageNet.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCryptageNet.Location = new System.Drawing.Point(230, 159);
            this.btnCryptageNet.Name = "btnCryptageNet";
            this.btnCryptageNet.Size = new System.Drawing.Size(164, 31);
            this.btnCryptageNet.TabIndex = 1;
            this.btnCryptageNet.Text = "Cryptage .NET";
            this.btnCryptageNet.UseVisualStyleBackColor = false;
            this.btnCryptageNet.Click += new System.EventHandler(this.btnCryptageNet_Click);
            // 
            // txtCryptMessage
            // 
            this.txtCryptMessage.Location = new System.Drawing.Point(49, 123);
            this.txtCryptMessage.Name = "txtCryptMessage";
            this.txtCryptMessage.Size = new System.Drawing.Size(345, 20);
            this.txtCryptMessage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message à Crypter";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(490, 123);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(264, 78);
            this.txtResult.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(487, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message Crypté";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(487, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Message Décrypté";
            // 
            // txtDecrptResult
            // 
            this.txtDecrptResult.Location = new System.Drawing.Point(490, 273);
            this.txtDecrptResult.Name = "txtDecrptResult";
            this.txtDecrptResult.ReadOnly = true;
            this.txtDecrptResult.Size = new System.Drawing.Size(264, 20);
            this.txtDecrptResult.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(46, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Message à Decrypter";
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(49, 273);
            this.txtDecrypt.Multiline = true;
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(345, 59);
            this.txtDecrypt.TabIndex = 8;
            // 
            // btnDecryptNet
            // 
            this.btnDecryptNet.BackColor = System.Drawing.Color.LightGray;
            this.btnDecryptNet.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptNet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDecryptNet.Location = new System.Drawing.Point(230, 349);
            this.btnDecryptNet.Name = "btnDecryptNet";
            this.btnDecryptNet.Size = new System.Drawing.Size(164, 31);
            this.btnDecryptNet.TabIndex = 7;
            this.btnDecryptNet.Text = "Decryptage .NET";
            this.btnDecryptNet.UseVisualStyleBackColor = false;
            this.btnDecryptNet.Click += new System.EventHandler(this.btnDecryptNet_Click);
            // 
            // btnDecryptPerso
            // 
            this.btnDecryptPerso.BackColor = System.Drawing.Color.LightGray;
            this.btnDecryptPerso.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptPerso.Location = new System.Drawing.Point(49, 349);
            this.btnDecryptPerso.Name = "btnDecryptPerso";
            this.btnDecryptPerso.Size = new System.Drawing.Size(164, 31);
            this.btnDecryptPerso.TabIndex = 6;
            this.btnDecryptPerso.Text = "Decryptage Personnel";
            this.btnDecryptPerso.UseVisualStyleBackColor = false;
            this.btnDecryptPerso.Click += new System.EventHandler(this.btnDecryptPerso_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(264, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Programme Cryptage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgrammeCryptage.Properties.Resources.ffa20346576771_585a0ac1d952f;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDecrptResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.btnDecryptNet);
            this.Controls.Add(this.btnDecryptPerso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCryptMessage);
            this.Controls.Add(this.btnCryptageNet);
            this.Controls.Add(this.btnCryptagePerso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCryptagePerso;
        private System.Windows.Forms.Button btnCryptageNet;
        private System.Windows.Forms.TextBox txtCryptMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDecrptResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.Button btnDecryptNet;
        private System.Windows.Forms.Button btnDecryptPerso;
        private System.Windows.Forms.Label label5;
    }
}

