using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float BottomY = -20f;
    void Update()
    {
        if (transform.position.y < BottomY)
        {
            Destroy(gameObject);
            ApplePicker applePicker = Camera.main.GetComponent<ApplePicker>();
            applePicker.AppleMissed();
        }
    }
}
