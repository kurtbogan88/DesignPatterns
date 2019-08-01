using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositePattern.Interface;

namespace CompositePattern.Model
{
    public class Emplooye : Interface.IPerson,IEnumerable<Interface.IPerson>
    {
        public string Name { get; set; }
        List<IPerson> _subordinates = new List<IPerson>();
        public void AddSubOrdinate(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void RemoveSubOrdinate(IPerson person)
        {
            _subordinates.Remove(person);
        }
        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }


        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
                yield return subordinate;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
