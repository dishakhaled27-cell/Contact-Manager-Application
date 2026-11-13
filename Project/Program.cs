using System;

namespace ContactManager
{
    class Address
    { 
          private string place;
          private string type;
          private string description;

           public Address()
        {
            place = "";
             type = "";
            description = "";
        }

         public void SetPlace(string p)
        {
            place = p;
        }

        public void SetType(string t)
        {
            type = t;
        }

        public void SetDescription(string d)
        {
            description = d;
        }

        public string GetAddress()
        {
              return place + " | " + type + " | " + description;
        }

        public void Show()
        {
                Console.WriteLine(GetAddress());
        }  
    }
    class Phone
    {
        private string phone;
        private string type;
        private string description;

        public Phone()
        {
            phone = "";
            type = "";
            description = "";
        }

        public void SetPhone(string p)
        {
            phone = p;
        }

        public void SetType(string t)
        {
            type = t;
        }

        public void SetDescription(string d)
        {
            description = d;
        }

        public string GetPhone()
        {
            return phone + " | " + type + " | " + description;
        }

        public void Show()
        {
            Console.WriteLine(GetPhone());
        }
    }
    class Email
    {
        private string email;
        private string type;
        private string description;

        public Email()
        {
            email = "";
            type = "";
            description = "";
        }

        public void SetEmail(string e)
        {
            email = e;
        }

        public void SetType(string t)
        {
            type = t;
        }

        public void SetDescription(string d)
        {
            description = d;
        }

        public string GetEmail()
        {
            return email + " | " + type + " | " + description;
        }

        public void Show()
        {
            Console.WriteLine(GetEmail());
        }
    }
    class User
    {
        private int id;
        private string firstname;
        private string lastname;
        private string gender;
        private string city;
        private DateTime addedDate;

        private Address[] addresses = new Address[10];
        private Phone[] phones = new Phone[10];
        private Email[] emails = new Email[10];

        private int addressCount = 0;
        private int phoneCount = 0;
        private int emailCount = 0;


        public int ID
        {
            get { return id; }
        }

