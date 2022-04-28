using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehavior : MonoBehaviour
{
    public GameObject sphere;

    private void OnEnable()
    {
        SphereBehavior.SpawnR += spawnSphere;
    }

    // Start is called before the first frame update
    void Start()
    {
        spawnSphere();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnSphere()
    {
        var pos = new Vector3(Random.Range(-0.75f, 0.75f), 2.0f, Random.Range(-0.75f, 0.75f));
        Instantiate(sphere, pos, Quaternion.identity);
    }
}
