using System;

namespace MyLibrary1
{
    public class ArrayWorker
    {
        //1. 	Создайте ClassLibrary с типом ArrayWorker, который будет уметь принимать массив, инвертировать его и возвращать.
        //    Массив передаем сами явно в метод, а не через консоль.
        private string[] _getArrayWorker = new string[10];
        private string[] _setArrayWorker = new string[10];

        public void SetArrayWorker(string[] array)
        {
            array.CopyTo(_setArrayWorker, 0);
        }

        public string[] GetInvertedArray()
        {
           for (int arrayInverted = 0; arrayInverted < _setArrayWorker.Length; arrayInverted++)
           {
                _getArrayWorker[arrayInverted] = _setArrayWorker[(_setArrayWorker.Length - 1) - arrayInverted];
           }
             
            return _getArrayWorker;
        }

    }
}
