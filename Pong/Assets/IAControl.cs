using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAControl : MonoBehaviour
{
    public GameObject ball;
    public GameObject ball1;
    public Rigidbody2D rb2d;
    public float boundY = 2.25f;

    void SegueBola(){
        Vector2 pos;
        pos.y = rb2d.position.y;
        pos.x = rb2d.position.x;
        if(ball.transform.position.y > pos.y && ball.transform.position.x < 0 || ball1.transform.position.y > pos.y && ball1.transform.position.x < 0 ){
            pos.y += 0.05f;
        }
        if(ball.transform.position.y < pos.y && ball.transform.position.x < 0 || ball1.transform.position.y < pos.y && ball1.transform.position.x < 0){
            pos.y -= 0.05f;
        }
        transform.position = pos; 
    }

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindWithTag("Ball");
        ball1 = GameObject.FindWithTag("Ball1");
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        SegueBola();

        var pos = transform.position;
    	if (pos.y > boundY) {
        	pos.y = boundY;
    	}
    	else if (pos.y < -boundY) {
        	pos.y = -boundY;
    	}
    	transform.position = pos;
    }
}
