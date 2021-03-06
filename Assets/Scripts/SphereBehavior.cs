using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehavior : MonoBehaviour
{
    public delegate void SpawnRequired();
    public static event SpawnRequired SpawnR;

    private float curPos, prevPos;
    private bool canCall = true;

    private void FixedUpdate()
    {
        curPos = this.transform.position.y;
        if (canCall)
        {
            //Debug.Log(curPos);
            if(curPos <= 1)
            {
                callSpawnRequired();
                canCall = false;
            }
        }
        if(curPos < -1)    // while the red ball below the bottom
        {
            destroyItself();
        }
        prevPos = curPos;
    }

    private void callSpawnRequired()
    {
        if (SpawnR != null)
        {
            SpawnR();
        }
    }

    private void destroyItself()
    {
        Destroy(this.gameObject);
    }

}
