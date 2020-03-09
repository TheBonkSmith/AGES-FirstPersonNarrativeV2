using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectInteraction : MonoBehaviour
{
    [Tooltip("Starting point of raycast used to detect interaction")]
    [SerializeField]
    private Transform rayCastOrigin;

    [Tooltip("Search range for interaction")]
    [SerializeField]
    private float maxRange = 5.0f;


    
    void Start()
    {
        
    }


    private void FixedUpdate()
    {
        Debug.DrawRay(rayCastOrigin.position, rayCastOrigin.forward * maxRange, Color.red);
        RaycastHit hitInfo;
        bool objectWasDetected = Physics.Raycast(rayCastOrigin.position, rayCastOrigin.forward, out hitInfo, maxRange);

        if(objectWasDetected)
        {
            Debug.Log($"Player is looking at: { hitInfo.collider.gameObject.name}");
        }
        
    }
}
