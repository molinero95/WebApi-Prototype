using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.DAOs;

namespace Application.Data.Services
{
    public class DAOServiceImp : DAOService
    {
        internal DAOServiceImp() { }
        public override IDAO GetDAO(ApplicationDAOs applicationDAO)
        {
            switch (applicationDAO)
            {
                case ApplicationDAOs.ArticleDAO: return new ArticleDAO();
                case ApplicationDAOs.ContainerDAO: return new ContainerDAO();
                default: return null;
            }
        }
    }
}
