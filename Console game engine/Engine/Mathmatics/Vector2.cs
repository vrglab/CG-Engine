using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mathmatics
{
    public class Vector2 : IEquatable<Vector2>
    {
        public float x { get => X; }
        public float y { get => Y; }

        private float X = 0, Y = 0;

        public Vector2(float x = 0, float y = 0)
        {
            X = x;
            Y = y;
        }


        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            return a * t + b * (1.0f - t);
        }


        public bool Equals(Vector2 other)
        {
            if (x == other.x && y == other.y)
            {
                return true;
            }
            return false;
        }

        public override bool Equals(object? obj)
        {
            return obj is Vector2 && Equals((Vector2)obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return x + "/" + y;
        }



        public static bool operator ==(Vector2 left, Vector2 right)
        {
            return Equals(left, right);
        }
        public static bool operator !=(Vector2 left, Vector2 right)
        {
            if (left.Equals(right))
            {
                return false;
            }
            return true;
        }
        public static bool operator >=(Vector2 left, Vector2 right)
        {
            if (left.x >= right.x || left.y >= right.y)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(Vector2 left, Vector2 right)
        {
            if (left.x <= right.x || left.y <= right.y)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Vector2 left, Vector2 right)
        {
            if (left.x > right.x || left.y > right.y)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Vector2 left, Vector2 right)
        {
            if (left.x < right.x || left.y < right.y)
            {
                return true;
            }
            return false;
        }


        public static Vector2 operator +(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x + right.x, left.y + right.y);
        }
        public static Vector2 operator -(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x - right.x, left.y - right.y);
        }
        public static Vector2 operator *(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x * right.x, left.y * right.y);
        }
        public static Vector2 operator /(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x / right.x, left.y / right.y);
        }
        public static Vector2 operator %(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x % right.x, left.y % right.y);
        }

        public static Vector2 operator +(float left, Vector2 right)
        {
            return new Vector2(left + right.x, left + right.y);
        }
        public static Vector2 operator -(float left, Vector2 right)
        {
            return new Vector2(left - right.x, left - right.y);
        }
        public static Vector2 operator *(float left, Vector2 right)
        {
            return new Vector2(left * right.x, left * right.y);
        }
        public static Vector2 operator /(float left, Vector2 right)
        {
            return new Vector2(left / right.x, left / right.y);
        }
        public static Vector2 operator %(float left, Vector2 right)
        {
            return new Vector2(left % right.x, left % right.y);
        }

        public static Vector2 operator +(Vector2 left, float right)
        {
            return new Vector2(left.x + right, left.y + right);
        }
        public static Vector2 operator -(Vector2 left, float right)
        {
            return new Vector2(left.x - right, left.y - right);
        }
        public static Vector2 operator *(Vector2 left, float right)
        {
            return new Vector2(left.x * right, left.y * right);
        }
        public static Vector2 operator /(Vector2 left, float right)
        {
            return new Vector2(left.x / right, left.y / right);
        }
        public static Vector2 operator %(Vector2 left, float right)
        {
            return new Vector2(left.x % right, left.y % right);
        }

        public static Vector2 operator +(int left, Vector2 right)
        {
            return new Vector2(left + right.x, left + right.y);
        }
        public static Vector2 operator -(int left, Vector2 right)
        {
            return new Vector2(left - right.x, left - right.y);
        }
        public static Vector2 operator *(int left, Vector2 right)
        {
            return new Vector2(left * right.x, left * right.y);
        }
        public static Vector2 operator /(int left, Vector2 right)
        {
            return new Vector2(left / right.x, left / right.y);
        }
        public static Vector2 operator %(int left, Vector2 right)
        {
            return new Vector2(left % right.x, left % right.y);
        }

        public static Vector2 operator +(Vector2 left, int right)
        {
            return new Vector2(left.x + right, left.y + right);
        }
        public static Vector2 operator -(Vector2 left, int right)
        {
            return new Vector2(left.x - right, left.y - right);
        }
        public static Vector2 operator *(Vector2 left, int right)
        {
            return new Vector2(left.x * right, left.y * right);
        }
        public static Vector2 operator /(Vector2 left, int right)
        {
            return new Vector2(left.x / right, left.y / right);
        }
        public static Vector2 operator %(Vector2 left, int right)
        {
            return new Vector2(left.x % right, left.y % right);
        }
    }
}
