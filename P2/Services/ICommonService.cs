﻿using P2.DTOs;

namespace P2.Services
{
    public interface ICommonService<T, TI, TU>
    {
        public List<string> Errors { get; }
        Task<IEnumerable<T>> Get();

        Task<T> GetById(int id);

        Task<T> Add(TI InsertDto);

        Task<T> Update(int id, TU UpdateDto);

        Task<T> Delete(int id);

        bool Validate(TI dto);

        bool Validate(TU dto);
    }
}
