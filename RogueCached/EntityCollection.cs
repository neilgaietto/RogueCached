using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueCached
{
    [Serializable]
    public class EntityCollection<T>
    {
        //accessor of the cached data 
        public T Read()
        {
            return default(T);
        }
        //called to load the file then memory
        public void Refresh()
        {
            var data = Collect();
            Save(data);
        }
        //user implimented method of loading the data. should be the only function needed to inherit
        public virtual T Collect()
        {
            return default(T);
        }
        //saves the data to file and memory
        private void Save(T data)
        {
        }
    }
}
