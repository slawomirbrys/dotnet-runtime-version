using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace dotnet_runtime_version.Controllers
{
    public class TestController : Controller
    {
        [HttpGet("/version")]
        public async Task<ActionResult> GetVersion()
        {
            var result = new
            {
                RuntimeIdentifier = RuntimeInformation.RuntimeIdentifier,
                FrameworkDescription = RuntimeInformation.FrameworkDescription,
                OSArchitecture = RuntimeInformation.OSArchitecture.ToString("F"),
                OSDescription = RuntimeInformation.OSDescription,
                ProcessArchitecture = RuntimeInformation.ProcessArchitecture.ToString("F"),
                IsFreeBsd = RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD),
                IsLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux),
                IsOsx = RuntimeInformation.IsOSPlatform(OSPlatform.OSX),
                IsWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows),
            };

            return Ok(result);
        }
    }
}
