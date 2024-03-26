using System;

namespace task_4_1
{
    abstract class ArrayBase<T> : IArrayBase<T>
    {
        const int default_size = 4;
        protected int array_size;

        //Создание массива с ёмкостью по умолчанию.
        //Создание массива заданной ёмкости.
        public ArrayBase(int array_size)
        {
            this.array_size = array_size;
        }

        public ArrayBase() : this(default_size) { }

        //Добавление элемента в массив. Если массив заполнен, увеличить его ёмкость по правилу 2n + 1 и добавить элемент на первую свободную позицию.
        public abstract void Add(T element);

        //Удаление элемента из массива.
        public abstract void Remove(T element);

        //Сортировка массива.
        //public abstract void Sort();

        //Подсчет количества элементов в массиве.
        //Подсчет количества элементов в массиве, удовлетворяющих переданному условию.
        public abstract int Length();
        public abstract int Length(Func<T, bool> func);

        //Проверка выполнения переданного условия хотя бы одного элемента массива.
        //Проверка выполнения переданного условия для всех элементов массива.

        //Проверка наличия элемента в массиве.
        public abstract bool Check(T element);

        //Получение первого элемента в массиве, удовлетворяющего условию.
        public abstract T Find(Func<T, bool> func);

        //Применение переданного действия ко всем элементам массива.

        //Получение элементов массива, удовлетворяющих переданному условию.
        //Получение элементов массива выбранного типа.
        public abstract T[] FindAll(Func<T, bool> func);
        public abstract T[] FindAll<TResult>();

        //Переворот массива.
        //public abstract void Reverse();

        //Получение минимального/максимального элемента массива.
        //Получение минимального/максимального элемента массива по его проекции.

        //Проекция элементов массива в другой тип.

        //Получить заданное количество элементов массива с указанного индекса.

        //Итерирование по экземпляру массива с помощью цикла foreach

    }
}