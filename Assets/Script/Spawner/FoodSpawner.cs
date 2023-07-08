using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] UnityEngine.GameObject[] foods;
    // [SerializeField] GameObject[] post;
    [SerializeField] UnityEngine.GameObject foodPosition;

    // Start is called before the first frame update
    void Start()
    {
        int spawn = Random.Range(0, foods.Length);

        UnityEngine.GameObject newImage = Instantiate(foods[spawn], transform.position, Quaternion.identity);
        newImage.transform.SetParent(foodPosition.transform, true);
        // newImage.SetActive(true);
       
    }

}
