using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehavior2 : MonoBehaviour
{
    public GameObject redSphere;
    public GameObject blueSphere;
    private bool isOdd = true;
    private int index;
    private void OnEnable()
    {
        SphereBehavior.SpawnR += spawnSphere;
    }

    // Start is called before the first frame update
    void Awake()
    {
        spawnSphere();
    }

    private void spawnSphere()
    {
        //Debug.Log(index++);
        var pos = new Vector3(Random.Range(-0.75f, 0.75f), 2.0f, Random.Range(-0.75f, 0.75f));
        
        if (isOdd)
        {
            Instantiate(blueSphere, pos, Quaternion.identity);
            
        }else
        {
            Instantiate(redSphere, pos, Quaternion.identity);
        }
        
        isOdd = !isOdd;
    }
}
