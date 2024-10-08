namespace TCS.OverlayCore.Simple {
    public struct Matrix2x2 {
        public Matrix2x2(double a11, double a12, double a21, double a22) {
            A11 = a11;
            A12 = a12;
            A21 = a21;
            A22 = a22;
        }

        public double A11 { get; }
        public double A12 { get; }
        public double A21 { get; }
        public double A22 { get; }
    }
    
        public struct Matrix3x3 {
        public Matrix3x3(
            double a11, double a12, double a13,
            double a21, double a22, double a23,
            double a31, double a32, double a33) {
            A11 = a11;
            A12 = a12;
            A13 = a13;
            A21 = a21;
            A22 = a22;
            A23 = a23;
            A31 = a31;
            A32 = a32;
            A33 = a33;
        }

        public double A11 { get; }
        public double A12 { get; }
        public double A13 { get; }
        public double A21 { get; }
        public double A22 { get; }
        public double A23 { get; }
        public double A31 { get; }
        public double A32 { get; }
        public double A33 { get; }
    }

    public struct Rectangle3D {
        public Rectangle3D(double x, double y, double z, double width, double height, double depth) {
            X = x;
            Y = y;
            Z = z;
            Width = width;
            Height = height;
            Depth = depth;
        }

        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public double Width { get; }
        public double Height { get; }
        public double Depth { get; }
    }

    public struct Triangle {
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3) {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
        }

        public double X1 { get; }
        public double Y1 { get; }
        public double X2 { get; }
        public double Y2 { get; }
        public double X3 { get; }
        public double Y3 { get; }
    }

    public struct Ellipse {
        public Ellipse(double centerX, double centerY, double radiusX, double radiusY) {
            CenterX = centerX;
            CenterY = centerY;
            RadiusX = radiusX;
            RadiusY = radiusY;
        }

        public double CenterX { get; }
        public double CenterY { get; }
        public double RadiusX { get; }
        public double RadiusY { get; }
    }
}