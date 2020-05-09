using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBeanStalk : MonoBehaviour
{
    [SerializeField]
    private GameObject beanStalkPrefab;

    [Tooltip("Starting point of raycast used to detect interaction")]
    [SerializeField]
    private Transform rayCastOrigin;
    RaycastHit hit;

    public Collider coll;

    //private Animator animator;

    //[SerializeField]
    //protected string displayText = nameof(InteractiveObject);
    //public virtual string DisplayText => displayText;

    void Awake()
    {
        //animator = GetComponent<Animator>();
    }

    void Start()
    {
        coll = GetComponent<Collider>();
    }
    void Update()
    {

        RaycastHit hit = GetComponent<DetectInteraction>().hitInfo;


        spawnThatStalk(hit.point);
    }

    //public virtual void InteractWith()
    //{
    //    try
    //    {
    //        //audioSource.Play();
    //    }
    //    catch (System.Exception)
    //    {

    //        throw new System.Exception("Interactive Object requires an Auidio Source Component.");
    //    }

    //    Debug.Log($"Player just interacted with {gameObject.name}.");
    //    Instantiate(beanStalkPrefab, gameObject.transform.position, Quaternion.identity);
    //}
    void spawnThatStalk(Vector3 instantiationPoint)
    {
        if (Input.GetButtonDown("SpawnStalk"))
        {

         
           Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
           RaycastHit hit;

          // if (coll.Raycast(ray, out hit, 100.0f))
           //{
                GameObject bean = Instantiate(beanStalkPrefab, instantiationPoint, Quaternion.identity);
                //transform.position = ray.GetPoint(100.0f);
          // }
          






            //Debug.Log(hit.point + "Hits a million" + "  " + instantiationPoint + " der");

            //GameObject bean = Instantiate(beanStalkPrefab, instantiationPoint, Quaternion.identity);

            //Debug.Log("Hey boi? WHere you at?" + bean.transform.position);
        }

    }
}
