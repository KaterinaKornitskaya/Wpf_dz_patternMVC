using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_dz_patternMVC.Model
{
    internal class ListOfPersons  // класс Список персон
    {
        List<Person> myPeopleList;

        public ListOfPersons()
        {
            myPeopleList = new List<Person>();
        }

        // Добавить персону в список
        public void AddPers(Person obj)
        {
            myPeopleList.Add(obj);
        }

        // удалить персону из списка
        public void RemovePers(Person obj)
        {
            myPeopleList.Remove(obj);
        }

        // поиск персоны в списке
        public List<Person> SearchPers(string user_search)
        {
            List<Person> list = new List<Person>();
            foreach(Person item in myPeopleList)
            {
                if (item.Name == user_search)
                    list.Add(item);
            }
            return list;
        }

        // геттер - получить весь список персон
        public List<Person> GetAll()
        {
            return myPeopleList;
        }

    }
}
