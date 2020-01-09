using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic.Being;

namespace Generic.Generic
{
    class ClassRoom<S, P>
    {

        //Add storage for people and schools
        public Dictionary<string, P> People = new Dictionary<string, P>();

        public S School { get; set; }

        public string GetClassList()
        {
            //Need to protect the classroom from undesirable schools.
            if (!(School is School))
            {
                return "School is not valid";
            }

            string ret = "";

            foreach (var item in People)
            {
                if (item.Value is Person)
                    ret += item.Key + " says " + (item.Value as Person).Saying + ",";
            }

            return (School as School).Name + " enrollment: " + ret;
        }

    }
}
