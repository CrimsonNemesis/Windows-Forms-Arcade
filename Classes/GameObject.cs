namespace Arcade_Game;

public class GameObject
{
    private Rectangle _bounds;

    public Image Image { get; set; }
    public bool Visible { get; set; } = true;

    public Rectangle Bounds
    {
        get => _bounds;
        set => _bounds = value;
    }

    public Size Size
    {
        get => _bounds.Size;
        set => _bounds = new Rectangle(_bounds.Location, value);
    }

    public Point Location
    {
        get => _bounds.Location;
        set => _bounds = new Rectangle(value, _bounds.Size);
    }

    public int Left
    {
        get => _bounds.X;
        set => _bounds.X = value;
    }

    public int Top
    {
        get => _bounds.Y;
        set => _bounds.Y = value;
    }

    public int Width
    {
        get => _bounds.Width;
        set => _bounds.Width = value;
    }

    public int Height
    {
        get => _bounds.Height;
        set => _bounds.Height = value;
    }
    public int Right => _bounds.Right;
    public int Bottom => _bounds.Bottom;

    public void Draw(Graphics g)
    {
        if (!Visible || Image == null) return;
        g.DrawImage(Image, _bounds);
    }
}