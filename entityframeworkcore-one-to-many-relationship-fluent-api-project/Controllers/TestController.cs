using entityframeworkcore_one_to_many_relationship_project.Models;
using entityframeworkcore_one_to_many_relationship_project.Repo;
using Microsoft.AspNetCore.Mvc;

namespace entityframeworkcore_one_to_many_relationship_project.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    private readonly Repository _repository;

    public TestController(Repository repository)
    {
        this._repository = repository;
    }

    [HttpGet("get-doctors")]
    public async Task<IActionResult> GetDoctors()
    {
        return Ok(await _repository.GetDoctors());
    }

    [HttpPost("add-doctor")]
    public async Task<IActionResult> AddDoctor(Doctor doctor)
    {
        await _repository.AddDoctor(doctor);
        return Ok("Successful operation");
    }

    [HttpGet("get-patients")]
    public async Task<IActionResult> GetPatients()
    {
        return Ok(await _repository.GetPatients());
    }

    [HttpPost("add-patient")]
    public async Task<IActionResult> AddPatient(Patient patient)
    {
        await _repository.AddPatient(patient);
        return Ok("Successful operation");
    }
}