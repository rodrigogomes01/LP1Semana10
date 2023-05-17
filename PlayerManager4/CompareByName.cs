using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private bool ascending;

        public int Compare(Player x, Player y)
        {
            return ascending ? x.Name.CompareTo(y.Name) : y.Name.CompareTo(x.Name);
        }

        public CompareByName(bool ascending)
        {
            this.ascending = ascending;
        }
    }
}