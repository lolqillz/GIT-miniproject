using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningPlatform : MonoBehaviour
{
    public GameObject Platform;

    [SerializeField]
    private float spawntime, spawnreset = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(Platform, new Vector3(0, 0, 0), Quaternion.identity);
        createplatform();
    }

    public void createplatform()
    {
        spawntime -= Time.deltaTime;
        if(spawntime <= 0)
        {
            Instantiate(Platform, transform.position, Quaternion.identity);
            spawntime = spawnreset;
        }
    }
}
