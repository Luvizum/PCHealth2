
namespace PCHealth2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.logoAnimTimer = new System.Windows.Forms.Timer(this.components);
            this.stoutlabel = new System.Windows.Forms.Label();
            this.Clspng = new System.Windows.Forms.PictureBox();
            this.rstpng = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clspng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rstpng)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::PCHealth2.Properties.Resources.pcHealthLogo;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(776, 426);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // logoAnimTimer
            // 
            this.logoAnimTimer.Tick += new System.EventHandler(this.logoAnimTimer_Tick);
            // 
            // stoutlabel
            // 
            this.stoutlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stoutlabel.BackColor = System.Drawing.Color.Transparent;
            this.stoutlabel.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stoutlabel.ForeColor = System.Drawing.Color.White;
            this.stoutlabel.Location = new System.Drawing.Point(12, 343);
            this.stoutlabel.Name = "stoutlabel";
            this.stoutlabel.Size = new System.Drawing.Size(776, 95);
            this.stoutlabel.TabIndex = 1;
            this.stoutlabel.Text = "Network Test";
            this.stoutlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clspng
            // 
            this.Clspng.BackColor = System.Drawing.Color.Transparent;
            this.Clspng.Image = global::PCHealth2.Properties.Resources.close;
            this.Clspng.Location = new System.Drawing.Point(732, 12);
            this.Clspng.Name = "Clspng";
            this.Clspng.Size = new System.Drawing.Size(30, 30);
            this.Clspng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Clspng.TabIndex = 2;
            this.Clspng.TabStop = false;
            this.Clspng.Visible = false;
            this.Clspng.Click += new System.EventHandler(this.Clspng_Click);
            // 
            // rstpng
            // 
            this.rstpng.BackColor = System.Drawing.Color.Transparent;
            this.rstpng.Image = global::PCHealth2.Properties.Resources.reset;
            this.rstpng.Location = new System.Drawing.Point(732, 306);
            this.rstpng.Name = "rstpng";
            this.rstpng.Size = new System.Drawing.Size(34, 34);
            this.rstpng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rstpng.TabIndex = 3;
            this.rstpng.TabStop = false;
            this.rstpng.Visible = false;
            this.rstpng.Click += new System.EventHandler(this.rstpng_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rstpng);
            this.Controls.Add(this.Clspng);
            this.Controls.Add(this.stoutlabel);
            this.Controls.Add(this.logoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clspng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rstpng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Timer logoAnimTimer;
        private System.Windows.Forms.Label stoutlabel;
        private System.Windows.Forms.PictureBox Clspng;
        private System.Windows.Forms.PictureBox rstpng;
    }
}

