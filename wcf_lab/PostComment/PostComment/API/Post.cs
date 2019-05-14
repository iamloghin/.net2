namespace PostComment
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public sealed partial class Post
    {
        public bool AddPost()
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                if (PostId == Guid.Empty) return false;
                ctx.Entry(this).State = EntityState.Added;
                ctx.SaveChanges();
                return true;
            }
        }
        public Post UpdatePost(Post newPost)
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                var oldPost = ctx.Posts.Find(newPost.PostId);
                if (oldPost == null) // nu exista in bd
                {
                    return null;
                }
                oldPost.Description = newPost.Description;
                oldPost.Domain = newPost.Domain;
                oldPost.Date = newPost.Date;
                ctx.SaveChanges();
                return oldPost;
            }
        }
        public int DeletePost(Guid id)
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Post where postid = @p0", id);
            }
        }
        public Post GetPostById(Guid id)
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                var items = from p in ctx.Posts where (p.PostId == id) select p;
                return items.Include(c => c.Comments).SingleOrDefault();
            }
        }
        public List<Post> GetAllPosts()
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                return ctx.Posts.Include("Comments").ToList<Post>();
                // Obligatoriu de verificat in apelant rezultatul primit.
            }
        }
    }
}
