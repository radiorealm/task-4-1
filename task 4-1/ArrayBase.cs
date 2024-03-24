using System;

namespace task_4_1
{
    abstract class ArrayBase<T> : IArrayBase
    {
        protected static Random rnd = new Random();

        protected int array_size;

        public ArrayBase(int array_size)
        {
            this.array_size = array_size;
        }

        //Добавление элемента в массив. Если массив заполнен, увеличить его ёмкость по правилу 2n + 1 и добавить элемент на первую свободную позицию.
        public abstract void Add(T element);

        //Удаление элемента из массива.
        public abstract void Remove(T element);

        //Сортировка массива.
        //public abstract void Sort();

        //Подсчет количества элементов в массиве.
        //Подсчет количества элементов в массиве, удовлетворяющих переданному условию.
        //public abstract void Count();

        //Проверка выполнения переданного условия хотя бы одного элемента массива.
        //Проверка выполнения переданного условия для всех элементов массива.
        //public abstract bool Check(Predicate<T> condition);

        //Проверка наличия элемента в массиве.
        public abstract bool Check(T element);

        //Получение первого элемента в массиве, удовлетворяющего условию.
        public abstract T Find(Predicate<T> condition);

        //Применение переданного действия ко всем элементам массива.

        //Получение элементов массива, удовлетворяющих переданному условию.
        //Получение элементов массива выбранного типа.
        public abstract T[] FindAll(Predicate<T> condition);

        //Переворот массива.
        //public abstract void Reverse();

        //Получение минимального/максимального элемента массива.
        //Получение минимального/максимального элемента массива по его проекции.

        //Проекция элементов массива в другой тип.

        //Получить заданное количество элементов массива с указанного индекса.

        //Итерирование по экземпляру массива с помощью цикла foreach

    }
}