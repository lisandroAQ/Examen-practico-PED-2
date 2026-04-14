using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace WindowsFormsApp1
{
    public class Arbol_Binario
    {
        public Nodo_Arbol Raiz;

        public Arbol_Binario(Nodo_Arbol nueva_raiz) 
        {
            Raiz = nueva_raiz;
        }

        //Funcion para agregar un nuevo nodo (valor) al arbol binario
        public void Insertar(int x) 
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
                Raiz.nivel = 0;
            }
            else
                Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel);
        }

        //Funcion para eliminar un nodo (valor) de arbol binario
        public void Eliminar(int x) 
        {
            if (Raiz == null)
                Raiz = new Nodo_Arbol(x, null, null, null);
            else
                Raiz.Eliminar(x, ref Raiz);
        }

        public void Buscar(int x) 
        {
            if(Raiz != null) 
            {
                Raiz.Buscar(x, Raiz);
            }
        }

        public void BuscarenArbol(int x, Graphics grafo, Size areadibujo, FormatoNodo formatonodo) 
        {
            Nodo_Arbol nodo;
            if(Raiz != null) 
            {
                nodo = Raiz.Buscar(x, Raiz);
                if (nodo != null)//Encontro al nodo
                {
                    nodo.Colorear(grafo, formatonodo);
                    MessageBox.Show("Nodo " + nodo.info.ToString() + " fue encontrado", "Busqueda de nodo en el arbol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("No se encontrol al nodo " + x.ToString() + " en el arbol", "Busqueda de nodo en arbol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Funcion para dibujar arbol
        public void DibujarArbol(Graphics grafo, Size areadibujo, FormatoNodo formatonodo) 
        {
            int x, y;//posicion del nodo raiz del arbol a graficar

            if (Raiz == null)
                return;//Si el arbol esta vacio no se dibuja nada

            x = 10;
            y = 40;

            //calcular posiciones de nodos
            Raiz.PosicionNodo(ref x, y);

            //Calcular ancho del arbol
            int min = Raiz.MinX();
            int max = Raiz.MaxX();
            int anchoArbol = max - min;

            //centro del panel
            int centroPanel = areadibujo.Width / 2;

            //centrol del arbol
            int centroArbol = min + anchoArbol / 2;

            //desplazamiento necesario
            int offset = centroPanel - centroArbol;

            //mover arbol completo
            Raiz.Desplazar(offset);

            //Dibujar ramas
            Raiz.DibujarRamas(grafo, formatonodo);

            //dibujar nodos
            Raiz.DibujarNodo(grafo, formatonodo);
        }

        //Funcion para colorear los nodos
        public void Colorear(Graphics grafo, FormatoNodo formatonodo, Nodo_Arbol Raiz, TipRecorridoArbol tiporecorrido) 
        {
            FormatoNodo formatonodo2 = formatonodo;
            formatonodo2.relleno = Brushes.Red;
            Brush entorno = Brushes.Red;

            switch (tiporecorrido) 
            {
                case TipRecorridoArbol.in0r:
                    if(Raiz != null) 
                    {
                        Colorear(grafo, formatonodo, Raiz.Izquierdo, tiporecorrido);
                        Raiz.Colorear(grafo, formatonodo2);
                        Thread.Sleep(1000);
                        Raiz.Colorear(grafo, formatonodo);
                        Colorear(grafo, formatonodo, Raiz.Derecho, tiporecorrido);
                    }
                    break;
                case TipRecorridoArbol.pre0r:
                    if(Raiz != null) 
                    {
                        Raiz.Colorear(grafo, formatonodo2);
                        Thread.Sleep(1000);
                        Raiz.Colorear(grafo, formatonodo);
                        Colorear(grafo, formatonodo, Raiz.Izquierdo, tiporecorrido);
                        Colorear(grafo, formatonodo, Raiz.Derecho, tiporecorrido);
                    }
                    break;
                case TipRecorridoArbol.post0r:
                    if (Raiz != null)
                    {
                        Colorear(grafo, formatonodo, Raiz.Izquierdo, tiporecorrido);
                        Colorear(grafo, formatonodo, Raiz.Derecho, tiporecorrido);
                        Raiz.Colorear(grafo, formatonodo2);
                        Thread.Sleep(1000);
                        Raiz.Colorear(grafo,formatonodo);
                    }
                    break;
            }
        }
    }
}
