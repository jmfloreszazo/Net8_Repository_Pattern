namespace Contracts;

public interface IRepositoryWrapper
{
    ICourseRepository Course { get; }
    ITeacherRepository Teacher{ get; }
    void Save();
}