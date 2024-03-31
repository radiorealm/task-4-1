using System;

namespace task_4_1
{
    sealed class OneDim<T> : ArrayBase<T>
    {

        private int current_size = 0;
        private T[] array;

        //do constructor chain?
        public OneDim(int array_size) : base(array_size)
        {
            array = new T[array_size];
        }
        public OneDim() { }

        public override void Add(T element)
        {
            if (current_size >= array_size)
            {
                array_size = array_size * 2 + 1;
                Array.Resize(ref array, array_size);
            }
            array[current_size] = element;
            current_size++;
        }

        public override void Remove(T element)
        {
            current_size--;

            int index = FindIndex(element);

            if (index != -1)
            {
                Array.Copy(array, index + 1, array, index, array_size - index);
            }
        }

        public override int Length(Func<T, bool> condition)
        {
            int ans = 0;
            for (int i = 0; i < array_size; i++)
            {
                if (condition(array[i]))
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

        public override void Reverse()
        {
            T[] _array = new T[array_size];

            for (int i = 0; i < array_size; i++)
            {
                _array[i] = array[array_size - i - 1];
            }

            array = _array;
        }

        public override void Foreach(Action<T> action)
        {
            for (int i = 0; i < array_size; i++)
            {
                action(array[i]);
            }
        }


        public override T Find(Func<T, bool> condition)
        {
            return array[FindIndex(condition)];
        }

        public override T[] FindAll(Func<T, bool> condition)
        {
            T[] elements = new T[Length(condition)];
            int index = 0;

            for (int i = 0; i < array_size; i++)
            {
                if (condition(array[i]))
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

        private int FindIndex(Func<T, bool> condition)
        {
            for (int i = 0; i < current_size; i++)
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

        public override TResult[] Projection<TResult>(Func<T, TResult> project)
        {
            TResult[] _array = new TResult[current_size];

            for (int i = 0; i < current_size; i++)
            {
                _array[i] = project(array[i]);
            }

            return _array;
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