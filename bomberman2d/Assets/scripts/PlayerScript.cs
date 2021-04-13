using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10f;
    private float minX = -2.55f;
    private float maxX = 2.55f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer() ;
    }

    void MovePlayer() {
        float h = Input.GetAxis("Horizontal");
        Vector2 currentPosition = transform.position;
        if(h > 0){
            currentPosition.x = currentPosition.x + speed * Time.deltaTime;
        } else if(h < 0){
            currentPosition.x = currentPosition.x - speed * Time.deltaTime;
        }

        if(currentPosition.x < minX){
            currentPosition.x = minX;
        }

        if(currentPosition.x > maxX) {
            currentPosition.x = maxX;
        }
        
        transform.position = currentPosition;
    }

    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "Bomb"){
            Time.timeScale = 0f;
        }
    }
}
