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
        private readonly IMapper _mapper;
        private readonly IDataRepository<User> _UserRepository;
        public UserService(IMapper mapper, IDataRepository<User> childRepository)
        {
            _mapper = mapper;
            _UserRepository = childRepository;
        }

        public async Task<UserDTO> Add(UserDTO entity)
        {
            return _mapper.Map<UserDTO>(await _UserRepository.AddAsync(_mapper.Map<User>(entity)));
        }

        public async Task Delete(int id)
        {
            await _UserRepository.DeleteAsync(id);

        }

        public async Task<List<UserDTO>> GetAll()
        {
            return _mapper.Map<List<UserDTO>>(await _UserRepository.GetAllAsync());
        }

        public async Task<UserDTO> GetById(int id)
        {
            return _mapper.Map<UserDTO>(await _UserRepository.GetByIdAsync(id));
        }

        public async Task<UserDTO> Update(UserDTO entity)
        {
            return _mapper.Map<UserDTO>(await _UserRepository.UpdateAsync(_mapper.Map<User>(entity)));
        }
    }
}
