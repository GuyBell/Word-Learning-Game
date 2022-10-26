using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Player
    {
        private int id;
        private string name;

        //Ctor
        public Player(int id,string name)
        {
            Id = id;
            Name = name;
        }


        public int Id
        { 
            get { return id; }
            set 
            {
                if (value > 99999999 && value < 1000000000)
                {
                    id = value;
                }
                else
                {
                    id = 111111111;
                }
            } 
        }

        public string Name { get { return name; } set { name=value;} }
    }
    
}
