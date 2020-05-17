using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace PersonalData.GrpcService.Data
{
    public class PersonData
    {
        public List<PersonResponse> lstPersons { get; set;  }


        public PersonData()
        {
            lstPersons = new List<PersonResponse>() {
                    new PersonResponse{Id=1, FirstName="Virang",LastName="Patel",Email="virang@abc.com.au"},
                    new PersonResponse{Id=2, FirstName="Nipa",LastName="Patel",Email="nipa@abc.com.au"},
                    new PersonResponse{Id=3, FirstName="Anaya",LastName="Patel",Email="anaya@abc.com.au"},
                    new PersonResponse{Id=4, FirstName="James",LastName="Black",Email="james@abc.com.au"},

            };


        }

        public PersonResponse GetPerson(int id)
        { 
            return lstPersons.FirstOrDefault<PersonResponse>(x => x.Id == id);
        }
    }
}
