using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakTreci
{
    class GenericsListEnumerator<T> : IEnumerator<T>
    {
        private T generic;
        private int index;
        private GenericsList<T> gLista;

        public GenericsListEnumerator(GenericsList<T> l)
        {
            gLista = l;
            generic = default(T);
            index = -1;
        }

        public T Current
        {
            get
            {
                return generic;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (index++ >= gLista.Count)
            {
                return false;
            }
            else
            {
                generic = gLista.GetElement(index);
            }
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
