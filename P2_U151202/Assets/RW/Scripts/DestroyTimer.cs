using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeToDestroy;
    void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
}
