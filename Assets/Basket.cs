using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public ScoreCounter scoreCounter;
    void Start()
    {
        scoreCounter =  GameObject.Find("ScoreCounter").GetComponent<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePosition);
        
        Vector3 pos = transform.position;
        pos.x = mousePos3D.x;
        transform.position = pos;
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
            scoreCounter.score+=100;
            HighScore.TrySetHighScore(scoreCounter.score);
        }
    }
}
