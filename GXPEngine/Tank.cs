using GXPEngine;
using GXPEngine.Core;
using GXPEngine.Managers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Tank : Sprite
    {

    
    float speed;

    bool TurnLeft;
    bool TurnRight;
    public Tank() : base("tanktesting.png")
    {
      speed = 1;
      scale = 0.1f;
       SetOrigin(width / 2, height / 2);
      SetXY(100, 100);

     

    }

    void Update()
    {
        TracksInput();
        LocationUpdate();

        PathTrace Line = new PathTrace(this.x, this.y);
        
    }

    // Set bools
    void TracksInput()
    {
        if (Input.GetKey(Key.D)){
            TurnLeft = true;
            Console.WriteLine("D key down");
        }

        if (Input.GetKey(Key.A)){
            TurnRight = true;
            Console.WriteLine("A ket down");
        }
    }

    
    void LocationUpdate()
    {
        if (TurnLeft && TurnRight)
        {
            Move(1, 0);
            
        }else if (TurnRight)
        {
            Turn(-1);
            Move(0.5f, 0);

        }else if (TurnLeft)
        {
            Turn(1);
            Move(0.5f, 0);
        }
        TurnLeft = false;
        TurnRight = false;

        
    }
    }

