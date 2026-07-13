namespace Arcade_Game;

public interface IDropSpecification { }

internal abstract class Collectable : GameObject
{
    public static List<Collectable> collectables = new();

    public Collectable(int startX, int startY, int width = 50, int height = 50)
    {
        this.Size = new Size(width, height);
        this.Left = startX - this.Width / 2;
        this.Top = startY - this.Height / 2;
    }

    public virtual void Move()
    {
        this.Top += 2;
    }

    public abstract void ApplyEffect();
}