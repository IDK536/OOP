using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MVC
{
    internal class Numbers
    {
        private const string fileName = "data.txt";
        private const int down = 0;
        private const int top = 100;


        private int a = 0;
        private int b = 0;
        private int c = 0;


        public event EventHandler? ShowEvent;


        public int A { 
             set 
             {
                if (down <= value && top >= value)
                {
                    if (value > b)
                    {
                        b = value;
                    }

                    if (value > c) 
                    { 
                        c = value;
                    }

                    a = value;
                }

                Show();
             }
            get
            {
                return a; 
            }
        }

        public int B
        {
            set
            {
                if (a <= value && value <= c)
                {
                    b = value;
                }

                Show();
            }
            get
            {
                return b;
            }
        }
        public int C
        {
            set
            {
                if (down <= value && top >= value)
                {
                    if (b > value)
                    {
                        b = value;
                    }
                    
                    if (a > value)
                    {
                        a = value;
                    }
                        c = value;
                }
                    
                Show();
            }
            get
            {
                return c;
            }
            
        }

        public void Show()
        {
            ShowEvent?.Invoke(this, EventArgs.Empty);
        }

        public void Load() 
        {
            if (!File.Exists(fileName)) return;

            string text = File.ReadAllText(fileName);
            string[] nums = text.Split('\n');

            if (nums.Length != 3) return;

            bool isParse;

            isParse = int.TryParse(nums[0], out int valueA);
            if (isParse) A = valueA;

            isParse = int.TryParse(nums[1], out int valueB);
            if (isParse) B = valueB;

            isParse = int.TryParse(nums[2], out int valueC);
            if (isParse) C = valueC;
        }

        public void Save()
        {
            string data = a.ToString() + '\n' + b.ToString() + '\n' + c.ToString();
            File.WriteAllText(fileName, data);
        }

    }
}
