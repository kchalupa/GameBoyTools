using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using kchalupa.GameBoy.Tools.Models;
using static kchalupa.GameBoy.Tools.Models.TileModel;

namespace kchalupa.GameBoy.Tools.TileDesigner
{
  /// <summary>
  /// The form the user is going to interact with.
  /// </summary>
  public partial class MainForm : Form
  {

    #region fields

    /// <summary>
    /// Keeps track of if something was changed. Warn the user.
    /// </summary>
    public bool m_modified = false;

    /// <summary>
    /// The filename to save to.
    /// </summary>
    private String m_filename = String.Empty;

    /// <summary>
    /// The selected color to draw with.
    /// </summary>
    private Color m_selectedColor = AvailableColors.White;

    /// <summary>
    /// The image to ultimately draw to.
    /// </summary>
    private Bitmap m_pixelsBitmap = new Bitmap(280, 280);

    /// <summary>
    /// The selected tile.
    /// </summary>
    private TileModel m_selectedTile = null;

    #endregion

    /// <summary>
    /// Constructor.
    /// </summary>
    public MainForm()
    {
      InitializeComponent();

      for(int i=0;i<128;++i)
      {
        TileModel tile = new TileModel();
        tile.Name = i.ToString();

        m_tilesComboBox.Items.Add(tile);
      }

      m_selectedTile = (TileModel)(m_tilesComboBox.Items[0]);
      m_tilesComboBox.SelectedItem = m_selectedTile;

      using (Graphics g = Graphics.FromImage(m_pixelsBitmap))
      {
        g.FillRectangle(new SolidBrush(AvailableColors.White), 0, 0, 280, 280);
      }

      m_previewPictureBox.BackgroundImage = m_pixelsBitmap;
      m_pixelsPictureBox.BackgroundImage = m_pixelsBitmap;
    } // MainForm()

    /// <summary>
    /// Handles the various menu items.
    /// </summary>
    /// <param name="sender">The origin of the event.</param>
    /// <param name="args">Arguments to take into account.</param>
    private void MenuItemClickHandler(object sender, EventArgs args)
    {
      if(sender == m_newMenuItem)
      {
        if(m_modified && DialogResult.No == WarnUnsavedWork())
        {
          return;
        }

        m_tilesComboBox.Items.Clear();

        for(int i=0;i<128;++i)
        {
          TileModel tile = new TileModel();
          tile.Name = i.ToString();

          m_tilesComboBox.Items.Add(tile);
        }

        m_tilesComboBox.SelectedIndex = 0;
        m_filename = String.Empty;
        m_modified = false;
      }
      else if(sender == m_openMenuItem)
      {
        if(m_modified && DialogResult.No == WarnUnsavedWork())
        {
          return;
        }

        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Filter = "Xml Files (*.xml)|*.xml";

        if (DialogResult.OK == dialog.ShowDialog())
        {
          m_tilesComboBox.Items.Clear();

          TileModel[] models = null;

          try
          {
            models = LoadTiles(dialog.FileName);
          }
          catch(Exception e)
          {
            MessageBox.Show("Error in Opening the File. " + e.Message, "Error");
          }

          m_tilesComboBox.Items.AddRange(models);
          m_tilesComboBox.SelectedIndex = 0;

          m_filename = dialog.FileName;
          m_modified = false;
        }
      }
      else if(sender == m_saveMenuItem || sender == m_saveAsMenuItem)
      {
        // Only show the save dialog when neccessary.
        if(sender == m_saveAsMenuItem || m_filename == String.Empty)
        { 
          SaveFileDialog dialog = new SaveFileDialog();
          dialog.Filter = "Xml Files (*.xml)|*.xml";

          if (DialogResult.Cancel == dialog.ShowDialog())
          {
            return;
          }

          m_filename = dialog.FileName;
        }

        try
        {
          SaveTiles(m_filename);
        }
        catch(Exception e)
        {
          MessageBox.Show("Error in saving the tile data. " + e.Message, "Error");
        }

        m_modified = false;
      }
      else if(sender == m_exitMenuItem)
      {
        this.Close();
      }
      else if(sender == m_cutMenuItem)
      {

      }
      else if(sender == m_copyMenuItem)
      {

      }
      else if(sender == m_pasteMenuItem)
      {

      }
      else if(sender == m_flipHorizontalMenuItem)
      {
        m_selectedTile.FlipHorizontal();
      }
      else if(sender == m_flipVerticalMenuItem)
      {
        m_selectedTile.FlipVertical();
      }
      else if(sender == m_rotateClockwiseMenuItem)
      {
        m_selectedTile.RotateClockwise();
      }
      else if(sender == m_rotateCounterclockwiseToolStripMenuItem)
      {
        m_selectedTile.RotateCounterclockwise();
      }
      else if(sender == m_randomizeMenuItem)
      {
        m_selectedTile.Randomize();
      }
      else if(sender == m_aboutMenuItem)
      {
        MessageBox.Show("This program helps manage tiles for Game Boy Development. Version: 1.0 Alpha");
      }
      else
      {
        Control control = (Control)sender;
        if(control != null)
        {
          MessageBox.Show("Unknown menu item, need to implement a handler. ", "Error");
        }
        else
        {
          MessageBox.Show("Unknown event origin. " + sender.ToString(), "Error");
        }
      }

      DrawImage(m_selectedTile.Pixels);
    } // MenuItemClickHandler( sender, args )


