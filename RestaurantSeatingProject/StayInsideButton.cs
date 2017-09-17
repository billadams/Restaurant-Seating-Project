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

  // This StayInsideButton class is used as such for bars and is the base class of
  // the RoundButton class used by tables and barseats

  public class StayInsideButton : Button
  {
    private static Size szPanel;

    // This SetPanelSize() function should be called form the frmManageSeatingLayout constructor after the
    // call to InitializeComponent(), passing SetPanelSize() the size of the seating panel.
    //
    public static void SetPanelSize(Size szSeatingPanel)
    {
      szPanel = szSeatingPanel;
    }

    // This CheckSetLocation() function should be called from the button_MouseMove() event in the FrmManageSeatingLayout class
    // to set the the position of the control being dragged to the new position calculated from the mouse position in the drag
    // event and have this function correct any position it is passed that would be outside of the panel.
    //
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
