using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TokenManagement.Model;

namespace TokenManagement.Core
{
    public static class ExtensionMethods
    {
        public static JObject Create(this Token token)
        {
            return new JObject();
        }

        public static JObject Update(this Token token)
        {
            return new JObject();
        }

        public static JObject Complete(this Token token)
        {
            return new JObject();
        }

        public static JObject Close(this Token token)
        {
            return new JObject();
        }

        public static JObject MarkAsSpam(this Token token)
        {
            return new JObject();
        }

        public static JObject UnMarkAsSpam(this Token token)
        {
            return new JObject();
        }

        public static JObject AddToFavorites(this Token token)
        {
            return new JObject();
        }

        public static JObject RemoveFromFavorites(this Token token)
        {
            return new JObject();
        }

        public static JObject LinkToAccount(this Token token)
        {
            return new JObject();
        }
    }
}
