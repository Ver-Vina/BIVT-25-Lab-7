namespace Lab7.Blue
{
        public class Task1
    {
        public struct Participant
        {
            //поля
            private string _surname;
            private int _Group;
            //private string _Trainer;
            //private string _Result;
            private int[] _Stars;
            //свойства
            public string Surname
            {
                get { return _surname; } // только для чтения
            }
            public int Group => _Group;
            
            public int[]Stars
            {
                get { }
            }
            public double Reiting
            { 
                get 
                {
                    if (_Stars==null|| _Stars.Length==0)
                        return 0;
                    double average = 0;
                    for (int i = 0; i < _Stars.Length; i++)
                    {
                        average += _Stars[i];
                    }
                    return _Stars[0];
                } 
            }

            //public double PassedTheStandard

            //Конструктор
            public Participant(string surname, int Group)
            {
                // проинициализировать ВСЕ поля
                _surname = surname;
                _Group = Group;
                _Stars = new int[0];
            }

            public void Print()
            {
                Console.WriteLine(_surname);
            }


        }
    }
}
