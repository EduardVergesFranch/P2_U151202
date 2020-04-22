using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Sheep : MonoBehaviour
{
    public GameObject sheep;
    public float runSpeed;
    public float gotHayDestroyDelay;
    private bool hitByHay;

    public float dropDestroyDelay ; // 1
    private Collider myCollider; // 2
    private Rigidbody myRigidbody;

    private SheepSpawner sheepSpawner;


    public float heartOffset; // 1
    public GameObject heartPrefab; // 2
    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<Collider>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * runSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter (Collider other) // 1
    {
        if (other.CompareTag("Hay") && !hitByHay) // 2 if a hale bale impacts with the sheep
        {
            Destroy(other.gameObject); // 3 Destroy the hale bale
            HitByHay(); // 4 
        }
        if (other.CompareTag("DropSheep"))
        {
            Drop();
        }

    }
    private void Drop()
    {
        GameStateManager.Instance.DroppedSheep();
        SoundManager.Instance.PlaySheepDroppedClip();
        
        myRigidbody.isKinematic = false; // 1
        myCollider.isTrigger = false; // 2 Make the sheep become sensible to gravity and fall
        
        Destroy(gameObject, dropDestroyDelay ); // 3 Destroy the object after some delay
        sheepSpawner.RemoveSheepFromList(gameObject);
    }

    private void HitByHay()
    {
        GameStateManager.Instance.SavedSheep();
        SoundManager.Instance.PlaySheepHitClip();
        Instantiate(heartPrefab, transform.position + new Vector3(0, heartOffset, 0), Quaternion.identity);
        TweenScale tweenScale = gameObject.AddComponent<TweenScale>();; // 1
        tweenScale.targetScale = 0; // 2
        tweenScale.timeToReachTarget = gotHayDestroyDelay; // 3
        sheepSpawner.RemoveSheepFromList(gameObject);
        hitByHay = true; // 1
        runSpeed = 0; // 2
        Destroy(gameObject, gotHayDestroyDelay); // 3
    }
    public void SetSpawner(SheepSpawner spawner)
    {
        sheepSpawner = spawner;
        
    }

}
