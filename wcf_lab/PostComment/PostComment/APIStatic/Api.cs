using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PostComment.APIStatic
{
    public static class Api
    {
        public static bool AddPost(Post post)
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                if (post.PostId != Guid.Empty) return false;
                ctx.Entry<Post>(post).State = EntityState.Added;
                ctx.SaveChanges();
                return true;
            }
        }
        public static Post UpdatePost(Post newPost)
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                // Ce e in bd. PK nu poate fi modificata
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

        public static int DeletePost(Guid id)
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Post where postid = @p0", id);
            }
        }

        /// <summary>
        /// Returnez un Post si toate Comment-urile asociate lui
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Post GetPostById(Guid id)
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                var items = from p in ctx.Posts where (p.PostId == id) select p;
                return items.Include(c => c.Comments).SingleOrDefault();
            }
        }
        /// <summary>
        /// Returnez toate Post-urile si Comment-urile corespunzatoare
        /// </summary>
        /// <returns></returns>
        public static List<Post> GetAllPosts()
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                return ctx.Posts.Include("Comments").ToList<Post>();
            }
        }

        // Comment table
        public static bool AddComment(Comment comment)
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                if (comment == null || comment.PostPostId == Guid.Empty) return false;
                if (comment.CommentId != Guid.Empty) return false;

                ctx.Entry<Comment>(comment).State = EntityState.Added;
                var p = ctx.Posts.Find(comment.PostPostId);
                ctx.Entry<Post>(p).State = EntityState.Unchanged;
                ctx.SaveChanges();
                return true;
            }
        }

        public static Comment UpdateComment(Comment newComment)
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                var oldComment = ctx.Comments.Find(newComment.CommentId);
                if (newComment.Text != null && oldComment != null) oldComment.Text = newComment.Text;
                if (oldComment != null && (oldComment.PostPostId != newComment.PostPostId
                                           && (newComment.PostPostId != Guid.Empty)))
                {
                    oldComment.PostPostId = newComment.PostPostId;
                }

                ctx.SaveChanges();
                return oldComment;
            }
        }

        public static Comment GetCommentById(Guid id)
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                var items = from c in ctx.Comments where (c.CommentId == id) select c;
                return items.Include(p => p.Post).SingleOrDefault();
            }
        }
    }
}
