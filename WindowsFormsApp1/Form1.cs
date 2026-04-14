using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int Dato = 0;
        int cont = 0;
        Arbol_Binario mi_Arbol;

        FormatoNodo formatonodo;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            mi_Arbol = new Arbol_Binario(null);

            formatonodo.fuente = this.Font;
            formatonodo.relleno = Brushes.Blue;
            formatonodo.rellenofuente = Brushes.White;
            formatonodo.lapiz = Pens.Black;
            formatonodo.encuentro = Brushes.White;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;

            mi_Arbol.DibujarArbol(g, panel1.Size, formatonodo);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text == "")
                MessageBox.Show("Debe ingresar un valor");
            else 
            {
                Dato = int.Parse(txtDato.Text);
                if (Dato <= 0 || Dato >= 1000)
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 999", "error de ingreso");
                else 
                {
                    mi_Arbol.Insertar(Dato);
                    txtDato.Clear();
                    txtDato.Focus();
                    cont++;

                    panel1.Refresh();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtEliminar.Text == "")
                MessageBox.Show("Debe ingresar el valor a eliminar");
            else 
            {
                mi_Arbol.Eliminar(Dato);
                txtEliminar.Clear();
                txtEliminar.Focus();
                cont--;


                panel1.Refresh();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
                MessageBox.Show("Debe ingresar el valor a buscar");
            else 
            {
                Dato = Convert.ToInt32(txtBuscar.Text);
                if (Dato <= 0 || Dato >= 1000)
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 999", "error de ingreso");
                else 
                {
                    FormatoNodo formatonodoencontrado;
                    formatonodoencontrado = formatonodo;
                    formatonodoencontrado.relleno = Brushes.ForestGreen;
                    mi_Arbol.BuscarenArbol(Dato,panel1.CreateGraphics(),panel1.Size,formatonodoencontrado);
                    txtBuscar.Clear();
                    txtBuscar.Focus();


                    panel1.Refresh();
                }
            }
        }
    }
}
