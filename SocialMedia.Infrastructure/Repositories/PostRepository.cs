﻿using System;
using System.Collections.Generic;
using System.Linq;
using SocialMedia.Core.Entities;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post> GetPosts()
        {
            var posts = Enumerable.Range(1, 10).Select(x => new Post
            {
                Id = x,
                Description = $"Description {x}",
                Date= DateTime.Now,
                Image = $"https://missapis.com/{x}",
                UserId =  x*2 
            });

            return posts;
        }
    }
}
