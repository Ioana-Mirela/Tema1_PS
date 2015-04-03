namespace app1
{
    partial class FormEmployee
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
            this.label_logged = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.panel_createAd = new System.Windows.Forms.Panel();
            this.textBox_descriptionAd = new System.Windows.Forms.TextBox();
            this.button_addAd = new System.Windows.Forms.Button();
            this.textBox_imageAd = new System.Windows.Forms.TextBox();
            this.textBox_titleAd = new System.Windows.Forms.TextBox();
            this.label_imageAd = new System.Windows.Forms.Label();
            this.label_descriptionAd = new System.Windows.Forms.Label();
            this.label_titleAd = new System.Windows.Forms.Label();
            this.label_createAd = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_updateAd = new System.Windows.Forms.Panel();
            this.label_updateImage = new System.Windows.Forms.Label();
            this.textBox_updateDescription = new System.Windows.Forms.TextBox();
            this.label_updateDescription = new System.Windows.Forms.Label();
            this.textBox_newUpdateTitle = new System.Windows.Forms.TextBox();
            this.comboBox_updateTitle = new System.Windows.Forms.ComboBox();
            this.label_updateNewTitle = new System.Windows.Forms.Label();
            this.label_updateT = new System.Windows.Forms.Label();
            this.label_updateAd = new System.Windows.Forms.Label();
            this.panel_deleteAd = new System.Windows.Forms.Panel();
            this.comboBox_deleteAd = new System.Windows.Forms.ComboBox();
            this.button_deleteAd = new System.Windows.Forms.Button();
            this.label_titleDeleteAd = new System.Windows.Forms.Label();
            this.label_deleteAd = new System.Windows.Forms.Label();
            this.panel_viewAd = new System.Windows.Forms.Panel();
            this.comboBox_viewAd = new System.Windows.Forms.ComboBox();
            this.label_viewAd = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_adImage = new System.Windows.Forms.Button();
            this.textBox_updateImage = new System.Windows.Forms.TextBox();
            this.textBox_viewAd = new System.Windows.Forms.TextBox();
            this.pictureBox_viewImage = new System.Windows.Forms.PictureBox();
            this.label_viewContentAd = new System.Windows.Forms.Label();
            this.button_addAdImage = new System.Windows.Forms.Button();
            this.panel_createAd.SuspendLayout();
            this.panel_updateAd.SuspendLayout();
            this.panel_deleteAd.SuspendLayout();
            this.panel_viewAd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_viewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label_logged
            // 
            this.label_logged.AutoSize = true;
            this.label_logged.Location = new System.Drawing.Point(927, 9);
            this.label_logged.Name = "label_logged";
            this.label_logged.Size = new System.Drawing.Size(120, 13);
            this.label_logged.TabIndex = 0;
            this.label_logged.Text = "Logged in as Employee:";
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(1162, 4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 1;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // panel_createAd
            // 
            this.panel_createAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_createAd.Controls.Add(this.button_addAdImage);
            this.panel_createAd.Controls.Add(this.textBox_descriptionAd);
            this.panel_createAd.Controls.Add(this.button_addAd);
            this.panel_createAd.Controls.Add(this.textBox_imageAd);
            this.panel_createAd.Controls.Add(this.textBox_titleAd);
            this.panel_createAd.Controls.Add(this.label_imageAd);
            this.panel_createAd.Controls.Add(this.label_descriptionAd);
            this.panel_createAd.Controls.Add(this.label_titleAd);
            this.panel_createAd.Controls.Add(this.label_createAd);
            this.panel_createAd.Location = new System.Drawing.Point(16, 84);
            this.panel_createAd.Name = "panel_createAd";
            this.panel_createAd.Size = new System.Drawing.Size(281, 379);
            this.panel_createAd.TabIndex = 2;
            // 
            // textBox_descriptionAd
            // 
            this.textBox_descriptionAd.Location = new System.Drawing.Point(16, 94);
            this.textBox_descriptionAd.Multiline = true;
            this.textBox_descriptionAd.Name = "textBox_descriptionAd";
            this.textBox_descriptionAd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_descriptionAd.Size = new System.Drawing.Size(245, 170);
            this.textBox_descriptionAd.TabIndex = 8;
            // 
            // button_addAd
            // 
            this.button_addAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addAd.Location = new System.Drawing.Point(152, 331);
            this.button_addAd.Name = "button_addAd";
            this.button_addAd.Size = new System.Drawing.Size(75, 23);
            this.button_addAd.TabIndex = 7;
            this.button_addAd.Text = "Add";
            this.button_addAd.UseVisualStyleBackColor = true;
            this.button_addAd.Click += new System.EventHandler(this.button_addAd_Click);
            // 
            // textBox_imageAd
            // 
            this.textBox_imageAd.Location = new System.Drawing.Point(58, 291);
            this.textBox_imageAd.Name = "textBox_imageAd";
            this.textBox_imageAd.Size = new System.Drawing.Size(154, 20);
            this.textBox_imageAd.TabIndex = 6;
            // 
            // textBox_titleAd
            // 
            this.textBox_titleAd.Location = new System.Drawing.Point(97, 37);
            this.textBox_titleAd.Name = "textBox_titleAd";
            this.textBox_titleAd.Size = new System.Drawing.Size(164, 20);
            this.textBox_titleAd.TabIndex = 4;
            // 
            // label_imageAd
            // 
            this.label_imageAd.AutoSize = true;
            this.label_imageAd.Location = new System.Drawing.Point(13, 294);
            this.label_imageAd.Name = "label_imageAd";
            this.label_imageAd.Size = new System.Drawing.Size(39, 13);
            this.label_imageAd.TabIndex = 3;
            this.label_imageAd.Text = "Image:";
            // 
            // label_descriptionAd
            // 
            this.label_descriptionAd.AutoSize = true;
            this.label_descriptionAd.Location = new System.Drawing.Point(13, 66);
            this.label_descriptionAd.Name = "label_descriptionAd";
            this.label_descriptionAd.Size = new System.Drawing.Size(63, 13);
            this.label_descriptionAd.TabIndex = 2;
            this.label_descriptionAd.Text = "Description:";
            // 
            // label_titleAd
            // 
            this.label_titleAd.AutoSize = true;
            this.label_titleAd.Location = new System.Drawing.Point(13, 44);
            this.label_titleAd.Name = "label_titleAd";
            this.label_titleAd.Size = new System.Drawing.Size(30, 13);
            this.label_titleAd.TabIndex = 1;
            this.label_titleAd.Text = "Title:";
            // 
            // label_createAd
            // 
            this.label_createAd.AutoSize = true;
            this.label_createAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_createAd.Location = new System.Drawing.Point(13, 9);
            this.label_createAd.Name = "label_createAd";
            this.label_createAd.Size = new System.Drawing.Size(116, 17);
            this.label_createAd.TabIndex = 0;
            this.label_createAd.Text = "Create a new Ad:";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(12, 32);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(233, 24);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "Operating Newspaper Ads";
            // 
            // panel_updateAd
            // 
            this.panel_updateAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_updateAd.Controls.Add(this.textBox_updateImage);
            this.panel_updateAd.Controls.Add(this.button_adImage);
            this.panel_updateAd.Controls.Add(this.button_update);
            this.panel_updateAd.Controls.Add(this.label_updateImage);
            this.panel_updateAd.Controls.Add(this.textBox_updateDescription);
            this.panel_updateAd.Controls.Add(this.label_updateDescription);
            this.panel_updateAd.Controls.Add(this.textBox_newUpdateTitle);
            this.panel_updateAd.Controls.Add(this.comboBox_updateTitle);
            this.panel_updateAd.Controls.Add(this.label_updateNewTitle);
            this.panel_updateAd.Controls.Add(this.label_updateT);
            this.panel_updateAd.Controls.Add(this.label_updateAd);
            this.panel_updateAd.Location = new System.Drawing.Point(317, 84);
            this.panel_updateAd.Name = "panel_updateAd";
            this.panel_updateAd.Size = new System.Drawing.Size(281, 379);
            this.panel_updateAd.TabIndex = 4;
            // 
            // label_updateImage
            // 
            this.label_updateImage.AutoSize = true;
            this.label_updateImage.Location = new System.Drawing.Point(12, 320);
            this.label_updateImage.Name = "label_updateImage";
            this.label_updateImage.Size = new System.Drawing.Size(39, 13);
            this.label_updateImage.TabIndex = 7;
            this.label_updateImage.Text = "Image:";
            // 
            // textBox_updateDescription
            // 
            this.textBox_updateDescription.Location = new System.Drawing.Point(15, 161);
            this.textBox_updateDescription.Multiline = true;
            this.textBox_updateDescription.Name = "textBox_updateDescription";
            this.textBox_updateDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_updateDescription.Size = new System.Drawing.Size(250, 146);
            this.textBox_updateDescription.TabIndex = 6;
            // 
            // label_updateDescription
            // 
            this.label_updateDescription.AutoSize = true;
            this.label_updateDescription.Location = new System.Drawing.Point(12, 145);
            this.label_updateDescription.Name = "label_updateDescription";
            this.label_updateDescription.Size = new System.Drawing.Size(63, 13);
            this.label_updateDescription.TabIndex = 5;
            this.label_updateDescription.Text = "Description:";
            // 
            // textBox_newUpdateTitle
            // 
            this.textBox_newUpdateTitle.Location = new System.Drawing.Point(15, 113);
            this.textBox_newUpdateTitle.Name = "textBox_newUpdateTitle";
            this.textBox_newUpdateTitle.Size = new System.Drawing.Size(250, 20);
            this.textBox_newUpdateTitle.TabIndex = 4;
            // 
            // comboBox_updateTitle
            // 
            this.comboBox_updateTitle.FormattingEnabled = true;
            this.comboBox_updateTitle.Location = new System.Drawing.Point(15, 66);
            this.comboBox_updateTitle.Name = "comboBox_updateTitle";
            this.comboBox_updateTitle.Size = new System.Drawing.Size(250, 21);
            this.comboBox_updateTitle.TabIndex = 3;
            this.comboBox_updateTitle.SelectedIndexChanged += new System.EventHandler(this.comboBox_updateTitle_SelectedIndexChanged);
            // 
            // label_updateNewTitle
            // 
            this.label_updateNewTitle.AutoSize = true;
            this.label_updateNewTitle.Location = new System.Drawing.Point(12, 97);
            this.label_updateNewTitle.Name = "label_updateNewTitle";
            this.label_updateNewTitle.Size = new System.Drawing.Size(51, 13);
            this.label_updateNewTitle.TabIndex = 2;
            this.label_updateNewTitle.Text = "New title:";
            // 
            // label_updateT
            // 
            this.label_updateT.AutoSize = true;
            this.label_updateT.Location = new System.Drawing.Point(12, 44);
            this.label_updateT.Name = "label_updateT";
            this.label_updateT.Size = new System.Drawing.Size(30, 13);
            this.label_updateT.TabIndex = 1;
            this.label_updateT.Text = "Title:";
            // 
            // label_updateAd
            // 
            this.label_updateAd.AutoSize = true;
            this.label_updateAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_updateAd.Location = new System.Drawing.Point(21, 9);
            this.label_updateAd.Name = "label_updateAd";
            this.label_updateAd.Size = new System.Drawing.Size(79, 17);
            this.label_updateAd.TabIndex = 0;
            this.label_updateAd.Text = "Update Ad:";
            // 
            // panel_deleteAd
            // 
            this.panel_deleteAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_deleteAd.Controls.Add(this.comboBox_deleteAd);
            this.panel_deleteAd.Controls.Add(this.button_deleteAd);
            this.panel_deleteAd.Controls.Add(this.label_titleDeleteAd);
            this.panel_deleteAd.Controls.Add(this.label_deleteAd);
            this.panel_deleteAd.Location = new System.Drawing.Point(632, 393);
            this.panel_deleteAd.Name = "panel_deleteAd";
            this.panel_deleteAd.Size = new System.Drawing.Size(610, 70);
            this.panel_deleteAd.TabIndex = 5;
            // 
            // comboBox_deleteAd
            // 
            this.comboBox_deleteAd.FormattingEnabled = true;
            this.comboBox_deleteAd.Location = new System.Drawing.Point(61, 34);
            this.comboBox_deleteAd.Name = "comboBox_deleteAd";
            this.comboBox_deleteAd.Size = new System.Drawing.Size(371, 21);
            this.comboBox_deleteAd.TabIndex = 4;
            // 
            // button_deleteAd
            // 
            this.button_deleteAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteAd.Location = new System.Drawing.Point(454, 32);
            this.button_deleteAd.Name = "button_deleteAd";
            this.button_deleteAd.Size = new System.Drawing.Size(96, 23);
            this.button_deleteAd.TabIndex = 3;
            this.button_deleteAd.Text = "Delete Ad";
            this.button_deleteAd.UseVisualStyleBackColor = true;
            this.button_deleteAd.Click += new System.EventHandler(this.button_deleteAd_Click);
            // 
            // label_titleDeleteAd
            // 
            this.label_titleDeleteAd.AutoSize = true;
            this.label_titleDeleteAd.Location = new System.Drawing.Point(25, 37);
            this.label_titleDeleteAd.Name = "label_titleDeleteAd";
            this.label_titleDeleteAd.Size = new System.Drawing.Size(30, 13);
            this.label_titleDeleteAd.TabIndex = 1;
            this.label_titleDeleteAd.Text = "Title:";
            // 
            // label_deleteAd
            // 
            this.label_deleteAd.AutoSize = true;
            this.label_deleteAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deleteAd.Location = new System.Drawing.Point(25, 9);
            this.label_deleteAd.Name = "label_deleteAd";
            this.label_deleteAd.Size = new System.Drawing.Size(74, 17);
            this.label_deleteAd.TabIndex = 0;
            this.label_deleteAd.Text = "Delete Ad:";
            // 
            // panel_viewAd
            // 
            this.panel_viewAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_viewAd.Controls.Add(this.label_viewContentAd);
            this.panel_viewAd.Controls.Add(this.pictureBox_viewImage);
            this.panel_viewAd.Controls.Add(this.textBox_viewAd);
            this.panel_viewAd.Controls.Add(this.comboBox_viewAd);
            this.panel_viewAd.Controls.Add(this.label_viewAd);
            this.panel_viewAd.Location = new System.Drawing.Point(632, 84);
            this.panel_viewAd.Name = "panel_viewAd";
            this.panel_viewAd.Size = new System.Drawing.Size(610, 294);
            this.panel_viewAd.TabIndex = 6;
            // 
            // comboBox_viewAd
            // 
            this.comboBox_viewAd.FormattingEnabled = true;
            this.comboBox_viewAd.Location = new System.Drawing.Point(93, 11);
            this.comboBox_viewAd.Name = "comboBox_viewAd";
            this.comboBox_viewAd.Size = new System.Drawing.Size(335, 21);
            this.comboBox_viewAd.TabIndex = 1;
            this.comboBox_viewAd.SelectedIndexChanged += new System.EventHandler(this.comboBox_viewAd_SelectedIndexChanged);
            // 
            // label_viewAd
            // 
            this.label_viewAd.AutoSize = true;
            this.label_viewAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_viewAd.Location = new System.Drawing.Point(25, 15);
            this.label_viewAd.Name = "label_viewAd";
            this.label_viewAd.Size = new System.Drawing.Size(62, 17);
            this.label_viewAd.TabIndex = 0;
            this.label_viewAd.Text = "View Ad:";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(96, 349);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 8;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_adImage
            // 
            this.button_adImage.Location = new System.Drawing.Point(221, 315);
            this.button_adImage.Name = "button_adImage";
            this.button_adImage.Size = new System.Drawing.Size(44, 23);
            this.button_adImage.TabIndex = 9;
            this.button_adImage.Text = "Add";
            this.button_adImage.UseVisualStyleBackColor = true;
            this.button_adImage.Click += new System.EventHandler(this.button_adImage_Click);
            // 
            // textBox_updateImage
            // 
            this.textBox_updateImage.Location = new System.Drawing.Point(57, 317);
            this.textBox_updateImage.Name = "textBox_updateImage";
            this.textBox_updateImage.Size = new System.Drawing.Size(158, 20);
            this.textBox_updateImage.TabIndex = 10;
            // 
            // textBox_viewAd
            // 
            this.textBox_viewAd.Location = new System.Drawing.Point(28, 77);
            this.textBox_viewAd.Multiline = true;
            this.textBox_viewAd.Name = "textBox_viewAd";
            this.textBox_viewAd.ReadOnly = true;
            this.textBox_viewAd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_viewAd.Size = new System.Drawing.Size(331, 194);
            this.textBox_viewAd.TabIndex = 2;
            // 
            // pictureBox_viewImage
            // 
            this.pictureBox_viewImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_viewImage.Location = new System.Drawing.Point(376, 44);
            this.pictureBox_viewImage.Name = "pictureBox_viewImage";
            this.pictureBox_viewImage.Size = new System.Drawing.Size(227, 227);
            this.pictureBox_viewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_viewImage.TabIndex = 3;
            this.pictureBox_viewImage.TabStop = false;
            // 
            // label_viewContentAd
            // 
            this.label_viewContentAd.AutoSize = true;
            this.label_viewContentAd.Location = new System.Drawing.Point(25, 61);
            this.label_viewContentAd.Name = "label_viewContentAd";
            this.label_viewContentAd.Size = new System.Drawing.Size(47, 13);
            this.label_viewContentAd.TabIndex = 4;
            this.label_viewContentAd.Text = "Content:";
            // 
            // button_addAdImage
            // 
            this.button_addAdImage.Location = new System.Drawing.Point(219, 289);
            this.button_addAdImage.Name = "button_addAdImage";
            this.button_addAdImage.Size = new System.Drawing.Size(42, 23);
            this.button_addAdImage.TabIndex = 9;
            this.button_addAdImage.Text = "Add";
            this.button_addAdImage.UseVisualStyleBackColor = true;
            this.button_addAdImage.Click += new System.EventHandler(this.button_addAdImage_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 484);
            this.Controls.Add(this.panel_viewAd);
            this.Controls.Add(this.panel_deleteAd);
            this.Controls.Add(this.panel_updateAd);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel_createAd);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.label_logged);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.panel_createAd.ResumeLayout(false);
            this.panel_createAd.PerformLayout();
            this.panel_updateAd.ResumeLayout(false);
            this.panel_updateAd.PerformLayout();
            this.panel_deleteAd.ResumeLayout(false);
            this.panel_deleteAd.PerformLayout();
            this.panel_viewAd.ResumeLayout(false);
            this.panel_viewAd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_viewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_logged;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Panel panel_createAd;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_imageAd;
        private System.Windows.Forms.Label label_descriptionAd;
        private System.Windows.Forms.Label label_titleAd;
        private System.Windows.Forms.Label label_createAd;
        private System.Windows.Forms.Button button_addAd;
        private System.Windows.Forms.TextBox textBox_imageAd;
        private System.Windows.Forms.TextBox textBox_titleAd;
        private System.Windows.Forms.TextBox textBox_descriptionAd;
        private System.Windows.Forms.Panel panel_updateAd;
        private System.Windows.Forms.Label label_updateAd;
        private System.Windows.Forms.Panel panel_deleteAd;
        private System.Windows.Forms.Button button_deleteAd;
        private System.Windows.Forms.Label label_titleDeleteAd;
        private System.Windows.Forms.Label label_deleteAd;
        private System.Windows.Forms.Panel panel_viewAd;
        private System.Windows.Forms.ComboBox comboBox_viewAd;
        private System.Windows.Forms.Label label_viewAd;
        private System.Windows.Forms.ComboBox comboBox_deleteAd;
        private System.Windows.Forms.Label label_updateImage;
        private System.Windows.Forms.TextBox textBox_updateDescription;
        private System.Windows.Forms.Label label_updateDescription;
        private System.Windows.Forms.TextBox textBox_newUpdateTitle;
        private System.Windows.Forms.ComboBox comboBox_updateTitle;
        private System.Windows.Forms.Label label_updateNewTitle;
        private System.Windows.Forms.Label label_updateT;
        private System.Windows.Forms.TextBox textBox_updateImage;
        private System.Windows.Forms.Button button_adImage;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.PictureBox pictureBox_viewImage;
        private System.Windows.Forms.TextBox textBox_viewAd;
        private System.Windows.Forms.Label label_viewContentAd;
        private System.Windows.Forms.Button button_addAdImage;

    }
}