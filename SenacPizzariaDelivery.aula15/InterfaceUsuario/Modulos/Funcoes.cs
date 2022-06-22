using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUsuario.Modulos
{
    public static class Funcoes
    {
        public static long? RemoverMascaraCampoNumerico(MaskedTextBox maskedTextBox)
        {
            maskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var str = RemoverEspacos(maskedTextBox.Text);
            maskedTextBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            if (str.Equals(string.Empty))
                return null;
            else
                return Convert.ToInt64(str);
        }

        public static string RemoverEspacos(string str)
        {
            return str.Trim().Replace(" ", "");
        }

        public static void ListViewCor(ListView lvl)
        {
            foreach(ListViewItem item in lvl.Items)
            {
                if((item.Index%2) == 0)
                {
                    item.BackColor = Color.White;
                }
                else
                {
                    item.BackColor = Color.LightBlue;
                }
            }
        }
    }
}
