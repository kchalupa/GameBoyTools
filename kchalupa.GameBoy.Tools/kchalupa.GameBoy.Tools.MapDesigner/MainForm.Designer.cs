
namespace kchalupa.GameBoy.Tools.MapDesigner
{
  partial class MainForm
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
      this.m_menuStrip = new System.Windows.Forms.MenuStrip();
      this.m_fileMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.m_newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.m_saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.m_exportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.m_exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_editMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.openTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
      this.fillMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_helpMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.m_aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_tilesListView = new System.Windows.Forms.ListView();
      this.m_nameColumn = new System.Windows.Forms.ColumnHeader();
      this.m_tileColumn = new System.Windows.Forms.ColumnHeader();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.m_menuStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // m_menuStrip
      // 
      this.m_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_fileMenu,
            this.m_editMenu,
            this.m_helpMenu});
      this.m_menuStrip.Location = new System.Drawing.Point(0, 0);
      this.m_menuStrip.Name = "m_menuStrip";
      this.m_menuStrip.Size = new System.Drawing.Size(486, 24);
      this.m_menuStrip.TabIndex = 0;
      this.m_menuStrip.Text = "menuStrip1";
      // 
      // m_fileMenu
      // 
      this.m_fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_newMenuItem,
            this.m_openMenuItem,
            this.toolStripMenuItem1,
            this.m_saveMenuItem,
            this.m_saveAsMenuItem,
            this.toolStripMenuItem2,
            this.m_exportMenuItem,
            this.toolStripMenuItem3,
            this.m_exitMenuItem});
      this.m_fileMenu.Name = "m_fileMenu";
      this.m_fileMenu.Size = new System.Drawing.Size(37, 20);
      this.m_fileMenu.Text = "File";
      // 
      // m_newMenuItem
      // 
      this.m_newMenuItem.Name = "m_newMenuItem";
      this.m_newMenuItem.Size = new System.Drawing.Size(114, 22);
      this.m_newMenuItem.Text = "New";
      // 
      // m_openMenuItem
      // 
      this.m_openMenuItem.Name = "m_openMenuItem";
      this.m_openMenuItem.Size = new System.Drawing.Size(114, 22);
      this.m_openMenuItem.Text = "Open";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(111, 6);
      // 
      // m_saveMenuItem
      // 
      this.m_saveMenuItem.Name = "m_saveMenuItem";
      this.m_saveMenuItem.Size = new System.Drawing.Size(114, 22);
      this.m_saveMenuItem.Text = "Save";
      // 
      // m_saveAsMenuItem
      // 
      this.m_saveAsMenuItem.Name = "m_saveAsMenuItem";
      this.m_saveAsMenuItem.Size = new System.Drawing.Size(114, 22);
      this.m_saveAsMenuItem.Text = "Save As";
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(111, 6);
      // 
      // m_exportMenuItem
      // 
      this.m_exportMenuItem.Name = "m_exportMenuItem";
      this.m_exportMenuItem.Size = new System.Drawing.Size(114, 22);
      this.m_exportMenuItem.Text = "Export";
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(111, 6);
      // 
      // m_exitMenuItem
      // 
      this.m_exitMenuItem.Name = "m_exitMenuItem";
      this.m_exitMenuItem.Size = new System.Drawing.Size(114, 22);
      this.m_exitMenuItem.Text = "Exit";
      // 
      // m_editMenu
      // 
      this.m_editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTilesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.fillMapToolStripMenuItem});
      this.m_editMenu.Name = "m_editMenu";
      this.m_editMenu.Size = new System.Drawing.Size(39, 20);
      this.m_editMenu.Text = "Edit";
      // 
      // openTilesToolStripMenuItem
      // 
      this.openTilesToolStripMenuItem.Name = "openTilesToolStripMenuItem";
      this.openTilesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
      this.openTilesToolStripMenuItem.Text = "Specify Tiles";
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(135, 6);
      // 
      // fillMapToolStripMenuItem
      // 
      this.fillMapToolStripMenuItem.Name = "fillMapToolStripMenuItem";
      this.fillMapToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
      this.fillMapToolStripMenuItem.Text = "Fill Map";
      // 
      // m_helpMenu
      // 
      this.m_helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_aboutMenuItem});
      this.m_helpMenu.Name = "m_helpMenu";
      this.m_helpMenu.Size = new System.Drawing.Size(44, 20);
      this.m_helpMenu.Text = "Help";
      // 
      // m_aboutMenuItem
      // 
      this.m_aboutMenuItem.Name = "m_aboutMenuItem";
      this.m_aboutMenuItem.Size = new System.Drawing.Size(107, 22);
      this.m_aboutMenuItem.Text = "About";
      // 
      // m_tilesListView
      // 
      this.m_tilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.m_nameColumn,
            this.m_tileColumn});
      this.m_tilesListView.FullRowSelect = true;
      this.m_tilesListView.GridLines = true;
      this.m_tilesListView.HideSelection = false;
      this.m_tilesListView.Location = new System.Drawing.Point(424, 39);
      this.m_tilesListView.Name = "m_tilesListView";
      this.m_tilesListView.Size = new System.Drawing.Size(43, 400);
      this.m_tilesListView.TabIndex = 1;
      this.m_tilesListView.UseCompatibleStateImageBehavior = false;
      // 
      // m_nameColumn
      // 
      this.m_nameColumn.Text = "#";
      // 
      // pictureBox2
      // 
      this.pictureBox2.Location = new System.Drawing.Point(12, 39);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(400, 400);
      this.pictureBox2.TabIndex = 3;
      this.pictureBox2.TabStop = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightSteelBlue;
      this.ClientSize = new System.Drawing.Size(486, 450);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.m_tilesListView);
      this.Controls.Add(this.m_menuStrip);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.m_menuStrip;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.Text = "Map Designer";
      this.m_menuStrip.ResumeLayout(false);
      this.m_menuStrip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip m_menuStrip;
    private System.Windows.Forms.ToolStripMenuItem m_fileMenu;
    private System.Windows.Forms.ToolStripMenuItem m_newMenuItem;
    private System.Windows.Forms.ToolStripMenuItem m_openMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem m_saveMenuItem;
    private System.Windows.Forms.ToolStripMenuItem m_saveAsMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem m_exportMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem m_exitMenuItem;
    private System.Windows.Forms.ToolStripMenuItem m_editMenu;
    private System.Windows.Forms.ToolStripMenuItem m_helpMenu;
    private System.Windows.Forms.ToolStripMenuItem m_aboutMenuItem;
    private System.Windows.Forms.ListView m_tilesListView;
    private System.Windows.Forms.ToolStripMenuItem openTilesToolStripMenuItem;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.ColumnHeader m_nameColumn;
    private System.Windows.Forms.ColumnHeader m_tileColumn;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem fillMapToolStripMenuItem;
  }
}

