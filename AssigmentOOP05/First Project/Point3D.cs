using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP05.First_Project
{
    public class Point3D : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() : this(0, 0, 0) { }

        public Point3D(int x, int y) : this(x, y, 0) { }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $": ({X}, {Y}, {Z})";
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, p2))
            {
                return true;
            }

            if ((object)p1 == null || (object)p2 == null)
            {
                return false;
            }

            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Point3D p = (Point3D)obj;
            return X == p.X && Y == p.Y && Z == p.Z;
        }

        public override int GetHashCode()
        {
            return (X, Y, Z).GetHashCode();
        }

        public int CompareTo(Point3D other)
        {
            if (other == null) return 1;

            int compareX = this.X.CompareTo(other.X);
            if (compareX == 0)
            {
                return this.Y.CompareTo(other.Y);
            }

            return compareX;
        }

        public object Clone()
        {
            return new Point3D(this.X, this.Y, this.Z);
        }
    }
}
