﻿namespace Main
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizeApp = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.m2lHotel1 = new Main.m2lHotel();
            this.m2lStands1 = new Main.m2lStands();
            this.m2lAteliers1 = new Main.m2lAteliers();
            this.btnHotels = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStands = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnParticipants = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAteliers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.m2lParticipants1 = new Main.m2lParticipants();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMinimizeApp);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 25);
            this.panel1.TabIndex = 1;
            // 
            // btnMinimizeApp
            // 
            this.btnMinimizeApp.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeApp.Image")));
            this.btnMinimizeApp.ImageActive = null;
            this.btnMinimizeApp.Location = new System.Drawing.Point(1156, 0);
            this.btnMinimizeApp.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizeApp.Name = "btnMinimizeApp";
            this.btnMinimizeApp.Size = new System.Drawing.Size(32, 25);
            this.btnMinimizeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizeApp.TabIndex = 3;
            this.btnMinimizeApp.TabStop = false;
            this.btnMinimizeApp.Zoom = 10;
            this.btnMinimizeApp.Click += new System.EventHandler(this.btnMinimizeApp_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1196, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.m2lParticipants1);
            this.bunifuGradientPanel1.Controls.Add(this.m2lHotel1);
            this.bunifuGradientPanel1.Controls.Add(this.m2lStands1);
            this.bunifuGradientPanel1.Controls.Add(this.m2lAteliers1);
            this.bunifuGradientPanel1.Controls.Add(this.btnHotels);
            this.bunifuGradientPanel1.Controls.Add(this.btnStands);
            this.bunifuGradientPanel1.Controls.Add(this.btnParticipants);
            this.bunifuGradientPanel1.Controls.Add(this.btnAteliers);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.BlueViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Azure;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 25);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1233, 570);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // m2lHotel1
            // 
            this.m2lHotel1.Location = new System.Drawing.Point(315, 0);
            this.m2lHotel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m2lHotel1.Name = "m2lHotel1";
            this.m2lHotel1.Size = new System.Drawing.Size(918, 570);
            this.m2lHotel1.TabIndex = 5;
            // 
            // m2lStands1
            // 
            this.m2lStands1.AutoScroll = true;
            this.m2lStands1.Location = new System.Drawing.Point(315, 0);
            this.m2lStands1.Name = "m2lStands1";
            this.m2lStands1.Size = new System.Drawing.Size(918, 570);
            this.m2lStands1.TabIndex = 4;
            // 
            // m2lAteliers1
            // 
            this.m2lAteliers1.Location = new System.Drawing.Point(315, 0);
            this.m2lAteliers1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m2lAteliers1.Name = "m2lAteliers1";
            this.m2lAteliers1.Size = new System.Drawing.Size(918, 570);
            this.m2lAteliers1.TabIndex = 2;
            // 
            // btnHotels
            // 
            this.btnHotels.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHotels.AutoSize = true;
            this.btnHotels.BackColor = System.Drawing.Color.Transparent;
            this.btnHotels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHotels.BorderRadius = 0;
            this.btnHotels.ButtonText = " Hotels";
            this.btnHotels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotels.DisabledColor = System.Drawing.Color.Gray;
            this.btnHotels.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHotels.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHotels.Iconimage")));
            this.btnHotels.Iconimage_right = null;
            this.btnHotels.Iconimage_right_Selected = null;
            this.btnHotels.Iconimage_Selected = null;
            this.btnHotels.IconMarginLeft = 0;
            this.btnHotels.IconMarginRight = 0;
            this.btnHotels.IconRightVisible = true;
            this.btnHotels.IconRightZoom = 0D;
            this.btnHotels.IconVisible = true;
            this.btnHotels.IconZoom = 90D;
            this.btnHotels.IsTab = false;
            this.btnHotels.Location = new System.Drawing.Point(0, 278);
            this.btnHotels.Margin = new System.Windows.Forms.Padding(5);
            this.btnHotels.Name = "btnHotels";
            this.btnHotels.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHotels.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHotels.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHotels.selected = false;
            this.btnHotels.Size = new System.Drawing.Size(307, 61);
            this.btnHotels.TabIndex = 3;
            this.btnHotels.Text = " Hotels";
            this.btnHotels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotels.Textcolor = System.Drawing.Color.White;
            this.btnHotels.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotels.Click += new System.EventHandler(this.BtnHotels_Click);
            // 
            // btnStands
            // 
            this.btnStands.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStands.AutoSize = true;
            this.btnStands.BackColor = System.Drawing.Color.Transparent;
            this.btnStands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStands.BorderRadius = 0;
            this.btnStands.ButtonText = "Stands";
            this.btnStands.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStands.DisabledColor = System.Drawing.Color.Gray;
            this.btnStands.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStands.Iconimage = global::Main.Properties.Resources.standsIcon;
            this.btnStands.Iconimage_right = null;
            this.btnStands.Iconimage_right_Selected = null;
            this.btnStands.Iconimage_Selected = null;
            this.btnStands.IconMarginLeft = 0;
            this.btnStands.IconMarginRight = 0;
            this.btnStands.IconRightVisible = true;
            this.btnStands.IconRightZoom = 0D;
            this.btnStands.IconVisible = true;
            this.btnStands.IconZoom = 90D;
            this.btnStands.IsTab = false;
            this.btnStands.Location = new System.Drawing.Point(0, 212);
            this.btnStands.Margin = new System.Windows.Forms.Padding(5);
            this.btnStands.Name = "btnStands";
            this.btnStands.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStands.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnStands.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStands.selected = false;
            this.btnStands.Size = new System.Drawing.Size(307, 61);
            this.btnStands.TabIndex = 1;
            this.btnStands.Text = "Stands";
            this.btnStands.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStands.Textcolor = System.Drawing.Color.White;
            this.btnStands.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStands.Click += new System.EventHandler(this.btnStands_Click);
            // 
            // btnParticipants
            // 
            this.btnParticipants.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnParticipants.AutoSize = true;
            this.btnParticipants.BackColor = System.Drawing.Color.Transparent;
            this.btnParticipants.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnParticipants.BorderRadius = 0;
            this.btnParticipants.ButtonText = "Participants";
            this.btnParticipants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParticipants.DisabledColor = System.Drawing.Color.Gray;
            this.btnParticipants.Iconcolor = System.Drawing.Color.Transparent;
            this.btnParticipants.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnParticipants.Iconimage")));
            this.btnParticipants.Iconimage_right = null;
            this.btnParticipants.Iconimage_right_Selected = null;
            this.btnParticipants.Iconimage_Selected = null;
            this.btnParticipants.IconMarginLeft = 0;
            this.btnParticipants.IconMarginRight = 0;
            this.btnParticipants.IconRightVisible = true;
            this.btnParticipants.IconRightZoom = 0D;
            this.btnParticipants.IconVisible = true;
            this.btnParticipants.IconZoom = 90D;
            this.btnParticipants.IsTab = false;
            this.btnParticipants.Location = new System.Drawing.Point(0, 145);
            this.btnParticipants.Margin = new System.Windows.Forms.Padding(5);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Normalcolor = System.Drawing.Color.Transparent;
            this.btnParticipants.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnParticipants.OnHoverTextColor = System.Drawing.Color.White;
            this.btnParticipants.selected = false;
            this.btnParticipants.Size = new System.Drawing.Size(309, 61);
            this.btnParticipants.TabIndex = 1;
            this.btnParticipants.Text = "Participants";
            this.btnParticipants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParticipants.Textcolor = System.Drawing.Color.White;
            this.btnParticipants.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // btnAteliers
            // 
            this.btnAteliers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAteliers.AutoSize = true;
            this.btnAteliers.BackColor = System.Drawing.Color.Transparent;
            this.btnAteliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAteliers.BorderRadius = 0;
            this.btnAteliers.ButtonText = "Ateliers";
            this.btnAteliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAteliers.DisabledColor = System.Drawing.Color.Gray;
            this.btnAteliers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAteliers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAteliers.Iconimage")));
            this.btnAteliers.Iconimage_right = null;
            this.btnAteliers.Iconimage_right_Selected = null;
            this.btnAteliers.Iconimage_Selected = null;
            this.btnAteliers.IconMarginLeft = 0;
            this.btnAteliers.IconMarginRight = 0;
            this.btnAteliers.IconRightVisible = true;
            this.btnAteliers.IconRightZoom = 0D;
            this.btnAteliers.IconVisible = true;
            this.btnAteliers.IconZoom = 90D;
            this.btnAteliers.IsTab = false;
            this.btnAteliers.Location = new System.Drawing.Point(0, 79);
            this.btnAteliers.Margin = new System.Windows.Forms.Padding(5);
            this.btnAteliers.Name = "btnAteliers";
            this.btnAteliers.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAteliers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAteliers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAteliers.selected = false;
            this.btnAteliers.Size = new System.Drawing.Size(314, 61);
            this.btnAteliers.TabIndex = 0;
            this.btnAteliers.Text = "Ateliers";
            this.btnAteliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAteliers.Textcolor = System.Drawing.Color.White;
            this.btnAteliers.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAteliers.Click += new System.EventHandler(this.btnAteliers_Click);
            // 
            // m2lParticipants1
            // 
            this.m2lParticipants1.Location = new System.Drawing.Point(315, 0);
            this.m2lParticipants1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m2lParticipants1.Name = "m2lParticipants1";
            this.m2lParticipants1.Size = new System.Drawing.Size(918, 570);
            this.m2lParticipants1.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 595);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizeApp;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHotels;
        private Bunifu.Framework.UI.BunifuFlatButton btnStands;
        private Bunifu.Framework.UI.BunifuFlatButton btnParticipants;
        private Bunifu.Framework.UI.BunifuFlatButton btnAteliers;
        private m2lAteliers m2lAteliers1;
        private m2lStands m2lStands1;
        private m2lHotel m2lHotel1;
        private m2lParticipants m2lParticipants1;
    }
}

