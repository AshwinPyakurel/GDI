namespace GPLA
{
    partial class frmGDI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ExecutionCmd = new System.Windows.Forms.TextBox();
            this.btn_ExecuteClick = new System.Windows.Forms.Button();
            this.txt_SyntaxArea = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shapeMovement = new System.Windows.Forms.PictureBox();
            this.pnl_DisplayOutput = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeMovement)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.txt_ExecutionCmd);
            this.panel1.Controls.Add(this.btn_ExecuteClick);
            this.panel1.Controls.Add(this.txt_SyntaxArea);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 252);
            this.panel1.TabIndex = 0;
            // 
            // txt_ExecutionCmd
            // 
            this.txt_ExecutionCmd.Location = new System.Drawing.Point(337, 224);
            this.txt_ExecutionCmd.Name = "txt_ExecutionCmd";
            this.txt_ExecutionCmd.Size = new System.Drawing.Size(75, 20);
            this.txt_ExecutionCmd.TabIndex = 14;
            this.txt_ExecutionCmd.TextChanged += new System.EventHandler(this.txt_ActionCmd_TextChanged);
            // 
            // btn_ExecuteClick
            // 
            this.btn_ExecuteClick.Location = new System.Drawing.Point(418, 222);
            this.btn_ExecuteClick.Name = "btn_ExecuteClick";
            this.btn_ExecuteClick.Size = new System.Drawing.Size(75, 23);
            this.btn_ExecuteClick.TabIndex = 10;
            this.btn_ExecuteClick.Text = "Execute";
            this.btn_ExecuteClick.UseVisualStyleBackColor = true;
            this.btn_ExecuteClick.Click += new System.EventHandler(this.Btn_run_Click);
            // 
            // txt_SyntaxArea
            // 
            this.txt_SyntaxArea.BackColor = System.Drawing.SystemColors.Info;
            this.txt_SyntaxArea.Location = new System.Drawing.Point(3, 27);
            this.txt_SyntaxArea.Name = "txt_SyntaxArea";
            this.txt_SyntaxArea.Size = new System.Drawing.Size(328, 218);
            this.txt_SyntaxArea.TabIndex = 1;
            this.txt_SyntaxArea.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.optionsToolStripMenuItem.Text = "...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.shapeMovement);
            this.panel2.Controls.Add(this.pnl_DisplayOutput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(498, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 252);
            this.panel2.TabIndex = 0;
            // 
            // shapeMovement
            // 
            this.shapeMovement.ErrorImage = null;
            this.shapeMovement.Location = new System.Drawing.Point(3, 322);
            this.shapeMovement.Name = "shapeMovement";
            this.shapeMovement.Size = new System.Drawing.Size(47, 46);
            this.shapeMovement.TabIndex = 7;
            this.shapeMovement.TabStop = false;
            // 
            // pnl_DisplayOutput
            // 
            this.pnl_DisplayOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnl_DisplayOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_DisplayOutput.Location = new System.Drawing.Point(0, 0);
            this.pnl_DisplayOutput.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_DisplayOutput.Name = "pnl_DisplayOutput";
            this.pnl_DisplayOutput.Size = new System.Drawing.Size(287, 252);
            this.pnl_DisplayOutput.TabIndex = 7;
            this.pnl_DisplayOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_output_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmGDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(785, 252);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGDI";
            this.Text = "Graphical Programming Language Application";
            this.Load += new System.EventHandler(this.FrmGPLA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shapeMovement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ExecuteClick;
        private System.Windows.Forms.RichTextBox txt_SyntaxArea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox shapeMovement;
        private System.Windows.Forms.Panel pnl_DisplayOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txt_ExecutionCmd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

