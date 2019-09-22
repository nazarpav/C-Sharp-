using System;
using System.Collections.Generic;
using System.Text;
/*Завдання:
Напишіть клас RangeOfArray, який дозволяє працювати з масивом такого типу, в якому індексний діапазон встановлюється користувачем. Наприклад, в діапазоні від 6 до 10, або від -9 до 15.
Діапазон встановлюєтья в параметризованому конструкторі, який приймає верхній та нижній індекс, або ж тільки верхній індекс, а нижній буде починатися з нуля.
Також передбачити конструктор по замовчуванню, який встановить діапазон [0...10).
Підказка: У класі можна оголосити дві змінних, які будуть містити верхній і нижній індекс допустимого діапазону.
*/
namespace _17._09._2019
{
    class RangeOfArray
    {
        int[] array;
        short up, down;
        private void _FillArray()
        {
            Random rnd = new Random();
            for (short i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10);
            }
        }
        public RangeOfArray(short up,short down=0)
        {
            if (up < down)
                throw new Exception("up<down");
            this.up = up;
            this.down = down;
            array = new int[up+Math.Abs(down)];
            _FillArray();
            
        }
        public RangeOfArray()
        {
            this.up = 10;
            this.down = 0;
            array = new int[up];
            _FillArray();
        }
        public int this[int index]
        {
            get
            {
                if (index >= up || index < down)
                    throw new Exception("Invalid index");
                return array[index+ Math.Abs(down)];
            }
            set
            {
                if (index >= up || index < down)
                    throw new Exception("Invalid index");
                array[index+ Math.Abs(down)] = value;
            }
        }

    }
}
