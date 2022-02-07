using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace kchalupa.GameBoy.Tools.Models
{
  /// <summary>
  /// The tile model.
  /// </summary>
  public class TileModel
  {

    #region AvailableColors class

    /// <summary>
    /// The available colors.
    /// </summary>
    public static class AvailableColors
    {

      #region fields

      /// <summary>
      /// Dark green color.
      /// </summary>
      private static Color m_darkGreen = Color.FromArgb(0, 64, 0);

      /// <summary>
      /// Middle green color.
      /// </summary>
      private static Color m_middleGreen = Color.FromArgb(0, 128, 0);

      /// <summary>
      /// Light green color.
      /// </summary>
      private static Color m_lightGreen = Color.FromArgb(0, 196, 0);

      /// <summary>
      /// White color.
      /// </summary>
      private static Color m_white = Color.FromArgb(255, 255, 255);

      #endregion

      #region properties

      /// <summary>
      /// Gets the dark green color.
      /// </summary>
      public static Color DarkGreen
      {
        get { return m_darkGreen; }
      } // DarkGreen


      /// <summary>
      /// Gets the middle green color.
      /// </summary>
      public static Color MiddleGreen
      {
        get { return m_middleGreen; }
      } // MiddleGreen


      /// <summary>
      /// Gets the light green color.
      /// </summary>
      public static Color LightGreen
      {
        get { return m_lightGreen; }
      } // LightGreen


      /// <summary>
      /// Gets the white color.
      /// </summary>
      public static Color White
      {
        get { return m_white; }
      } // White

      #endregion

    } // class AvailableColors

    #endregion

    #region fields

    /// <summary>
    /// The name of the tile.
    /// </summary>
    private String m_name = String.Empty;

    /// <summary>
    /// The array of colors that make up the tile.
    /// </summary>
    private Color[] m_pixels = new Color[64];

    #endregion

    #region construction

    /// <summary>
    /// Constructor.
    /// </summary>
    public TileModel()
    {
      for(int y=0;y<8;++y)
      {
        for(int x=0;x<8;++x)
        {
          m_pixels[y * 8 + x] = AvailableColors.White;
        }
      }
    } // TileModel()

    #endregion

    #region properties

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public String Name
    {
      get { return m_name; }
      set { m_name = value; }
    } // Name


    /// <summary>
    /// Gets or sets the pixel values.
    /// </summary>
    public Color[] Pixels
    {
      get { return m_pixels; }
      set { m_pixels = value; }
    } // Pixels

    #endregion

    #region methods

    /// <summary>
    /// Flips the pixels horizontally. The pixels are updated to the new result.
    /// </summary>
    public void FlipHorizontal()
    {
      Color[] temp = (Color[])Pixels.Clone();

      for(int y=0;y<8;++y)
      {
        for(int x=0;x<8;++x)
        {
          Pixels[y * 8 + x] = temp[y * 8 + (7 - x)];
        }
      }
    } // FlipHorizontal()


    /// <summary>
    /// Flips the pixels vertically. The pixels are updated to the new result.
    /// </summary>
    public void FlipVertical()
    {
      Color[] temp = (Color[])Pixels.Clone();

      for (int y=0;y<8;++y)
      {
        for(int x=0;x<8;++x)
        {
          Pixels[y * 8 + x] = temp[(7 - y) * 8 + x];
        }
      }
    } // FlipVertical()


    /// <summary>
    /// Rotate clockwise. The pixels are updated to the new result.
    /// </summary>
    public void RotateClockwise()
    {
      Color[] temp = (Color[])Pixels.Clone();

      for(int y=0;y<8;++y)
      {
        for(int x=0;x<8;++x)
        {
          Pixels[y * 8 + x] = temp[(7 - x) * 8 + y];
        }
      }
    } // RotateClockwise()


    /// <summary>
    /// Rotate counterclockwise. The pixels are updated to the new result.
    /// </summary>
    public void RotateCounterclockwise()
    {
      // Just rotate the thing three times.
      RotateClockwise();
      RotateClockwise();
      RotateClockwise();
    } // RotateCounterclockwise()


    /// <summary>
    /// Randomize. The pixels are updated to the new result.
    /// </summary>
    public void Randomize()
    {
      Random rand = new Random();

      for(int y=0;y<8;++y)
      {
        for(int x=0;x<8;++x)
        {
          int value = rand.Next(4);
          Color color = AvailableColors.White;

          switch(value)
          {
            case 3:
              color = AvailableColors.DarkGreen;
              break;

            case 2:
              color = AvailableColors.MiddleGreen;
              break;

            case 1:
              color = AvailableColors.LightGreen;
              break;

            case 0:
              color = AvailableColors.White;
              break;
          }

          m_pixels[y * 8 + x] = color;
        }
      }
    } // Randomize()


    /// <summary>
    /// Returns an xml representation.
    /// </summary>
    /// <returns>The complete xml documen</returns>
    public virtual XmlElement ToXml(XmlDocument doc)
    {
      XmlElement tile = doc.CreateElement("tile");
      tile.SetAttribute("name", m_name);

      XmlElement pixels = doc.CreateElement("pixels");
      tile.AppendChild(pixels);
//      elem.SetAttribute("Pixels", GetPixelString());
      for(int i=0;i<64;++i)
      {
        int value = 0;
        Color color = Pixels[i];
        if(color == AvailableColors.DarkGreen)
        {
          value = 3;
        }
        else if(color == AvailableColors.MiddleGreen)
        {
          value = 2;
        }
        else if(color == AvailableColors.LightGreen)
        {
          value = 1;
        }
        else if(color == AvailableColors.White)
        {
          value = 0;
        }
        else
        {
          throw new ArgumentOutOfRangeException("ToXml An unknown color was used. [Name: \"" + color.Name + "\"]");
        }

        XmlElement pixel = doc.CreateElement("pixel");
        pixel.InnerText = value.ToString();
        pixels.AppendChild(pixel);
      }

      return tile;
    } // ToXml()

    public static TileModel FromXml(XmlNode node)
    {
      TileModel model = new TileModel();
      model.Name = node.Attributes["name"].Value;

      XmlNodeList nodes = node.SelectSingleNode("pixels").SelectNodes("pixel");
      for(int i=0;i<64;++i)
      {
        int value = int.Parse(nodes[i].InnerText);
        switch(value)
        {
          case 3:
            model.Pixels[i] = AvailableColors.DarkGreen;
            break;

          case 2:
            model.Pixels[i] = AvailableColors.MiddleGreen;
            break;

          case 1:
            model.Pixels[i] = AvailableColors.LightGreen;
            break;

          case 0:
            model.Pixels[i] = AvailableColors.White;
            break;

          default:
            throw new ArgumentOutOfRangeException("FromXml Invalid value for Pixel Value. [Value: \""
              + value + "\"]");
        }
      }

      return model;
    } // FromXml( node )


    /// <summary>
    /// Gets the objects string representation.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return Name;
    } // ToString()

    #endregion

  } // class TileModel
} // namespace kchalupa.GameBoy.Tools.Models
