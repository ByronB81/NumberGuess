using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    class Program
    {
        bool ProgramRunning = true;
        private int _userNum;
        private int _comNum;

        //public int SetComNum
        //{
        //    set { _comNum}
        //}

        public static void ComPicksNum()
        {
            Random rng = new Random();
            set { _comNum = rng.Next(1, 10); }
        }

        static void Main(string[] args)
        {
        }
    }
}
