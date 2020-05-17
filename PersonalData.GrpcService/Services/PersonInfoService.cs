using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using PersonalData.GrpcService.Data;

namespace PersonalData.GrpcService
{
    public  class PersonInfoService : PersonInfo.PersonInfoBase
    {
        private readonly ILogger<PersonInfoService> _logger;
        public PersonInfoService(ILogger<PersonInfoService> logger)
        {
            _logger = logger;
        }

        public override Task<PersonResponse> GetPerson(PersonRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Request Received for : " + request.Id);
            return Task.FromResult( new PersonData().GetPerson(request.Id));
        }
    }
}
