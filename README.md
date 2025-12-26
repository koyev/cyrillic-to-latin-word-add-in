# Cyrillic to Latin Word Add-In

[![GitHub Release](https://img.shields.io/github/v/release/koyev/cyrillic-to-latin-word-add-in?label=release&style=flat-square)](https://github.com/koyev/cyrillic-to-latin-word-add-in/releases) [![License](https://img.shields.io/badge/license-MIT-green?style=flat-square)](https://github.com/koyev/cyrillic-to-latin-word-add-in/blob/main/LICENSE.txt) [![GitHub Issues](https://img.shields.io/github/issues/koyev/cyrillic-to-latin-word-add-in?style=flat-square)](https://github.com/koyev/cyrillic-to-latin-word-add-in/issues) [![GitHub Pull Requests](https://img.shields.io/github/issues-pr/koyev/cyrillic-to-latin-word-add-in?style=flat-square)](https://github.com/koyev/cyrillic-to-latin-word-add-in/pulls)

## About

This is a Add-In for Microsoft Word that provides seamless conversion of Cyrillic text to Latin and vice versa. Perfect for users working with multilingual documents or migrating content between writing systems.

**Features:**

- ✨ One-click conversion of selected Cyrillic text to Latin
- 🎯 Preserves text formatting and document structure
- 🔄 Bidirectional conversion support (Cyrillic ↔ Latin)
- 📱 Works on both Word Desktop and Word Online

## Supported Versions

| Platform         | Versions                  | Status         |
| ---------------- | ------------------------- | -------------- |
| **Word Desktop** | 2016, 2019, Microsoft 365 | ✅ Supported   |
| **Word Online**  | Current version           | 🚧 Coming Soon |

## Getting Started

Jump to:

- [Installation (Word Desktop)](#installation-word-desktop)
- [Installation (Word Online)](#installation-word-online)
- [Usage](#usage)

### Installation (Word Desktop)

1. **Download the Add-In**

   - Visit the [Releases](https://github.com/koyev/cyrillic-to-latin-word-add-in/releases) page
   - Download the latest version

2. **Install in Word Desktop**

   - Extract the downloaded files
   - Open Word
   - Go to **File** → **Options** → **Trust Center** → **Trust Center Settings** → **Trusted Add-In Catalogs**
   - Add the manifest URL or install manually through the add-in store

### Installation (Word Online)

1. **Download the Add-In**

   - Visit the [Releases](https://github.com/koyev/cyrillic-to-latin-word-add-in/releases) page
   - Download the latest version

2. **Install in Word Online**
   - Open your document in Word Online
   - Click **Insert** → **Get Add-Ins** → **My Add-Ins** → **Upload My Add-In**
   - Select the manifest file

<!-- System Requirements removed as requested -->

## Usage

### Basic Conversion

1. Open your document in Microsoft Word
2. Select the text you want to convert from Cyrillic to Latin
3. Click the **Convert** button in the Word ribbon
4. Your text will be instantly converted

### Supported Character Mappings

The add-in supports comprehensive Cyrillic to Latin conversion including:

- Standard letters (А-Я, а-я)
- Special characters (Ђ/Đ, Љ/Lj, Њ/Nj, Ћ/Ć, Џ/Dž, Ж/Ž, Ш/Š, Ч/Č)
- Preserves numbers and punctuation

### Example

**Input (Cyrillic):**

```text
Ћуд је женска смијешна работа!
```

**Output (Latin):**

```text
Ćud je ženska smiješna rabota!
```

## Support & Contribution

💖 **Love this project?** Consider supporting it by:

- ⭐ Giving it a star on [GitHub](https://github.com/koyev/cyrillic-to-latin-word-add-in)
- 🐛 [Reporting issues](https://github.com/koyev/cyrillic-to-latin-word-add-in/issues)
- 🤝 [Contributing code improvements](CONTRIBUTING.md)
- 💬 [Sharing feedback and suggestions](https://github.com/koyev/cyrillic-to-latin-word-add-in/discussions)

### Donate

If you find this add-in helpful and would like to support its development:

[![Buy Me A Coffee](https://img.shields.io/badge/buy%20me%20a%20coffee-donate-yellow?style=flat-square)](https://buymeacoffee.com)
[![OpenCollective](https://img.shields.io/badge/open%20collective-donate-blue?style=flat-square)](https://opencollective.com)

Your support helps ensure continued maintenance and new features!

## Frequently Asked Questions

**Q: Is my data safe?**  
A: Yes! This add-in works entirely within your document. No data is sent to external servers.

**Q: Can I undo a conversion?**  
A: Yes, use Ctrl+Z (Cmd+Z on Mac) to undo any conversion.

**Q: Does it work offline?**  
A: Word Desktop version works offline. Word Online requires internet connectivity.

**Q: What about other Cyrillic languages?**  
A: The add-in is primarily designed for Serbian conversion. Feel free to test & contribute mappings for other languages!

## Additional Resources

- 📖 [Documentation](https://github.com/koyev/cyrillic-to-latin-word-add-in/wiki)
- 🐛 [Report Issues](https://github.com/koyev/cyrillic-to-latin-word-add-in/issues)
- 💭 [Discussions](https://github.com/koyev/cyrillic-to-latin-word-add-in/discussions)
- 🤝 [Contributing Guide](CONTRIBUTING.md)

## License

MIT — see [LICENSE.txt](LICENSE.txt).
