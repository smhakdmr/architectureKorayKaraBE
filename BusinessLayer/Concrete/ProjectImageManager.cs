using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProjectImageManager : IProjectImageService
    {
        IProjectImageDal _projectImageDal;

        public ProjectImageManager(IProjectImageDal projectImageDal)
        {
            _projectImageDal = projectImageDal;
        }

        public ProjectImage GetById(int id)
        {
            return _projectImageDal.GetById(id);
        }

        public List<ProjectImage> GetList()
        {
            return _projectImageDal.GetAll();
        }

        public void TAdd(ProjectImage t)
        {
            _projectImageDal.Insert(t);
        }

        public void TDelete(ProjectImage t)
        {
            _projectImageDal.Delete(t);
        }

        public void TUpdate(ProjectImage t)
        {
            _projectImageDal.Update(t);
        }
    }
}
