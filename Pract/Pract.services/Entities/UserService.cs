using AutoMapper;
using Pract.common.DTO_s;
using Pract.Repository.Entities;
using Pract.Repository.Interfaces;
using Pract.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Services.Entities
{
    public class UserService : IService<UserDTO>
    {
        private readonly IMapper _Mapper;
        private readonly IDataRepository<User> _userRepository;
        public UserService(IMapper mapper, IDataRepository<User> childRepository)
        {
            _Mapper = mapper;
            _userRepository = childRepository;
        }

     
        public async Task<List<UserDTO>> Add(List<UserDTO> entity)
        {
            return _Mapper.Map<List<UserDTO>>(await _userRepository.AddAsync(_Mapper.Map<List<User>>(entity)));
        }

       
    }
}