        public void AddUser()
        {
            Console.Write("Enter ID: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("First Name: ");
            firstname = Console.ReadLine();

            Console.Write("Last Name: ");
            lastname = Console.ReadLine();

            Console.Write("Gender: ");
            gender = Console.ReadLine();

            Console.Write("City: ");
            city = Console.ReadLine();

            addedDate = DateTime.Now;

            Console.WriteLine("\nAdd Phone? 1.Yes 0.No");

            if (int.Parse(Console.ReadLine()) == 1)
                AddPhone();

            Console.WriteLine("\nAdd Email? 1.Yes 0.No");

            if (int.Parse(Console.ReadLine()) == 1)
                AddEmail();

            Console.WriteLine("\nAdd Address? 1.Yes 0.No");

            if (int.Parse(Console.ReadLine()) == 1)
                AddAddress();
        }

        public void AddPhone()
        {
            if (phoneCount >= 10)
            {
                Console.WriteLine("Phone List Is Full!");
                return;
            }

            Phone p = new Phone();

            Console.Write("Enter Phone: ");
            p.SetPhone(Console.ReadLine());

            Console.Write("Enter Type: ");
            p.SetType(Console.ReadLine());

            Console.Write("Enter Description: ");
            p.SetDescription(Console.ReadLine());

              phones[phoneCount] = p;

            phoneCount++;

            Console.WriteLine("Phone Added!");
        }

        public void AddEmail()
        {
            if (emailCount >= 10)
            {
                Console.WriteLine("Email List Is Full!");
                return;
            }

            Email e = new Email();

            Console.Write("Enter Email: ");
            e.SetEmail(Console.ReadLine());

            Console.Write("Enter Type: ");
            e.SetType(Console.ReadLine());

            Console.Write("Enter Description: ");
            e.SetDescription(Console.ReadLine());

            emails[emailCount] = e;

            emailCount++;

            Console.WriteLine("Email Added!");
        }
        public void AddAddress()
        {
            if (addressCount >= 10)
            {
                Console.WriteLine("Address List Is Full!");
                return;
            }

            Address a = new Address();

            Console.Write("Enter Place: ");
            a.SetPlace(Console.ReadLine());

            Console.Write("Enter Type: ");
            a.SetType(Console.ReadLine());

            Console.Write("Enter Description: ");
            a.SetDescription(Console.ReadLine());

            addresses[addressCount] = a;

            addressCount++;

            Console.WriteLine("Address Added!");
        }
        public void Show()
        {
            Console.WriteLine("\n========== USER INFORMATION ==========");

            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + firstname + " " + lastname);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Added Date: " + addedDate);

            Console.WriteLine("\nPHONES:");

            for (int i = 0; i < phoneCount; i++)
                phones[i].Show();

            Console.WriteLine("\nEMAILS:");

            for (int i = 0; i < emailCount; i++)
                emails[i].Show();

            Console.WriteLine("\nADDRESSES:");

            for (int i = 0; i < addressCount; i++)
                addresses[i].Show();

            Console.WriteLine("======================================");
        }
        public bool Search(string key)
        {
            if (id.ToString().Contains(key) ||
                firstname.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                lastname.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                city.Contains(key, StringComparison.OrdinalIgnoreCase) ||
                gender.Contains(key, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            for (int i = 0; i < phoneCount; i++)
            {
                if (phones[i].GetPhone().Contains(key))
                    return true;
            }
            for (int i = 0; i < emailCount; i++)
            {
                if (emails[i].GetEmail().Contains(key,
                    StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            for (int i = 0; i < addressCount; i++)
            {
                if (addresses[i].GetAddress().Contains(key,
                    StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }
        public void EditUser()
        {
            Console.Write("New First Name: ");
            firstname = Console.ReadLine();

            Console.Write("New Last Name: ");
            lastname = Console.ReadLine();

            Console.Write("New Gender: ");
            gender = Console.ReadLine();

            Console.Write("New City: ");
            city = Console.ReadLine();

            Console.WriteLine("User Updated Successfully!");
        }
        public void ManageDetails()
        {
            Console.WriteLine("\n1. Add Phone");
            Console.WriteLine("2. Add Email");
            Console.WriteLine("3. Add Address");

            Console.Write("Choose: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddPhone();
                    break;

                case 2:
                    AddEmail();
                    break;

                case 3:
                    AddAddress();
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
    class Contact
    {
        private User[] users = new User[100];
        private int userCount = 0;
        public void Add()
        {
            if (userCount >= 100)
            {
                Console.WriteLine("Contact List Is Full!");
                return;
            }

            User u = new User();

            u.AddUser();

            for (int i = 0; i < userCount; i++)
            {
                if (users[i].ID == u.ID)
                {
                    Console.WriteLine("ID Already Exists!");
                    return;
                }
            }

            users[userCount] = u;

            userCount++;

            Console.WriteLine("Contact Added Successfully!");
        }
        public void ShowAll()
        {
            if (userCount == 0)
            {
                Console.WriteLine("No Contacts Found!");
                return;
            }

            for (int i = 0; i < userCount; i++)
            {
                users[i].Show();
            }
        }
        public int Count()
        {
            return userCount;
        }
        public void SearchUser()
        {
            Console.Write("Enter Search Data: ");

            string key = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < userCount; i++)
            {
                if (users[i].Search(key))
                {
                    users[i].Show();

                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("Contact Not Found!");
        }
        public void DeleteUser()
        {
            Console.Write("Enter User ID: ");

            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < userCount; i++)
            {
                if (users[i].ID == id)
                {
                    for (int j = i; j < userCount - 1; j++)
                    {
                        users[j] = users[j + 1];
                    }

                    users[userCount - 1] = null;

                    userCount--;

                    Console.WriteLine("Contact Deleted!");

                    return;
                }
            }

            Console.WriteLine("User Not Found!");
        }
        public void EditUser()
        {
            Console.Write("Enter User ID: ");

            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < userCount; i++)
            {
                if (users[i].ID == id)
                {
                    users[i].EditUser();

                    return;
                }
            }

            Console.WriteLine("User Not Found!");
        }
        public void ManageDetails()
        {
            Console.Write("Enter User ID: ");

            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < userCount; i++)
            {
                if (users[i].ID == id)
                {
                    users[i].ManageDetails();

                    return;
                }
            }

            Console.WriteLine("User Not Found!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();

            int choice;

            do
            {
                Console.WriteLine("\n========== CONTACT MANAGER ==========");

                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Show All Contacts");
                Console.WriteLine("3. Search Contact");
                Console.WriteLine("4. Edit Contact");
                Console.WriteLine("5. Delete Contact");
                Console.WriteLine("6. Count Contacts");
                Console.WriteLine("7. Manage Contact Details");
                Console.WriteLine("0. Exit");

                Console.Write("\nChoose Option: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        contact.Add();
                        break;

                    case 2:
                        contact.ShowAll();
                        break;

                    case 3:
                        contact.SearchUser();
                        break;

                    case 4:
                        contact.EditUser();
                        break;

                    case 5:
                        contact.DeleteUser();
                        break;

                    case 6:
                        Console.WriteLine("Total Contacts: " + contact.Count());
                        break;

                    case 7:
                        contact.ManageDetails();
                        break;

                    case 0:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 0);
        }
    }
}