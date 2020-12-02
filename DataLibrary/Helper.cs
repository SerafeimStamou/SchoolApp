using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLibrary
{
    public static class Helper
    {
      public static string InputFormat(string input) => input.ToUpper().First() + input.Substring(1).ToLower();

      public static void LoadForm(Form nextForm,Form previousForm)
      {
        nextForm.Show();
        previousForm.Hide();
      }
    }
}
