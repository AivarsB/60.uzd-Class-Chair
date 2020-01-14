using System;
using System.Collections.Generic;
using System.Text;

namespace _60.uzd_Class_Chair
{
    public class Chair
    {
        public int height { get; set; }
        public string color { get; set; }
        public string material { get; set; }
        public string room { get; set; }


        public string AvailableChairs()
        {
            return $"{material}, {color}, {room}, {height}";
        }
    }
}
// Izveidot klasi Chair, un pievienot tai atbilstošus properties(piemēram, augstums, krāsa utt.). 
