using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZadatakPrvi
{
    class IntegerList : IIntegerList
    {
        private int?[] _Pohrana = new int?[4];
        private int brojac = 0;
        public int Brojac => brojac;
        public IntegerList()
        {
            for (int i = 0; i < _Pohrana.Length; ++i)
            {
                _Pohrana[i] = null;
            }
        }

        public IntegerList(int velicina)
        {
            int?[] pomocnaLista = new int?[velicina];
            for (int i = 0; i < velicina; ++i)
            {
                pomocnaLista[i] = null;
            }

            _Pohrana = pomocnaLista;
        }

        public void Add(int clan)
        {
            brojac++;
            int trenutnoStanje = _Pohrana.Length;
            if (brojac > trenutnoStanje)
            {
                int index = 0;
                int?[] pomocni = new int?[2 * trenutnoStanje];
                for (int i = 0; i < pomocni.Length; ++i)
                {
                    pomocni[i] = null;
                }
                for (int i = 0; i < trenutnoStanje; ++i)
                {
                    pomocni[i] = _Pohrana[i];
                    index++;
                }
                pomocni[index] = clan;
                _Pohrana = pomocni;
                return;
            }
            for (int i = 0; i < trenutnoStanje; ++i)
            {
                if (_Pohrana[i] == null)
                {
                    _Pohrana[i] = clan;
                    return;
                }
                else continue;
            }

        }

        public bool Remove(int clan)
        {
            int index = 0;
            for (int i = 0; i < _Pohrana.Length; i++)
            {
                if (_Pohrana[i] == clan)
                {
                    index = i;
                    break;
                }

                index = -1;

            }
            if (index > 0)
            {
                for (int i = index; i < _Pohrana.Length - 1; i++)
                {
                    _Pohrana[i] = _Pohrana[i + 1];
                }
                brojac--;
                return true;
            }
            return false;

        }

        public bool RemoveAt(int index)
        {
            if (_Pohrana[index] == null)
            {
                return false;
            }
            for (int i = index; i < _Pohrana.Length - 1; i++)
            {


                _Pohrana[i] = _Pohrana[i + 1];


            }
            brojac--;
            return true;

        }

        public int GetElement(int index)
        {
            return (int)_Pohrana[index];
        }

        public int IndexOf(int clan)
        {
            for (int i = 0; i < _Pohrana.Length; i++)
            {
                if (clan == _Pohrana[i])
                    return i;
            }
            return -1;
        }

        public void Clear()
        {
            for (int i = 0; i < _Pohrana.Length; i++)
            {
                if (_Pohrana[i] != null)
                {
                    _Pohrana[i] = null;
                    brojac--;
                }
            }
        }

        public bool Contains(int clan)
        {
            foreach (int i in _Pohrana)
            {
                if (i == clan)
                    return true;
            }
            return false;

        }
    }
}