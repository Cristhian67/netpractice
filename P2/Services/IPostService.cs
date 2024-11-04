using P2.DTOs;

namespace P2.Services
{
    public interface IPostService
    {
        public Task<IEnumerable<PostDTO>> Get();
    }
}
