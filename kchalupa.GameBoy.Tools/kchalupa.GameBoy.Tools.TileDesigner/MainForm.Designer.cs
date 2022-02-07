using kchalupa.GameBoy.Tools.Models;
using static kchalupa.GameBoy.Tools.Models.TileModel;

namespace kchalupa.GameBoy.Tools.TileDesigner
{
  /// <summary>
  /// Designer Portion Of The Mainform.
  /// </summary>
  partial class MainForm
  {

    #region fields

    /// <summary>
    /// Required designer variable
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// The main menu
    /// </summary>
    private System.Windows.Forms.MenuStrip m_menuStrip;

    /// <summary>
    /// File menu
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_fileMenu;

    /// <summary>
    /// New menu item
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_newMenuItem;

    /// <summary>
    /// Open menu item
    /// </summary>    
    private System.Windows.Forms.ToolStripMenuItem m_openMenuItem;

    /// <summary>
    /// Save menu item
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_saveMenuItem;

    /// <summary>
    /// Save As menu item
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_saveAsMenuItem;

    /// <summary>
    /// Export menu item
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_exportMenuItem;

    /// <summary>
    /// Exit menu item
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_exitMenuItem;

    /// <summary>
    /// Edit menu
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_editMenuItem;

    /// <summary>
    /// Cut menu item
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_cutMenuItem;

    /// <summary>
    /// Copy menu item
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_copyMenuItem;

    /// <summary>
    /// Paste menu item
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_pasteMenuItem;

    /// <summary>
    /// Flip horizontal menu item
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_flipHorizontalMenuItem;

    /// <summary>
    /// Flip horizontal menu item
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_flipVerticalMenuItem;

    /// <summary>
    /// Rotate clockwise menu item
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_rotateClockwiseMenuItem;

    /// <summary>
    /// Rotate counterclockwise menu item
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_rotateCounterclockwiseToolStripMenuItem;

    /// <summary>
    /// Randomize menu item
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_randomizeMenuItem;

    /// <summary>
    /// Help menu
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_helpMenu;

    /// <summary>
    /// About menu item
    /// </summary>
    private System.Windows.Forms.ToolStripMenuItem m_aboutMenuItem;

    /// <summary>
    /// The list of tiles.
    /// </summary>
    private System.Windows.Forms.ComboBox m_tilesComboBox;

    /// <summary>
    /// The preview picture.
    /// </summary>
    private System.Windows.Forms.PictureBox m_previewPictureBox;

    /// <summary>
    /// The picture box to display the result.
    /// </summary>
    private System.Windows.Forms.PictureBox m_pixelsPictureBox;

    /// <summary>
    /// Button to select the color.
    /// </summary>
    private System.Windows.Forms.Button m_darkGreenButton;

    /// <summary>
    /// Button to select the color.
    /// </summary>
    private System.Windows.Forms.Button m_middleGreenButton;

    /// <summary>
    /// Button to select the color.
    /// </summary>
    private System.Windows.Forms.Button m_lightGreenButton;

    /// <summary>
    /// Button to select the color.
    /// </summary>
    private System.Windows.Forms.Button m_whiteButton;

    /// <summary>
    /// The name label
    /// </summary>
    private System.Windows.Forms.Label m_nameLabel;

    /// <summary>
    /// Name textbox
    /// </summary>
    private System.Windows.Forms.TextBox m_nameTextBox;

    /// <summary>
    /// Update button
    /// </summary>
    private System.Windows.Forms.Button m_updateButton;

    /// <summary>
    /// The number of seperators
    /// </summary>
    private System.Windows.Forms.ToolStripSeparator m_menuSeperator1;
    private System.Windows.Forms.ToolStripSeparator m_menSeperator2;
    private System.Windows.Forms.ToolStripSeparator m_menuSeperator4;
    private System.Windows.Forms.ToolStripSeparator m_menuSeperator5;
    private System.Windows.Forms.ToolStripSeparator m_menuSeperator6;
    private System.Windows.Forms.ToolStripSeparator m_menuSeperator3;

    #endregion

