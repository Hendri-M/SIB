using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadKarakter : MonoBehaviour
{
    [SerializeField] Image karakter;
    [SerializeField] Sprite[] pose;

    int pilihKarakter;

// TIDAK DI PAKAI SCRIPT INI
    
    void Start()
    {
        pilihKarakter = PlayerPrefs.GetInt("Karakter");

        if (pilihKarakter == 0)
        {
            karakter.sprite = pose[0];
        }

        if (pilihKarakter == 1)
        {
            karakter.sprite = pose[4];
        }
    }

}
