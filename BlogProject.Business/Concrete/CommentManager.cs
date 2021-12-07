using BlogProject.Business.Abstract;
using BlogProject.DataAccess.Abstract;
using BlogProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDAL _commentDAL;
        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public void AddComment(Comment comment)
        {
            _commentDAL.Add(comment);
        }

        public List<Comment> GetAll(int id)
        {
            return _commentDAL.GetAll(x => x.ArticleID == id);
        }
    }
}
