using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace lab_2._1
{
    class Program
    {

        static void Main(string[] args)
        {


            Vector3D vector_1 = new Vector3D(-5, 3, -9);
            Vector3D vector_2 = new Vector3D(4, -2, 8);


            //сложение векторов

            Vector3D sum_vector = vector_2 + vector_1;
            Console.WriteLine("сложение векторов");
            Console.WriteLine(sum_vector.ToString());


            //разность векторов

            Vector3D dif_vector = vector_2 - vector_1;
            Console.WriteLine( "разность векторов" );
            Console.WriteLine(dif_vector.ToString());


            //скалярное произведение

            Vector3D product_of_vectors = vector_1 * vector_2;
            Console.WriteLine( "скалярное произведение векторов" );
            Console.WriteLine(product_of_vectors.ToString());


            //умножение на скаляр

            Vector3D vector_3 = vector_1.Сomposition(vector_1); ;
            Console.WriteLine(vector_3.ToString());


            //сравнение векторов
            vector_1.Compare_vectors(vector_1, vector_2);


            // длина одного вектора 

            Vector3D vector_length = new Vector3D();
            vector_length.vector_lenght(dif_vector);


            // длина двух вектора

            sum_vector.vectors_lenght(sum_vector);


            XmlSerializer formatter = new XmlSerializer(typeof(Vector3D));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("pers.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, typeof(Vector3D));

                Console.WriteLine("Объект сериализован");
            }
            //XmlSerializer formatter = new XmlSerializer(typeof(Vector3D));

            //// создаем поток (xml файл)
            //using (FileStream fs = new FileStream("d://visual studio/program_ing/new.xml", FileMode.OpenOrCreate))
            //{
            //    // сериализация (сохранение объекта в поток)
            //    formatter.Serialize(fs, vector_1);
            //}

            //// открываем поток (xml файл)
            //using (FileStream fs = new FileStream("d://visual studio/program_ing/new.xml", FileMode.OpenOrCreate))
            //{
            //    // десериализация (создание объекта из потока)
            //    Vector3D book2 = (Vector3D)formatter.Deserialize(fs);
            //}
        }
    }
}
