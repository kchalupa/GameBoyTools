
namespace kchalupa.GameBoy.Tools.MapDesigner
{
  partial class MapOptionsDialog
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
      this.m_selectTilesFileLabel = new System.Windows.Forms.Label();
      this.m_tileNavigator = new System.Windows.Forms.Button();
      this.m_selectSizeGroupBox = new System.Windows.Forms.GroupBox();
      this.m_maximumSizeRadioButton = new System.Windows.Forms.RadioButton();
      this.m_fullScreenRadioButton = new System.Windows.Forms.RadioButton();
      this.m_quarterScreenRadioButton = new System.Windows.Forms.RadioButton();
      this.m_okButton = new System.Windows.Forms.Button();
      this.m_cancelButton = new System.Windows.Forms.Button();
      this.m_selectSizeGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // m_selectTilesFileLabel
      // 
      this.m_selectTilesFileLabel.AutoSize = true;
      this.m_selectTilesFileLabel.Location = new System.Drawing.Point(12, 9);
      this.m_selectTilesFileLabel.Name = "m_selectTilesFileLabel";
      this.m_selectTilesFileLabel.Size = new System.Drawing.Size(88, 15);
      this.m_selectTilesFileLabel.TabIndex = 0;
      this.m_selectTilesFileLabel.Text = "Select Tiles File:";
      // 
      // m_tileNavigator
      // 
      this.m_tileNavigator.Location = new System.Drawing.Point(200, 5);
      this.m_tileNavigator.Name = "m_tileNavigator";
      this.m_tileNavigator.Size = new System.Drawing.Size(34, 23);
      this.m_tileNavigator.TabIndex = 1;
      this.m_tileNavigator.Text = "...";
      this.m_tileNavigator.UseVisualStyleBackColor = true;
      this.m_tileNavigator.Click += new System.EventHandler(this.OnTilesFileNavigatorClickHandler);
      // 
      // m_selectSizeGroupBox
      // 
      this.m_selectSizeGroupBox.Controls.Add(this.m_maximumSizeRadioButton);
      this.m_selectSizeGroupBox.Controls.Add(this.m_fullScreenRadioButton);
      this.m_selectSizeGroupBox.Controls.Add(this.m_quarterScreenRadioButton);
      this.m_selectSizeGroupBox.Location = new System.Drawing.Point(12, 46);
      this.m_selectSizeGroupBox.Name = "m_selectSizeGroupBox";
      this.m_selectSizeGroupBox.Size = new System.Drawing.Size(222, 75);
      this.m_selectSizeGroupBox.TabIndex = 2;
      this.m_selectSizeGroupBox.TabStop = false;
      this.m_selectSizeGroupBox.Text = "Select Size";
      // 
      // m_maximumSizeRadioButton
      // 
      this.m_maximumSizeRadioButton.AutoSize = true;
      this.m_maximumSizeRadioButton.Location = new System.Drawing.Point(16, 47);
      this.m_maximumSizeRadioButton.Name = "m_maximumSizeRadioButton";
      this.m_maximumSizeRadioButton.Size = new System.Drawing.Size(154, 19);
      this.m_maximumSizeRadioButton.TabIndex = 3;
      this.m_maximumSizeRadioButton.TabStop = true;
      this.m_maximumSizeRadioButton.Text = "Maximum Size Available";
      this.m_maximumSizeRadioButton.UseVisualStyleBackColor = true;
      this.m_maximumSizeRadioButton.Enter += new System.EventHandler(this.OnSizeCheckedChangedHandler);
      // 
      // m_fullScreenRadioButton
      // 
      this.m_fullScreenRadioButton.AutoSize = true;
      this.m_fullScreenRadioButton.Location = new System.Drawing.Point(125, 22);
      this.m_fullScreenRadioButton.Name = "m_fullScreenRadioButton";
      this.m_fullScreenRadioButton.Size = new System.Drawing.Size(82, 19);
      this.m_fullScreenRadioButton.TabIndex = 3;
      this.m_fullScreenRadioButton.TabStop = true;
      this.m_fullScreenRadioButton.Text = "Full Screen";
      this.m_fullScreenRadioButton.UseVisualStyleBackColor = true;
      this.m_fullScreenRadioButton.Enter += new System.EventHandler(this.OnSizeCheckedChangedHandler);
      // 
      // m_quarterScreenRadioButton
      // 
      this.m_quarterScreenRadioButton.AutoSize = true;
      this.m_quarterScreenRadioButton.Location = new System.Drawing.Point(16, 22);
      this.m_quarterScreenRadioButton.Name = "m_quarterScreenRadioButton";
      this.m_quarterScreenRadioButton.Size = new System.Drawing.Size(103, 19);
      this.m_quarterScreenRadioButton.TabIndex = 3;
      this.m_quarterScreenRadioButton.TabStop = true;
      this.m_quarterScreenRadioButton.Text = "Quarter Screen";
      this.m_quarterScreenRadioButton.UseVisualStyleBackColor = true;
      this.m_quarterScreenRadioButton.CheckedChanged += new System.EventHandler(this.OnSizeCheckedChangedHandler);
      // 
      // m_okButton
      // 
      this.m_okButton.Location = new System.Drawing.Point(72, 142);
      this.m_okButton.Name = "m_okButton";
      this.m_okButton.Size = new System.Drawing.Size(75, 23);
      this.m_okButton.TabIndex = 3;
      this.m_okButton.Text = "OK";
      this.m_okButton.UseVisualStyleBackColor = true;
      // 
      // m_cancelButton
      // 
      this.m_cancelButton.Location = new System.Drawing.Point(159, 142);
      this.m_cancelButton.Name = "m_cancelButton";
      this.m_cancelButton.Size = new System.Drawing.Size(75, 23);
      this.m_cancelButton.TabIndex = 4;
      this.m_cancelButton.Text = "Cancel";
      this.m_cancelButton.UseVisualStyleBackColor = true;
      // 
      // MapOptionsDialog
      // 
      this.AcceptButton = this.m_okButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightSteelBlue;
      this.CancelButton = this.m_cancelButton;
      this.ClientSize = new System.Drawing.Size(246, 177);
      this.Controls.Add(this.m_cancelButton);
      this.Controls.Add(this.m_okButton);
      this.Controls.Add(this.m_selectSizeGroupBox);
      this.Controls.Add(this.m_tileNavigator);
      this.Controls.Add(this.m_selectTilesFileLabel);
      this.ForeColor = System.Drawing.Color.DarkBlue;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MinimizeBox = false;
      this.Name = "MapOptionsDialog";
      this.Text = "Map Options";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosingHandler);
      this.m_selectSizeGroupBox.ResumeLayout(false);
      this.m_selectSizeGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label m_selectTilesFileLabel;
    private System.Windows.Forms.Button m_tileNavigator;
    private System.Windows.Forms.GroupBox m_selectSizeGroupBox;
    private System.Windows.Forms.RadioButton m_maximumSizeRadioButton;
    private System.Windows.Forms.RadioButton m_fullScreenRadioButton;
    private System.Windows.Forms.RadioButton m_quarterScreenRadioButton;
    private System.Windows.Forms.Button m_okButton;
    private System.Windows.Forms.Button m_cancelButton;
  }
}