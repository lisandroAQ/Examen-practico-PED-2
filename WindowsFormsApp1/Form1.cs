using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
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

        // ── Actualizar estadísticas automáticamente ───────────────────────
        private void ActualizarEstadisticas()
        {
            lblNodos.Text = "Total nodos: " + mi_Arbol.TotalNodos();
            lblAltura.Text = "Altura: " + mi_Arbol.AlturaArbol();
            lblPromedio.Text = "Promedio nivel: " + mi_Arbol.PromedioNivel();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor");
                return;
            }

            int dato = int.Parse(txtDato.Text);
            if (dato <= 0 || dato >= 1000)
            {
                MessageBox.Show("Solo recibe valores del 1 al 999", "Error de ingreso");
                return;
            }

            mi_Arbol.Insertar(dato);
            txtDato.Clear();
            txtDato.Focus();
            cont++;
            panel1.Refresh();
            ActualizarEstadisticas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtEliminar.Text == "")
            {
                MessageBox.Show("Debe ingresar el valor a eliminar");
                return;
            }

            int dato = int.Parse(txtEliminar.Text); // Bug corregido: ahora lee txtEliminar
            if (dato <= 0 || dato >= 1000)
            {
                MessageBox.Show("Solo recibe valores del 1 al 999", "Error de ingreso");
                return;
            }

            mi_Arbol.Eliminar(dato);
            txtEliminar.Clear();
            txtEliminar.Focus();
            panel1.Refresh();
            ActualizarEstadisticas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar el valor a buscar");
                return;
            }

            int dato = int.Parse(txtBuscar.Text);
            if (dato <= 0 || dato >= 1000)
            {
                MessageBox.Show("Solo recibe valores del 1 al 999", "Error de ingreso");
                return;
            }

            FormatoNodo fEncontrado = formatonodo;
            fEncontrado.relleno = Brushes.ForestGreen;
            fEncontrado.rellenofuente = Brushes.White;

            mi_Arbol.BuscarenArbol(dato, panel1.CreateGraphics(), panel1.Size, fEncontrado);
            txtBuscar.Clear();
            txtBuscar.Focus();
            panel1.Refresh();
        }

        // ── Recorridos con RadioButton ────────────────────────────────────
        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            if (mi_Arbol.TotalNodos() == 0)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            if (rbInOrden.Checked)
                mi_Arbol.Recorrer(panel1.CreateGraphics(), formatonodo, TipRecorridoArbol.in0r, listRecorrido);
            else if (rbPreOrden.Checked)
                mi_Arbol.Recorrer(panel1.CreateGraphics(), formatonodo, TipRecorridoArbol.pre0r, listRecorrido);
            else if (rbPostOrden.Checked)
                mi_Arbol.Recorrer(panel1.CreateGraphics(), formatonodo, TipRecorridoArbol.post0r, listRecorrido);
            else
                MessageBox.Show("Selecciona un tipo de recorrido primero");

            panel1.Refresh();
        }
    }
}
