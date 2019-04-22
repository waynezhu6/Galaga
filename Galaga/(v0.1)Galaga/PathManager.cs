using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _v0._1_Galaga
{
    class PathManager : Path
    {
        //generate one preset path based on enemy number
        public PathManager(int ObjectID) //ObjectID should be between 0 - 39
        {
            finished = true;
            if (ObjectID < 8) //first sub-wave of 8 enemies
            {
                Waypoint circle1, line2, circle3, line4;
                if (ObjectID <= 3) //4 enemies on the right
                {
                    circle1 = new Waypoint(300, 0, 150, -180, -250);
                    line2 = new Waypoint(circle1, 370, 185);
                    circle3 = new Waypoint(line2, 350, 240, 180);
                }
                else //4 enemies on the left
                {
                    circle1 = new Waypoint(150, 0, 150, 0, 70);
                    line2 = new Waypoint(circle1, 80, 185);
                    circle3 = new Waypoint(line2, 100, 240, -360);
                }

                int tempX, tempY;
                if (ObjectID % 2 == 0)
                {
                    tempX = 200;
                }
                else
                {
                    tempX = 230;
                }
                tempY = (int)(95 + 30 * Math.Floor((double)ObjectID / 2));

                line4 = new Waypoint(circle3, tempX, tempY);

                AddWaypoint(circle1);
                AddWaypoint(line2);
                AddWaypoint(circle3);
                AddWaypoint(line4);

            }
            else if (ObjectID >= 8 && ObjectID < 24) //second subwave of 2x8 enemies
            {
                Waypoint circle1, circle2, line3;
                if(ObjectID >= 8 && ObjectID < 16) //left side
                {
                    if(ObjectID >=8 && ObjectID < 12) //inner circle
                    {
                        circle1 = new Waypoint(0, 260, 200, -270, -360);
                        circle2 = new Waypoint(circle1, 125, 260, -360);
                        
                        line3 = new Waypoint(circle2, 170 + (ObjectID - 8) * 30, 65);
                    }
                    else //outer circle
                    {
                        circle1 = new Waypoint(0, 260, 225, -270, -360);
                        circle2 = new Waypoint(circle1, 125, 260, -360);
                        if (ObjectID % 2 == 0)
                        {
                            line3 = new Waypoint(circle2, 170, 95 + 30 * (int)Math.Floor((double)ObjectID / 14));
                        }
                        else
                        {
                            line3 = new Waypoint(circle2, 260, 95 + 30 * (int)Math.Floor((double)ObjectID /14));
                        }
                    }
                    AddWaypoint(circle1);
                    AddWaypoint(circle2);
                    AddWaypoint(line3);
                }
                else
                {
                    if (ObjectID >= 16 && ObjectID < 20) //inner circle
                    {
                        circle1 = new Waypoint(450, 260, 200, 90, 180);
                        circle2 = new Waypoint(circle1, 325, 260, 540);

                        int tempX, tempY;
                        if(ObjectID % 2 == 0)
                        {
                            tempX = 320;
                        }
                        else
                        {
                            tempX = 290;
                        }
                        tempY = (int)(95 + 30 * Math.Floor((double)ObjectID / 18));
                        line3 = new Waypoint(circle2, tempX, tempY);
                    }
                    else //outer circle
                    {
                        circle1 = new Waypoint(450, 260, 225, 90, 180);
                        circle2 = new Waypoint(circle1, 325, 260, 540);
                        int tempX, tempY;
                        if (ObjectID % 2 == 0)
                        {
                            tempX = 140;
                        }
                        else
                        {
                            tempX = 110;
                        }
                        tempY = (int)(95 + 30 * Math.Floor((double)ObjectID / 22));
                        line3 = new Waypoint(circle2, tempX, tempY);
                    }
                    AddWaypoint(circle1);
                    AddWaypoint(circle2);
                    AddWaypoint(line3);
                }         
            }
            else if (ObjectID >= 24 && ObjectID < 40) //third subwave of 2x8 enemies
            {
                Waypoint circle1, line2, circle3, line4;
                if (ObjectID >= 24 && ObjectID < 32) //8 enemies on the left
                {
                    if(ObjectID >= 24 && ObjectID < 28) //inner path
                    {
                        circle1 = new Waypoint(275, 0, 150, -180, -250);
                        line2 = new Waypoint(circle1, 345, 240);
                        circle3 = new Waypoint(line2, 325, 295, 180);

                        int tempX, tempY;
                        if (ObjectID % 2 == 0)
                        {
                            tempX = 170;
                        }
                        else
                        {
                            tempX = 140;
                        }
                        tempY = (int)(155 + 30 * Math.Floor((double)ObjectID / 26));
                        line4 = new Waypoint(circle3, tempX, tempY);
                    }
                    else //outer path
                    {
                        circle1 = new Waypoint(300, 0, 150, -180, -250);
                        line2 = new Waypoint(circle1, 370, 240);
                        circle3 = new Waypoint(line2, 350, 295, 180);

                        int tempX, tempY;
                        if (ObjectID % 2 == 0)
                        {
                            tempX = 290;
                        }
                        else
                        {
                            tempX = 260;
                        }
                        tempY = (int)(155 + 30 * Math.Floor((double)ObjectID / 30));
                        line4 = new Waypoint(circle3, tempX, tempY);
                    }                  
                }
                else //8 enemies on the right
                {
                    if (ObjectID >= 32 && ObjectID < 36) //inner path
                    {
                        circle1 = new Waypoint(175, 0, 150, 0, 70);
                        line2 = new Waypoint(circle1, 105, 240);
                        circle3 = new Waypoint(line2, 125, 295, -360);

                        int tempX, tempY;
                        if (ObjectID % 2 == 0)
                        {
                            tempX = 110;
                        }
                        else
                        {
                            tempX = 80;
                        }
                        tempY = (int)(155 + 30 * Math.Floor((double)ObjectID / 34));
                        line4 = new Waypoint(circle3, tempX, tempY);
                    }
                    else //outer path
                    {
                        circle1 = new Waypoint(150, 0, 150, 0, 70);
                        line2 = new Waypoint(circle1, 80, 240);
                        circle3 = new Waypoint(line2, 100, 295, -360);

                        int tempX, tempY;
                        if (ObjectID % 2 == 0)
                        {
                            tempX = 350;
                        }
                        else
                        {
                            tempX = 320;
                        }
                        tempY = (int)(155 + 30 * Math.Floor((double)ObjectID / 38));
                        line4 = new Waypoint(circle3, tempX, tempY);
                    }
                }

                AddWaypoint(circle1);
                AddWaypoint(line2);
                AddWaypoint(circle3);
                AddWaypoint(line4);
            }
        }

        //Generate random path for enemies breaking formation
        Random r = new Random();
        public PathManager(int initX, int initY)
        {
            //Random r = new Random();
            int lastY = initY;
            int index = 0;
            Waypoint lastPoint = null;
            Waypoint temp = null;
            int direction = r.Next(0, 2);
            int centerX = 0;
            int centerY = 0;

            while(lastY < 720) //while still on screen
            {
                int leftRadius = r.Next(60, initX + 60) / 2;
                int rightRadius = r.Next(60, 450 - initX + 60) / 2;
                int defaultRadius;

                if(leftRadius > rightRadius)
                {
                    defaultRadius = rightRadius;
                }
                else
                {
                    defaultRadius = leftRadius;
                }

                int loop = r.Next(0, 2);
                if(index == 0)
                {
                    if(direction == 0) //clockwise
                    {
                        temp = new Waypoint(initX - defaultRadius, initY, defaultRadius, 0, 90);
                        lastPoint = temp;
                        AddWaypoint(temp);
                        index += 1;
                        lastY += defaultRadius;
                        centerX = initX - defaultRadius;
                        centerY = defaultRadius;
                        direction = 1;
                        lastPoint = temp;
                    }
                    else //counterclockwise
                    {
                        temp = new Waypoint(initX + defaultRadius, initY, defaultRadius, -180, -270);
                        lastPoint = temp;
                        AddWaypoint(temp);
                        index += 1;
                        lastY += defaultRadius;
                        centerX = initX + defaultRadius;
                        centerY = defaultRadius;
                        direction = 0;
                        lastPoint = temp;
                    }                   
                }
                else
                {
                    if(direction == 0) //clockwise
                    {
                        centerY = lastPoint.Center.Y + lastPoint.Radius + defaultRadius;

                        if(loop == 0 || defaultRadius < 50 || centerY + defaultRadius > 670)
                        {
                            temp = new Waypoint(centerX, centerY, defaultRadius, 270, 450);
                        }
                        else
                        {
                            temp = new Waypoint(centerX, centerY, defaultRadius, 270, 810);
                        }
                        lastPoint = temp;
                        AddWaypoint(temp);
                        index += 1;                      
                        centerY += defaultRadius;
                        lastY = centerY + defaultRadius;
                        direction = 1;
                        lastPoint = temp;
                    }
                    else //counterclockwise
                    {
                        centerY = lastPoint.Center.Y + lastPoint.Radius + defaultRadius;

                        if(loop == 0 || defaultRadius < 50 || centerY + defaultRadius > 670)
                        {
                            temp = new Waypoint(centerX, centerY, defaultRadius, -90, -270);
                        }
                        else
                        {
                            temp = new Waypoint(centerX, centerY, defaultRadius, -90, -630);
                        }
                        lastPoint = temp;
                        AddWaypoint(temp);
                        index += 1;
                        centerY += defaultRadius;
                        lastY = centerY + defaultRadius;
                        direction = 0;
                        lastPoint = temp;
                    }
                    
                }
                
            }
            temp = new Waypoint(lastPoint.End.X, -50, initX, initY);
            AddWaypoint(temp);
        }
            
    }
}
