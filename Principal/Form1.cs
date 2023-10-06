using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String recta1a = recta1.Text;               //volvemos los textbox cadenas de strings
            String recta2a = recta2.Text;

            String recta1b = recta1a.Replace(" ", "");      //Dejamos sin espacios los strings
            String recta2b = recta2a.Replace(" ", "");

            String recta1c = recta1b.ToLower();
            String recta2c = recta2b.ToLower();



            int x = (validacion(recta1c));   //Validamos la recta 1 y 2 en las variables x y y
            int y = (validacion(recta2c));

            string xd = x.ToString();
            
            //ACA IRIAN LOS CASOS Y LUEGO SACAREMOS LOS VALORES DE LAS TUPLAS Y LOS OPERAREMOS


            //Ahora queremos crear un condicional que ayude a validar si las dos rectas son del mismo tipo,en caso de no serlo indicarle que el formato es invalido

            if ((x==1 || x==2|| x==3 || x == 4 || x==5 || x==12 ) && (y==1 || y==2 || y==3 || y==4 || y==5|| y==12))      //Solo se pueden usar los valores (pendiente,b, , )
            {
                //Codigo para operar si los dos son y=mx+b
                MessageBox.Show("y=mx+b");
                var r1valor = valores(recta1c);
                var r2valor = valores(recta2c);            
                float pendiente1 = r1valor.Item1;
                float pendiente2 = r2valor.Item1;
               // MessageBox.Show(pendiente1.ToString());
               // MessageBox.Show(pendiente2.ToString());



                if (pendiente1 == pendiente2)
                {
                    MessageBox.Show("Las rectas son paralelas");
                }
                else
                {
                    if (pendiente1 * pendiente2 == -1)
                    {
                        MessageBox.Show("Las rectas son perpendiculares");
                    }
                    else        //Ya que no es perpendicular no tampoco paralela entonces sabemos que se corta en un punto
                    {
                        float b1 = r1valor.Item2;
                        float b2 = r2valor.Item2;

                        float X = (b2-b1/(pendiente1 - pendiente2));        //Este tiene que ser el valor de La coordenada en x de la interseccion
                        float Y = pendiente1 * X + b1;
                        MessageBox.Show("Las coordenadas de la interseccion son :" + X + " y " + Y);
                    }
                }
            }
            else
            {
                if ((x == 3 || x == 6 || x == 7 || x == 8 || x == 9 || x==13) && (y == 3 || y == 6 || y == 7 || y == 8 || y == 9 || y==13))
                {
                    //Codigo en caso de que la notacion sea y-y1=m(x-x1)
                    MessageBox.Show("y-y1=m(x-x1)");

                    //b=x1m+y1
                    var r1valor = valores(recta1c);
                    var r2valor = valores(recta2c);
                    float pendiente1 = r1valor.Item1;
                    float pendiente2 = r2valor.Item1;
                    

                    //Multipliar el xo por -1
                    if (pendiente1 == pendiente2)
                    {
                        MessageBox.Show("Las rectas son paralelas");
                    }
                    else
                    {
                        if (pendiente1 * pendiente2 == -1)
                        {
                            MessageBox.Show("Las rectas son perpendiculares");
                        }
                        else        //Ya que no es perpendicular no tampoco paralela entonces sabemos que se corta en un punto
                        {
                            float x1 = r1valor.Item3;
                            float y1 = r1valor.Item4;

                            float x2 = r2valor.Item3;
                            float y2 = r2valor.Item4;

                            float b1 = pendiente1 * x1 + y1;
                            float b2 = pendiente2 * x2 + y2;

                            float X = (b2 - b1 / (pendiente1 - pendiente2));        //Este tiene que ser el valor de La coordenada en x de la interseccion
                            float Y = pendiente1 * X + b1;
                            MessageBox.Show("Las coordenadas de la interseccion son :" + X + " y " + Y);
                        }
                    }
                }
                else   //Caso en que escribio de manera incorrecta la notacion
                {                  
                    if (x == 11 && y==11)
                    {
                        MessageBox.Show("Las dos ecuaciones tiene un formato incorrecto");
                    }
                    else
                    {
                        if ( x==11)
                        {
                            MessageBox.Show("La ecuacion 1 tiene un formato incorrecto");
                        }
                        else
                        {
                            MessageBox.Show("La ecuacion 2 tiene un formato incorrecto");
                        }
                    }
                }
            }
        }

        public int validacion(String cadena)
        {
            //   string patron1 = @"^y=(\d+)x\+(\d+)$";      //abarca el caso ideal que seria y=mx+b))
            // if (Regex.IsMatch(cadena, patron1))
            //{
            //   return 1;
            //            }

            if (cadena == "y =x" || cadena == "x=y")                //Abarca el caso x=y
            {
                return 2;
            }

            if (cadena == "y=0")      //abarca el caso y=0                      //-?\d+(\.\d+)?
            {
                return 3;
            }
            string patron11 = @"^y=(-?\d+(\.\d+)?)x+(\d+)$";        //Abarca  y=cualquiervalor x + cualquier valor
            if (Regex.IsMatch(cadena, patron11))
            {
                return 10;
            }
            String patron2 = @"^y=(-?\d+(\.\d+)?)$";  //abarca y = cualquier numero   //abarca el caso y=(cualquier numero)
            if (Regex.IsMatch(cadena, patron2))
            {
                return 4;
            }
            string patron3 = @"^y=(-?\d+(\.\d+)?)x$";  //abarca el caso y=(cualquier numero)x
            if (Regex.IsMatch(cadena, patron3))
            {
                return 5;
            }
            string patron4 = @"^y-(-?\d+(\.\d+)?)=(-?\d+)x$"; //abarca el caso y-(cualquier numero) = cualqier numero(x
            if (Regex.IsMatch(cadena, patron4))
            {
                return 8;
            }
            string patron5 = @"^y-(-?\d+(\.\d+)?)=0$";        //Abarca el caso y-(cualquier numero=0
            if (Regex.IsMatch(cadena, patron5))
            {
                return 7;
            }
            string patron6 = @"^y-(-?\d+(\.\d+)?)=(-?\d+)\(x-(-?\d+(\.\d+)?)\)$";       //abarca el caso y-cualquier numero=cualquier numero(x-cualquier numero)
            if (Regex.IsMatch(cadena, patron6))
            {
                return 6;
            }

            string patron7 = @"^y-(-?\d+(\.\d+)?)=\(x-(-?\d+(\.\d+)?)\)$";  //abarca el caso y-cualquier número=(x-cualquier número)
            if (Regex.IsMatch(cadena, patron7))
            {
                return 9;
            }
            String patron8 = @"^y=(-?\d+(\.\d+)?)x\s*\+?\s*(-?\d+(\.\d+)?)?$";
            if (Regex.IsMatch(cadena, patron8))
            {
                return 12;
            }

            string patron9 = @"^y-(-?\d+(\.\d+)?)=(-?\d+(\.\d+)?)\(x-(-?\d+(\.\d+)?)\)$";
            if (Regex.IsMatch(cadena, patron9))
            {
                return 13;
            }
           
            else
            {
                return 11;  //Si retorna 11 significa que esta mal escrito
            }
        }//Fin funcion


        public string sacarString(String cadena, String antes, String despues) //Nos retorna la sub cadena desde una posicion 1 hasta la posicion 2
        {
            int posicion1 = cadena.IndexOf(antes) + 1;
            int posicion2 = cadena.IndexOf(despues) -2;
            return cadena.Substring(posicion1, posicion2);
        }//fin funcion

        public string StringHastaFin(String cadena, String antes)       //Nos retorna la subcadena desde la posicion 1 hasta el final
        {
            int posicion1 = cadena.IndexOf(antes) + 1;
            return cadena.Substring(posicion1);
        }//fin funcion

        public (float,float, float, float) valores(string cadena)       //ESTA FUNCION NOS RETORNARA UNA TUPLA CON LAS SIGUIENTES POSICIONES (M,B,X,Y)
        {   //  m    b    x     y                                      //Ya que no podemos afirmar que y1 y x1 sean cero en los caso en los que se usa la primera notacion entonces usaremos dependiendo al caso 

            switch ((validacion(cadena)))       //Casos para saber que valores asignarle a cada variable 
            {
                case 1:
                    string m11 = sacarString(cadena, "=", "x");
                    string b11 = StringHastaFin(cadena, "+");
                    float m1 = float.Parse(m11);
                    float b1 = float.Parse(b11);
                    return (m1, b1, 0, 0);
                   
                case 2:
                    return (1, 0, 0, 0);
                    

                case 3:
                    return (0, 0, 0, 0);
                   
                case 4:
                    b11 = StringHastaFin(cadena, "=");
                    b1 = float.Parse(b11);
                    return (0, b1, 0, 0);
                    
                case 5:
                    m11 = sacarString(cadena, "=", "x");
                    m1 = float.Parse(m11);
                    return (m1, 0, 0, 0);

                case 6:
                    int posiciontemp = (cadena.IndexOf("x")+1);
                    string x11 = cadena.Substring(posiciontemp+1,(cadena.IndexOf("("))-2);
                   // string x11 = sacarString(cadena, "x", ")"); //saca x1              
                    float x1 = float.Parse(x11);
                    string y11 = sacarString(cadena, "-", "="); //Saca y1 
                    float y1 = float.Parse(y11);
                    string m22 = sacarString(cadena, "=", "("); //saca m
                    float m2 = float.Parse(m22);                                      
                    return (m2, 0, x1, y1);

                case 7:
                     y11 = sacarString(cadena, "-", "="); //Saca y1 
                     y1 = float.Parse(y11);
                     return (0, 0, 0, y1);

                case 8:
                    x11 = sacarString(cadena, "-", ")"); //saca x1              
                    x1 = float.Parse(x11);
                    m22 = sacarString(cadena, "=", "("); //saca m
                    m2 = float.Parse(m22);
                    return(m2,0,x1,0);

                case 9:
                    x11 = sacarString(cadena, "-", ")"); //saca x1              
                    x1 = float.Parse(x11);
                    y11 = sacarString(cadena, "-", "="); //Saca y1 
                    y1 = float.Parse(y11);
                    return (1, 0, x1, y1);

                case 10:
                    b11 = StringHastaFin(cadena, "+");
                    b1 = float.Parse(b11);              //saca el valor de b
                    return (0, b1, 0, 0);

               case 12:
                    m11 = sacarString(cadena, "=", "x");
                    if (cadena.IndexOf("+") == -1)
                    {
                        b11 = StringHastaFin(cadena,"-");
                    }
                    else
                    {
                        b11 = StringHastaFin(cadena,"+");
                    }
                    m1 = float.Parse(m11);
                    b1 = float.Parse(b11);
                    return (m1, b1, 0, 0);
                case 13:
                    x11 = sacarString(cadena, "-", ")"); //saca x1              
                    x1 = float.Parse(x11);
                    y11 = sacarString(cadena, "-", "="); //Saca y1 
                    y1 = float.Parse(y11);
                     m22 = sacarString(cadena, "=", "("); //saca m
                    m2 = float.Parse(m22);
                    return (m2, 0, x1, y1);

                default:
                    MessageBox.Show("los valores de la recta no son correctos");
                    return (0,0, 0, 0);                   
           
            
            }   //fin funcion


    } //fin del semi main
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void recta2_TextChanged(object sender, EventArgs e)
        {            
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
