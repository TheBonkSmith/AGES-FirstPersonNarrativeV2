using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBeanStalk : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetButtonDown("SpawnStalk"))
        {
            Debug.Log("Spawn thus boi");
        }
    }
}
