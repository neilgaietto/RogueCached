using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RogueCached
{
    public class CachedFileAccess
    {
        

        public const string EXTENTION = ".rcached";

        public static string WriteCache<T>(CachedFile<T> data, string cacheDirectory)
        {
            
            byte[] bin = ObjectToByteArray(data);
            string path = GetCacheFilePath(data.Key, cacheDirectory);
            CheckForPath(path);
            WriteToStorage(bin, path);
            return path;
        }
        public static CachedFile<T> ReadCache<T>(string key)
        {
            return default(CachedFile<T>);
        }
        public static string GetCacheFilePath(string key, string cacheDirectory)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new Exception("The Key cannot be null or empty"); 
            }
            if (key.Any(Path.GetInvalidPathChars().Contains))
            {
                throw new Exception(String.Format("The Key can only contain characters that are valid for a file path ({0})", key)); 
            }

            return cacheDirectory + key + EXTENTION;
        }
        public static void CheckForPath(string path)
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
        public static void WriteToStorage(byte[] value, string filelocation)
        {
            try
            {
                File.WriteAllBytes(filelocation, value);

            }
            catch (Exception)
            {

            }

        }
    }
}
