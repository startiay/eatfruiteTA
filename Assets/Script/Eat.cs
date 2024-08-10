using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Eat : MonoBehaviour
{

    [SerializeField] Sprite[] Images;
    [SerializeField] bool eatable = true;
    // Start is called before the first frame update
    void Start()
    {
        randomImages();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void randomImages()
    {

        this.gameObject.GetComponent<SpriteRenderer>().sprite = Images[Random.Range(0, Images.Length)];
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(this.gameObject);
        if (other.gameObject.tag == "Player")
        {
            if (this.eatable)
            {
                other.gameObject.GetComponent<Player>().score += 1;
                Debug.Log(other.gameObject.GetComponent<Player>().score);
            }
            else
            {
                other.gameObject.GetComponent<Player>().health--;
                if (other.gameObject.GetComponent<Player>().health == 0)
                {
                    SceneManager.LoadScene("Game Over");
                    Destroy(other.gameObject);
                }
                else
                {
                    Debug.Log("Nhap nhay");
                    Debug.Log(other.gameObject.GetComponent<Player>().health);
                }
            }

        }
    }
}
