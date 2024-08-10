using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject Player;
    public int scoreNumber = 0;
    public int healthNumber;
    public Text textScore;
    public Text textHealth;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreNumber = Player.gameObject.GetComponent<Player>().score;
        healthNumber = Player.gameObject.GetComponent<Player>().health;
        textScore.text = "Score: " + scoreNumber;
        textHealth.text = " x " + healthNumber;
    }
}
