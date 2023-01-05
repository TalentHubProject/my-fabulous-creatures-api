// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Mvc;
using MyFabulousCreatures.Services;

namespace MyFabulousCreatures.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public sealed class EggController
    : ControllerBase
{
    private readonly ILogger<EggController> _logger;
    private readonly IStaticFileService _staticFileService;

    public EggController(
        ILogger<EggController> logger,
        IStaticFileService staticFileService)
    {
        _logger = logger;
        _staticFileService = staticFileService;
    }

    [HttpGet]
    public async Task<IActionResult> GetEggAsync()
    {
        var egg = await _staticFileService.GetImageFileAsync("Egg/1/egg_1f.png");
        
        if (egg is null)
        {
            return NotFound();
        }

        return File(egg.FileContents, "image/png");
    }
}