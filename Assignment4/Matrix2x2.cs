using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Matrix2x2
    {
        double e11, e12, e21, e22;
        //Getter and setter for e11
        double E11
        {
            get { return e11; }
            set { e11 = value; }
        }
        //Getter and setter for e12
        double E12
        {
            get { return e12; }
            set { e12 = value; }
        }
        //Getter and setter for e21
        double E21
        {
            get { return e21; }
            set { e21 = value; }
        }
        //Getter and setter for e22
        double E22
        {
            get { return e22; }
            set { e22 = value; }
        }

        //defualt constructor
        public Matrix2x2()
        {
            SetIdentityMatrix();
        }

        //parameterised  constructor
        public Matrix2x2(double _e11, double _e12, double _e21, double _e22)
        {
            e11 = _e11;
            e12 = _e12;
            e21 = _e21;
            e22 = _e22;
        }

        public void SetIdentityMatrix()
        {
            e11 = e22 = 1;
            e12 = e21 = 0;
        }

        public void SetRotationMatrixInDegrees(double angle)
        {
            angle *= Math.PI / 180;
            e11 = Math.Cos(angle) * (180/Math.PI);
            e12 = -Math.Sin(angle) * (180 / Math.PI);
            e21 = Math.Sin(angle) * (180 / Math.PI);
            e22 = Math.Cos(angle) * (180 / Math.PI);
        }

        public void SetScalingMatrix(double scaleX, double scaleY)
        {
            double _e11, _e12, _e21, _e22;
            _e11 = e11 * scaleX;
            _e21 = e21 * scaleX;
            _e12 = e12 * scaleY;
            _e22 = e22 * scaleY;

            Console.WriteLine(_e11 + "    " + _e12 + "\n" + _e21 + "    " + _e22);
        }

        //Add two matrices
        public void AddMatrix(Matrix2x2 otherMatrix)
        {
            double _e11, _e12, _e21, _e22;
            _e11 = e11 + otherMatrix.e11;
            _e12 = e12 + otherMatrix.e12;
            _e21 = e21 + otherMatrix.e21;
            _e22 = e22 + otherMatrix.e22;
            Console.WriteLine(_e11 + "    " + _e12 + "\n" + _e21 + "    " + _e22);
        }

        //Subtract two matrices
        public void SubtractMatrix(Matrix2x2 otherMatrix)
        {
            double _e11, _e12, _e21, _e22;
            _e11 = e11 - otherMatrix.e11;
            _e12 = e12 - otherMatrix.e12;
            _e21 = e21 - otherMatrix.e21;
            _e22 = e22 - otherMatrix.e22;
            Console.WriteLine(_e11 + "    " + _e12 + "\n" + _e21 + "    " + _e22);
        }

    }
}
