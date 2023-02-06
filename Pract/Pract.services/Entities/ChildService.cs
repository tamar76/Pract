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
    public class ChildService : IService<ChildDTO>
    {
        private readonly IMapper _mapper;
        private readonly IDataRepository<Child> _ChildRepository;
        public ChildService(IMapper mapper, IDataRepository<Child> childRepository)
        {
            _mapper = mapper;
            _ChildRepository = childRepository;
        }
    
        public async  Task<ChildDTO> AddAsync(ChildDTO entity)
        {
            return _mapper.Map<ChildDTO>(await _ChildRepository.AddAsync(_mapper.Map<Child>(entity)));
        }

        public async Task DeleteAsync(int id)
        {
             await _ChildRepository.DeleteAsync(id);  
        }

        public async Task<List<ChildDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildDTO>>(await _ChildRepository.GetAllAsync());
        }

        public async Task<ChildDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<ChildDTO>(await _ChildRepository.GetByIdAsync(id));
        }

        public async Task<ChildDTO> UpdateAsync(ChildDTO entity)
        {
            Child child = _mapper.Map<Child>(entity);
            child = await _ChildRepository.UpdateAsync(child);
            return _mapper.Map<ChildDTO>(child);
        }
    }
}
