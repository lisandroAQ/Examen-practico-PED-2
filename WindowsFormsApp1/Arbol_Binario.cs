using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class Arbol_Binario
    {
        public Nodo_Arbol Raiz;

        public Arbol_Binario(Nodo_Arbol nueva_raiz)
        {
            Raiz = nueva_raiz;
        }

        // ── Insertar ─────────────────────────────────────────────────────
        public void Insertar(int x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
                Raiz.nivel = 0;
            }
            else
            {
                Raiz = Raiz.Insertar(x, Raiz, 1);
            }

            if (Raiz != null) Raiz.AsignarNiveles(1);
        }


        // ── Eliminar ─────────────────────────────────────────────────────
        public void Eliminar(int x)
        {
            if (Raiz == null)
            {
                MessageBox.Show("El árbol está vacío", "Error");
                return;
            }
            bool existe = ExisteISBN(x);
            if (!existe)
            {
                MessageBox.Show("ISBN no encontrado", "Error de eliminación");
                return;
            }
            Raiz = Raiz.Eliminar(x, Raiz);
            // Reasignar niveles después de eliminar
            if (Raiz != null) Raiz.AsignarNiveles(0);
        }

        private bool ExisteISBN(int x)
        {
            int comp = 0;
            return Raiz != null && Raiz.Buscar(x, Raiz, ref comp) != null;
        }

        // ── Buscar con camino ─────────────────────────────────────────────
        public void BuscarenArbol(int x, Graphics grafo, Size areadibujo, FormatoNodo formatonodo)
        {
            if (Raiz == null) return;

            int comparaciones = 0;
            Nodo_Arbol nodo = Raiz.Buscar(x, Raiz, ref comparaciones);

            if (nodo != null)
            {
                // Colorear el camino hasta el nodo encontrado
                ColorearCamino(x, Raiz, grafo, formatonodo);
                nodo.Colorear(grafo, formatonodo);
                MessageBox.Show(
                    "Nodo " + nodo.info + " encontrado.\nComparaciones realizadas: " + comparaciones,
                    "Búsqueda exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "ISBN " + x + " no encontrado.\nComparaciones realizadas: " + comparaciones,
                    "ISBN no encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Colorea cada nodo visitado en el camino de búsqueda
        private void ColorearCamino(int x, Nodo_Arbol t, Graphics grafo, FormatoNodo formatonodo)
        {
            if (t == null) return;

            FormatoNodo fVisitado = formatonodo;
            fVisitado.relleno = Brushes.Orange;
            t.Colorear(grafo, fVisitado);
            Thread.Sleep(400);

            if (x < t.info)
                ColorearCamino(x, t.Izquierdo, grafo, formatonodo);
            else if (x > t.info)
                ColorearCamino(x, t.Derecho, grafo, formatonodo);
        }

        // ── Dibujar árbol ─────────────────────────────────────────────────
        public void DibujarArbol(Graphics grafo, Size areadibujo, FormatoNodo formatonodo)
        {
            if (Raiz == null) return;

            int x = 10, y = 40;
            Raiz.PosicionNodo(ref x, y);

            int min = Raiz.MinX();
            int max = Raiz.MaxX();
            int anchoArbol = max - min;
            int centroPanel = areadibujo.Width / 2;
            int centroArbol = min + anchoArbol / 2;
            int offset = centroPanel - centroArbol;

            Raiz.Desplazar(offset);
            Raiz.DibujarRamas(grafo, formatonodo);
            Raiz.DibujarNodo(grafo, formatonodo);
        }

        // ── Recorridos con ListBox ────────────────────────────────────────
        public void Recorrer(Graphics grafo, FormatoNodo formatonodo, TipRecorridoArbol tipo, ListBox listbox)
        {
            listbox.Items.Clear();
            FormatoNodo fVisitado = formatonodo;
            fVisitado.relleno = Brushes.Red;

            Colorear(grafo, formatonodo, Raiz, tipo, listbox, fVisitado);
        }

        private void Colorear(Graphics grafo, FormatoNodo formatonodo, Nodo_Arbol raiz,
            TipRecorridoArbol tipo, ListBox listbox, FormatoNodo fVisitado)
        {
            if (raiz == null) return;

            switch (tipo)
            {
                case TipRecorridoArbol.in0r:
                    Colorear(grafo, formatonodo, raiz.Izquierdo, tipo, listbox, fVisitado);
                    VisitarNodo(grafo, formatonodo, raiz, listbox, fVisitado);
                    Colorear(grafo, formatonodo, raiz.Derecho, tipo, listbox, fVisitado);
                    break;

                case TipRecorridoArbol.pre0r:
                    VisitarNodo(grafo, formatonodo, raiz, listbox, fVisitado);
                    Colorear(grafo, formatonodo, raiz.Izquierdo, tipo, listbox, fVisitado);
                    Colorear(grafo, formatonodo, raiz.Derecho, tipo, listbox, fVisitado);
                    break;

                case TipRecorridoArbol.post0r:
                    Colorear(grafo, formatonodo, raiz.Izquierdo, tipo, listbox, fVisitado);
                    Colorear(grafo, formatonodo, raiz.Derecho, tipo, listbox, fVisitado);
                    VisitarNodo(grafo, formatonodo, raiz, listbox, fVisitado);
                    break;
            }
        }

        private void VisitarNodo(Graphics grafo, FormatoNodo formatonodo, Nodo_Arbol nodo,
            ListBox listbox, FormatoNodo fVisitado)
        {
            nodo.Colorear(grafo, fVisitado);
            listbox.Items.Add(nodo.info.ToString());
            listbox.TopIndex = listbox.Items.Count - 1;
            Thread.Sleep(700);
            nodo.Colorear(grafo, formatonodo);
        }

        // ── Estadísticas ──────────────────────────────────────────────────
        public int TotalNodos()
        {
            return Raiz == null ? 0 : Raiz.ContarNodos();
        }

        public int AlturaArbol()
        {
            return Raiz == null ? 0 : Raiz.ObtenerAltura();
        }

        public double PromedioNivel()
        {
            if (Raiz == null) return 0;
            int suma = 0, cantidad = 0;
            Raiz.SumarNiveles(ref suma, ref cantidad);
            return cantidad == 0 ? 0 : Math.Round((double)suma / cantidad, 2);
        }
    }
}