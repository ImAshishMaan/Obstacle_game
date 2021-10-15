using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitTimes = 0;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit") 
        {
            hitTimes++;
        }
        print("You've bumped into a thing this many times: "+ hitTimes);
    }
}
