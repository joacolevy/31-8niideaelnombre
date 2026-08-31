using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorScript : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){

            GameObject clon;
            clon = Instantiate (prefab, spawnPoint.position, Quaternion.identity);
         Destroy(clon, 1);
        }
    }
}
