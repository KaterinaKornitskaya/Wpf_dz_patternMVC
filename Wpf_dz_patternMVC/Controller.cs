using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_dz_patternMVC.Model;

namespace Wpf_dz_patternMVC
{
    public class Controller
    {
        // класс Контроллер - инкапсулирует объект класса СписокПерсон
        ListOfPersons myListPers = new ListOfPersons();

        // Добавление Персоны
        public void AddPerson(string name, int age)
        {
            myListPers.AddPers(new Person(name, age));
        }

        // Удаление Персоны
        public void RemovePerson(Person obj)
        {
            myListPers.RemovePers(obj);
        }

        // поиск - вернуть список найденных Персон по имени
        public List<Person> GetSearchPerson(string user_search)
        {
            return myListPers.SearchPers(user_search);
        }

        // геттер - вернуть список Персон
        public List<Person> GetAllPerson()
        {
            return myListPers.GetAll();
        }
    }
}
