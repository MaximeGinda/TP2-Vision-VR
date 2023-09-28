using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIBehaviorScript : MonoBehaviour
{
    TMP_Text headText;
    TMP_Text timeText;
    TMP_Text winText;

    private int nbCats = 0;

    // Start is called before the first frame update
    void Start()
    {
        headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
        timeText = GameObject.Find("lblTime").GetComponent<TMPro.TMP_Text>();
        winText = GameObject.Find("lblWin").GetComponent<TMPro.TMP_Text>();
        StartCoroutine(TimerTick());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddHit()
    {
        nbCats++;
        headText.text = "BobHeads: " + nbCats;

        if(nbCats == 10)
        {
            SceneManager.LoadScene("Scene2");
        }
            
    }

    public void endGame()
    {
        winText.text ="Bravo tu as gagné !";
    }

    IEnumerator TimerTick()
    {
        while (GameVariables.currentTime > 0)
        {
            // attendre une seconde
            yield return new WaitForSeconds(1);
            GameVariables.currentTime--;
            timeText.text = "Time :" + GameVariables.currentTime.ToString();
        }
        // game over
        SceneManager.LoadScene("Scene1"); 
    }
}
