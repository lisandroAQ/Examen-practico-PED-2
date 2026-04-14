using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum TipRecorridoArbol 
    {
        post0r,
        in0r,
        pre0r,
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
        // Campos públicos
        public int info;        // dato a almacenar en el nodo
        public Nodo_Arbol Izquierdo;   // hijo izquierdo
        public Nodo_Arbol Derecho;     // hijo derecho
        public Nodo_Arbol Padre;       // padre del nodo
        public int altura;
        public int nivel;

        // Constantes de dibujo
        private const int Radio = 30;  // tamaño del círculo nodo
        private const int DistanciaH = 50;  // distancia horizontal
        private const int DistanciaV = 40;  // distancia vertical
        private int CoordenadaX;
        private int CoordenadaY;
        private Arbol_Binario arbol;

        // Constructor con parámetros
        public Nodo_Arbol(int nueva_info, Nodo_Arbol izquierdo, Nodo_Arbol derecho, Nodo_Arbol padre)
        {
            info = nueva_info;
            Izquierdo = izquierdo;
            Derecho = derecho;
            Padre = padre;
            altura = 0;
        }

        // Verificar altura del árbol
        private static int Alturas(Nodo_Arbol t)
        {
            return t == null ? -1 : t.altura;
        }

        // Función para insertar un nodo en el árbol
        public Nodo_Arbol Insertar(int x, Nodo_Arbol t, int Level)
        {
            if (t == null)
            {
                t = new Nodo_Arbol(x, null, null, null);
                t.nivel = Level;   // ← asigna nivel al nuevo nodo
            }
            else if (x < t.info) // valor menor → subárbol izquierdo
            {
                Level++;
                t.Izquierdo = Insertar(x, t.Izquierdo, Level);
            }
            else if (x > t.info) // valor mayor → subárbol derecho
            {
                Level++;
                t.Derecho = Insertar(x, t.Derecho, Level);
            }
            else
                MessageBox.Show("Dato ya existe en el Arbol", "Error de Ingreso");

            return t;
        }

        // Función buscar un nodo — retorna el nodo si existe, null si no
        public Nodo_Arbol Buscar(int x, Nodo_Arbol t)
        {
            if (t != null)
            {
                if (x == t.info)        // encontró al nodo, lo retorna
                    return t;
                else if (x < t.info)   // busca en el subárbol izquierdo
                    return Buscar(x, t.Izquierdo);
                else if (x > t.info)   // búsqueda en el subárbol derecho
                    return Buscar(x, t.Derecho);
            }
            return null; // nodo no existe en esta hoja del arbol
        }

        public void Eliminar(int x, ref Nodo_Arbol t) 
        {
            if (t != null) //Si la raiz es distinta de null
            {
                if (x < t.info) //Si el valor a eliminar es menor que la raiz
                    Eliminar(x, ref t.Izquierdo);
                else
                {
                    if (x > t.info) //si el valor a eliminar es mayor que la raiz
                        Eliminar(x, ref t.Derecho);
                    else
                    {
                        Nodo_Arbol NodoEliminar = t; //se ubica el nodo a eliminar
                                                     // se verifica si tiene hijo derecho
                        if (NodoEliminar.Derecho == null)
                            t = NodoEliminar.Izquierdo;
                        else
                        {
                            //se verifica si tiene hojo izquierda
                            if (NodoEliminar.Izquierdo == null)
                                t = NodoEliminar.Derecho;
                            else
                            {
                                if (Alturas(t.Izquierdo) - Alturas(t.Derecho) > 0)
                                //Para verificar que hijo pasa a ser raiz del subarbol
                                {
                                    Nodo_Arbol AuxiliarNodo = null;
                                    Nodo_Arbol Auxiliar = t.Izquierdo;
                                    bool bandera = false;

                                    while (Auxiliar.Derecho != null)
                                    {
                                        AuxiliarNodo = Auxiliar;
                                        Auxiliar = Auxiliar.Derecho;
                                        bandera = true;
                                    }
                                    //Se crea un nodo temporal
                                    t.info = Auxiliar.info; NodoEliminar = Auxiliar;

                                    if (bandera == true)
                                        AuxiliarNodo.Derecho = AuxiliarNodo.Izquierdo;
                                    else
                                        t.Izquierdo = Auxiliar.Izquierdo;
                                }
                                else
                                {
                                    if (Alturas(t.Derecho) - Alturas(t.Izquierdo) > 0)
                                    {
                                        Nodo_Arbol AuxiliarNodo = null;
                                        Nodo_Arbol Auxiliar = t.Derecho;
                                        bool bandera = false;

                                        while (Auxiliar.Izquierdo != null)
                                        {
                                            AuxiliarNodo = Auxiliar;
                                            Auxiliar = Auxiliar.Izquierdo;
                                            bandera = true;
                                        }

                                        t.info = Auxiliar.info;
                                        NodoEliminar = Auxiliar;

                                        if (bandera == true)
                                        {
                                            AuxiliarNodo.Izquierdo = Auxiliar.Derecho;
                                        }
                                        else
                                        {
                                            t.Derecho = Auxiliar.Derecho;
                                        }
                                    }
                                    else
                                        if (Alturas(t.Derecho) - Alturas(t.Izquierdo) == 0)
                                        {
                                            Nodo_Arbol AuxiliarNodo = null;
                                            Nodo_Arbol Auxiliar = t.Izquierdo;
                                            bool bandera = false;

                                            while (Auxiliar.Derecho != null)
                                            {
                                                AuxiliarNodo = Auxiliar;
                                                Auxiliar = Auxiliar.Derecho;
                                                bandera = true;
                                            }

                                            t.info = Auxiliar.info;
                                            NodoEliminar = Auxiliar;

                                            if (bandera == true)
                                                AuxiliarNodo.Derecho = Auxiliar.Izquierdo;
                                            else
                                                t.Izquierdo = Auxiliar.Izquierdo;
                                        }
                                }
                            }
                        }
                    }
                }

            }
            else
                MessageBox.Show("Nodo NO existente en el Arbol", "Error de eliminacion");
        }

        public int MinX() 
        {
            int min = CoordenadaX;

            if (Izquierdo != null)
                min = Math.Min(min, Izquierdo.MinX());

            if (Derecho != null)
                min = Math.Min(min, Derecho.MinX());

            return min;
        }

        public int MaxX() 
        {
            int max = CoordenadaX;

            if (Izquierdo != null)
                max = Math.Max(max, Izquierdo.MaxX());

            if (Derecho != null)
                max = Math.Max(max, Derecho.MaxX());

            return max;
        }

        public void Desplazar(int setX) 
        {
            if(Izquierdo != null)
                Izquierdo.Desplazar(setX);

            if(Derecho != null)
                Derecho.Desplazar(setX);
        }

        public void PosicionNodo(ref int xmin, int ymin) 
        {
            //Posicionar subarbol izquierdo
            if (Izquierdo != null)
                Izquierdo.PosicionNodo(ref xmin, ymin + DistanciaV);

            // si no hay hijo izquierdo, usar posicion actual
            if (Izquierdo == null)
            {
                CoordenadaX = xmin;
                xmin += Radio + DistanciaH;
            }
            else 
            {
                CoordenadaX = Izquierdo.CoordenadaX + DistanciaH;
            }

            //Posicionar subarbol derecho
            if (Derecho != null)
                Derecho.PosicionNodo(ref xmin, ymin + DistanciaV);

            //si tiene ambos hijos, centar nodo entre ellos
            if (Izquierdo != null && Derecho != null)
                CoordenadaX = (Izquierdo.CoordenadaX + Derecho.CoordenadaX) / 2;

            CoordenadaY = ymin;
        }

        //funcion Para dibujar las ramas de los nodos izquierdo y derecho
        public void DibujarRamas(Graphics grafo, FormatoNodo formatonodo) 
        {
            if(Izquierdo != null)//Dibujara rama izquierda
            {
                grafo.DrawLine(formatonodo.lapiz, CoordenadaX, CoordenadaY, Izquierdo.CoordenadaX, Izquierdo.CoordenadaY);
                Izquierdo.DibujarRamas(grafo, formatonodo);
            }
            if (Derecho != null)//Dibujara rama derecha
            {
                grafo.DrawLine(formatonodo.lapiz, CoordenadaX, CoordenadaY, Derecho.CoordenadaX, Derecho.CoordenadaY);
                Derecho.DibujarRamas(grafo, formatonodo);
            }
        }

        //Funcion para dibujar el nodo en la posicion especificada
        public void DibujarNodo(Graphics grafo, FormatoNodo formatonodo) 
        {
            //Dibuja el contorno del nodo
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            grafo.FillEllipse(formatonodo.encuentro, rect);
            grafo.FillEllipse(formatonodo.relleno, rect);
            grafo.DrawEllipse(formatonodo.lapiz, rect);

            //Para dibujar el nombre del nodo, es decir el contenido
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), formatonodo.fuente, formatonodo.rellenofuente, CoordenadaX, CoordenadaY, formato);

            //Dibuja los nodos hijos derecho e izquierdo 
            if (Izquierdo != null)
                Izquierdo.DibujarNodo(grafo, formatonodo);

            if (Derecho != null)
                Derecho.DibujarNodo(grafo, formatonodo);
        }

        public void Colorear(Graphics grafo, FormatoNodo formatonodo) 
        {
            //Dibuja el contorno del nodo 
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            grafo.FillEllipse(formatonodo.relleno, rect);
            grafo.DrawEllipse(formatonodo.lapiz, rect);
            //Dibuja el nombre
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), formatonodo.fuente, formatonodo.rellenofuente, CoordenadaX, CoordenadaY, formato);

        }
    }
}
