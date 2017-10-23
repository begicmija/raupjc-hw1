using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakDrugi
{
    class GenericList<T> : IGenericList<T>
    {
        private T[] Pohrana = new T[4];
        private int brojac = 0;
        public int Count => brojac;
        public GenericList()
        {
            for (int i = 0; i < Pohrana.Length; i++)
            {
                Pohrana[i] = default(T);
            }
        }
        public GenericList(int initialSize)
        {
            T[] pomocnaLista = new T[initialSize];
            for (int i = 0; i < initialSize; i++)
            {
                pomocnaLista[i] = default(T);
            }

            Pohrana = pomocnaLista;
        }
        public void Add(T item)
        {
            brojac++;
            int trenutnoStanje = Pohrana.Length;
            if (brojac > trenutnoStanje)
            {
                int index = 0;
                T[] pomocni = new T[2 * trenutnoStanje];
                for (int i = 0; i < pomocni.Length; i++)
                {
                    pomocni[i] = default(T);
                }
                for (int i = 0; i < trenutnoStanje; i++)
                {
                    pomocni[i] = Pohrana[i];
                    index++;

                }
                pomocni[index] = item;
                Pohrana = pomocni;
                return;
            }
            for (int i = 0; i < trenutnoStanje; i++)
            {
                if (Pohrana[i].Equals(default(T)))
                {
                    Pohrana[i] = item;
                    return;
                }
                else
                {
                    continue;
                }
            }
        }
        public bool Remove(T item)
        {
            int index = 0;
            for (int i = 0; i < Pohrana.Length; i++)
            {
                if (Pohrana[i].Equals(item))
                {
                    index = i;
                    break;
                }

                index = -1;
            }
            if (index > 0)
            {
                for (int i = index; i < Pohrana.Length - 1; i++)
                {
                    Pohrana[i] = Pohrana[i + 1];
                    brojac--;
                    return true;
                }
                return false;

            }
            return false;
        }
            public bool RemoveAt(int indeX)
            {
                if (Pohrana[indeX].Equals(default(T)))
                {
                    return false;
                }
                for (int i = indeX; i < Pohrana.Length - 1; i++)
                {
                    Pohrana[i] = Pohrana[i + 1];
                }
                brojac--;
                return true;

            }

            public T GetElement(int index)
            {
                return (T)Pohrana[index];
            }

            public int IndexOf(T item)
            {
                for (int i = 0; i < Pohrana.Length; i++)
                {
                    if (Pohrana[i].Equals(item))
                        return i;
                }
                return -1;
            }

            public void Clear()
            {
                for (int i = 0; i < Pohrana.Length; i++)
                {
                    if (Pohrana[i] != null)
                    {
                        Pohrana[i] = default(T);
                        brojac--;
                    }
                }
            }

            public bool Contains(T item)
            {
                for (int i = 0; i < Pohrana.Length; i++)
                {
                    if (Pohrana[i].Equals(item))
                    {
                        return true;
                    }
                }
                return false;
            }

        
    }
}
