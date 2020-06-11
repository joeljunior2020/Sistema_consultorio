using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_consultorio
{
    class Limpiar
    {
        public void BorrarCampos (Control control,GroupBox gb)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
                else if (txt is CheckBox)
                {
                    ((CheckBox)txt).Checked = false;
                }

            }

            /////////////////////////
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
                else if (combo is ComboBox)
                {
                    ((ComboBox)combo).SelectedIndex = 0;
                }

                else if (combo is CheckBox)
                {
                    ((CheckBox)combo).Checked = false;
                }

            }

        }

    }
}
