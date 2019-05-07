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
                    PostId = new Guid(),
                    Date = DateTime.Now,
                    Description = "Postul numarul 1",
                    Domain = "UnitTest",
                    Comments = new List<Comment>()
                    {
                        new Comment()
                        {
                            CommentId = new Guid(),
                            Text = "Comment_1"
                        },
                        new Comment()
                        {
                            CommentId = new Guid(),
                            Text = "Comment_2"
                        },
                        new Comment()
                        {
                            CommentId = new Guid(),
                            Text = "Comment_3"
                        }
                    }
                },
                new Post()
                {
                    PostId = new Guid(),
                    Date = DateTime.Now,
                    Description = "Postul numarul 2",
                    Domain = "UnitTest",
                    Comments = new List<Comment>()
                    {
                        new Comment()
                        {
                            CommentId = new Guid(),
                            Text = "Comment_1"
                        },
                        new Comment()
                        {
                            CommentId = new Guid(),
                            Text = "Comment_2"
                        },
                        new Comment()
                        {
                            CommentId = new Guid(),
                            Text = "Comment_3"
                        },
                        new Comment()
                        {
                            CommentId = new Guid(),
                            Text = "Comment_4"
                        },
                        new Comment()
                        {
                            CommentId = new Guid(),
                            Text = "Comment_5"
                        }
                    }
                }
            };
            postsList.ForEach(post => post.AddPost());
        }
    }
}
