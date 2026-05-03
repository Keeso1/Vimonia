using System.Drawing;
using System.Text;
using Sharpie;
using Vimonia.Enums;
using Vimonia.Assets;

namespace Vimonia.Core;

public class TitleScreen
{
    private readonly Canvas _canvas;
    private int _selectedIndex = 0;
    private readonly string[] _options = { "Start New Game", "Exit" };

    public TitleScreen(Canvas canvas)
    {
        _canvas = canvas;
    }

    public int SelectedIndex => _selectedIndex;

    public void MoveUp()
    {
        _selectedIndex--;
        if (_selectedIndex < 0) _selectedIndex = _options.Length - 1;
    }

    public void MoveDown()
    {
        _selectedIndex++;
        if (_selectedIndex >= _options.Length) _selectedIndex = 0;
    }

    public void Render()
    {
        _canvas.Fill(new Rectangle(Point.Empty, _canvas.Size), new Rune(' '), Style.Default);
        
        var centerX = _canvas.Size.Width / 2;
        var centerY = _canvas.Size.Height / 2;

        // Draw Title
        string title = "VIMONIA";
        _canvas.Text(new Point(centerX - (title.Length / 2), centerY - 4), title, Canvas.Orientation.Horizontal, Style.Default);

        // Draw Options
        for (int i = 0; i < _options.Length; i++)
        {
            var optionText = _options[i];
            if (i == _selectedIndex)
            {
                optionText = "> " + optionText + " <";
            }
            
            _canvas.Text(
                new Point(centerX - (optionText.Length / 2), centerY + i * 2),
                optionText,
                Canvas.Orientation.Horizontal,
                i == _selectedIndex ? new Style { Attributes = VideoAttribute.Reverse } : Style.Default
            );
        }
    }
}
