namespace Painter {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.brown = new System.Windows.Forms.PictureBox();
            this.clearCanvas = new System.Windows.Forms.Button();
            this.brushThickness = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.white = new System.Windows.Forms.PictureBox();
            this.violet = new System.Windows.Forms.PictureBox();
            this.indigo = new System.Windows.Forms.PictureBox();
            this.orange = new System.Windows.Forms.PictureBox();
            this.yellow = new System.Windows.Forms.PictureBox();
            this.black = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.default1 = new System.Windows.Forms.PictureBox();
            this.canvas = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.white)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.default1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.brown);
            this.panel1.Controls.Add(this.clearCanvas);
            this.panel1.Controls.Add(this.brushThickness);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.white);
            this.panel1.Controls.Add(this.violet);
            this.panel1.Controls.Add(this.indigo);
            this.panel1.Controls.Add(this.orange);
            this.panel1.Controls.Add(this.yellow);
            this.panel1.Controls.Add(this.black);
            this.panel1.Controls.Add(this.blue);
            this.panel1.Controls.Add(this.green);
            this.panel1.Controls.Add(this.red);
            this.panel1.Controls.Add(this.default1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 66);
            this.panel1.TabIndex = 0;
            // 
            // brown
            // 
            this.brown.BackColor = System.Drawing.Color.SaddleBrown;
            this.brown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brown.Location = new System.Drawing.Point(94, 31);
            this.brown.Name = "brown";
            this.brown.Size = new System.Drawing.Size(25, 27);
            this.brown.TabIndex = 13;
            this.brown.TabStop = false;
            this.brown.Click += new System.EventHandler(this.brown_Click);
            // 
            // clearCanvas
            // 
            this.clearCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.clearCanvas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearCanvas.Location = new System.Drawing.Point(501, 8);
            this.clearCanvas.Name = "clearCanvas";
            this.clearCanvas.Size = new System.Drawing.Size(84, 50);
            this.clearCanvas.TabIndex = 12;
            this.clearCanvas.Text = "Clear Canvas";
            this.clearCanvas.UseVisualStyleBackColor = false;
            this.clearCanvas.Click += new System.EventHandler(this.clearCanvas_Click);
            // 
            // brushThickness
            // 
            this.brushThickness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushThickness.FormattingEnabled = true;
            this.brushThickness.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.brushThickness.Location = new System.Drawing.Point(390, 37);
            this.brushThickness.Name = "brushThickness";
            this.brushThickness.Size = new System.Drawing.Size(86, 21);
            this.brushThickness.TabIndex = 11;
            this.brushThickness.Text = "1";
            this.brushThickness.SelectedIndexChanged += new System.EventHandler(this.brushThickness_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Brush Thickness:";
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.Cursor = System.Windows.Forms.Cursors.Hand;
            this.white.Location = new System.Drawing.Point(342, 31);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(25, 27);
            this.white.TabIndex = 9;
            this.white.TabStop = false;
            this.white.Click += new System.EventHandler(this.white_Click);
            // 
            // violet
            // 
            this.violet.BackColor = System.Drawing.Color.Violet;
            this.violet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.violet.Location = new System.Drawing.Point(311, 31);
            this.violet.Name = "violet";
            this.violet.Size = new System.Drawing.Size(25, 27);
            this.violet.TabIndex = 8;
            this.violet.TabStop = false;
            this.violet.Click += new System.EventHandler(this.violet_Click);
            // 
            // indigo
            // 
            this.indigo.BackColor = System.Drawing.Color.Indigo;
            this.indigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.indigo.Location = new System.Drawing.Point(280, 31);
            this.indigo.Name = "indigo";
            this.indigo.Size = new System.Drawing.Size(25, 27);
            this.indigo.TabIndex = 7;
            this.indigo.TabStop = false;
            this.indigo.Click += new System.EventHandler(this.indigo_Click);
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.Orange;
            this.orange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orange.Location = new System.Drawing.Point(156, 31);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(25, 27);
            this.orange.TabIndex = 6;
            this.orange.TabStop = false;
            this.orange.Click += new System.EventHandler(this.orange_Click);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yellow.Location = new System.Drawing.Point(187, 31);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(25, 27);
            this.yellow.TabIndex = 5;
            this.yellow.TabStop = false;
            this.yellow.Click += new System.EventHandler(this.yellow_Click);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Cursor = System.Windows.Forms.Cursors.Hand;
            this.black.Location = new System.Drawing.Point(63, 31);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(25, 27);
            this.black.TabIndex = 4;
            this.black.TabStop = false;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blue.Location = new System.Drawing.Point(249, 31);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(25, 27);
            this.blue.TabIndex = 3;
            this.blue.TabStop = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Green;
            this.green.Cursor = System.Windows.Forms.Cursors.Hand;
            this.green.Location = new System.Drawing.Point(218, 31);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(25, 27);
            this.green.TabIndex = 2;
            this.green.TabStop = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.red.Location = new System.Drawing.Point(125, 31);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(25, 27);
            this.red.TabIndex = 1;
            this.red.TabStop = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // default1
            // 
            this.default1.BackColor = System.Drawing.Color.Black;
            this.default1.Cursor = System.Windows.Forms.Cursors.Default;
            this.default1.Location = new System.Drawing.Point(8, 8);
            this.default1.Name = "default1";
            this.default1.Size = new System.Drawing.Size(49, 50);
            this.default1.TabIndex = 0;
            this.default1.TabStop = false;
            // 
            // canvas
            // 
            this.canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 24);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(593, 365);
            this.canvas.TabIndex = 1;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Enabled = false;
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsImageToolStripMenuItem.Text = "Save as Image";
            this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 455);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Painter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.white)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.default1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox blue;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.PictureBox default1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.PictureBox black;
        private System.Windows.Forms.PictureBox yellow;
        private System.Windows.Forms.PictureBox orange;
        private System.Windows.Forms.PictureBox white;
        private System.Windows.Forms.PictureBox violet;
        private System.Windows.Forms.PictureBox indigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox brushThickness;
        private System.Windows.Forms.Button clearCanvas;
        private System.Windows.Forms.PictureBox brown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

