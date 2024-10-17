using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBallLogic : MonoBehaviour
{
    private Camera mainCam;

    [SerializeField] private GameObject BallPrefab;

    [SerializeField] private float ballForwardForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = FindObjectOfType<Camera>();
        UIButtonHandler.OnUIShootButtonClicked += ShootBall;
    }

    private void ShootBall()
    {
        Vector3 spawnPosition = mainCam.transform.position + mainCam.transform.forward * 0.1f;
        Quaternion spawnRotation = mainCam.transform.rotation;

        GameObject spawnedBall = Instantiate(BallPrefab,spawnPosition,spawnRotation);
        Rigidbody rb = spawnedBall.GetComponent<Rigidbody>();

        if(rb!= null)
        {
            rb.AddForce(mainCam.transform.forward * ballForwardForce);
        }

        Destroy(spawnedBall,5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
