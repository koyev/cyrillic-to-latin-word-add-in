# Contributing

We're excited that you're interested in contributing to the Cyrillic to Latin Word Plug-In! This document provides guidelines and instructions for contributing to the project.

## Table of contents

- [Setting Up the Environment](#setting-up-the-environment)
- [Building and Testing](#building-and-testing)
- [Submitting a Pull Request](#submitting-a-pull-request)
- [Commit Message Guidelines](#commit-message-guidelines)
- [Code of Conduct](#code-of-conduct)

## Setting Up the Environment

### Prerequisites

Before you start, ensure you have the following installed:

- **Visual Studio 2019 or later** (Community, Professional, or Enterprise edition)
- **.NET Framework 4.7.2 or higher**
- **Git** for version control
- **Office Developer Tools for Visual Studio** (required for VSTO development)

### Steps to Set Up

1. **Clone the repository**

   ```bash
   git clone https://github.com/koyev/cyrillic-to-latin-word-add-in.git
   cd cyrillic-to-latin-word-add-in
   ```

2. **Open the solution in Visual Studio**

   - Open `CyrillicToLatinWordPlugIn.sln` in Visual Studio
   - Visual Studio should automatically restore any required NuGet packages

3. **Install Office Developer Tools (if needed)**

   - In Visual Studio, go to **Tools** → **Get Tools and Features**
   - Search for "Office Developer Tools"
   - Install if not already present
   - Restart Visual Studio after installation

4. **Configure the Project**
   - Right-click on the `CyrillicToLatinWordPlugIn` project
   - Select **Properties**
   - Verify that the .NET Framework version is set to 4.7.2 or higher
   - Set your preferred build configuration (Debug/Release)

## Building and Testing

### Building the Project

1. **Build in Visual Studio**

   - Select **Build** → **Build Solution** (Ctrl+Shift+B)
   - Ensure the build completes without errors

2. **Build from Command Line**

   ```bash
   cd CyrillicToLatinWordPlugIn
   msbuild CyrillicToLatinWordPlugIn.csproj /p:Configuration=Debug /p:Platform=AnyCPU
   ```

### Running and Testing

1. **Debug the Plug-In**

   - Set `CyrillicToLatinWordPlugIn` as the startup project
   - Press F5 to start debugging
   - This will launch a test instance of Microsoft Word with the add-in loaded

2. **Manual Testing**

   - Word will open with the add-in loaded
   - Create or open a test document
   - Test the conversion functionality with Cyrillic text
   - Verify that the Convert button works correctly
   - Test both Cyrillic to Latin conversions

3. **Unit Testing** (if applicable)
   - Any unit tests should be placed in a `Tests` folder
   - Run tests using **Test** → **Run All Tests** in Visual Studio
   - Ensure all tests pass before submitting a PR

### Common Issues

**Issue:** Word doesn't load the add-in  
**Solution:** Check the Visual Studio Output window for error messages. Ensure .NET Framework 4.7.2 is installed.

**Issue:** "Could not load file or assembly" errors  
**Solution:** Clean the solution and rebuild. Delete the bin and obj folders if needed.

## Submitting a Pull Request

### Before You Submit

1. **Search for existing issues/PRs**

   - Check [GitHub Issues](https://github.com/koyev/cyrillic-to-latin-word-add-in/issues)
   - Check [GitHub Pull Requests](https://github.com/koyev/cyrillic-to-latin-word-add-in/pulls)
   - Don't duplicate existing work

2. **Create a feature branch**

   ```bash
   git checkout -b feature/your-feature-name main
   ```

   or for bug fixes:

   ```bash
   git checkout -b fix/your-bug-fix main
   ```

3. **Make your changes**

   - Keep changes focused and atomic
   - Update relevant documentation
   - Add or update comments for complex logic
   - Test your changes thoroughly

4. **Commit your changes**

   - Follow the [Commit Message Guidelines](#commit-message-guidelines)
   - Use clear, descriptive commit messages
   - Reference any related issues in commit messages

5. **Push to your fork**
   ```bash
   git push origin feature/your-feature-name
   ```

### Creating the Pull Request

1. Go to the [repository](https://github.com/koyev/cyrillic-to-latin-word-add-in)
2. Click **New Pull Request**
3. Select your branch and create a PR against `main`
4. Fill in the PR title and description
5. Reference any related issues using `#issue-number`
6. Wait for review and CI checks to complete

### PR Review Process

- At least one maintainer will review your PR
- We may request changes or ask clarifying questions
- Once approved, your PR will be merged
- Thank you for your contribution!

### After Your Pull Request Is Merged

1. **Delete your local branch**

   ```bash
   git branch -D feature/your-feature-name
   ```

2. **Delete the remote branch**

   ```bash
   git push origin --delete feature/your-feature-name
   ```

3. **Update your local main**
   ```bash
   git checkout main
   git pull upstream main
   ```

<!-- Coding Style Guidelines removed as requested -->

## Commit Message Guidelines

Use concise Conventional Commits for clarity and automation.

Format:

```
<type>/optional scope: <short imperative subject>
```

Common types: `feature`, `fix`, `docs`, `refactor`, `test`, `chore`.

Examples:

```
feature/converter: add support for Macedonian characters
fix/ui: handle selection on Word Online
docs: simplify installation steps
```

## Code of Conduct

Please see [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md).

## Questions?

- 📖 Check the [Documentation](https://github.com/koyev/cyrillic-to-latin-word-add-in/wiki)
- 💬 Open a [Discussion](https://github.com/koyev/cyrillic-to-latin-word-add-in/discussions)
- 🐛 [Report an Issue](https://github.com/koyev/cyrillic-to-latin-word-add-in/issues)

Thank you for contributing to the Cyrillic to Latin Word Plug-In! 🎉
