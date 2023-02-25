using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProject1
{
    public static class FinalValueOfRepetitionsBoxController
    {
        static FinalValueOfRepetitionsBoxController()
        {
        }

        public static void UpdateValue(Main main)
        {
            if(!int.TryParse(main.StartOnBox.Text, out int startOnValue))
                value = 0;

            if (!int.TryParse(main.IncrementBox.Text, out int incrementValue))
                value = 0;

            if (!int.TryParse(main.RepeatAmountBox.Text, out int repeatValue))
                value = 0;

            value = startOnValue + (incrementValue * repeatValue);
            main.FinalValueOfRepetitionsBox.Text = value.ToString();
        }

        private static int value { get; set; }
    }
}
