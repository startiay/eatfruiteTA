using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Animations;

public class Player : MonoBehaviour
{

    Animator animator;
    const int RUN = 1;
    const int IDLE = 0;
    const int HURT = 3;
    [SerializeField] private int speedMove = 5;
    public int health { get; set; }
    public int score { get; set; }
    private Vector2 pos;
    [SerializeField] private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        score = 0;
        this.animator = this.gameObject.GetComponent<Animator>();
        this.transform.position = new Vector2(0, camera.gameObject.transform.position.y - 8);
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKey("right"))
        {
           
            animator.SetInteger("animationState", RUN);
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
            
        }
        else if (Input.GetKey("left"))
        {
            animator.SetInteger("animationState", RUN);
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else 
        {
            animator.SetInteger("animationState", IDLE);
        }
        float h = Input.GetAxis("Horizontal");
        pos.x += h * speedMove * Time.deltaTime;
        pos.y = transform.position.y;
        this.transform.position = pos;
    }
}
