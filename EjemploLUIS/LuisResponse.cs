using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploLUIS
{
    public class LuisResponse
    {
        public Prediction Prediction { get; set; }
    }

    public class Prediction
    {
        public string TopIntent { get; set; }

        public Entity Entities { get; set; }
    }

    public class Entity
    {

        public List<string> Name { get; set; }
        public List<Age> Age { get; set; }
    }

    public class Age
    {
        public int Number { get; set; }

        public string Units { get; set; }
    }
}
