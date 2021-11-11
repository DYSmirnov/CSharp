using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Vector
    {
        private double[] values;
        int size;

        public Vector(int size = 0) //конструктор совпадает с именем класса 
        {
            values = new double[size];
        }

        public Vector(double [] values) //конструктор совпадает с именем класса 
        {
            this.values = values;
        }

        public void Append(double new_value)
        {
            double[] new_values = new double[values.Length + 1];
            for (int i = 0; i< values.Length; i++)
            {
                new_values[i] = values[i];
            }
            new_values[values.Length + 1] = new_value;
            values = new_values;
        }

        public int GetSize() { return values.Length; }

        public double GetElementAt(int index)
        {
            if (index<0 || index > values.Length) { throw new IndexOutOfRangeException("Index is out of vector's range"); }
            return values[index];
        }

        // написать SetElement

        //public Vector Add (Vector other)
        //{
        //    if (values.Length != other.GetSize()) { throw new Exception("Vectors have diffrent sizes")}
        //    Vector resultVector = new Vector(values.Length);
        //    for (int i = 0; i < values.Length; i++)
        //    {
        //        resultVector.SetElement(i) = values[i] + other.GetElementAt;
        //    }
        //}

        //add Substract

        // public Vector Multiply( double scalarValue) { }

        //add Divide

        public override string ToString()//переопределяем метод ToString()
        {
            StringBuilder sb = new StringBuilder("Vector elements are: ");
                for (int i = 0; i < values.Length; i++)
            {
                if (i != 0) sb.Append(", ");
                sb.Append(values[i]);
            }
            return sb.ToString();
            //return base.ToString();
        }

    }

}
