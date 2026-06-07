# Vimonia

Vimonia is a terminal-based roguelike game inspired by Vim keybindings. Navigate through procedurally generated rooms, fight enemies using keyboard combinations, and survive the dungeon.

## Features

- **Vim-inspired Combat**: Use familiar key combinations (like `dw`) to perform skills.
- **Procedural Generation**: Every run features a unique floor layout.
- **Terminal UI**: Built using the `Sharpie` library for a rich terminal experience.
- **Minimap**: Keep track of your exploration with an integrated minimap.

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later.

### Running the Game

1. Clone the repository.
2. Navigate to the project directory.
3. Run the game using the .NET CLI:

   ```bash
   dotnet run
   ```

## Controls

- **Movement**: Standard Vim keys (`h`, `j`, `k`, `l`) or Arrow keys.
- **Skills**: Perform combinations to trigger powerful abilities.
- **Quit**: Press `q` or `Ctrl+C` to exit.

## Development

Vimonia is written in C# and utilizes the following libraries:
- [Sharpie](https://github.com/sh4rpie/sharpie): A high-level Curses wrapper for .NET.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
