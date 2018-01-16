using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication18
{
    class Port<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Port<T>>
    {
        private Dictionary<int, T> places;
        private int maxCount;
        private T defValue;
        private int curIndex;

        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defValue;
            }
        }

        private bool CheckFreePlaces(int index)
        {
            return !places.ContainsKey(index);
        }

        private void AddShip(int index, T ship)
        {
            places[index] = ship;
        }

        private T GetShip(int index)
        {
            T ship = places[index];
            places[index] = defValue;
            return ship;
        }

        public static int operator +(Port<T> p, T ship)
        {
            var isCruiser = ship is Cruiser;
            if (p.places.Count == p.maxCount)
            {
                throw new ParkingOverflowException();
            }
            int index = p.places.Count;
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlaces(i))
                {
                    index = i;
                }
                if (ship.GetType() == p.places[i].GetType())
                {
                    if (isCruiser)
                    {
                        if ((ship as Cruiser).Equals(p.places[i]))
                        {
                            throw new ParkingAlredyHaveException();
                        }
                    }
                    else if ((ship as Ship).Equals(p.places[i]))
                    {
                        throw new ParkingAlredyHaveException();
                    }
                }
            }
            if (index != p.places.Count)
            {
                p.places.Add(index, ship);
                return index;
            }
            p.places.Add(p.places.Count, ship);
            return p.places.Count - 1;
        }

        public static T operator -(Port<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T ship = p.places[index];
                p.places.Remove(index);
                return ship;
            }
            throw new ParkingIndexOutOfRangeException();
        }

        public Port(int size, T defVal)
        {
            defValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size;
        }

        public T Current { get { return places[places.Keys.ToList()[curIndex]]; } }
        object IEnumerator.Current { get { return Current; } }
        public void Dispose() { }

        public bool MoveNext()
        {
            if (curIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            curIndex++;
            return true;
        }

        public void Reset()
        {
            curIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(Port<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }
            else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < this.places.Count; ++i)
                {
                    if (this.places[thisKeys[i]] is Ship && other.places[thisKeys[i]] is Cruiser)
                    {
                        return 1;
                    }
                    if (this.places[thisKeys[i]] is Cruiser && other.places[thisKeys[i]] is Ship)
                    {
                        return -1;
                    }
                    if (this.places[thisKeys[i]] is Cruiser && other.places[thisKeys[i]] is Cruiser)
                    {
                        return (this.places[thisKeys[i]] is Cruiser).CompareTo(other.places[thisKeys[i]] is Cruiser);
                    }
                    if (this.places[thisKeys[i]] is Ship && other.places[thisKeys[i]] is Ship)
                    {
                        return (this.places[thisKeys[i]] is Ship).CompareTo(other.places[thisKeys[i]] is Ship);
                    }

                }
            }
            return 0;
        }
    }
}
