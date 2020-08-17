using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Diagnostics;

namespace Leer_XML_de_Romanas
{
    public partial class FrmPrincipal : Form
    {
        #region Campos
        private string ruta;
        private string soloRuta;
        string rutaCSV;
        private string archivo;
        ListViewItem lista;
        private int n = 0;
        string[] listaNodo = new string[100];
        private char delimitador;
        private char finLinea;
        private int anchoColumna;
        private int cantidadFilas;
        private int cantidadColumnas;
        private int contadorLineas;
        private int columnaActual;
        private int filaActual;
        private int cantidadItemsPorLinea;
        private int contadorItemDeListView;
        private string[] ItemsPorLinea;
        private int ultimoNodo;
        StringBuilder sb = new StringBuilder();
        #endregion Campos


        #region Constructor
        public FrmPrincipal()
        {
            InitializeComponent();
            delimitador = ';';
            finLinea = '+';
            ultimoNodo = 0;
            cantidadColumnas = 0;
            columnaActual = 0;
            filaActual = 0;
            anchoColumna = 100;
        }
        #endregion Constructor


        #region Eventos
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Lvw1.View = View.Details;
        }

        private void BtnLimpiarVentana_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
        private void BtnAbrirXML_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            AbrirArchivoXML();
            LeerArchivoLineaPorLineaySeparaItems();
        }
        private void BtnAbrirArchivoCSV_Click(object sender, EventArgs e)
        {
            AbrirArchivoCSV(rutaCSV);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
            frmAcercaDe.ShowDialog();
        }
        #endregion Eventos



        public void AbrirArchivoXML()
        {
            OfdArchivoXML.Filter = "XML files (*.xml)|*.xml";

            if (OfdArchivoXML.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la ruta y el nombre del archivo 
                ruta = OfdArchivoXML.FileName;
                soloRuta = ruta.Substring(0, ruta.LastIndexOf('\\'));
                archivo = OfdArchivoXML.SafeFileNames[0];
                TxtRutaArchivoXML.Text = ruta;

                MuestraArchivoLeidoEnTextBox();
                MuestraArchivoLeidoEnListBox();
                CreaArchivoCSV();
            }
        }

        public void MuestraArchivoLeidoEnTextBox()
        {
            // Lee el archivo XML y lo muestra en un TextBox
            using (StreamReader sr = new StreamReader(ruta, Encoding.Default))
            {
                TxtArchivoXMLLeido.Text = sr.ReadToEnd();
            }
        }

        public void MuestraArchivoLeidoEnListBox()
        {
            // Crea encabezado en archivo CSV
            string[] encabezadoCSV = { "Fecha", "Hora", "IdProducto","NombreProducto", "Categoria", "IdBodega",
                                            "NombreBodega", "Temperatura", "Peso", "Usuario"};
            for (int i = 0; i < 9; i++)
            {
                sb.Append(encabezadoCSV[i] + ";");
            }
            sb.Append(encabezadoCSV[9]);
            sb.Append(Environment.NewLine);


            // Lee el archivo XML y lo muestra en un ListBox
            XmlTextReader reader = new XmlTextReader(ruta);
            try
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        listaNodo[n] = "</" + reader.Name + ">";

                        string nombreNodo = listaNodo[n];

                        if (listaNodo[n] == "</usuario>")
                        {
                            // llegó hasta el ultimo nodo de esa fila y hace un cambio de linea
                            sb.Append(Environment.NewLine);

                            filaActual++;

                            // iniciliza el contador de columna en cero que es la primera columna
                            columnaActual = 0;
                        }
                    }
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        listaNodo[n] = "<" + reader.Name + ">";
                        // sb.Append(listaNodo[n] + delimitador);  // 27-03-2020

                        if (listaNodo[n] == "<usuario>")
                        {
                            // llegó hasta la última columna de la fila
                            ultimoNodo = 1;
                        }

                        string nombreNodo = listaNodo[n];

                        #region No usado
                        //if (cantidadFilas < 1)
                        //{
                        //    switch (nombreNodo)
                        //    {
                        //        case "<fecha>":
                        //            columnaActual = Convert.ToInt32(listaNodo[n]);
                        //            break;
                        //        case "<hora>":
                        //            Dgv1.Columns.Add("hora", "Hora");
                        //            break;
                        //            //default:
                        //            //    Console.WriteLine("Default case");
                        //            //    break;
                        //    }
                        //}
                        #endregion
                    }
                    // Verifica que no sea el ultimo nodo de esa fila
                    if (ultimoNodo == 0)
                    {
                        if (reader.NodeType == XmlNodeType.Text)
                        {
                            listBox1.Items.Add(reader.Value);
                            sb.Append(reader.Value + delimitador);
                            columnaActual++;
                        }
                    }
                    else
                    {
                        if (reader.NodeType == XmlNodeType.Text)
                        {
                            listBox1.Items.Add(reader.Value);
                            sb.Append(reader.Value); // + finLinea);

                            // va a empezar una nueva fila y pone elcontador de nodos o columnas a cero
                            ultimoNodo = 0;
                        }
                    }
                    n++;
                }
            }
            catch (Exception ex)
            {
                //  MessageBox.Show($"Error --> {ex}");
            }
        }

        public void CreaArchivoCSV()
        {
            // Crea el archivo CSV
            rutaCSV = ($"{soloRuta}{"\\"}{"sap.csv"}");
            TxtRutaArchivoCSV.Text = rutaCSV;
            StreamWriter sw = new StreamWriter(rutaCSV);
            sw.WriteLine(sb.ToString());
            sw.Close();
        }

        public void LeerArchivoLineaPorLineaySeparaItems()
        {
            if (File.Exists(ruta))
            {
                StreamReader flujoEntrada = File.OpenText(rutaCSV);
                string lineaLeida = flujoEntrada.ReadLine();
                char separadorItems = (delimitador);

                // Lee el archivo linea por linea
                while (lineaLeida != null)
                {
                    ItemsPorLinea = lineaLeida.Split(separadorItems);
                    try
                    {
                        lineaLeida.Contains(separadorItems);
                        {
                            if (cantidadItemsPorLinea == 0)
                            {
                                cantidadItemsPorLinea = ItemsPorLinea.Length;
                                cantidadColumnas = cantidadItemsPorLinea;
                                AgregaEncabezadoDeColumnas(cantidadColumnas, "Columna");
                            }
                            // Usado para mostrar las lineas y la cantidad de estas
                            cantidadFilas++;

                            // Agrega el contenido a las columnas del ListView
                            AgregaContenidoEnColumnas();

                            lineaLeida = flujoEntrada.ReadLine();
                            contadorLineas++;
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("La cadena no tiene un separador de items válido");
                        //MessageBox.Show(ex.Message);
                        break;
                    }
                }
                flujoEntrada.Close();
                cantidadFilas = 0;
            }

        }

        public void AgregaEncabezadoDeColumnas(int cantCol, string nombre)
        {
            Lvw1.Columns.Add("      ", 80, HorizontalAlignment.Left);
            Lvw1.Columns.Add("      ", 80, HorizontalAlignment.Left);
            Lvw1.Columns.Add("      ", 80, HorizontalAlignment.Left);
            Lvw1.Columns.Add("      ", 200, HorizontalAlignment.Left);
            Lvw1.Columns.Add("      ", 100, HorizontalAlignment.Left);
            Lvw1.Columns.Add("      ", 100, HorizontalAlignment.Left);
            Lvw1.Columns.Add("      ", 100, HorizontalAlignment.Left);
            Lvw1.Columns.Add("      ", 100, HorizontalAlignment.Left);
            Lvw1.Columns.Add("      ", 100, HorizontalAlignment.Left);
            Lvw1.Columns.Add("      ", 100, HorizontalAlignment.Left);

            // Oculta los encabezados o Headers del ListView
            Lvw1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            Lvw1.GridLines = false;

            #region No usado
            //for (int i = 0; i < cantCol; i++)
            //{
            //    anchoColumna = nombre.Length + 100;
            //    Lvw1.Columns.Add(nombre + " " + (i + 1).ToString(), anchoColumna, HorizontalAlignment.Left);
            //}

            //Lvw1.Columns.Add("Fecha", 80, HorizontalAlignment.Left);
            //Lvw1.Columns.Add("Hora", 80, HorizontalAlignment.Left);
            //Lvw1.Columns.Add("IdProducto", 80, HorizontalAlignment.Left);
            //Lvw1.Columns.Add("NombreProducto", 200, HorizontalAlignment.Left);
            //Lvw1.Columns.Add("Categoria", 100, HorizontalAlignment.Left);
            //Lvw1.Columns.Add("IdBodega", 100, HorizontalAlignment.Left);
            //Lvw1.Columns.Add("NombreBodega", 100, HorizontalAlignment.Left);
            //Lvw1.Columns.Add("Temperatura", 100, HorizontalAlignment.Left);
            //Lvw1.Columns.Add("Peso", 100, HorizontalAlignment.Left);
            //Lvw1.Columns.Add("Usuario", 100, HorizontalAlignment.Left);
            #endregion
        }

        public void AgregaContenidoEnColumnas()
        {
            for (int i = 0; i < cantidadItemsPorLinea; i++)
            {
                if (contadorItemDeListView == 0)
                {
                    // Agrega primero el Item
                    // lista = new ListViewItem(cantidadFilas.ToString());
                    lista = new ListViewItem(ItemsPorLinea);
                    Lvw1.Items.Add(lista);
                    contadorItemDeListView++;
                }
                else
                {
                    // Agrega después los SubItems
                    lista.SubItems.Add(ItemsPorLinea[i]);
                }
            }
            contadorItemDeListView = 0;
        }

        public void AbrirArchivoCSV(string archivo)
        {
            if (File.Exists(rutaCSV))
            {
                Process.Start(rutaCSV);
            }
        }

        public void LimpiarDatos()
        {
            TxtArchivoXMLLeido.Clear();
            TxtRutaArchivoCSV.Clear();
            listBox1.Items.Clear();
            TxtRutaArchivoXML.Clear();
            Lvw1.Items.Clear();
           // ItemsPorLinea.Initialize();
            contadorItemDeListView = 0;
            cantidadFilas = 0;
            contadorLineas = 0;
            sb.Clear();
            n = 0;
        }

        
    }
}