    #region methods

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
    } // Dispose(bool disposing)

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.m_menuStrip = new System.Windows.Forms.MenuStrip();
      this.m_fileMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.m_newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_menuSeperator1 = new System.Windows.Forms.ToolStripSeparator();
      this.m_saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_menSeperator2 = new System.Windows.Forms.ToolStripSeparator();
      this.m_exportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_menuSeperator3 = new System.Windows.Forms.ToolStripSeparator();
      this.m_exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_menuSeperator4 = new System.Windows.Forms.ToolStripSeparator();
      this.m_flipHorizontalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_flipVerticalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_menuSeperator5 = new System.Windows.Forms.ToolStripSeparator();
      this.m_rotateClockwiseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_rotateCounterclockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_menuSeperator6 = new System.Windows.Forms.ToolStripSeparator();
      this.m_randomizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_helpMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.m_aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.m_previewPictureBox = new System.Windows.Forms.PictureBox();
      this.m_darkGreenButton = new System.Windows.Forms.Button();
      this.m_middleGreenButton = new System.Windows.Forms.Button();
      this.m_lightGreenButton = new System.Windows.Forms.Button();
      this.m_whiteButton = new System.Windows.Forms.Button();
      this.m_nameLabel = new System.Windows.Forms.Label();
      this.m_nameTextBox = new System.Windows.Forms.TextBox();
      this.m_updateButton = new System.Windows.Forms.Button();
      this.m_tilesComboBox = new System.Windows.Forms.ComboBox();
      this.m_pixelsPictureBox = new System.Windows.Forms.PictureBox();
      this.m_menuStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_previewPictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.m_pixelsPictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // m_menuStrip
      // 
      this.m_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_fileMenu,
            this.m_editMenuItem,
            this.m_helpMenu});
      this.m_menuStrip.Location = new System.Drawing.Point(0, 0);
      this.m_menuStrip.Name = "m_menuStrip";
      this.m_menuStrip.Size = new System.Drawing.Size(336, 24);
      this.m_menuStrip.TabIndex = 2;
      this.m_menuStrip.Text = "menuStrip1";
      // 
      // m_fileMenu
      // 
      this.m_fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_newMenuItem,
            this.m_openMenuItem,
            this.m_menuSeperator1,
            this.m_saveMenuItem,
            this.m_saveAsMenuItem,
            this.m_menSeperator2,
            this.m_exportMenuItem,
            this.m_menuSeperator3,
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
      this.m_newMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
      // 
      // m_openMenuItem
      // 
      this.m_openMenuItem.Name = "m_openMenuItem";
      this.m_openMenuItem.Size = new System.Drawing.Size(114, 22);
      this.m_openMenuItem.Text = "Open";
      this.m_openMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
      // 
      // m_menuSeperator1
      // 
      this.m_menuSeperator1.Name = "m_menuSeperator1";
      this.m_menuSeperator1.Size = new System.Drawing.Size(111, 6);
      // 
      // m_saveMenuItem
      // 
      this.m_saveMenuItem.Name = "m_saveMenuItem";
      this.m_saveMenuItem.Size = new System.Drawing.Size(114, 22);
      this.m_saveMenuItem.Text = "Save";
      this.m_saveMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
      // 
      // m_saveAsMenuItem
      // 
      this.m_saveAsMenuItem.Name = "m_saveAsMenuItem";
      this.m_saveAsMenuItem.Size = new System.Drawing.Size(114, 22);
      this.m_saveAsMenuItem.Text = "Save As";
      this.m_saveAsMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
      // 
      // m_menSeperator2
      // 
      this.m_menSeperator2.Name = "m_menSeperator2";
      this.m_menSeperator2.Size = new System.Drawing.Size(111, 6);
      // 
      // m_exportMenuItem
      // 
      this.m_exportMenuItem.Name = "m_exportMenuItem";
      this.m_exportMenuItem.Size = new System.Drawing.Size(114, 22);
      this.m_exportMenuItem.Text = "Export";
      this.m_exportMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
      // 
      // m_menuSeperator3
      // 
      this.m_menuSeperator3.Name = "m_menuSeperator3";
      this.m_menuSeperator3.Size = new System.Drawing.Size(111, 6);
      // 
      // m_exitMenuItem
      // 
      this.m_exitMenuItem.Name = "m_exitMenuItem";
      this.m_exitMenuItem.Size = new System.Drawing.Size(114, 22);
      this.m_exitMenuItem.Text = "Exit";
      this.m_exitMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
      // 
      // m_editMenuItem
      // 
      this.m_editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_cutMenuItem,
            this.m_copyMenuItem,
            this.m_pasteMenuItem,
            this.m_menuSeperator4,
            this.m_flipHorizontalMenuItem,
            this.m_flipVerticalMenuItem,
            this.m_menuSeperator5,
            this.m_rotateClockwiseMenuItem,
            this.m_rotateCounterclockwiseToolStripMenuItem,
            this.m_menuSeperator6,
            this.m_randomizeMenuItem});
      this.m_editMenuItem.Name = "m_editMenuItem";
      this.m_editMenuItem.Size = new System.Drawing.Size(39, 20);
      this.m_editMenuItem.Text = "Edit";
      // 
      // m_cutMenuItem
      // 
      this.m_cutMenuItem.Name = "m_cutMenuItem";
      this.m_cutMenuItem.Size = new System.Drawing.Size(205, 22);
      this.m_cutMenuItem.Text = "Cut";
      this.m_cutMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
      // 
      // m_copyMenuItem
      // 
      this.m_copyMenuItem.Name = "m_copyMenuItem";
      this.m_copyMenuItem.Size = new System.Drawing.Size(205, 22);
      this.m_copyMenuItem.Text = "Copy";
      this.m_copyMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
      // 
      // m_pasteMenuItem
      // 
      this.m_pasteMenuItem.Name = "m_pasteMenuItem";
      this.m_pasteMenuItem.Size = new System.Drawing.Size(205, 22);
      this.m_pasteMenuItem.Text = "Paste";
      this.m_pasteMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
      // 
      // m_menuSeperator4
      // 
      this.m_menuSeperator4.Name = "m_menuSeperator4";
      this.m_menuSeperator4.Size = new System.Drawing.Size(202, 6);
      // 
      // m_flipHorizontalMenuItem
      // 
      this.m_flipHorizontalMenuItem.Name = "m_flipHorizontalMenuItem";
      this.m_flipHorizontalMenuItem.Size = new System.Drawing.Size(205, 22);
      this.m_flipHorizontalMenuItem.Text = "Flip Horizontal";
      this.m_flipHorizontalMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
      // 
      // m_flipVerticalMenuItem
      // 
      this.m_flipVerticalMenuItem.Name = "m_flipVerticalMenuItem";
      this.m_flipVerticalMenuItem.Size = new System.Drawing.Size(205, 22);
      this.m_flipVerticalMenuItem.Text = "Flip Vertical";
      this.m_flipVerticalMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
      // 
      // m_menuSeperator5
      // 
      this.m_menuSeperator5.Name = "m_menuSeperator5";
      this.m_menuSeperator5.Size = new System.Drawing.Size(202, 6);
      // 
      // m_rotateClockwiseMenuItem
      // 
      this.m_rotateClockwiseMenuItem.Name = "m_rotateClockwiseMenuItem";
      this.m_rotateClockwiseMenuItem.Size = new System.Drawing.Size(205, 22);
      this.m_rotateClockwiseMenuItem.Text = "Rotate Clockwise";
      this.m_rotateClockwiseMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
      // 
      // m_rotateCounterclockwiseToolStripMenuItem
      // 
      this.m_rotateCounterclockwiseToolStripMenuItem.Name = "m_rotateCounterclockwiseToolStripMenuItem";
      this.m_rotateCounterclockwiseToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.m_rotateCounterclockwiseToolStripMenuItem.Text = "Rotate Counterclockwise";
      this.m_rotateCounterclockwiseToolStripMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
      // 
      // m_menuSeperator6
      // 
      this.m_menuSeperator6.Name = "m_menuSeperator6";
      this.m_menuSeperator6.Size = new System.Drawing.Size(202, 6);
      // 
      // m_randomizeMenuItem
      // 
      this.m_randomizeMenuItem.Name = "m_randomizeMenuItem";
      this.m_randomizeMenuItem.Size = new System.Drawing.Size(205, 22);
      this.m_randomizeMenuItem.Text = "Randomize";
      this.m_randomizeMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
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
      this.m_aboutMenuItem.Click += new System.EventHandler(this.MenuItemClickHandler);
      // 
      // m_previewPictureBox
      // 
      this.m_previewPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.m_previewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.m_previewPictureBox.Location = new System.Drawing.Point(277, 34);
      this.m_previewPictureBox.Name = "m_previewPictureBox";
      this.m_previewPictureBox.Size = new System.Drawing.Size(32, 32);
      this.m_previewPictureBox.TabIndex = 3;
      this.m_previewPictureBox.TabStop = false;
      // 
      // m_darkGreenButton
      // 
      this.m_darkGreenButton.Location = new System.Drawing.Point(232, 364);
      this.m_darkGreenButton.Name = "m_darkGreenButton";
      this.m_darkGreenButton.Size = new System.Drawing.Size(21, 21);
      this.m_darkGreenButton.BackColor = AvailableColors.DarkGreen;
      this.m_darkGreenButton.TabIndex = 4;
      this.m_darkGreenButton.UseVisualStyleBackColor = false;
      this.m_darkGreenButton.Click += new System.EventHandler(this.ColorButtonClickHandler);
      // 
      // m_middleGreenButton
      // 
      this.m_middleGreenButton.Location = new System.Drawing.Point(250, 364);
      this.m_middleGreenButton.Name = "m_middleGreenButton";
      this.m_middleGreenButton.Size = new System.Drawing.Size(21, 21);
      this.m_middleGreenButton.BackColor = AvailableColors.MiddleGreen;
      this.m_middleGreenButton.TabIndex = 5;
      this.m_middleGreenButton.UseVisualStyleBackColor = false;
      this.m_middleGreenButton.Click += new System.EventHandler(this.ColorButtonClickHandler);
      // 
      // m_lightGreenButton
      // 
      this.m_lightGreenButton.Location = new System.Drawing.Point(269, 364);
      this.m_lightGreenButton.Name = "m_lightGreenButton";
      this.m_lightGreenButton.Size = new System.Drawing.Size(21, 21);
      this.m_lightGreenButton.BackColor = AvailableColors.LightGreen;
      this.m_lightGreenButton.TabIndex = 6;
      this.m_lightGreenButton.UseVisualStyleBackColor = false;
      this.m_lightGreenButton.Click += new System.EventHandler(this.ColorButtonClickHandler);
      // 
      // m_whiteButton
      // 
      this.m_whiteButton.Location = new System.Drawing.Point(288, 364);
      this.m_whiteButton.Name = "m_whiteButton";
      this.m_whiteButton.Size = new System.Drawing.Size(21, 21);
      this.m_whiteButton.BackColor = AvailableColors.White;
      this.m_whiteButton.TabIndex = 7;
      this.m_whiteButton.UseVisualStyleBackColor = false;
      this.m_whiteButton.Click += new System.EventHandler(this.ColorButtonClickHandler);
      // 
      // m_nameLabel
      // 
      this.m_nameLabel.AutoSize = true;
      this.m_nameLabel.Location = new System.Drawing.Point(26, 398);
      this.m_nameLabel.Name = "m_nameLabel";
      this.m_nameLabel.Size = new System.Drawing.Size(41, 13);
      this.m_nameLabel.TabIndex = 8;
      this.m_nameLabel.Text = "Name:";
      // 
      // m_nameTextBox
      // 
      this.m_nameTextBox.Location = new System.Drawing.Point(82, 395);
      this.m_nameTextBox.Name = "m_nameTextBox";
      this.m_nameTextBox.Size = new System.Drawing.Size(129, 22);
      this.m_nameTextBox.TabIndex = 9;
      // 
      // m_updateButton
      // 
      this.m_updateButton.Location = new System.Drawing.Point(234, 393);
      this.m_updateButton.Name = "m_updateButton";
      this.m_updateButton.Size = new System.Drawing.Size(75, 23);
      this.m_updateButton.TabIndex = 10;
      this.m_updateButton.Text = "Update";
      this.m_updateButton.UseVisualStyleBackColor = true;
      this.m_updateButton.Click += new System.EventHandler(this.OnUpdateButtonClickHandler);
      // 
      // m_tilesComboBox
      // 
      this.m_tilesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.m_tilesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.m_tilesComboBox.FormattingEnabled = true;
      this.m_tilesComboBox.Location = new System.Drawing.Point(29, 40);
      this.m_tilesComboBox.Name = "m_tilesComboBox";
      this.m_tilesComboBox.Size = new System.Drawing.Size(230, 21);
      this.m_tilesComboBox.TabIndex = 0;
      this.m_tilesComboBox.SelectedIndexChanged += new System.EventHandler(this.TilesComboSelectedIndexChangedHandler);
      // 
      // m_pixelsPictureBox
      // 
      this.m_pixelsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.m_pixelsPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.m_pixelsPictureBox.Location = new System.Drawing.Point(29, 78);
      this.m_pixelsPictureBox.Name = "m_pixelsPictureBox";
      this.m_pixelsPictureBox.Size = new System.Drawing.Size(280, 280);
      this.m_pixelsPictureBox.TabIndex = 0;
      this.m_pixelsPictureBox.TabStop = false;
      this.m_pixelsPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PixelsMouseDownHandler);
      this.m_pixelsPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PixelsMouseMoveHandler);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.LightSteelBlue;
      this.ClientSize = new System.Drawing.Size(336, 430);
      this.Controls.Add(this.m_pixelsPictureBox);
      this.Controls.Add(this.m_updateButton);
      this.Controls.Add(this.m_nameTextBox);
      this.Controls.Add(this.m_nameLabel);
      this.Controls.Add(this.m_whiteButton);
      this.Controls.Add(this.m_lightGreenButton);
      this.Controls.Add(this.m_middleGreenButton);
      this.Controls.Add(this.m_darkGreenButton);
      this.Controls.Add(this.m_previewPictureBox);
      this.Controls.Add(this.m_tilesComboBox);
      this.Controls.Add(this.m_menuStrip);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.ForeColor = System.Drawing.Color.DarkBlue;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MainMenuStrip = this.m_menuStrip;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.Text = "Tile Designer";
      this.m_menuStrip.ResumeLayout(false);
      this.m_menuStrip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_previewPictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.m_pixelsPictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    } // InitializeComponent()

    #endregion

    #endregion

  } // class MainForm
} // namespace kchalupa.GameBoy.Tools.TileDesigner
