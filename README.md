## Engineering Quality

Repository quality is enforced through small, reviewable changes and automated verification:

- **Continuous integration:** every push to `main` or a feature branch and every pull request to `main` restores, builds, and verifies the executable examples in Release mode.
- **Strict compilation:** CI treats compiler warnings as errors to prevent warning debt from entering the stable branch.
- **Behavior verification:** `dotnet run -- verify` exercises the example decision paths and fails fast when expected outcomes drift.
- **Documentation integrity:** Markdown links are checked automatically when documentation changes.
- **Reproducible tooling:** workflows install the .NET 10 SDK explicitly instead of relying on the runner's preinstalled SDKs.