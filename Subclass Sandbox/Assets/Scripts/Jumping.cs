using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SubclassSandbox
{
    public abstract class Jumping
    {
        public abstract void Activate(GameObject Player);
        
        //Method For Jumping -------------------------------------------------------------------
        protected void Jump(GameObject Player, int speed)
        {
            Player.transform.position = new Vector3(0,speed,0);
        }

        //Method for playing a Sound ----------------------------------------------------------
        protected void PlaySound(string jumpSound)
        {
            Debug.Log(jumpSound);
        } 
    }


    //Function for Small Jump -----------------------------------------------------------------
    public class SmallJump : Jumping
    {
        public override void Activate(GameObject Player)
        {
            Jump(Player, 5);
            PlaySound("Small Sound");
        }
    }

    //Function for High Jump ------------------------------------------------------------------
    public class HighJump : Jumping
    { 
        public override void Activate(GameObject Player)
        {
            Jump(Player, 20);
            PlaySound("Big Sound");
        }
    }

}
