using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace CustomerManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomerService service = new CustomerService();

            bool runApp = true;
            while (runApp)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Dodaj klienta");
                Console.WriteLine("2. Wyświetl wszystkich klientów");
                Console.WriteLine("3. Aktualizuj dane klienta");
                Console.WriteLine("4. Usuń klienta");
                Console.WriteLine("5. Wyszukaj klienta po nazwisku");
                Console.WriteLine("6. Wyjście");
                Console.Write("Wybierz opcję: ");

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            service.CreateCustomer();
                            break;
                        case 2:
                            service.ShowAllCustomers();
                            break;
                        case 3:
                            service.EditCustomer();
                            break;
                        case 4:
                            service.RemoveCustomer();
                            break;
                        case 5:
                            service.SearchCustomer();
                            break;
                        case 6:
                            runApp = false;
                            break;
                        default:
                            Console.WriteLine("Nieprawidłowa opcja, spróbuj ponownie.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Podaj poprawny numer opcji!");
                }
            }
        }
    }


    class DatabaseHelper
    {
      
        private readonly string _connectionString = "Server=localhost;Database=CustomerDB;Trusted_Connection=True;";

        public void ExecuteNonQuery(string sql, Action<SqlCommand> setParameters = null)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    setParameters?.Invoke(cmd);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Customer> QueryCustomers(string sql, Action<SqlCommand> setParameters = null)
        {
            var customers = new List<Customer>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    setParameters?.Invoke(cmd);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new Customer
                            {
                                Id = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Email = reader.GetString(3),
                                Phone = reader.GetString(4),
                                RegistrationDate = reader.GetDateTime(5)
                            });
                        }
                    }
                }
            }
            return customers;
        }
    }


    class CustomerService
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();

        public void CreateCustomer()
        {
            Console.Write("Podaj imię: ");
            string firstName = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string lastName = Console.ReadLine();

            Console.Write("Podaj email: ");
            string email = Console.ReadLine();

            Console.Write("Podaj telefon: ");
            string phone = Console.ReadLine();

            string insertSql = @"INSERT INTO Klienci (Imie, Nazwisko, Email, Telefon, DataRejestracji)
                                 VALUES (@FirstName, @LastName, @Email, @Phone, GETDATE())";

            _dbHelper.ExecuteNonQuery(insertSql, cmd =>
            {
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
            });

            Console.WriteLine("Nowy klient został dodany.");
        }

        public void ShowAllCustomers()
        {
            string selectSql = "SELECT * FROM Klienci";
            List<Customer> customers = _dbHelper.QueryCustomers(selectSql);

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.Id}: {customer.FirstName} {customer.LastName} | Email: {customer.Email} | Telefon: {customer.Phone} | Rejestracja: {customer.RegistrationDate}");
            }
        }

        public void EditCustomer()
        {
            Console.Write("Podaj ID klienta do aktualizacji: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.Write("Podaj nowy email: ");
                string newEmail = Console.ReadLine();

                Console.Write("Podaj nowy telefon: ");
                string newPhone = Console.ReadLine();

                string updateSql = "UPDATE Klienci SET Email = @Email, Telefon = @Phone WHERE Id = @Id";
                _dbHelper.ExecuteNonQuery(updateSql, cmd =>
                {
                    cmd.Parameters.AddWithValue("@Email", newEmail);
                    cmd.Parameters.AddWithValue("@Phone", newPhone);
                    cmd.Parameters.AddWithValue("@Id", id);
                });

                Console.WriteLine("Dane klienta zostały zaktualizowane.");
            }
            else
            {
                Console.WriteLine("Niepoprawne ID.");
            }
        }

        public void RemoveCustomer()
        {
            Console.Write("Podaj ID klienta do usunięcia: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                string deleteSql = "DELETE FROM Klienci WHERE Id = @Id";
                _dbHelper.ExecuteNonQuery(deleteSql, cmd =>
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                });

                Console.WriteLine("Klient został usunięty.");
            }
            else
            {
                Console.WriteLine("Niepoprawne ID.");
            }
        }

        public void SearchCustomer()
        {
            Console.Write("Podaj nazwisko do wyszukania: ");
            string lastNamePart = Console.ReadLine();

            string searchSql = "SELECT * FROM Klienci WHERE Nazwisko LIKE @LastName";
            List<Customer> customers = _dbHelper.QueryCustomers(searchSql, cmd =>
            {
                cmd.Parameters.AddWithValue("@LastName", "%" + lastNamePart + "%");
            });

            if (customers.Count == 0)
            {
                Console.WriteLine("Nie znaleziono klientów pasujących do kryterium.");
            }
            else
            {
                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.Id}: {customer.FirstName} {customer.LastName} | Email: {customer.Email} | Telefon: {customer.Phone} | Rejestracja: {customer.RegistrationDate}");
                }
            }
        }
    }


    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }  
        public string LastName { get; set; }  
        public string Email { get; set; }
        public string Phone { get; set; }      
        public DateTime RegistrationDate { get; set; } 
}
