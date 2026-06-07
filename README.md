# Vimonia

Vimonia is a terminal-based roguelike game inspired by Vim keybindings. Navigate through procedurally generated rooms, fight enemies using keyboard combinations, and survive the dungeon.

## Features

- **Vim-inspired Combat**: Use vim key combinations (like `dw`) to perform skills. So far dw is the only skill.
- **Procedural Generation**: Every run features a unique floor layout.
- **Terminal UI**: Built using the `Sharpie` library.
- **Minimap**: Press 'M' to toggle minimap visibility.

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later.

### Running the Game

1. Download the executable from the release
2. Run it.

## Controls

- **Movement**: Standard Vim keys (`h`, `j`, `k`, `l`) or Arrow keys.
- **Skills**: Perform combinations to trigger abilities (currently only `dw`.
- **Quit**: Press `q` or `Ctrl+C` to exit.

## Development

Vimonia is written in C# and utilizes the following libraries:
- [Sharpie](https://github.com/pavkam/sharpie): A high-level Curses wrapper for .NET.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
