using p1.core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace p1.core.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Champion>> GetPosts();
    }
}
