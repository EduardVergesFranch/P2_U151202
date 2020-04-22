using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayMachine : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed;
    public float horizontalBoundary ;

    public GameObject hayBalePrefab;
    public Transform haySpawnpoint;
    public float shootInterval;
    private float shootTimer;
    public Transform modelParent; // 1

    // 2
    public GameObject blueModelPrefab;
    public GameObject yellowModelPrefab;
    public GameObject redModelPrefab;

    void Start()
    {
        LoadModel();
    }
    private void LoadModel()
    {
        Destroy(modelParent.GetChild(0).gameObject); // 1

        switch (GameSettings.hayMachineColor) // 2
        {
            case HayMachineColor.Blue:
                Instantiate(blueModelPrefab, modelParent);
            break;

            case HayMachineColor.Yellow:
                Instantiate(yellowModelPrefab, modelParent);
            break;

            case HayMachineColor.Red:
                Instantiate(redModelPrefab, modelParent);
            break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
        UpdateShooting();
    }
    private void UpdateMovement()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal"); // 1 Left or Right keys of the keyboard (-1 or 1)

        if (horizontalInput < 0 && transform.position.x > -horizontalBoundary) // 2 Move left
        {
            transform.Translate(transform.right * - movementSpeed * Time.deltaTime);
        }
        else if (horizontalInput > 0 && transform.position.x < horizontalBoundary) // 3 Move Right
        {
            transform.Translate(transform.right * movementSpeed * Time.deltaTime);
        }
    }
    private void UpdateShooting()
    {
        shootTimer -= Time.deltaTime;
        if (shootTimer <= 0 && Input.GetKey(KeyCode.Space)) 
        {
            shootTimer = shootInterval;
            ShootHay();
        }
    }
    private void ShootHay()
    {
        SoundManager.Instance.PlayShootClip();
        Instantiate(hayBalePrefab, haySpawnpoint.position, Quaternion.identity);
    }

}
