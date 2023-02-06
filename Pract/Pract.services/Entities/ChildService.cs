using AutoMapper;
using Pract.common.DTO_s;
using Pract.Repository.Entities;
using Pract.Repository.Interfaces;
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
    
        public async  Task<ChildDTO> Add(ChildDTO entity)
        {
            return _mapper.Map<ChildDTO>(await _ChildRepository.AddAsync(_mapper.Map<Child>(entity)));
        }

        public async Task Delete(int id)
        {
             await _ChildRepository.DeleteAsync(id);  
        }

        public async Task<List<ChildDTO>> GetAll()
        {
            return _mapper.Map<List<ChildDTO>>(await _ChildRepository.GetAllAsync());
        }

        public async Task<ChildDTO> GetById(int id)
        {
            return _mapper.Map<ChildDTO>(await _ChildRepository.GetByIdAsync(id));
        }

        public async Task<ChildDTO> Update(ChildDTO entity)
        {
            return _mapper.Map<ChildDTO>(await _ChildRepository.UpdateAsync(_mapper.Map<Child>(entity)));
        }
    }
}
