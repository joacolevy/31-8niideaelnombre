using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnPoint;
    public bool isActive = false;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive){
            Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        }

        void OnCollisionEnter(Collision Col){
            
            isActive = true;
        }
    }
}
