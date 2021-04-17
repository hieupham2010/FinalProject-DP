using ManageCoffe.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCoffe.DataAccessObject
{
    public interface IDAO<T>
    {
        List<T> GetAll();

        void Create(T t);


        void Update(T t);

        bool CheckExists(string Name);

    }
}
