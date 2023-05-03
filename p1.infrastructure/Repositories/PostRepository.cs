using Microsoft.EntityFrameworkCore;
using p1.core.Entities;
using p1.core.Interfaces;
using p1.infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1.infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly p1Context _context;
        public PostRepository(p1Context context) 
        {
            _context = context;
        }
        public async Task<IEnumerable<Champion>> GetPosts()
        {
            var posts = await _context.Champion.ToListAsync();
            return posts;
        }


    }
}
