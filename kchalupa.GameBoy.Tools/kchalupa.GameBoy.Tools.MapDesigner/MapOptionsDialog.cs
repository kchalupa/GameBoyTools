using kchalupa.GameBoy.Tools.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static kchalupa.GameBoy.Tools.Models.MapModel;

namespace kchalupa.GameBoy.Tools.MapDesigner
{
  /// <summary>
  /// Map Options Dialog
  /// </summary>
  public partial class MapOptionsDialog : Form
  {

    #region fields

    /// <summary>
    /// The filename that was loaded.
    /// </summary>
    private string m_tilesFilename = string.Empty;

    /// <summary>
    /// The tiles that were loaded.
    /// </summary>
    private TileModel[] m_tiles = null;

    /// <summary>
    /// The size of the map.
    /// </summary>
    private Sizes m_mapSize = Sizes.Maximum;

    #endregion

    #region construction

    /// <summary>
    /// Constructor
    /// </summary>
    public MapOptionsDialog()
    {
      InitializeComponent();
    } // MapOptionsDialog()

    #endregion

    #region properties

    /// <summary>
    /// The filename that was loaded.
    /// </summary>
    public string TilesFilename
    {
      get { return m_tilesFilename; }
    } // TilesFilename


    /// <summary>
    /// Gets the tiles.
    /// </summary>
    public TileModel[] Tiles
    {
      get { return m_tiles; }
    } // Tiles


    /// <summary>
    /// Gets the size of the map.
    /// </summary>
    public Sizes MapSize
    {
      get { return m_mapSize; }
    } // Size

    #endregion

    #region event handlers

    /// <summary>
    /// Handles the tiles navigator click event.
    /// </summary>
    /// <param name="sender">The origin of the event.</param>
    /// <param name="args">Arguments to take into account.</param>
    private void OnTilesFileNavigatorClickHandler(object sender, EventArgs args)
    {
      OpenFileDialog dialog = new OpenFileDialog();
      dialog.Filter = "Xml Files (*.xml)|*.xml";
 
      if(DialogResult.OK == dialog.ShowDialog())
      {
        m_tilesFilename = dialog.FileName;
      }

      try
      {
        XmlDocument doc = new XmlDocument();
        doc.Load(m_tilesFilename);

        XmlNodeList list = doc.DocumentElement.ChildNodes;
        for (int i = 0; i < list.Count; ++i)
        {
          try
          {
            m_tiles[i] = TileModel.FromXml(list[i]);
          }
          catch (ArgumentException)
          {
            MessageBox.Show("Invalid value specified. [NAME=\"" + list[i].Attributes["name"] + "\"]");
            
            // Do not allow a partial list.
            m_tiles = null;
            break;
          }
        }
      }
      catch(System.IO.IOException e)
      {
        MessageBox.Show("Unable to load specified file. [MESSAGE=\"" + e.Message + "\"]");
      }
      catch(Exception e)
      {
        MessageBox.Show("Unspecified exception occurred. [MESSAGE=\"" + e.Message + "\"]");
      }
    } // OnTilesFileNavigatorClickHandler( sender, args )


    /// <summary>
    /// Handles one of the size buttons being checked.
    /// </summary>
    /// <param name="sender">The origin of the event.</param>
    /// <param name="args">Arguments to take into account.</param>
    private void OnSizeCheckedChangedHandler(object sender, EventArgs args)
    {
      if(sender == m_maximumSizeRadioButton)
      {
        m_mapSize = Sizes.Maximum;
      }
      else if(sender == m_fullScreenRadioButton)
      {
        m_mapSize = Sizes.FullScreen;
      }
      else
      {
        m_mapSize = Sizes.QuarterScreen;
      }
    } // OnSizeCheckedChangedHandler( sender, args )


    /// <summary>
    /// Handles the form closing event.
    /// </summary>
    /// <param name="sender">The origin of the event.</param>
    /// <param name="args">Arguments to take into account.</param>
    private void OnFormClosingHandler(object sender, FormClosingEventArgs args)
    {
      if(m_tiles == null)
      {
        if(DialogResult.No == MessageBox.Show(this, "Tiles has not been initialized, that means you need to click the button and select a file.\nIf it failed, please contact Kyle. Click Yes to exit the application.", "Tiles Not Loaded", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
        {
          args.Cancel = true;
        }
        else
        {
          Application.Exit();
        }
      }
    } // OnFormClosingHandler(object sender, FormClosingEventArgs args)

    #endregion

  } // class MapOptionsDialog
} // namespace kchalupa.GameBoy.Tools.MapDesigner

