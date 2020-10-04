using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotateSpeed = 10f;

    public GameObject CatchEffect;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerManager.numberOfCoins++;
            FindObjectOfType<AudioManager>().PlaySound("PickUpCoin");
            Instantiate(CatchEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }

}
