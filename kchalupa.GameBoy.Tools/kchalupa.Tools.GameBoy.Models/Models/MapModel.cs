using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kchalupa.GameBoy.Tools.Models
{
  /// <summary>
  /// A map model to record and load a map.
  /// </summary>
  public class MapModel
  {

    #region size enum

    /// <summary>
    /// An enum describing the potential sizes of the map.
    /// </summary>
    public enum Sizes
    {
      QuarterScreen,
      FullScreen,
      Maximum
    } // enum Sizes

    #endregion

    #region fields

    /// <summary>
    /// The actual map.
    /// </summary>
    private TileModel[] m_map = null;

    /// <summary>
    /// The width of the map.
    /// </summary>
    private int m_width;

    /// <summary>
    /// The height of the map.
    /// </summary>
    private int m_height;

    #endregion

    #region construction

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="size">The size of the map.</param>
    public MapModel(Sizes size)
    {
      if (size == Sizes.Maximum)
      {
        m_map = new TileModel[1024];
        m_width = 32;
        m_height = 32;
      }
      else if (size == Sizes.FullScreen)
      {
        m_map = new TileModel[320];
        m_width = 20;
        m_height = 16;
      }
      else
      {
        m_map = new TileModel[80];
        m_width = 10;
        m_height = 8;
      }
    } // MapModel()

    #endregion

    #region properties

    /// <summary>
    /// Gets or sets the map.
    /// </summary>
    public TileModel[] Map
    {
      get { return m_map; }
      //set { m_map = value; }
    } // Map


    /// <summary>
    /// Gets the width.
    /// </summary>
    public int Width
    {
      get { return m_width; }
    } // Width


    /// <summary>
    /// Gets the height.
    /// </summary>
    public int Height
    {
      get { return m_height; }
    } // Height

    #endregion

  } // class MapModel
} // namespace kchalupa.GameBoy.Tools.Models

