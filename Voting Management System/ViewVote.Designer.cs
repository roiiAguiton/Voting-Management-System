﻿namespace Voting_Management_System
{
    partial class ViewVote
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVote));
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.StudentPicture = new System.Windows.Forms.PictureBox();
            this.BtnVote = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnUnVote = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblposition = new System.Windows.Forms.Label();
            this.lblfullname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltrackstrand = new System.Windows.Forms.Label();
            this.lblplatform = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblpartylist = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.lblcandidateid = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StudentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this;
            // 
            // StudentPicture
            // 
            this.StudentPicture.BackColor = System.Drawing.Color.White;
            this.StudentPicture.Image = ((System.Drawing.Image)(resources.GetObject("StudentPicture.Image")));
            this.StudentPicture.Location = new System.Drawing.Point(15, 109);
            this.StudentPicture.Name = "StudentPicture";
            this.StudentPicture.Size = new System.Drawing.Size(180, 180);
            this.StudentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentPicture.TabIndex = 237;
            this.StudentPicture.TabStop = false;
            // 
            // BtnVote
            // 
            this.BtnVote.Active = false;
            this.BtnVote.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnVote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.BtnVote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVote.BorderRadius = 5;
            this.BtnVote.ButtonText = "Vote";
            this.BtnVote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVote.DisabledColor = System.Drawing.Color.Gray;
            this.BtnVote.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnVote.Iconimage = null;
            this.BtnVote.Iconimage_right = null;
            this.BtnVote.Iconimage_right_Selected = null;
            this.BtnVote.Iconimage_Selected = null;
            this.BtnVote.IconMarginLeft = 0;
            this.BtnVote.IconMarginRight = 0;
            this.BtnVote.IconRightVisible = true;
            this.BtnVote.IconRightZoom = 0D;
            this.BtnVote.IconVisible = true;
            this.BtnVote.IconZoom = 90D;
            this.BtnVote.IsTab = false;
            this.BtnVote.Location = new System.Drawing.Point(15, 404);
            this.BtnVote.Name = "BtnVote";
            this.BtnVote.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.BtnVote.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.BtnVote.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnVote.selected = false;
            this.BtnVote.Size = new System.Drawing.Size(410, 58);
            this.BtnVote.TabIndex = 236;
            this.BtnVote.Text = "Vote";
            this.BtnVote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnVote.Textcolor = System.Drawing.Color.White;
            this.BtnVote.TextFont = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVote.Click += new System.EventHandler(this.BtnVote_Click);
            // 
            // BtnUnVote
            // 
            this.BtnUnVote.Active = false;
            this.BtnUnVote.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnUnVote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.BtnUnVote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUnVote.BorderRadius = 5;
            this.BtnUnVote.ButtonText = "Un-Vote";
            this.BtnUnVote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUnVote.DisabledColor = System.Drawing.Color.Gray;
            this.BtnUnVote.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnUnVote.Iconimage = null;
            this.BtnUnVote.Iconimage_right = null;
            this.BtnUnVote.Iconimage_right_Selected = null;
            this.BtnUnVote.Iconimage_Selected = null;
            this.BtnUnVote.IconMarginLeft = 0;
            this.BtnUnVote.IconMarginRight = 0;
            this.BtnUnVote.IconRightVisible = true;
            this.BtnUnVote.IconRightZoom = 0D;
            this.BtnUnVote.IconVisible = true;
            this.BtnUnVote.IconZoom = 90D;
            this.BtnUnVote.IsTab = false;
            this.BtnUnVote.Location = new System.Drawing.Point(15, 404);
            this.BtnUnVote.Name = "BtnUnVote";
            this.BtnUnVote.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.BtnUnVote.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.BtnUnVote.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnUnVote.selected = false;
            this.BtnUnVote.Size = new System.Drawing.Size(410, 58);
            this.BtnUnVote.TabIndex = 238;
            this.BtnUnVote.Text = "Un-Vote";
            this.BtnUnVote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnUnVote.Textcolor = System.Drawing.Color.White;
            this.BtnUnVote.TextFont = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.BtnUnVote.Click += new System.EventHandler(this.BtnUnVote_Click);
            // 
            // lblposition
            // 
            this.lblposition.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblposition.ForeColor = System.Drawing.Color.Black;
            this.lblposition.Location = new System.Drawing.Point(15, 56);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(410, 48);
            this.lblposition.TabIndex = 240;
            this.lblposition.Text = "President";
            this.lblposition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.ForeColor = System.Drawing.Color.Black;
            this.lblfullname.Location = new System.Drawing.Point(205, 174);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(231, 20);
            this.lblfullname.TabIndex = 242;
            this.lblfullname.Text = "Kenneth Glenn Somera Bamba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(205, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 241;
            this.label4.Text = "Student Name";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(446, 5);
            this.panel6.TabIndex = 243;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(205, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 246;
            this.label5.Text = "Track and Strand";
            // 
            // lbltrackstrand
            // 
            this.lbltrackstrand.AutoSize = true;
            this.lbltrackstrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrackstrand.ForeColor = System.Drawing.Color.Black;
            this.lbltrackstrand.Location = new System.Drawing.Point(205, 270);
            this.lbltrackstrand.Name = "lbltrackstrand";
            this.lbltrackstrand.Size = new System.Drawing.Size(34, 20);
            this.lbltrackstrand.TabIndex = 247;
            this.lbltrackstrand.Text = "ICT";
            // 
            // lblplatform
            // 
            this.lblplatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplatform.ForeColor = System.Drawing.Color.Black;
            this.lblplatform.Location = new System.Drawing.Point(11, 328);
            this.lblplatform.Name = "lblplatform";
            this.lblplatform.Size = new System.Drawing.Size(414, 73);
            this.lblplatform.TabIndex = 248;
            this.lblplatform.Text = "asdasdasdasndjkasdashjdhaskdas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(11, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 249;
            this.label7.Text = "Platform";
            // 
            // lblpartylist
            // 
            this.lblpartylist.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpartylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblpartylist.Location = new System.Drawing.Point(10, 8);
            this.lblpartylist.Name = "lblpartylist";
            this.lblpartylist.Size = new System.Drawing.Size(415, 48);
            this.lblpartylist.TabIndex = 250;
            this.lblpartylist.Text = "First Partylist";
            this.lblpartylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asd.ForeColor = System.Drawing.Color.DimGray;
            this.asd.Location = new System.Drawing.Point(205, 109);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(109, 21);
            this.asd.TabIndex = 251;
            this.asd.Text = "Candidate ID";
            // 
            // lblcandidateid
            // 
            this.lblcandidateid.AutoSize = true;
            this.lblcandidateid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcandidateid.ForeColor = System.Drawing.Color.Black;
            this.lblcandidateid.Location = new System.Drawing.Point(205, 130);
            this.lblcandidateid.Name = "lblcandidateid";
            this.lblcandidateid.Size = new System.Drawing.Size(18, 20);
            this.lblcandidateid.TabIndex = 252;
            this.lblcandidateid.Text = "1";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.ForeColor = System.Drawing.Color.Black;
            this.lblgender.Location = new System.Drawing.Point(205, 223);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(114, 20);
            this.lblgender.TabIndex = 254;
            this.lblgender.Text = "asdadadasdas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(205, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 253;
            this.label9.Text = "Gender";
            // 
            // t1
            // 
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // ViewVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblcandidateid);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.lblpartylist);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblplatform);
            this.Controls.Add(this.lbltrackstrand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblposition);
            this.Controls.Add(this.StudentPicture);
            this.Controls.Add(this.BtnVote);
            this.Controls.Add(this.BtnUnVote);
            this.Name = "ViewVote";
            this.Size = new System.Drawing.Size(446, 469);
            this.Load += new System.EventHandler(this.ViewVote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        public System.Windows.Forms.PictureBox StudentPicture;
        public Bunifu.Framework.UI.BunifuFlatButton BtnVote;
        public Bunifu.Framework.UI.BunifuFlatButton BtnUnVote;
        public System.Windows.Forms.Label lblfullname;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label lbltrackstrand;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblplatform;
        public System.Windows.Forms.Label lblpartylist;
        public System.Windows.Forms.Label lblposition;
        public System.Windows.Forms.Label asd;
        public System.Windows.Forms.Label lblcandidateid;
        public System.Windows.Forms.Label lblgender;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer t1;
    }
}
