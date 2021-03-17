using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSet.Entities
{
    class User
    {
        public string Name { get; set; }
        public DateTime Instant { get; set; }

        public User(string name, DateTime instant)
        {
            Name = name;
            Instant = instant;
        }

        
        public override bool Equals(object obj)
        {
            if (!(obj is User))
            {
                throw new ArgumentException("Item in not User valid");
            }

            User other = obj as User;

            return Name.Equals(other.Name);

        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

    }
}
