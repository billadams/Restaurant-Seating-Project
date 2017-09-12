using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSeatingProject
{
    public class DisplayData
    {
        //display data class is just used so I can strip and format data in/from the listbox
        public string Value { get; set; }
        public string Text { get; set; }

        public DisplayData()
        {
          this.Value = "";
          this.Text = "";
        }

        public DisplayData(string value, string text)
        {
          this.Value = value;
          this.Text = text;
        }
    }
}
