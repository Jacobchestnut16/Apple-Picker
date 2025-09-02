using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject applePrefab;

    public float 
        speed = 1f, 
        leftAndRightEdge = 10f, 
        changeDirChance = 0.1f, 
        appleDropDelay = 1f;
    
    void Start()
    {
        // Start Apple Drops
        Invoke("DropApple",2f);
    }

    void Update()
    {
        // Basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        
        // Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if  (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        // else if (Random.value < changeDirChance)
        // {
        //     speed *= -1;
        // }
    }

    void FixedUpdate()
    {
        if (Random.value < changeDirChance)
        {
            speed *= -1;
        }
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }
}
