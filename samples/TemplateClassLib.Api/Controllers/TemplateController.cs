using JacksonVeroneze.NET.TemplateClassLib.Interfaces;
using JacksonVeroneze.NET.TemplateClassLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace TemplateClassLib.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TemplateController : ControllerBase
{
    private readonly ITemplateService _service;

    public TemplateController(
        ITemplateService service)
    {
        _service = service;
    }

    [HttpGet("/{id}")]
    public async Task<IActionResult> GetAsync(
        string id, CancellationToken cancellationToken)
    {
        TemplateModel? result = await _service
            .GetByIdAsync(id, cancellationToken)
            .ConfigureAwait(false);

        return result is null ? NotFound() : Ok(result);
    }
}