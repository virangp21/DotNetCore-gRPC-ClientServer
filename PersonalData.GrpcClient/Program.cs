using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using PersonalData.GrpcService;

namespace PersonalData.GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                using var channel = GrpcChannel.ForAddress("https://localhost:5001");
                var client = new PersonInfo.PersonInfoClient(channel);

                var person = await client.GetPersonAsync(new PersonRequest { Id = 2 });

                Console.WriteLine("First Name : {0} Last Name: {1} Email :{2}", person.FirstName, person.LastName, person.Email);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error has occured while calling gRPC service");
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();



        }
    }
}
