using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehaviorScript : MonoBehaviour
{
    private AudioSource collisionSound;

    [SerializeField]
    private GameObject fx;

    public GameObject worldObject;


    // Start is called before the first frame update
    void Start()
    {
        worldObject = GameObject.Find("World");
        collisionSound = GameObject.Find("World").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    { 
        // OnCollisionEnter 
        if (other.tag == "Player")
        {
            if (collisionSound)
            {
                collisionSound.Play();
            }

            worldObject.SendMessage("AddHit");
            Instantiate(fx, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
