namespace LoginForm2
{
    partial class frmHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBck = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnTC = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnPb = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnSS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hi! Sir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Welcome!";
            // 
            // btnBck
            // 
            this.btnBck.Image = global::LoginForm2.Properties.Resources.image_removebg_preview__7_;
            this.btnBck.Location = new System.Drawing.Point(120, 525);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(75, 75);
            this.btnBck.TabIndex = 6;
            this.btnBck.UseVisualStyleBackColor = true;
            this.btnBck.Click += new System.EventHandler(this.btnBck_Click);
            // 
            // btnV
            // 
            this.btnV.Image = global::LoginForm2.Properties.Resources.image_removebg_preview__3_;
            this.btnV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnV.Location = new System.Drawing.Point(120, 297);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(325, 205);
            this.btnV.TabIndex = 5;
            this.btnV.Text = "Vendors";
            this.btnV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnTC
            // 
            this.btnTC.Image = global::LoginForm2.Properties.Resources.image_removebg_preview__6_;
            this.btnTC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTC.Location = new System.Drawing.Point(814, 297);
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(325, 205);
            this.btnTC.TabIndex = 4;
            this.btnTC.Text = "Time Clock";
            this.btnTC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTC.UseVisualStyleBackColor = true;
            this.btnTC.Click += new System.EventHandler(this.btnTC_Click);
            // 
            // btnU
            // 
            this.btnU.Image = global::LoginForm2.Properties.Resources.image_removebg_preview__5_;
            this.btnU.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnU.Location = new System.Drawing.Point(466, 297);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(325, 205);
            this.btnU.TabIndex = 3;
            this.btnU.Text = "Users";
            this.btnU.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnPb
            // 
            this.btnPb.Image = global::LoginForm2.Properties.Resources.image_removebg_preview__2_;
            this.btnPb.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPb.Location = new System.Drawing.Point(814, 55);
            this.btnPb.Name = "btnPb";
            this.btnPb.Size = new System.Drawing.Size(325, 205);
            this.btnPb.TabIndex = 2;
            this.btnPb.Text = "Pricebook";
            this.btnPb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPb.UseVisualStyleBackColor = true;
            this.btnPb.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnR
            // 
            this.btnR.Image = global::LoginForm2.Properties.Resources.image_removebg_preview;
            this.btnR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnR.Location = new System.Drawing.Point(120, 55);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(325, 205);
            this.btnR.TabIndex = 1;
            this.btnR.Text = "Register";
            this.btnR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnSS
            // 
            this.btnSS.Image = global::LoginForm2.Properties.Resources.image_removebg_preview__1_;
            this.btnSS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSS.Location = new System.Drawing.Point(466, 55);
            this.btnSS.Name = "btnSS";
            this.btnSS.Size = new System.Drawing.Size(325, 205);
            this.btnSS.TabIndex = 0;
            this.btnSS.Text = "Store Status";
            this.btnSS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSS.UseVisualStyleBackColor = true;
            this.btnSS.Click += new System.EventHandler(this.btnSS_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 641);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBck);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnTC);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnPb);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnSS);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSS;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnPb;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnTC;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnBck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}