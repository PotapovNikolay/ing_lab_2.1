using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace lab_2._1
{
    /// <summary>
    /// <c>vector3D</c>
    /// Содержит перегрузку операторов и математические функции
    /// </summary>
    /// <remarks>
    /// <para>Этот класс может вычислить длину вектора, сложить вектора, перемножить вектора</para>
    /// </remarks>
    /// /// <include file='docs.xml' path='docs/members[@name="vector3D"]/Vector3D/*'/>
    [Serializable]
    public class Vector3D
    {
        private double c { get; set; }

        private double b { get; set; }

        private double a;

        public double A
        {
            get { return a;}
            set {
                if ( value is double )
                {
                    a = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }


        public Vector3D()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }

        public Vector3D(double a, double b,double c )
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        /// <summary>
        /// Перегрузка ToString
        /// </summary>
        public override string ToString()
        {
            return $"a = { a}, b = { b}, c = {c}";
        }

        /// <summary>
        /// Перегрузка оператора сложения
        /// </summary>
        /// <returns>
        /// Сумма векторов
        /// </returns>
        /// See <Посмотрите cref="Vector3D.Сomposition(Vector3D)"/> для других умножений.
        /// <param name="d1">Экземпляр класса Vector3D.</param>
        /// <param name="d2">Экземпляр класса Vector3D.</param>
        public static Vector3D operator +( Vector3D d1, Vector3D d2)
        {

            return new Vector3D(d1.a+d2.a, d1.b+d2.b, d1.c+d2.c);

        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// </summary>
        /// <returns>
        /// Разность векторов
        /// </returns>
        /// <param name="d1">Экземпляр класса Vector3D.</param>
        /// <param name="d2">Экземпляр класса Vector3D.</param>
        public static Vector3D operator -(Vector3D d1, Vector3D d2)
        {

            return new Vector3D(d1.a - d2.a, d1.b - d2.b, d1.c - d2.c);

        }
        /// <summary>
        /// Перегрузка оператора умножения
        /// </summary>
        /// <returns>
        /// Произведение векторов
        /// </returns>
        /// <param name="d1">Экземпляр класса Vector3D.</param>
        /// <param name="d2">Экземпляр класса Vector3D.</param>
        public static Vector3D operator *(Vector3D d1, Vector3D d2)
        {

            return new Vector3D(d1.a * d2.a, d1.b * d2.b, d1.c * d2.c);

        }

        /// <summary>
        /// Скалярное произведение
        /// </summary>
        /// <returns>
        /// Скалярное произведение 3-х векторов
        /// </returns>
        /// <param name="d">Экземпляр класса Vector3D.</param>
        public Vector3D Сomposition( Vector3D d)
        {
            double scalar = 5;
            return new Vector3D(scalar * d.a, scalar * d.b, scalar * d.c);

        }
        /// <summary>
        /// Сравнение векторов
        /// </summary>
        /// <returns>
        /// Равенство векторов
        /// </returns>
        /// <example>
        /// <code>
        /// Vector3D vector_1 = new Vector3D(-5, 3, -9);
        /// Vector3D vector_2 = new Vector3D(4, -2, 8);
        /// vector_1.Compare_vectors(vector_1, vector_2);
        /// </code>
        /// </example>
        /// <param name="d1">Экземпляр класса Vector3D.</param>
        /// <param name="d2">Экземпляр класса Vector3D.</param>
        public void Compare_vectors(Vector3D d1, Vector3D d2)
        {

            if (d1.a == d2.a && d1.b == d2.b && d1.c == d2.c)
            {
                Console.WriteLine("векторы равны");

            }
            else { Console.WriteLine( "векторы не равны" ); }

        }
        /// <summary>
        /// Вычисление длины векторов
        /// </summary>
        /// <returns>
        /// Длина векторов
        /// </returns>
        /// <param name="d">Экземпляр класса Vector3D.</param>
        public void vector_lenght (Vector3D d)
        {

            double lenght_vector = Math.Sqrt(Math.Pow(d.a, 2) + Math.Pow( d.b, 2 ) + Math.Pow( d.c, 2 ) );

            Console.WriteLine("длина одного вектора = " + Math.Round( lenght_vector, 2 ) );

        }
        /// <summary>
        /// Вычисление длины вектора
        /// </summary>
        /// /// <returns>
        /// Длина вектора
        /// </returns>
        /// <param name="d">Экземпляр класса Vector3D.</param>
        public void vectors_lenght(  Vector3D d )
        {

            double lenght_vector = Math.Sqrt( Math.Pow( d.a, 2 ) + Math.Pow( d.b, 2 ) + Math.Pow( d.c, 2 ) );

            Console.WriteLine( "длина двух векторов = " + Math.Round(lenght_vector,2) );

        }

    }
}
