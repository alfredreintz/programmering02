using System;
using System.Numerics;
using System.Text.RegularExpressions;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace SpaceShooter;

class GameObject
{
    protected Texture2D texture;
    protected Vector2 vector;

    public GameObject(Texture2D texture, float X, float Y)
    {
        this.texture = texture;
        this.vector.X = X;
        this.vector.Y = Y;
    }

    public void Draw(SpriteBatch spritebatch)
    {
        spritebatch.Draw(texture, vector, Color.White);
    }

    public float X
    {
        get { return vector.X; }
    }

    public float Y
    {
        get { return vector.Y; }
    }

    public float Width
    {
        get { return texture.Width; }
    }

    public float Height
    {
        get { return texture.Height; }
    }
}

abstract class MovingObject : GameObject
{
    protected Vector2 speed;

    public MovingObject(Texture2D texture, float X, float Y, float speedX, float speedY) : base(texture, X, Y)
    {
        this.speed.X = speedX;
        this.speed.Y = speedY;
    }
}
