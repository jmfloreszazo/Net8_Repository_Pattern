using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace repository_pattern.Controllers;

[ApiController]
[Route("[controller]")]
public class MyRepositoryPatternSampleController : ControllerBase
{
    private readonly ILogger<MyRepositoryPatternSampleController> _logger;
    private readonly IRepositoryWrapper _repositoryWrapper;

    public MyRepositoryPatternSampleController(ILogger<MyRepositoryPatternSampleController> logger,
        IRepositoryWrapper repositoryWrapper)
    {
        _logger = logger;
        _repositoryWrapper = repositoryWrapper;
    }

    [HttpGet]
    public string Get()
    {
        var courses = _repositoryWrapper.Course.FindByCondition(x => x.CourseName.Equals("DDD"));
        var teacher = _repositoryWrapper.Teacher.FindAll();
        return "OK";
    }
}