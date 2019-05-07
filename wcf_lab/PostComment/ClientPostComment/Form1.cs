using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PostComment;

namespace ClientPostComment
{
    public partial class Form1 : Form
    {
        private List<Post> _posts = new List<Post>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _posts = LoadPosts().ToList();
            dgp.DataSource = _posts;
            dgp.Columns[0].Width = 0;
            if (dgp.Rows.Count > 0)
                dgc.DataSource = _posts[0].Comments;
        }
        private static PostComment.Post[] LoadPosts()
        {
            PostCommentClient pc = new PostCommentClient();
            PostComment.Post[] p = pc.GetPosts();
            return p;
        }

        private void dgp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            dgc.DataSource = null;
            dgc.DataSource = _posts[e.RowIndex].Comments;
        }
    }
}
