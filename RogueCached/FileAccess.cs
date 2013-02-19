using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RogueCached
{
    public class FileAccess
    {
        
        public string CacheDirectory { get; set; }
        private const string _EXTENTION = ".rcached";

        public string WriteCache(string key, object obj)
        {
            byte[] bin = ObjectToByteArray(obj);
            string path = GetCacheFilePath(key);
            CheckForPath(path);
            return path;
        }

        public string GetCacheFilePath(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new Exception("The Key cannot be null or empty"); 
            }
            if (key.Any(Path.GetInvalidPathChars().Contains))
            {
                throw new Exception(String.Format("The Key can only contain characters that are valid for a file path ({0})", key)); 
            }

            return CacheDirectory + key + _EXTENTION;
        }
        public void CheckForPath(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }
            catch //(Exception ex)
            {
                throw;
            }
        }
        public static byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();

            using (ms)
            {
                bf.Serialize(ms, obj);
            }

            obj = null;

            return ms.ToArray();
        }
    }
}
