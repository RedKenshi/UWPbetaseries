using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTP.Model.API
{
    public static class SessionAPI
    {
        private static String _key = "e115e4161ddd";
        private static String _secretKey = "8e027fcfef99e05064d5ac31e9634dcb";

        public static String getKey() {
            return _key;
        }

        public static String getSecretKey() {
            return _secretKey;
        }
    }
}
