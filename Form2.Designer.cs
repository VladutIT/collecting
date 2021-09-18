
namespace collecting
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.box = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "SCORE:00";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player.Image = global::collecting.Properties.Resources.cart1;
            this.player.Location = new System.Drawing.Point(704, 441);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(82, 81);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // box
            // 
            this.box.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.box.Image = global::collecting.Properties.Resources.target3;
            this.box.Location = new System.Drawing.Point(243, -100);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(97, 93);
            this.box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box.TabIndex = 2;
            this.box.TabStop = false;
            this.box.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "GRESELI:00";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1328, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.Name = "Form2";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox box;
        private System.Windows.Forms.Label label2;
    }
}