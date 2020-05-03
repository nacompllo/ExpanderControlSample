using ExpanderControl.Models;
using ExpanderControl.ViewModels.Base;
using System.Collections.ObjectModel;

namespace ExpanderControl.ViewModels
{
    public class PersonsHomeViewModel : BaseViewModel
    {
        private ObservableCollection<Person> _persons = new ObservableCollection<Person>();

        public ObservableCollection<Person> Persons
        {
            get => _persons;
            set
            {
                _persons = value;
                RaiseOnPropertyChanged();
            }
        }

        public PersonsHomeViewModel()
        {
            InitializePersons();
        }

        private void InitializePersons()
        {
            for (var i = 0; i < 50; i++)
            {
                var newPerson = new Person
                {
                    Name = $"Name {i}",
                    Surname = $"Surname {i}",
                    Email = $"email{i}@outlook.com",
                    Phone = $"Phone: {i}",
                    Icon = "woman"
                };

                if (i % 2 == 0)
                {
                    newPerson.Icon = "man";
                }
                Persons.Add(newPerson);
            }
        }
    }
}