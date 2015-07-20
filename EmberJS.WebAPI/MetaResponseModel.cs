using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EmberJS.WebAPI
{
    public abstract class BaseMetaResponseModel
    {
        protected dynamic m_Content;
        [JsonIgnore]
        public dynamic Content { get { return m_Content; } }

        public Object Meta { get; set; }
    }

    public class MetaResponseModel<T> : BaseMetaResponseModel
    {
        public T Response
        {
            get
            {
                return (T)Content ;
            }
            set { m_Content = value; }
        }

    }
}