    /// <summary>
    /// Handles the Combo Box's Selected Changed event.
    /// </summary>
    /// <param name="sender">The origin of the event.</param>
    /// <param name="args">Arguments to take into account.</param>
    private void TilesComboSelectedIndexChangedHandler(object sender, EventArgs args)
    {
      // Set up the new one.
      m_selectedTile = ((TileModel)m_tilesComboBox.SelectedItem);
      m_nameTextBox.Text = m_selectedTile.Name;

      // Load the pixel configuration.
      DrawImage(m_selectedTile.Pixels);
    } // TilesComboSelectedIndexChangedHandler( sender, args )


    /// <summary>
    /// Handles the Picture Box's Mouse Down event.
    /// </summary>
    /// <param name="sender">The origin of the event.</param>
    /// <param name="args">Arguments to take into account.</param>
    private void PixelsMouseDownHandler(object sender, MouseEventArgs args)
    {
      PixelsMouseMoveHandler(sender, args);
    } // PixelsMouseDownHandler( sender, args )


    /// <summary>
    /// Handles the Picture Box's Mouse Move to paint the image.
    /// </summary>
    /// <param name="sender">The origin of the event.</param>
    /// <param name="args">Arguments to take into account.</param>
    private void PixelsMouseMoveHandler(object sender, MouseEventArgs args)
    {
      Color color = AvailableColors.White;
      if (args.Button == MouseButtons.Left)
      {
        int x = args.X / 35;
        int y = args.Y / 35;

        if (args.Button == MouseButtons.Left)
          color = m_selectedColor;

        if (x >= 0 && x <= 7 && y >= 0 && y <= 7)
        {
          m_selectedTile.Pixels[y * 8 + x] = m_selectedColor;
        }

        DrawImage(m_selectedTile.Pixels);
        m_modified = true;
      }
    } // PixelMouseMoveHandler( sender, args )


    /// <summary>
    /// Changes the pen based on the button click.
    /// </summary>
    /// <param name="sender">The origin of the event.</param>
    /// <param name="args">The arguments to take into account.</param>
    private void ColorButtonClickHandler(object sender, EventArgs args)
    {
      if (sender == m_darkGreenButton)
      {
        m_selectedColor = AvailableColors.DarkGreen;
      }
      else if (sender == m_middleGreenButton)
      {
        m_selectedColor = AvailableColors.MiddleGreen;
      }
      else if (sender == m_lightGreenButton)
      {
        m_selectedColor = AvailableColors.LightGreen;
      }
      else
      {
        m_selectedColor = AvailableColors.White;
      }
    } // ColoButtonClick( sender, args )


    /// <summary>
    /// Update the name of the tile.
    /// </summary>
    /// <param name="sender">The origin of the event.</param>
    /// <param name="args">Arguments to take into account.</param>
    private void OnUpdateButtonClickHandler(object sender, EventArgs args)
    {
      m_selectedTile.Name = m_nameTextBox.Text;

      int index = m_tilesComboBox.SelectedIndex;
      m_tilesComboBox.Items.Remove(m_selectedTile);
      m_tilesComboBox.Items.Insert(index, m_selectedTile);
      m_tilesComboBox.SelectedIndex = index;

      m_modified = true;
    } // OnUpdateButtonClickHandler( sender, args )


    /// <summary>
    /// Loads the tile models.
    /// </summary>
    /// <param name="filename"></param>
    /// <returns></returns>
    private TileModel[] LoadTiles(string filename)
    {
      TileModel[] m_models = new TileModel[128];

      XmlDocument doc = new XmlDocument();
      doc.Load(filename);

      XmlNodeList tiles = doc.DocumentElement.SelectNodes("tile");

      int i = 0;
      foreach (XmlNode tile in tiles)
      {
        m_models[i++] = TileModel.FromXml(tile);
      }

      return m_models;
    } // LoadTiles( filename )


    /// <summary>
    /// Saves a big 'ol Xml file.
    /// </summary>
    /// <param name="filename">The filename to write to.</param>
    private void SaveTiles(String filename)
    {
      XmlDocument doc = new XmlDocument();
      XmlElement elem = doc.CreateElement("tiles");
      doc.AppendChild(elem);

      for(int i=0;i<m_tilesComboBox.Items.Count;++i)
      {
        TileModel model = (TileModel)(m_tilesComboBox.Items[i]);
        elem.AppendChild(model.ToXml(doc));
      }

      doc.Save(filename);
    } // SaveTiles( filename )


    /// <summary>
    /// Single simple draw method for updating the picture box.
    /// </summary>
    /// <param name="pixels">Describes the picture.</param>
    private void DrawImage(Color[] pixels)
    {
      using (Graphics g = Graphics.FromImage(m_pixelsBitmap))
      {
        for (int y = 0; y < 8; ++y)
        {
          for (int x = 0; x < 8; ++x)
          {
            g.FillRectangle(new SolidBrush(pixels[y * 8 + x]), x * 35, y * 35, 35, 35);
          }
        }
      }

      m_pixelsPictureBox.Invalidate();
      m_previewPictureBox.Invalidate();
    } // DrawImage( pixels )


    /// <summary>
    /// Need to use this in multiple places consolidate it.
    /// </summary>
    /// <returns></returns>
    private DialogResult WarnUnsavedWork()
    {
      return MessageBox.Show(this, "You have unsaved work. Do you wish to continue?",
        "Overwrite Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
    } // WarnUnsavedWork()

  } // class MainForm
} // namespace kchalupa.GameBoy.Tools.TileDesigner
