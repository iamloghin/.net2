using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PostComment;

namespace ClientPostComment
{
    public partial class Form1 : Form
    {
        private List<Post> Posts = new List<Post>();

        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void Form1_Load()
        {
            Posts = LoadPosts().ToList();
            dgp.DataSource = Posts;
            dgp.Columns[0].Width = 0;
            if (dgp.Rows.Count > 0)
                dgc.DataSource = Posts[0].Comments;
        }

        private static IEnumerable<Post> LoadPosts()
        {
            var pc = new PostCommentClient();
            var p = pc.GetPosts();
            return p;
        }

        private void dgp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            dgc.DataSource = null;
            dgc.DataSource = Posts[e.RowIndex].Comments;
        }
    }
}
