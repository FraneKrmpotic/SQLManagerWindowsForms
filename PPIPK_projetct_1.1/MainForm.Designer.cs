
namespace PPIPK_projetct_1._1
{
    partial class MainForm
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
            this.CbDatabase = new System.Windows.Forms.ComboBox();
            this.TbQuery = new System.Windows.Forms.TextBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TbResults = new System.Windows.Forms.TabPage();
            this.TbMessage = new System.Windows.Forms.TabPage();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.FLPResults = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.TbResults.SuspendLayout();
            this.TbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbDatabase
            // 
            this.CbDatabase.FormattingEnabled = true;
            this.CbDatabase.Location = new System.Drawing.Point(12, 12);
            this.CbDatabase.Name = "CbDatabase";
            this.CbDatabase.Size = new System.Drawing.Size(115, 21);
            this.CbDatabase.TabIndex = 0;
            // 
            // TbQuery
            // 
            this.TbQuery.Location = new System.Drawing.Point(12, 39);
            this.TbQuery.Multiline = true;
            this.TbQuery.Name = "TbQuery";
            this.TbQuery.Size = new System.Drawing.Size(870, 377);
            this.TbQuery.TabIndex = 1;
            // 
            // BtnExecute
            // 
            this.BtnExecute.Location = new System.Drawing.Point(742, 10);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(140, 23);
            this.BtnExecute.TabIndex = 4;
            this.BtnExecute.Text = "Go";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TbResults);
            this.tabControl1.Controls.Add(this.TbMessage);
            this.tabControl1.Location = new System.Drawing.Point(12, 422);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 189);
            this.tabControl1.TabIndex = 5;
            // 
            // TbResults
            // 
            this.TbResults.Controls.Add(this.FLPResults);
            this.TbResults.Location = new System.Drawing.Point(4, 22);
            this.TbResults.Name = "TbResults";
            this.TbResults.Padding = new System.Windows.Forms.Padding(3);
            this.TbResults.Size = new System.Drawing.Size(862, 163);
            this.TbResults.TabIndex = 0;
            this.TbResults.Text = "Results";
            this.TbResults.UseVisualStyleBackColor = true;
            // 
            // TbMessage
            // 
            this.TbMessage.Controls.Add(this.TxtMessage);
            this.TbMessage.Location = new System.Drawing.Point(4, 22);
            this.TbMessage.Name = "TbMessage";
            this.TbMessage.Padding = new System.Windows.Forms.Padding(3);
            this.TbMessage.Size = new System.Drawing.Size(862, 163);
            this.TbMessage.TabIndex = 1;
            this.TbMessage.Text = "Message";
            this.TbMessage.UseVisualStyleBackColor = true;
            // 
            // TxtMessage
            // 
            this.TxtMessage.Location = new System.Drawing.Point(-4, 0);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(866, 163);
            this.TxtMessage.TabIndex = 0;
            // 
            // FLPResults
            // 
            this.FLPResults.Location = new System.Drawing.Point(0, 0);
            this.FLPResults.Name = "FLPResults";
            this.FLPResults.Size = new System.Drawing.Size(862, 167);
            this.FLPResults.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 623);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.TbQuery);
            this.Controls.Add(this.CbDatabase);
            this.Name = "MainForm";
            this.Text = "Query";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.TbResults.ResumeLayout(false);
            this.TbMessage.ResumeLayout(false);
            this.TbMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbDatabase;
        private System.Windows.Forms.TextBox TbQuery;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TbResults;
        private System.Windows.Forms.TabPage TbMessage;
        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.FlowLayoutPanel FLPResults;
    }
}

