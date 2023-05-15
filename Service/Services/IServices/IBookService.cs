using Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.IServices
{
    public interface IBookService
    {
        public Task<List<BookDto>> GetAll();
        public Task<BookDetailsDto> Get(int id);
    }
}
