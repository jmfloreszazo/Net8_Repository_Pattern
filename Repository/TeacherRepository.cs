using Contracts;
using Entities;
using Entities.Models;

namespace Repository;

public class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
{
    public TeacherRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }
}