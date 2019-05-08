using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostComment;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var postsList = new List<Post>()
            {
                new Post()
                {
                    Date = DateTime.Now,
                    Description = "Postul numarul 1",
                    Domain = "UnitTest"
                },
                new Post()
                {
                    Date = DateTime.Now,
                    Description = "Postul numarul 2",
                    Domain = "UnitTest"
                }
            };

            var commentsList = new List<Comment>()
            {
                new Comment()
                {
                    Post = postsList[0],
                    PostPostId = postsList[0].PostId,
                    Text = "Comment_1"
                },
                new Comment()
                {
                    Post = postsList[0],
                    PostPostId = postsList[0].PostId,
                    Text = "Comment_2"
                },
                new Comment()
                {
                    Post = postsList[0],
                    PostPostId = postsList[0].PostId,
                    Text = "Comment_3"
                },
                new Comment()
                {
                    Post = postsList[1],
                    PostPostId = postsList[1].PostId,
                    Text = "Comment_1"
                },
                new Comment()
                {
                    Post = postsList[1],
                    PostPostId = postsList[1].PostId,
                    Text = "Comment_2"
                },
                new Comment()
                {
                    Post = postsList[1],
                    PostPostId = postsList[1].PostId,
                    Text = "Comment_3"
                },
                new Comment()
                {
                    Post = postsList[1],
                    PostPostId = postsList[1].PostId,
                    Text = "Comment_4"
                },
            };

            postsList.ForEach(post => post.AddPost());
            commentsList.ForEach(comment => comment.AddComment());
        }
    }
}
