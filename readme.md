# Readme

This apps shows the environment variables of OS and NET version. 

## How to run

Run the application, Swagger should launch automatically. 
If not, navigate to `hhttps://localhost:7054/version` in your browser.
You should get results similar to this, depending on your OS and installed runtime.

```json
{
    "runtimeIdentifier": "{your-OS}-{architecture}",
    "frameworkDescription": ".NET x.x.x",
    "osArchitecture": "X64",
    "osDescription": "Microsoft Windows x.x.x",
    "processArchitecture": "{architecture}",
    "isFreeBsd": false or true,
    "isLinux": false or true,
    "isOsx": false or true,
    "isWindows": false or true
}
```