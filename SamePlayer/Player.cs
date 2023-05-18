using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamePlayer
{
    public class Player
    {
        public PlayerType Type { get; set; }
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return Type.GetHashCode() ^ Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || (this.GetType() != obj.GetType()))
            {
                return false;


            }
            else
            {
                Player p = (Player)obj;
                return (Type == p.Type) && (Name == p.Name);
            }
        }
    }
}