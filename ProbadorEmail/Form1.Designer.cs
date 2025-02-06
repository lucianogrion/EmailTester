namespace ProbadorEmail
{
    partial class frmEmail
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
            this.lblSMTP = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtSMTP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.cmdSendCDO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSMTP
            // 
            this.lblSMTP.AutoSize = true;
            this.lblSMTP.Location = new System.Drawing.Point(11, 23);
            this.lblSMTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSMTP.Name = "lblSMTP";
            this.lblSMTP.Size = new System.Drawing.Size(41, 16);
            this.lblSMTP.TabIndex = 1;
            this.lblSMTP.Text = "SVR :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 55);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(51, 16);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "USER :";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(12, 87);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(45, 16);
            this.lblPwd.TabIndex = 5;
            this.lblPwd.Text = "PWD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "TEXT ";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(16, 164);
            this.txtText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtText.MaxLength = 200;
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(407, 117);
            this.txtText.TabIndex = 5;
            this.txtText.Text = "Texto de Prueba";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(77, 52);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.MaxLength = 100;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(345, 22);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "webmaster@domain.gov.ar";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(77, 84);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(345, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cmdEnviar
            // 
            this.cmdEnviar.Location = new System.Drawing.Point(15, 289);
            this.cmdEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdEnviar.Name = "cmdEnviar";
            this.cmdEnviar.Size = new System.Drawing.Size(187, 28);
            this.cmdEnviar.TabIndex = 6;
            this.cmdEnviar.Text = "Envia Con SMTP";
            this.cmdEnviar.UseVisualStyleBackColor = true;
            this.cmdEnviar.Click += new System.EventHandler(this.cmdEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "PORT :";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(77, 116);
            this.txtDest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDest.MaxLength = 100;
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(345, 22);
            this.txtDest.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "DEST :";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(16, 364);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(53, 16);
            this.lblError.TabIndex = 16;
            this.lblError.Text = "Estado:";
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // txtSMTP
            // 
            this.txtSMTP.Location = new System.Drawing.Point(77, 20);
            this.txtSMTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSMTP.MaxLength = 20;
            this.txtSMTP.Name = "txtSMTP";
            this.txtSMTP.Size = new System.Drawing.Size(132, 22);
            this.txtSMTP.TabIndex = 0;
            this.txtSMTP.Text = "exchange.domain.local";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(336, 20);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.MaxLength = 3;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(87, 22);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "25";
            // 
            // cmdSendCDO
            // 
            this.cmdSendCDO.Location = new System.Drawing.Point(209, 289);
            this.cmdSendCDO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSendCDO.Name = "cmdSendCDO";
            this.cmdSendCDO.Size = new System.Drawing.Size(215, 28);
            this.cmdSendCDO.TabIndex = 17;
            this.cmdSendCDO.Text = "Enviar Con CDO";
            this.cmdSendCDO.UseVisualStyleBackColor = true;
            this.cmdSendCDO.Click += new System.EventHandler(this.cmdSendCDO_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Enviar con mailClient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdSendCDO);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtSMTP);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdEnviar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblSMTP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEmail";
            this.Text = "Probador de Envio Email (SIN SSL)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSMTP;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button cmdEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtSMTP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button cmdSendCDO;
        private System.Windows.Forms.Button button1;
    }
}

