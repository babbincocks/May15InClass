namespace Card_Loader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ilCards = new System.Windows.Forms.ImageList(this.components);
            this.lbCards = new System.Windows.Forms.ListBox();
            this.pbSelectedCard = new System.Windows.Forms.PictureBox();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedCard)).BeginInit();
            this.SuspendLayout();
            // 
            // ilCards
            // 
            this.ilCards.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilCards.ImageStream")));
            this.ilCards.TransparentColor = System.Drawing.Color.Transparent;
            this.ilCards.Images.SetKeyName(0, "2_Clubs.bmp");
            this.ilCards.Images.SetKeyName(1, "2_Diamonds.bmp");
            this.ilCards.Images.SetKeyName(2, "2_Hearts.bmp");
            this.ilCards.Images.SetKeyName(3, "2_Spades.bmp");
            this.ilCards.Images.SetKeyName(4, "3_Clubs.bmp");
            this.ilCards.Images.SetKeyName(5, "3_Diamonds.bmp");
            this.ilCards.Images.SetKeyName(6, "3_Hearts.bmp");
            this.ilCards.Images.SetKeyName(7, "3_Spades.bmp");
            this.ilCards.Images.SetKeyName(8, "4_Clubs.bmp");
            this.ilCards.Images.SetKeyName(9, "4_Diamonds.bmp");
            this.ilCards.Images.SetKeyName(10, "4_Hearts.bmp");
            this.ilCards.Images.SetKeyName(11, "4_Spades.bmp");
            this.ilCards.Images.SetKeyName(12, "5_Clubs.bmp");
            this.ilCards.Images.SetKeyName(13, "5_Diamonds.bmp");
            this.ilCards.Images.SetKeyName(14, "5_Hearts.bmp");
            this.ilCards.Images.SetKeyName(15, "5_Spades.bmp");
            this.ilCards.Images.SetKeyName(16, "6_Clubs.bmp");
            this.ilCards.Images.SetKeyName(17, "6_Diamonds.bmp");
            this.ilCards.Images.SetKeyName(18, "6_Hearts.bmp");
            this.ilCards.Images.SetKeyName(19, "6_Spades.bmp");
            this.ilCards.Images.SetKeyName(20, "7_Clubs.bmp");
            this.ilCards.Images.SetKeyName(21, "7_Diamonds.bmp");
            this.ilCards.Images.SetKeyName(22, "7_Hearts.bmp");
            this.ilCards.Images.SetKeyName(23, "7_Spades.bmp");
            this.ilCards.Images.SetKeyName(24, "8_Clubs.bmp");
            this.ilCards.Images.SetKeyName(25, "8_Diamonds.bmp");
            this.ilCards.Images.SetKeyName(26, "8_Hearts.bmp");
            this.ilCards.Images.SetKeyName(27, "8_Spades.bmp");
            this.ilCards.Images.SetKeyName(28, "9_Clubs.bmp");
            this.ilCards.Images.SetKeyName(29, "9_Diamonds.bmp");
            this.ilCards.Images.SetKeyName(30, "9_Hearts.bmp");
            this.ilCards.Images.SetKeyName(31, "9_Spades.bmp");
            this.ilCards.Images.SetKeyName(32, "10_Clubs.bmp");
            this.ilCards.Images.SetKeyName(33, "10_Diamonds.bmp");
            this.ilCards.Images.SetKeyName(34, "10_Hearts.bmp");
            this.ilCards.Images.SetKeyName(35, "10_Spades.bmp");
            this.ilCards.Images.SetKeyName(36, "Ace_Clubs.bmp");
            this.ilCards.Images.SetKeyName(37, "Ace_Diamonds.bmp");
            this.ilCards.Images.SetKeyName(38, "Ace_Hearts.bmp");
            this.ilCards.Images.SetKeyName(39, "Ace_Spades.bmp");
            this.ilCards.Images.SetKeyName(40, "Jack_Clubs.bmp");
            this.ilCards.Images.SetKeyName(41, "Jack_Diamonds.bmp");
            this.ilCards.Images.SetKeyName(42, "Jack_Hearts.bmp");
            this.ilCards.Images.SetKeyName(43, "Jack_Spades.bmp");
            this.ilCards.Images.SetKeyName(44, "Queen_Clubs.bmp");
            this.ilCards.Images.SetKeyName(45, "Queen_Diamonds.bmp");
            this.ilCards.Images.SetKeyName(46, "Queen_Hearts.bmp");
            this.ilCards.Images.SetKeyName(47, "Queen_Spades.bmp");
            this.ilCards.Images.SetKeyName(48, "King_Clubs.bmp");
            this.ilCards.Images.SetKeyName(49, "King_Diamonds.bmp");
            this.ilCards.Images.SetKeyName(50, "King_Hearts.bmp");
            this.ilCards.Images.SetKeyName(51, "King_Spades.bmp");
            this.ilCards.Images.SetKeyName(52, "Joker_Black.bmp");
            this.ilCards.Images.SetKeyName(53, "Joker_Red.bmp");
            this.ilCards.Images.SetKeyName(54, "Backface_Blue.bmp");
            this.ilCards.Images.SetKeyName(55, "Backface_Red.bmp");
            // 
            // lbCards
            // 
            this.lbCards.FormattingEnabled = true;
            this.lbCards.Location = new System.Drawing.Point(12, 12);
            this.lbCards.Name = "lbCards";
            this.lbCards.Size = new System.Drawing.Size(181, 290);
            this.lbCards.TabIndex = 0;
            this.lbCards.SelectedIndexChanged += new System.EventHandler(this.lbCards_SelectedIndexChanged);
            // 
            // pbSelectedCard
            // 
            this.pbSelectedCard.Location = new System.Drawing.Point(218, 109);
            this.pbSelectedCard.Name = "pbSelectedCard";
            this.pbSelectedCard.Size = new System.Drawing.Size(101, 125);
            this.pbSelectedCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelectedCard.TabIndex = 1;
            this.pbSelectedCard.TabStop = false;
            this.pbSelectedCard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSelectedCard_MouseDown);
            this.pbSelectedCard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbSelectedCard_MouseMove);
            this.pbSelectedCard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbSelectedCard_MouseUp);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(446, 278);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(93, 24);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show Cards";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 316);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.pbSelectedCard);
            this.Controls.Add(this.lbCards);
            this.Name = "Form1";
            this.Text = "Cards";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilCards;
        private System.Windows.Forms.ListBox lbCards;
        private System.Windows.Forms.PictureBox pbSelectedCard;
        private System.Windows.Forms.Button btnShow;
    }
}

