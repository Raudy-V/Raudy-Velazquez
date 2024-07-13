using System;
using System.Xml;

namespace ejemplo_nodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Xmlwriter();
        }

        private static void Xmlwriter()
        {
            using (XmlWriter xmlwriter = XmlWriter.Create("Ejemplo_de_Xmlwriter.xml"))
            {
                xmlwriter.WriteStartDocument();

                xmlwriter.WriteStartElement("Libros");
                xmlwriter.WriteStartElement("Genero");
                xmlwriter.WriteAttributeString("Tipo", "Aventura");
                xmlwriter.WriteString("Jumanji");
                xmlwriter.WriteEndElement(); // Genero


                xmlwriter.WriteStartElement("Genero");
                xmlwriter.WriteAttributeString("Tipo", "Terror");
                xmlwriter.WriteString("La monja");

                xmlwriter.WriteEndDocument();
                xmlwriter.Close();
            }
        }
    }
}
