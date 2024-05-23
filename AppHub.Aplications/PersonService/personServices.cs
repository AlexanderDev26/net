using AppHub.Domain.Models;
using AppHub.Domain.Repositories;
using AppHub.Aplications.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHub.Aplications.PersonService
{
    public class personServices
    {
        private readonly IPersonRepository _personRepository;

        public personServices(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<PersonModel> create(PersonModel personModel)
        {
            if (await _personRepository.IsEmailDuplicated(personModel.Email))
                throw new DuplicatedEmailtException();

            if (await _emailValidatorProvider.IsEmailProvider.IsEmailValid(personModel.Email))
                throw new InvalidEmailException();

            return await _personRepository.InsertAsync(personModel);
        }
    }
}
