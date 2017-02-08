using CGKSBibliothouris.Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.Repositories {
    interface IPersonRepository {
        Person CreatePerson(Person person);
        Person ReadPerson(int id);

        IEnumerable<Person> ReadAllPersons();
    }
}
