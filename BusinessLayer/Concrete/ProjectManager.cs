using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public Project GetById(int id)
        {
            return _projectDal.GetById(id);
        }

        public List<Project> GetList()
        {
            return _projectDal.GetAll();
        }

        public List<Project> GetProjectWithImages(int id)
        {
            return _projectDal.GetListWithImages(id);
        }

        public void TAdd(Project t)
        {
            _projectDal.Insert(t);
        }

        public void TDelete(Project t)
        {
            _projectDal.Delete(t);
        }

        public void TUpdate(Project t)
        {
            _projectDal.Update(t);
        }
    }
}
