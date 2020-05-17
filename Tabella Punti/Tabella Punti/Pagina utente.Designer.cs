namespace Tabella_Punti
{
    partial class Pagina_utente
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.action = new MetroFramework.Controls.MetroButton();
            this.bonus = new System.Windows.Forms.Button();
            this.puntiLabel = new MetroFramework.Controls.MetroLabel();
            this.punti = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.username = new MetroFramework.Controls.MetroTextBox();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.ciaoLabel = new MetroFramework.Controls.MetroLabel();
            this.nomeUtente = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(521, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Qui puoi vedere il tuo streamer preferito, se vuoi accumulare punteggio effettua " +
    "il login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 253);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // action
            // 
            this.action.Location = new System.Drawing.Point(23, 381);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(70, 23);
            this.action.TabIndex = 2;
            this.action.Text = "PLAY";
            this.action.UseSelectable = true;
            this.action.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // bonus
            // 
            this.bonus.BackColor = System.Drawing.Color.SkyBlue;
            this.bonus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bonus.ForeColor = System.Drawing.Color.White;
            this.bonus.Location = new System.Drawing.Point(514, 381);
            this.bonus.Name = "bonus";
            this.bonus.Size = new System.Drawing.Size(75, 23);
            this.bonus.TabIndex = 4;
            this.bonus.Text = "BONUS";
            this.bonus.UseVisualStyleBackColor = false;
            this.bonus.Click += new System.EventHandler(this.button2_Click);
            // 
            // puntiLabel
            // 
            this.puntiLabel.AutoSize = true;
            this.puntiLabel.Location = new System.Drawing.Point(441, 93);
            this.puntiLabel.Name = "puntiLabel";
            this.puntiLabel.Size = new System.Drawing.Size(71, 19);
            this.puntiLabel.TabIndex = 5;
            this.puntiLabel.Text = "I tuoi punti";
            // 
            // punti
            // 
            // 
            // 
            // 
            this.punti.CustomButton.Image = null;
            this.punti.CustomButton.Location = new System.Drawing.Point(49, 1);
            this.punti.CustomButton.Name = "";
            this.punti.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.punti.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.punti.CustomButton.TabIndex = 1;
            this.punti.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.punti.CustomButton.UseSelectable = true;
            this.punti.CustomButton.Visible = false;
            this.punti.Lines = new string[] {
        "0"};
            this.punti.Location = new System.Drawing.Point(518, 93);
            this.punti.MaxLength = 32767;
            this.punti.Name = "punti";
            this.punti.PasswordChar = '\0';
            this.punti.ReadOnly = true;
            this.punti.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.punti.SelectedText = "";
            this.punti.SelectionLength = 0;
            this.punti.SelectionStart = 0;
            this.punti.ShortcutsEnabled = true;
            this.punti.Size = new System.Drawing.Size(71, 23);
            this.punti.TabIndex = 6;
            this.punti.Text = "0";
            this.punti.UseSelectable = true;
            this.punti.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.punti.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(615, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Username";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(615, 176);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Password";
            // 
            // username
            // 
            // 
            // 
            // 
            this.username.CustomButton.Image = null;
            this.username.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.username.CustomButton.Name = "";
            this.username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.username.CustomButton.TabIndex = 1;
            this.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.username.CustomButton.UseSelectable = true;
            this.username.CustomButton.Visible = false;
            this.username.Lines = new string[0];
            this.username.Location = new System.Drawing.Point(615, 143);
            this.username.MaxLength = 32767;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.ShortcutsEnabled = true;
            this.username.Size = new System.Drawing.Size(174, 23);
            this.username.TabIndex = 10;
            this.username.UseSelectable = true;
            this.username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // password
            // 
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(615, 198);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(174, 23);
            this.password.TabIndex = 11;
            this.password.UseSelectable = true;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ciaoLabel
            // 
            this.ciaoLabel.AutoSize = true;
            this.ciaoLabel.Location = new System.Drawing.Point(24, 97);
            this.ciaoLabel.Name = "ciaoLabel";
            this.ciaoLabel.Size = new System.Drawing.Size(36, 19);
            this.ciaoLabel.TabIndex = 12;
            this.ciaoLabel.Text = "Ciao";
            // 
            // nomeUtente
            // 
            this.nomeUtente.AutoSize = true;
            this.nomeUtente.Location = new System.Drawing.Point(66, 97);
            this.nomeUtente.Name = "nomeUtente";
            this.nomeUtente.Size = new System.Drawing.Size(46, 19);
            this.nomeUtente.TabIndex = 13;
            this.nomeUtente.Text = "Nome";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(615, 227);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(174, 22);
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "LOGIN";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // Pagina_utente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.nomeUtente);
            this.Controls.Add(this.ciaoLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.punti);
            this.Controls.Add(this.puntiLabel);
            this.Controls.Add(this.bonus);
            this.Controls.Add(this.action);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Pagina_utente";
            this.Text = "Stream Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pagina_utente_FormClosing);
            this.Load += new System.EventHandler(this.Pagina_utente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton action;
        private System.Windows.Forms.Button bonus;
        private MetroFramework.Controls.MetroLabel puntiLabel;
        private MetroFramework.Controls.MetroTextBox punti;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox username;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroLabel ciaoLabel;
        private MetroFramework.Controls.MetroLabel nomeUtente;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}