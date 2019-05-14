using System;
using System.Collections.Generic;
using PostComment;

namespace ObjectWCF
{
    public class PostComment : IPostComment
    {
        public bool AddPost(Post post)
        {
            return post.AddPost();
            // return Api.AddPost(post);
        }

        public Post UpdatePost(Post post)
        {
            return post.UpdatePost(post);
        }

        public int DeletePost(Guid id)
        {
            var post = new Post();
            return post.DeletePost(id);
            // static
            //return Api.DeletePost(id);
        }

        public Post GetPostById(Guid id)
        {
            // E nevoie de ac instanta. Metodele din Api sunt metode ale instantei.
            var post = new Post();

            // Mesaj ce apare in server CUI. Nu e necesar.
            Console.WriteLine("GetPostById. Id = {0}", id);
            post = post.GetPostById(id); // Neclar acest cod.

            Console.WriteLine("Post returnat. Id = {0} , Description = {1}",
                post.PostId, post.Description);
            return post;
        }

        public List<Post> GetPosts()
        {
            var post = new Post();
            return post.GetAllPosts();
        }

        public bool AddComment(Comment comment)
        {
            return comment.AddComment();
        }

        public Comment UpdateComment(Comment newComment)
        {
            return newComment.UpdateComment(newComment);
        }

        public Comment GetCommentById(Guid id)
        {
            var comment = new Comment();
            return comment.GetCommentById(id);
        }
    }
}
