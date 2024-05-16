using Contracts;
using Entities;

namespace Repository;

public class RepositoryWrapper : IRepositoryWrapper
{
    private readonly RepositoryContext _repositoryContext;
    private ITeacherRepository _teacher;
    private ICourseRepository _course;

    public ITeacherRepository Teacher
    {
        get
        {
            if (_teacher == null) _teacher = new TeacherRepository(_repositoryContext);
            return _teacher;
        }
    }

    public ICourseRepository Course
    {
        get
        {
            if (_course == null) _course = new CourseRepository(_repositoryContext);
            return _course;
        }
    }

    public RepositoryWrapper(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
    }

    public void Save()
    {
        _repositoryContext.SaveChanges();
    }
}