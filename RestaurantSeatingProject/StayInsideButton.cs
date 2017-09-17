using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RestaurantSeatingProject
{
  public class StayInsideButton : Button
  {
    private static Size szPanel;


    public static void SetPanelSize(Size szSeatingPanel)
    {
      szPanel = szSeatingPanel;
    }

    public void CheckSetLocation(int x, int y)
    {
      if (x < 1)
        x = 1;

      if (x + this.Width > szPanel.Width - 2)
        x = szPanel.Width - this.Width - 2;

      if (y < 1)
        y = 1;

      if (y + this.Height > szPanel.Height - 2)
        y = szPanel.Height - this.Height - 2;

      this.Left = x;
      this.Top = y;
    }
  }
}
