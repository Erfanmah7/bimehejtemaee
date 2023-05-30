using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bimehejtemaee
{
  public  class Globa
    {
        private static int _userLog = 0;

        public static int userLog
        {
            get { return _userLog; }
            set { _userLog = value; }
        }
    }
}
