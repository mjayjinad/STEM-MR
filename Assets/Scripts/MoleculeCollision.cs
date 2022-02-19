using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeCollision : MonoBehaviour

{

    public GameObject ObjectToDestroy;
    public GameObject TheObject;
    public GameObject Player;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == TheObject)
        {
            ObjectToDestroy.SetActive(true);
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject == TheObject)
        {
            ObjectToDestroy.SetActive(false);
        }
    }
}



// public GameObject waterGameobject;
//public Transform earthGameobject;
   // private void Start()
  //  {
    //    Destroy (waterGameobject);
   // }
    

   // void OnCollisionEnter(Collision collision)
   // {
  //      ContactPoint contact = collision.contacts[0];
  //      Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
  //      Vector3 position = contact.point;
   //     Instantiate (earthGameobject, position, rotation);
   //     //Destroy(gameObject);
   // }

   // private void Update()
  //  {
  //      Instantiate(waterGameobject, Vector3(0, 0, 0), transform.rotation);
    //    var waterGameobject.Vector3 : Transform; Instantiate(waterGameobject, theLocation.position, transform.rotation);
   // }
//}
