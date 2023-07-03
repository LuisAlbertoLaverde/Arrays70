﻿namespace Arrays.Logic
{
    public class MyArray
    {
        private int _top; //logic size
        private int[] _array;

        public MyArray(int n)
        {
            N = n;
            _array = new int[n];
            _top = 0;
        }

        public bool IsEmpty => _top == 0;
        public bool IsFull => _top == N;
        public int N { get; } //physical size

        public void Fill(int minimun, int maximun)
        {
            Random random = new();
            for (int i = 0; i < N; i++)
            {
                _array[i] = random.Next(minimun, maximun);
            }
            _top = N;
        }
        public override string ToString()
        {
            if (IsEmpty)
            {
                return "Empty array";
            }

            string output = string.Empty;
            int count = 0;
            for (int i = 0; i < _top; i++)
            {
                output += $"{_array[i]}\t";
                count++;
                if (count > 9)
                {
                    count = 0;
                    output += "\n";
                }
            }
            return output;
        }
        public void Sort() 
        {
            Sort(false);
        }
        public void Sort(bool descending)
        {
            for (int i = 0; i < _top - 1; i++)
            {
                for (int j = i + 1; j < _top; j++)
                {
                    if (descending)
                    {
                        if (_array[i] < _array[j])
                        {
                            Change(ref _array[i], ref _array[j]);
                        }
                    }
                    else 
                    {
                        if (_array[i] > _array[j])
                        {
                            Change(ref _array[i], ref _array[j]);

                        }

                    }
                }
            }
        }

        private void Change(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
    }
}