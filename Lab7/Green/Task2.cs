using System.Collections;

namespace Lab7.Green
{
    public class Task2
    {
        public struct Student
        {
            // Поля 
            private string _name;
            private string _surname;
            private int[] _marks;
        
            // Свойства
            public string Name => _name;
            public string Surname => _surname;
            public int[] Marks => _marks.ToArray();
            //public int[] Star
            //{
            //    get
            //    {
        
            //        if (_stars == null || _stars.Length == 0)
            //            return null;
            //        int[] copy = new int[_stars.Length];
            //        for (int i = 0; i < copy.Length; i++)
            //        {
            //            copy[i] = _stars[i];
            //        }
            //        return copy;
            //    }
            //}
        
            public double AverageMark
            {
                get
                {
        
                    if (_marks == null || _marks.Length == 0) 
                        return 0;
        
                    double average = 0;
                    for (int i = 0; i < _marks.Length; i++)
                    {
                        average += _marks[i];
                    }
                    average /= _marks.Length;
                    return average;
                }
            }
            public bool IsExcellent
            {
                get
                {
        
                    if (_marks == null || _marks.Length == 0)
                        return false;
                    for (int i = 0; i < _marks.Length; i++)
                    {
        
                        if (_marks[i] < 4)
                            return false;
                    }
                    return true;
        
                }
            }
        
        
            // Конструктор
            public Student(string name, string surname)
            {
                // Проинициализировать ВСЕ поля
                _name = name;
                _surname = surname;
                _marks = new int[4];
            }
        
            // Методы
        
            public void Exam(int mark)
            {
                for(int i = 0; i < _marks.Length; i++) 
                {
                    _marks[i] = mark;
                }
                
            }
            public static void SortByAverageMark(Student[] array)
            {
                for (int i = 0; i<array.Length;i++)
                {
                    array[i]= AverageMark
                }
            }
            public void Print()
            {
                Console.WriteLine(_name);
                Console.WriteLine(_surname);
                Console.WriteLine(string.Join(" ", _marks));
                Console.WriteLine(Rating);
            }
        }
    }

}
