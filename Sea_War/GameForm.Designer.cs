namespace Sea_War
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.infoPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHighestScore = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.warFieldPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoPanel.SuspendLayout();
            this.warFieldPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            resources.ApplyResources(this.infoPanel, "infoPanel");
            this.infoPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.infoPanel.Controls.Add(this.label6);
            this.infoPanel.Controls.Add(this.lblHighestScore);
            this.infoPanel.Controls.Add(this.lblDifficulty);
            this.infoPanel.Controls.Add(this.lblScore);
            this.infoPanel.Controls.Add(this.lblTime);
            this.infoPanel.Controls.Add(this.label5);
            this.infoPanel.Controls.Add(this.label4);
            this.infoPanel.Controls.Add(this.label3);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Name = "infoPanel";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lblHighestScore
            // 
            resources.ApplyResources(this.lblHighestScore, "lblHighestScore");
            this.lblHighestScore.Name = "lblHighestScore";
            // 
            // lblDifficulty
            // 
            resources.ApplyResources(this.lblDifficulty, "lblDifficulty");
            this.lblDifficulty.Name = "lblDifficulty";
            // 
            // lblScore
            // 
            resources.ApplyResources(this.lblScore, "lblScore");
            this.lblScore.Name = "lblScore";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.Name = "lblTime";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // warFieldPanel
            // 
            resources.ApplyResources(this.warFieldPanel, "warFieldPanel");
            this.warFieldPanel.BackColor = System.Drawing.SystemColors.Info;
            this.warFieldPanel.Controls.Add(this.panel1);
            this.warFieldPanel.Name = "warFieldPanel";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Name = "panel1";
            // 
            // GameForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.warFieldPanel);
            this.Controls.Add(this.infoPanel);
            this.Name = "GameForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.warFieldPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel infoPanel;
        private Label label2;
        private Label label1;
        private Panel warFieldPanel;
        private Label lblHighestScore;
        private Label lblDifficulty;
        private Label lblScore;
        private Label lblTime;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Panel panel1;
    }
}