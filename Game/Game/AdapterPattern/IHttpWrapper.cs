using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.AdapterPattern
{
    public interface IHttpWrapper {
        Task<T> Get<T>(string path);
        Task<T> Post<T>(string path, object param);
    }
}
