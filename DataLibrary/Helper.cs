using System.Linq;
using System.Windows.Forms;


namespace DataLibrary
{
    public static class Helper
    {
        public static string InputFormat(string input)
        {
            if (!string.IsNullOrEmpty(input))
                return input.ToUpper().First() + input.Substring(1).ToLower();
            else
                return input;
        }

        public static void LoadForm(Form nextForm,Form previousForm)
        {
            nextForm.Show();

            if (Application.OpenForms.Count > 2)
             previousForm.Close();
            else
             previousForm.Hide();
        }
    }
}
