using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SubclassSandbox
{
    public abstract class Superpowers
    {
        public abstract void Activate(GameObject Player);
        
        protected void Move(GameObject Player, int speed)
        {
            Player.transform.position = new Vector3(0,speed,0);
            Debug.Log("Moving with speed ");
        }

        protected void PlaySound(string coolSound)
        {
            Debug.Log("Playing sound" +  coolSound);
        }

        public class SkyLaunch : Superpowers
        {
            public override void Activate(GameObject Player)
            {
                Move(Player, 10);
                PlaySound("SkySound");
            }
        }

        public class GroundDive : Superpowers
        {
            public override void Activate(GameObject Player)
            {
                Move(Player, 15);
                PlaySound("GroundSound");
            }
        }
    }
    
}
