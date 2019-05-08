using System;

namespace PostComment
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public sealed partial class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Post()
        {
            PostId = Guid.NewGuid();
            Comments = new HashSet<Comment>();
        }

        [DataMember]
        public System.Guid PostId { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Domain { get; set; }

        [DataMember]
        public System.DateTime Date { get; set; }

        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Comment> Comments { get; set; }
    }
}
