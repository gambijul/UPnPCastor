namespace UPnPCastor
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.CmdDiscover = new System.Windows.Forms.Button();
            this.cbDevices = new System.Windows.Forms.ComboBox();
            this.CmdPlay = new System.Windows.Forms.Button();
            this.CmdPause = new System.Windows.Forms.Button();
            this.TxtUri = new System.Windows.Forms.TextBox();
            this.LblUri = new System.Windows.Forms.Label();
            this.CmdStop = new System.Windows.Forms.Button();
            this.CmdCast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdDiscover
            // 
            this.CmdDiscover.Location = new System.Drawing.Point(12, 12);
            this.CmdDiscover.Name = "CmdDiscover";
            this.CmdDiscover.Size = new System.Drawing.Size(80, 23);
            this.CmdDiscover.TabIndex = 1;
            this.CmdDiscover.Text = "Discover";
            this.CmdDiscover.UseVisualStyleBackColor = true;
            this.CmdDiscover.Click += new System.EventHandler(this.CmdDiscover_Click);
            // 
            // cbDevices
            // 
            this.cbDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevices.FormattingEnabled = true;
            this.cbDevices.Location = new System.Drawing.Point(98, 13);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(188, 23);
            this.cbDevices.TabIndex = 2;
            // 
            // CmdPlay
            // 
            this.CmdPlay.Location = new System.Drawing.Point(12, 71);
            this.CmdPlay.Name = "CmdPlay";
            this.CmdPlay.Size = new System.Drawing.Size(100, 23);
            this.CmdPlay.TabIndex = 3;
            this.CmdPlay.Text = "Play";
            this.CmdPlay.UseVisualStyleBackColor = true;
            this.CmdPlay.Click += new System.EventHandler(this.CmdPlay_Click);
            // 
            // CmdPause
            // 
            this.CmdPause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdPause.Location = new System.Drawing.Point(118, 71);
            this.CmdPause.Name = "CmdPause";
            this.CmdPause.Size = new System.Drawing.Size(148, 23);
            this.CmdPause.TabIndex = 4;
            this.CmdPause.Text = "Pause";
            this.CmdPause.UseVisualStyleBackColor = true;
            this.CmdPause.Click += new System.EventHandler(this.CmdPause_Click);
            // 
            // TxtUri
            // 
            this.TxtUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUri.Location = new System.Drawing.Point(43, 42);
            this.TxtUri.Name = "TxtUri";
            this.TxtUri.Size = new System.Drawing.Size(329, 23);
            this.TxtUri.TabIndex = 5;
            this.TxtUri.Text = "http://commondatastorage.googleapis.com/gtv-videos-bucket/big_buck_bunny_1080p.mp" +
    "4";
            // 
            // LblUri
            // 
            this.LblUri.AutoSize = true;
            this.LblUri.Location = new System.Drawing.Point(12, 45);
            this.LblUri.Name = "LblUri";
            this.LblUri.Size = new System.Drawing.Size(25, 15);
            this.LblUri.TabIndex = 6;
            this.LblUri.Text = "Uri:";
            // 
            // CmdStop
            // 
            this.CmdStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdStop.Location = new System.Drawing.Point(272, 71);
            this.CmdStop.Name = "CmdStop";
            this.CmdStop.Size = new System.Drawing.Size(100, 23);
            this.CmdStop.TabIndex = 7;
            this.CmdStop.Text = "Stop";
            this.CmdStop.UseVisualStyleBackColor = true;
            this.CmdStop.Click += new System.EventHandler(this.CmdStop_Click);
            // 
            // CmdCast
            // 
            this.CmdCast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdCast.Location = new System.Drawing.Point(292, 12);
            this.CmdCast.Name = "CmdCast";
            this.CmdCast.Size = new System.Drawing.Size(80, 23);
            this.CmdCast.TabIndex = 9;
            this.CmdCast.Text = "Cast";
            this.CmdCast.UseVisualStyleBackColor = true;
            this.CmdCast.Click += new System.EventHandler(this.CmdCast_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 106);
            this.Controls.Add(this.CmdCast);
            this.Controls.Add(this.CmdStop);
            this.Controls.Add(this.LblUri);
            this.Controls.Add(this.TxtUri);
            this.Controls.Add(this.CmdPause);
            this.Controls.Add(this.CmdPlay);
            this.Controls.Add(this.cbDevices);
            this.Controls.Add(this.CmdDiscover);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPnPCastor";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button CmdDiscover;
        private ComboBox cbDevices;
        private Button CmdPlay;
        private Button CmdPause;
        private TextBox TxtUri;
        private Label LblUri;
        private Button CmdStop;
        private Button CmdCast;
    }
}