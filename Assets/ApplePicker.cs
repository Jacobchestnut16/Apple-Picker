using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject basketPrefab;

    public int numBaskets = 3;
    public float basketBottomY = -14f, basketSpacingY = 2f;
    public List<GameObject> baskets = new List<GameObject>();
    
    void Start()
    {
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject basket = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (i * basketSpacingY);
            basket.transform.position = pos;
            baskets.Add(basket);
        }
    }

    public void AppleMissed()
    {
        GameObject[] appleArr =  GameObject.FindGameObjectsWithTag("Apple");
        foreach (var temp in appleArr)
        {
            Destroy(temp);
        }
        int basketIndex = baskets.Count - 1;
        Destroy(baskets[basketIndex]);
        baskets.RemoveAt(basketIndex);

        if (baskets.Count == 0)
        {
            SceneManager.LoadScene("AppleTreeMain");
        }
    }

}
