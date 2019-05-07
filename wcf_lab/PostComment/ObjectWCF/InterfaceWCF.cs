using PostComment;

namespace ObjectWCF
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using System;

    [ServiceContract]
    internal interface INterfacePost
    {
        [OperationContract]
        bool AddPost(Post post);

        [OperationContract]
        Post UpdatePost(Post post);

        [OperationContract]
        int DeletePost(Guid id);

        [OperationContract]
        Post GetPostById(Guid id);

        [OperationContract]
        List<Post> GetPosts();
    }

    [ServiceContract]
    internal interface INterfaceComment
    {
        [OperationContract]
        bool AddComment(Comment comment);

        [OperationContract]
        Comment UpdateComment(Comment newComment);

        [OperationContract]
        Comment GetCommentById(Guid id);
    }

    [ServiceContract]
    internal interface IPostComment: INterfacePost, INterfaceComment
    {
    }
}
