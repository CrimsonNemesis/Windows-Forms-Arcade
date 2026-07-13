namespace Arcade_Game;

public interface IDropSpecification { }

internal abstract class Collectable : GameObject
{
    public static List<Collectable> collectables = new();

    protected double exactX;
    protected double exactY;

    public Collectable(int startX, int startY, int width = 50, int height = 50)
    {
        this.Size = new Size(width, height);
        this.Left = startX - this.Width / 2;
        this.Top = startY - this.Height / 2;

        this.exactX = this.Left;
        this.exactY = this.Top;
    }

    public virtual void Move(double deltaTime)
    {
        this.exactY += 2 * deltaTime * 60.0;

        this.Top = (int)Math.Round(this.exactY);
    }

    public abstract void ApplyEffect();
}