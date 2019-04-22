using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _v0._1_Galaga
{
    class Waypoint
    {
        //all angles in degrees
        //for angles 3 o'clock == 0 degrees, incrementing clockwise
        public string Type; //linear or circular
        public Point Start; //Start point of linear
        public Point End; //End point of linear 
        public Point Center; //Center point of circle
        public int Radius; //Radius of circle
        public float InitialAngle; //Starting angle of circle
        public float FinalAngle; //Ending angle of circle
        public float AngleIncrement;

        private double LinearDistance; //total linear distance between start and end point
        public double Steps; //animation cycles required to traverse entire waypoint
        public int currentStep = 0; //current animation cycle
        public float currentAngle = 0; //current circular angle

        public Waypoint(int x1, int y1, int x2, int y2) //new linear waypoint from start and end points
        {
            Type = "Linear";
            Start = new Point(x1, y1);
            End = new Point(x2, y2);

            LinearDistance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Steps = LinearDistance / 5; //subject to modification later, as a speed factor
        }

        public Waypoint(Waypoint lastPoint, int x2, int y2) //new linear waypoint, using end of previous waypoint as start
        {
            Type = "Linear";
            Start = new Point(lastPoint.End.X, lastPoint.End.Y);
            End = new Point(x2, y2);

            LinearDistance = Math.Sqrt(Math.Pow(x2 - Start.X, 2) + Math.Pow(y2 - Start.Y, 2));
            Steps = LinearDistance / 5; //subject to modification later, as a speed factor
        }

        public Waypoint(int centerX, int centerY, int r, float StartAngle, float EndAngle)
        {
            Type = "Circular";
            Radius = r;
            Center = new Point(centerX, centerY);
            InitialAngle = StartAngle;
            FinalAngle = EndAngle;
            currentAngle = StartAngle;

            End = this.GetLastCircularPoint();

            LinearDistance = (2 * Math.PI * r) * (Math.Abs(StartAngle - EndAngle) / 360);
            Steps = LinearDistance / 5; //subject to modification later, as a speed factor
            AngleIncrement = (FinalAngle - InitialAngle) / (float)Steps;
        }

        public Waypoint(Waypoint lastPoint, int centerX, int centerY, float EndAngle)
        {
            Type = "Circular";
            Start = new Point(lastPoint.End.X, lastPoint.End.Y);
            Radius = (int)Math.Sqrt(Math.Pow(Start.Y - centerY, 2) + Math.Pow(Start.X - centerX, 2));
            Center = new Point(centerX, centerY);         
            FinalAngle = EndAngle;
            End = this.GetLastCircularPoint();
            if(Start.X - centerX != 0)
            {
                currentAngle = (float)(Math.Atan2(Start.Y - centerY, Start.X - centerX) * 180 / Math.PI);
            }
            else
            {
                currentAngle = -270;
            }         
            InitialAngle = currentAngle;

            LinearDistance = (2 * Math.PI * Radius) * (Math.Abs(InitialAngle - EndAngle) / 360);
            Steps = LinearDistance / 5; //subject to modification later, as a speed factor
            AngleIncrement = (FinalAngle - InitialAngle) / (float)Steps;
        }

        public Point GetLastCircularPoint()
        {
            int tempX = Convert.ToInt32(Center.X + Radius * Math.Cos(FinalAngle / 180 * Math.PI));
            int tempY = Convert.ToInt32(Center.Y + Radius * Math.Sin(FinalAngle / 180 * Math.PI));
            return new Point(tempX, tempY);
        }
    }
}
