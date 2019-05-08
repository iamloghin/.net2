namespace PostComment
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public partial class Comment
    {
        public bool AddComment()
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                if (PostPostId == Guid.Empty) return false;
                if (CommentId == Guid.Empty) return false;
                ctx.Entry(this).State = EntityState.Added;
                var p = ctx.Posts.Find(this.PostPostId);
                ctx.Entry(p).State = EntityState.Unchanged;
                ctx.SaveChanges();
                return true;
            }
        }
        public Comment UpdateComment(Comment newComment)
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                var oldComment = ctx.Comments.Find(newComment.CommentId);

                // Deoarece parametrul este un Comment ar trebui verificata fiecare
                // proprietate din newComment daca are valoare atribuita si
                // daca valoarea este diferita de cea din bd.
                // Acest lucru il fac numai la modificarea asocierii.
                if (newComment.Text != null && oldComment != null) oldComment.Text = newComment.Text;
                if (oldComment != null && (oldComment.PostPostId != newComment.PostPostId) && (newComment.PostPostId == Guid.Empty))
                {
                    oldComment.PostPostId = newComment.PostPostId;
                }
                ctx.SaveChanges();
                return oldComment;
            }
        }
        public Comment GetCommentById(Guid id)
        {
            using (var ctx = new ModelPostCommentContainer())
            {
                var items = from c in ctx.Comments where (c.CommentId == id) select c;
                return items.Include(p => p.Post).SingleOrDefault();
            }
        }
    }
}
