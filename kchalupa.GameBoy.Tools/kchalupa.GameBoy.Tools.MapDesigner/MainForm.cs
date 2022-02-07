using kchalupa.GameBoy.Tools.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kchalupa.GameBoy.Tools.MapDesigner
{
  /// <summary>
  /// The main form.
  /// </summary>
  public partial class MainForm : Form
  {

    #region fields

    /// <summary>
    /// Has the dialog been displayed?
    /// </summary>
    private bool m_dialogDisplayed = false;

    /// <summary>
    /// The model.
    /// </summary>
    private MapModel m_model = null;

    /// <summary>
    /// The list of tiles to paint with.
    /// </summary>
    private TileModel[] m_tiles = null;

    #endregion

    #region construction

    /// <summary>
    /// Constructor
    /// </summary>
    public MainForm()
    {
      InitializeComponent();

      Application.Idle += OnApplicationIdleHandler;
    } // MainForm()

    #endregion

    #region event handlers

    /// <summary>
    /// Handles the application idle to show the options dialog.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void OnApplicationIdleHandler(object sender, EventArgs args)
    {
      Mutex mutex = new Mutex();

      try
      {
        mutex.WaitOne();
        if(!m_dialogDisplayed)
        {
          MapOptionsDialog dialog = new MapOptionsDialog();
          if((_ = dialog.ShowDialog()) == DialogResult.OK)
          {
            m_tiles = dialog.Tiles;
          }
          else
          {
            Application.Exit();
          }
        }
      }
      finally
      {
        Application.Idle -= OnApplicationIdleHandler;
        m_dialogDisplayed = true;

        mutex.ReleaseMutex();
      }
    } // OnApplicationIdleHandler(object sender, EventArgs args)

    #endregion

  } // class MainForm
} // namespace kchalupa.GameBoy.Tools.MapDesigner
