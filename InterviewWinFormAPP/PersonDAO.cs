using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewWinFormAPP
{
    internal class PersonDAO
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["InterviewDB"].ConnectionString;
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            string query = "SELECT * From Person";
            using(SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Person person = new Person
                        {
                            personID = reader.GetInt32(0),
                            name = reader.GetString(1),
                            age = reader.GetDecimal(2),
                            nationalityID = reader.GetInt32(3),
                            birthdate = reader.GetDateTime(4),
                        };
                        people.Add(person);

                    }
                }
            }
            return people;
        }
        public void insertperson(Person person)
        {
            string insertstatement = $"INSERT INTO Person (personID, name, age, nationalityID, birthDate) Values ({person.personID},'{person.name}',{person.age},{person.nationalityID},{person.birthdate.Date.Day}-{person.birthdate.Date.Month}-{person.birthdate.Date.Year})";
            using(SqlConnection conn = new SqlConnection(connectionstring)) 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(insertstatement, conn);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
