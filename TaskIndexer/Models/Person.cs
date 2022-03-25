using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskIndexer.Models
{
    public class Person
    {
        private string[] person = new string[10];

        private string[] _name;



        public string this[int i]
        {
            get
            {
                return _name[i];
            }
            set
            {
                _name[i] = value;
            }
        }
        private string[] _surname;
        public string this[int y, string x]
        {
            get
            {
                return _surname[y];

            }
            set
            {
                _surname[y] = value;
            }
        }
        private int[] _age;
        public int this[int a, bool d]
        {
            get
            {
                return _age[a];
            }
            set
            {
                _age[a] = value;
            }
        }
        public Person()
        {
            _name = new string[6];
           _surname = new string[6];
            _age = new int[6];



        }
    }
}
        
        

