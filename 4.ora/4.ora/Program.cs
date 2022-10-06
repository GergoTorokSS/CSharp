using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ora
{   class arrayContainer
    {
        private int[] array = new int[0];
        private int size=0;
        
        public void addElement(int newInt)
        {
            int[] newArray = new int[size+1];
            System.Array.Copy(array, newArray, size);
            newArray[size] = newInt;
            array = newArray;
            size = newArray.Length;

        }
        public int getElement(int index)
        {
            return array[index];
        }
        public int getSize()
        {
            return size;
        }
        public int getSum()
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum+=item;
            }
            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            arrayContainer array = new arrayContainer();
            for (int i=0;i<10;i++)
            {
                array.addElement(i*2);
            }
            for (int i = 0; i < array.getSize(); i++)
            {
                Console.WriteLine(array.getElement(i));
            }
            Console.WriteLine("Sum of elements in array: {0}",array.getSum());
            arrayContainer array2 = new arrayContainer();
            for (int i = 0; i < 10; i++)
            {
                array2.addElement(i);
            }
            int[] mergedArray = new int[array.getSize()*2];
            for (int i = 0; i < array.getSize(); i++)
            {
                mergedArray[i] = array.getElement(i);
            }
            for (int i = 0; i < array2.getSize(); i++)
            {
                mergedArray[array2.getSize()+i] = array2.getElement(i);
            }
            System.Array.Sort(mergedArray);
            foreach (int item in mergedArray)
            {
                Console.WriteLine("Merged Array items: {0}",item);
            }
        }
    }
}
