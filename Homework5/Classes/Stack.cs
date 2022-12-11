using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Classes
{
    //3.* Создать класс Stack.Прочитать про него в сети если необходимо больше информации.
    //Стек (от англ. stack — стопка) — структура данных, представляющая из себя упорядоченный набор элементов, в которой добавление новых элементов и удаление существующих
    //производится с одного конца, называемого вершиной стека.Притом первым из стека удаляется элемент, который был помещен туда последним,
    //то есть в стеке реализуется стратегия «последним вошел — первым вышел» (last-in, first-out — LIFO).
    //Примером стека в реальной жизни может являться стопка тарелок: когда мы хотим вытащить тарелку, мы должны снять все тарелки выше.Вернемся к описанию операций стека:
    //IsEmpty— проверка стека на наличие в нем элементов,
    //Push (запись в стек) — операция вставки нового элемента,

    internal class Stack
    {
        private string[] _stack = new string[10];
        private string _tempValue = string.Empty;

        //проверка стека на наличие в нем элементов
         public bool IsEmpty()
        {
            bool flag = true;

            for(int i = 0; i < _stack.Length; i++)
            {
               flag = string.IsNullOrEmpty(_stack[i]) & flag;
            }

            return flag;
        }

        //операция вставки нового элемента
        public void Push(string value)
        {
            if (string.IsNullOrEmpty(_stack[_stack.Length - 1]))
            {
                for(int i = _stack.Length - 1; i >= 0; i--)
                {
                    if (i != 0)
                    {
                        _stack[i] = _stack[i - 1];  
                    }
                    else
                    {
                        _stack[i] = value;
                    }
                   
                }
                    
            }
        }

        //извлекает и возвращает первый элемент из стека
        public string Pop()
        {
            _tempValue = _stack[0];
            _stack[0] = string.Empty;

            for (int i = 0; i < _stack.Length - 1; i++)
            {
                _stack[i] = _stack[i + 1];
            }
            return _tempValue;
        }

        //очищает стек
        public void Clear()
        {
            for (int i = 0; i < _stack.Length; i++)
            {
                _stack[i] = string.Empty;
            }
        }

        //проверяет наличие в стеке элемента и возвращает true при его наличии
        public bool Contains(string value)
        {
            bool result = false;

            for (int i = 0; i < _stack.Length; i++)
            {
                if (_stack[i] == value) //Сравниваем при помощи ==, Equals сравнивает ссылки ?
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        //просто возвращает первый элемент из стека без его удаления
        public string Peek()
        { 
            return _stack[0]; 
        }
    }
}
