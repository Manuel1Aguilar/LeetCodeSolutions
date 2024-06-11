using System.Numerics;

namespace LeetCodeSolutions.Advancing
{
    public class DataTypes
    {
        //Variable 
        //Tipo de dato
        //Funcion = Metodo
        //Argumento
        //Clase
        //Espacio de nombres =Namespace

        public const string InicioDominio = "https://www.";
        public void EjemplosTiposDeDatosReferencias()
        {
            int numer = 0;
            char caracter = 'A';
            bool booleano = false;
        }
        public int Sumar3Numeros(int num1, int num2, int num3)
        {
            //Escribir una funcion que reciba 3 numeros y devuelva la suma de los 3
            return num1 + num2 + num3;
        }

        public string Saludarme(string name)
        {
            //Escribir una funcion que reciba un nombre y devuelva una cadena de caracteres diciendome Hola Manu que gusto verte
            //Recorda definir el tipo de dato del retorno y el argumento de la funcion

            return "Hola " + name + " que gusto verte";

        }
        public string SaludarmeSiQuiero(string name, bool quiero)
        {
            //Escribir una funcion que reciba un nombre y un valor que puede ser verdadero o falso y devuelva una cadena de caracteres diciendome Hola Manu que gusto verte si el valor es verdadero
            //Recorda definir el tipo de dato del retorno y el argumento de la funcion

            if (quiero)
            {
                return "Hola" + name + "Que Gusto Verte";
            }
            return "";
        }
    }
}