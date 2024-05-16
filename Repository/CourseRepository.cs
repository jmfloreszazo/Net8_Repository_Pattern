﻿using Contracts;
using Entities;
using Entities.Models;

namespace Repository;

public class CourseRepository : RepositoryBase<Course>, ICourseRepository
{
    public CourseRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }
}