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
            if (values.Length == 0) { new_values[0] = new_value; }
            else {
                for (int i = 0; i < values.Length; i++)
                {
                    new_values[i] = values[i];
                }
                new_values[values.Length] = new_value;
                 }
             values = new_values;
            }

        public int GetSize() { return values.Length; }

        public double GetElementAt(int index)
        {
            if (index<0 || index > values.Length) { throw new IndexOutOfRangeException("Index is out of vector's range"); }
            return values[index];
        }

        //public void SetElement(int index)
        //{
        //    values [index] = 
        //}

        public Vector Sum(Vector other)
        {
            if (values.Length != other.GetSize()) { throw new Exception("Vectors have diffrent sizes"); }
            Vector resultVector = new Vector ();
            for (int i = 0; i < values.Length; i++)
            {
                resultVector.Append(values[i] + other.GetElementAt(i));
            }
            return resultVector;
        }
        public Vector Diff(Vector other)
        {
            if (values.Length != other.GetSize()) { throw new Exception("Vectors have diffrent sizes"); }
            Vector resultVector = new Vector();
            for (int i = 0; i < values.Length; i++)
            {
                resultVector.Append(values[i] - other.GetElementAt(i));
            }
            return resultVector;
        }

        //add Substract

        public Vector Multiply( double scalarValue) 
        {  
            Vector resultVector = new Vector();
            for (int i = 0; i < values.Length; i++)
            {
                resultVector.Append(values[i]* scalarValue);
            }
            return resultVector;
        }

        public Vector Divide(double scalarValue)
        {
            if (scalarValue == 0) { throw new Exception("divided by zero"); }
            Vector resultVector = new Vector();
            for (int i = 0; i < values.Length; i++)
            {
                resultVector.Append(values[i] / scalarValue);
            }
            return resultVector;
        }

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
