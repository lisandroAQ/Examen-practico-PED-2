using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public enum TipRecorridoArbol
    {
        post0r, in0r, pre0r,
    }

    public struct FormatoNodo
    {
        public Font fuente;
        public Brush relleno;
        public Brush rellenofuente;
        public Pen lapiz;
        public Brush encuentro;
    }

    public class Nodo_Arbol
    {
        public int info;
        public Nodo_Arbol Izquierdo;
        public Nodo_Arbol Derecho;
        public Nodo_Arbol Padre;
        public int altura;
        public int nivel;

        private const int Radio = 30;
        private const int DistanciaH = 50;
        private const int DistanciaV = 60;

        public int CoordenadaX;
        public int CoordenadaY;

        public Nodo_Arbol(int nueva_info, Nodo_Arbol izquierdo, Nodo_Arbol derecho, Nodo_Arbol padre)
        {
            info = nueva_info;
            Izquierdo = izquierdo;
            Derecho = derecho;
            Padre = padre;
            altura = 0;
        }

        private static int Alturas(Nodo_Arbol t)
        {
            return t == null ? -1 : t.altura;
        }

        // ── Inserción recursiva ──────────────────────────────────────────
        public Nodo_Arbol Insertar(int x, Nodo_Arbol t, int Level)
        {
            if (t == null)
            {
                t = new Nodo_Arbol(x, null, null, null);
                t.nivel = Level;
            }
            else if (x < t.info)
            {
                t.Izquierdo = Insertar(x, t.Izquierdo, Level + 1);
            }
            else if (x > t.info)
            {
                t.Derecho = Insertar(x, t.Derecho, Level + 1);
            }
            else
            {
                MessageBox.Show("ISBN ya registrado", "Error de Ingreso");
            }

            // Actualizar altura del nodo
            t.altura = 1 + Math.Max(Alturas(t.Izquierdo), Alturas(t.Derecho));
            return t;
        }

        // ── Búsqueda con camino y conteo de comparaciones ───────────────
        public Nodo_Arbol Buscar(int x, Nodo_Arbol t, ref int comparaciones)
        {
            if (t != null)
            {
                comparaciones++;
                if (x == t.info)
                    return t;
                else if (x < t.info)
                    return Buscar(x, t.Izquierdo, ref comparaciones);
                else
                    return Buscar(x, t.Derecho, ref comparaciones);
            }
            return null;
        }

        // ── Eliminación con sucesor InOrden para dos hijos ───────────────
        public Nodo_Arbol Eliminar(int x, Nodo_Arbol t)
        {
            if (t == null)
            {
                MessageBox.Show("ISBN no encontrado", "Error de eliminación");
                return null;
            }

            if (x < t.info)
            {
                t.Izquierdo = Eliminar(x, t.Izquierdo);
            }
            else if (x > t.info)
            {
                t.Derecho = Eliminar(x, t.Derecho);
            }
            else
            {
                // Caso 1: nodo hoja
                if (t.Izquierdo == null && t.Derecho == null)
                    return null;

                // Caso 2a: solo tiene hijo derecho
                if (t.Izquierdo == null)
                    return t.Derecho;

                // Caso 2b: solo tiene hijo izquierdo
                if (t.Derecho == null)
                    return t.Izquierdo;

                // Caso 3: dos hijos → buscar sucesor InOrden (mínimo del subárbol derecho)
                Nodo_Arbol sucesor = MinimoNodo(t.Derecho);
                t.info = sucesor.info;
                t.Derecho = Eliminar(sucesor.info, t.Derecho);
            }

            // Actualizar altura
            t.altura = 1 + Math.Max(Alturas(t.Izquierdo), Alturas(t.Derecho));
            return t;
        }

        // Retorna el nodo con el valor mínimo de un subárbol
        private Nodo_Arbol MinimoNodo(Nodo_Arbol t)
        {
            while (t.Izquierdo != null)
                t = t.Izquierdo;
            return t;
        }

        // ── Posicionamiento ──────────────────────────────────────────────
        public int MinX()
        {
            int min = CoordenadaX;
            if (Izquierdo != null) min = Math.Min(min, Izquierdo.MinX());
            if (Derecho != null) min = Math.Min(min, Derecho.MinX());
            return min;
        }

        public int MaxX()
        {
            int max = CoordenadaX;
            if (Izquierdo != null) max = Math.Max(max, Izquierdo.MaxX());
            if (Derecho != null) max = Math.Max(max, Derecho.MaxX());
            return max;
        }

        public void Desplazar(int setX)
        {
            CoordenadaX += setX;
            if (Izquierdo != null) Izquierdo.Desplazar(setX);
            if (Derecho != null) Derecho.Desplazar(setX);
        }

        public void PosicionNodo(ref int xmin, int ymin)
        {
            if (Izquierdo != null)
                Izquierdo.PosicionNodo(ref xmin, ymin + DistanciaV);

            if (Izquierdo == null)
            {
                CoordenadaX = xmin;
                xmin += Radio + DistanciaH;
            }
            else
            {
                CoordenadaX = Izquierdo.CoordenadaX + DistanciaH;
            }

            if (Derecho != null)
                Derecho.PosicionNodo(ref xmin, ymin + DistanciaV);

            if (Izquierdo != null && Derecho != null)
                CoordenadaX = (Izquierdo.CoordenadaX + Derecho.CoordenadaX) / 2;

            CoordenadaY = ymin;
        }

        // ── Dibujo ───────────────────────────────────────────────────────
        public void DibujarRamas(Graphics grafo, FormatoNodo formatonodo)
        {
            if (Izquierdo != null)
            {
                grafo.DrawLine(formatonodo.lapiz, CoordenadaX, CoordenadaY, Izquierdo.CoordenadaX, Izquierdo.CoordenadaY);
                Izquierdo.DibujarRamas(grafo, formatonodo);
            }
            if (Derecho != null)
            {
                grafo.DrawLine(formatonodo.lapiz, CoordenadaX, CoordenadaY, Derecho.CoordenadaX, Derecho.CoordenadaY);
                Derecho.DibujarRamas(grafo, formatonodo);
            }
        }

        public void DibujarNodo(Graphics grafo, FormatoNodo formatonodo)
        {
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            grafo.FillEllipse(formatonodo.encuentro, rect);
            grafo.FillEllipse(formatonodo.relleno, rect);
            grafo.DrawEllipse(formatonodo.lapiz, rect);

            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), formatonodo.fuente, formatonodo.rellenofuente, CoordenadaX, CoordenadaY, formato);

            if (Izquierdo != null) Izquierdo.DibujarNodo(grafo, formatonodo);
            if (Derecho != null) Derecho.DibujarNodo(grafo, formatonodo);
        }

        public void Colorear(Graphics grafo, FormatoNodo formatonodo)
        {
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            grafo.FillEllipse(formatonodo.relleno, rect);
            grafo.DrawEllipse(formatonodo.lapiz, rect);

            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), formatonodo.fuente, formatonodo.rellenofuente, CoordenadaX, CoordenadaY, formato);
        }

        // ── Estadísticas ─────────────────────────────────────────────────
        public int ContarNodos()
        {
            int total = 1;
            if (Izquierdo != null) total += Izquierdo.ContarNodos();
            if (Derecho != null) total += Derecho.ContarNodos();
            return total;
        }

        public int ObtenerAltura()
        {
            int altIzq = (Izquierdo != null) ? Izquierdo.ObtenerAltura() : 0;
            int altDer = (Derecho != null) ? Derecho.ObtenerAltura() : 0;
            return 1 + Math.Max(altIzq, altDer);
        }

        public void SumarNiveles(ref int suma, ref int cantidad)
        {
            suma += nivel;
            cantidad++;
            if (Izquierdo != null) Izquierdo.SumarNiveles(ref suma, ref cantidad);
            if (Derecho != null) Derecho.SumarNiveles(ref suma, ref cantidad);
        }

        // Reasignar niveles correctamente desde la raíz
        public void AsignarNiveles(int nivelActual)
        {
            nivel = nivelActual;
            if (Izquierdo != null) Izquierdo.AsignarNiveles(nivelActual + 1);
            if (Derecho != null) Derecho.AsignarNiveles(nivelActual + 1);
        }
    }
}