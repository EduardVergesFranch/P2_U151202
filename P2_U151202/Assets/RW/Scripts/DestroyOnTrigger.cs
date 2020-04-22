using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    public string tagFilter;
    private void OnTriggerEnter (Collider other) // 1
    {
        if (other.CompareTag(tagFilter)) // 2 If the tag of the object that is colliding is the same as the one we want, destroy this object
        {
            Destroy(gameObject); // 3
        }
    }
}
