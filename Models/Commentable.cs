using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookClub.Services;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace BookClub.Models
{

    public abstract class Commentable
    {

        private List<Comment> m_comments = new List<Comment>();

        protected List<Comment> LoadComments(ParentType parentType, int parentId)
        {
            if (m_comments.Count == 0)
            {
                using (SqlConnection connection = Program.GetAppConnection())
                {
                    connection.Open();
                    using (var commentService = new CommentService(connection))
                        m_comments = commentService.ReadByParent(parentType, parentId);
                }
            }
            return m_comments;
        }

        protected void SaveComments(ParentType parentType, int parentId)
        {
            using (SqlConnection connection = Program.GetAppConnection())
            {
                connection.Open();
                using (var commentService = new CommentService(connection))
                    if (m_comments == null || m_comments.Count == 0)
                        commentService.DeleteByParent(parentType, parentId);
                    else
                        commentService.UpdateAll(parentType, parentId, m_comments);
            }
        }

        public void AddComment(Comment comment)
        {
            comment.Status = ChangeStatus.New;
            m_comments.Add(comment);
        }

        public void DeleteComment(Comment comment)
        {
            comment.Status = ChangeStatus.Deleted;
        }

    }

}
