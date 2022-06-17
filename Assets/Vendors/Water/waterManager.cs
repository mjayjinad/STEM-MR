using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterManager : MonoBehaviour
{
    public GameObject spill;
    public Vector3 spawnHere;

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        Instantiate(spill, pos, rot);
        Destroy(gameObject);
    }
}
