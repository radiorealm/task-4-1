﻿using System;

namespace task_4_1
{
    sealed class OneDim<T> : ArrayBase<T>
    {

        private int current_size = 0;
        private T[] array;

        public OneDim(int array_size = 0) : base(array_size)
        {
            array = new T[array_size];
        }

        public override void Add(T element)
        {
            if (current_size < array_size)
            {
                array[current_size] = element;
            }
            else
            {
                Resize();
                Add(element);
            }
            current_size++;
        }

        private void Resize()
        {
            T[] Array = new T[array_size * 2 + 1];
            for (int i = 0; i < array_size; i++)
            {
                Array[i] = array[i];
            }
            array = Array;
            array_size = array_size * 2 + 1;
        }

        public override void Remove(T element)
        {
            int index = FindIndex(element);

            if (index != -1)
            {
                Array.Copy(array, index + 1, array, index, array_size - index - 1);
            }
        }

        public override int Length(Func<T, bool> func)
        {
            int ans = 0;
            for (int i = 0; i < array_size; i++)
            {
                if (func(array[i]))
                {
                    ans += 1;
                }
            }
            return ans;
        }
        public override int Length()
        {
            return current_size;
        }

        public override bool Check(T element)
        {
            return FindIndex(element) != -1;
        }

        public override T Find(Func<T, bool> func)
        {
            return array[FindIndex(func)];
        }

        public override T[] FindAll(Func<T, bool> func)
        {
            T[] elements = new T[Length(func)];
            int index = 0;

            for (int i = 0; i < array_size; i++)
            {
                if (func(array[i]))
                {
                    elements[index] = array[i];
                    index++;
                }
            }

            return elements;
        }

        public override T[] FindAll<TResult>()
        {
            T[] elements = new T[current_size];
            int index = 0;

            for (int i = 0; i < array_size; i++)
            {
                if (array[i] is TResult)
                {
                    elements[index] = array[i];
                    index++;
                }
            }

            Array.Resize(ref elements, index);
            return elements;
        }

        private int FindIndex(Func<T, bool> func)
        {
            for (int i = 0; i < array_size; i++)
            {
                if (func(array[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        private int FindIndex(T element)
        {
            for (int i = 0; i < array_size; i++)
            {
                if (element.Equals(array[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Print()
        {
            foreach (T element in array)
            {
                Console.Write($"{element} ");
            }                
            Console.WriteLine();
        }
        public void Print(T[] _array)
        {
            foreach (T element in _array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}