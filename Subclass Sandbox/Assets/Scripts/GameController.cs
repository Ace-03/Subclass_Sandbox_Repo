using SubclassSandbox;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SubclassSandbox.Superpowers;

public class GameController : MonoBehaviour
{
    List<Superpowers> sup = new List<Superpowers>();

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        sup.Add(new SkyLaunch());
        sup.Add(new GroundDive());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            sup[0].Activate(Player);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            sup[1].Activate(Player);
        }
    }
}
