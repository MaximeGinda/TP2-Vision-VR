using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DragonBehaviorScript : MonoBehaviour
{
    TMP_Text headText;
    public GameObject worldObject;

    // Start is called before the first frame update
    void Start()
    {
        worldObject = GameObject.Find("World");
        GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>().text = "aller voir le dragon";
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

            worldObject.SendMessage("endGame");
            Destroy(gameObject);
        }
    }
}
