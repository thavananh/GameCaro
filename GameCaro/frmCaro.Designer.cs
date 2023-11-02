namespace GameCaro
{
    partial class frmCaro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaro));
            pnlBanCo = new Panel();
            ptcbThumbnail = new PictureBox();
            pnlThumbnail = new Panel();
            panel3 = new Panel();
            progessBarCoolDown = new ProgressBar();
            button1 = new Button();
            txtIP = new TextBox();
            txtPlayerName = new TextBox();
            label1 = new Label();
            pctbAvatar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptcbThumbnail).BeginInit();
            pnlThumbnail.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbAvatar).BeginInit();
            SuspendLayout();
            // 
            // pnlBanCo
            // 
            pnlBanCo.Location = new Point(2, 3);
            pnlBanCo.Name = "pnlBanCo";
            pnlBanCo.Size = new Size(755, 599);
            pnlBanCo.TabIndex = 0;
            // 
            // ptcbThumbnail
            // 
            ptcbThumbnail.BackgroundImage = Properties.Resources._1;
            ptcbThumbnail.BackgroundImageLayout = ImageLayout.Stretch;
            ptcbThumbnail.Location = new Point(3, 3);
            ptcbThumbnail.Name = "ptcbThumbnail";
            ptcbThumbnail.Size = new Size(338, 319);
            ptcbThumbnail.TabIndex = 0;
            ptcbThumbnail.TabStop = false;
            // 
            // pnlThumbnail
            // 
            pnlThumbnail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlThumbnail.Controls.Add(ptcbThumbnail);
            pnlThumbnail.Location = new Point(763, 3);
            pnlThumbnail.Name = "pnlThumbnail";
            pnlThumbnail.Size = new Size(344, 325);
            pnlThumbnail.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(progessBarCoolDown);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(txtIP);
            panel3.Controls.Add(txtPlayerName);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pctbAvatar);
            panel3.Location = new Point(763, 334);
            panel3.Name = "panel3";
            panel3.Size = new Size(344, 268);
            panel3.TabIndex = 2;
            // 
            // progessBarCoolDown
            // 
            progessBarCoolDown.Location = new Point(3, 36);
            progessBarCoolDown.Name = "progessBarCoolDown";
            progessBarCoolDown.Size = new Size(160, 29);
            progessBarCoolDown.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(3, 102);
            button1.Name = "button1";
            button1.Size = new Size(160, 29);
            button1.TabIndex = 5;
            button1.Text = "Lan";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(3, 69);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(160, 27);
            txtIP.TabIndex = 4;
            txtIP.Text = "127.0.0.1";
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(3, 3);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(160, 27);
            txtPlayerName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 203);
            label1.Name = "label1";
            label1.Size = new Size(312, 43);
            label1.TabIndex = 1;
            label1.Text = "5 in a line to win";
            // 
            // pctbAvatar
            // 
            pctbAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            pctbAvatar.Location = new Point(169, 0);
            pctbAvatar.Name = "pctbAvatar";
            pctbAvatar.Size = new Size(175, 187);
            pctbAvatar.TabIndex = 0;
            pctbAvatar.TabStop = false;
            // 
            // frmCaro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 607);
            Controls.Add(panel3);
            Controls.Add(pnlThumbnail);
            Controls.Add(pnlBanCo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCaro";
            Text = "frmCaro";
            Load += frmCaro_Load;
            ((System.ComponentModel.ISupportInitialize)ptcbThumbnail).EndInit();
            pnlThumbnail.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBanCo;
        private Panel pnlThumbnail;
        private PictureBox ptcbThumbnail;
        private Panel panel3;
        private Label label1;
        private PictureBox pctbAvatar;
        private Button button1;
        private TextBox txtIP;
        private TextBox txtPlayerName;
        private ProgressBar progessBarCoolDown;
    }
}