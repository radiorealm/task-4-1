using System;

namespace task_4_1
{
    sealed class OneDimensional<T> : ArrayBase<T>
    {
        private int current_size = 0;
        private T[] array;

        public OneDimensional(int array_size = 0) : base(array_size)
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
                T[] _array = new T[array_size - 1];

                Array.Copy(array, 0, _array, 0, index);
                Array.Copy(array, index + 1, _array, index, array_size - index - 1);
                array = _array;
            }
        }

        public override bool Check(T element)
        {
            return (bool flag = (FindIndex(element) = -1) ? false : true);
        }

        public override T Find(Predicate<T> condition)
        {
            return array[FindIndex(condition)];
        }

        private int FindIndex(Predicate<T> condition)
        {
            for (int i = 0; i < array_size; i++)
            {
                if (condition(array[i]))
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
        //можно ли прописать 1 FindIndex?
    }
}