using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuangMakanManager : MonoBehaviour
{
    [SerializeField] UnityEngine.GameObject loadKarakter;
    [SerializeField] UnityEngine.GameObject prefabsKarakter;
    [SerializeField] Button nextButton;

    // SCRIPT INI TIDAK DIGUNAKAN

    void Start()
    {
        Instantiate(prefabsKarakter, loadKarakter.transform);

        nextButton.interactable = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
