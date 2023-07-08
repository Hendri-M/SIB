using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public TextAsset soalAsset;

    private string [] soal;
    private string [,] bagianSoal;

    public Text txtSoal, txtOpsiA, txtOpsiB;

    int indexSoal;
    int maxSoal;
    bool ambilSoal;

    // Start is called before the first frame update
    void Start()
    {
        ambilSoal = true;

        soal = soalAsset.ToString().Split('#');
        bagianSoal = new string[soal.Length, 3];

        maxSoal = soal.Length;

        olahSoal();
        tampilkanSoal();
        
    }

    private void olahSoal()
    {
        for (int i = 0; i < soal.Length; i++)
        {
            string [] tempSoal = soal[i].Split('+');

            for (int j = 0; j < tempSoal.Length; j++)
            {
                bagianSoal[i, j] = tempSoal[j];
                continue;
            }
            continue;
        }
    }

    private void tampilkanSoal()
    {
        if (indexSoal < maxSoal)
        {
            if (ambilSoal)
            {
                txtSoal.text = bagianSoal[indexSoal, 0];
                txtOpsiA.text = bagianSoal[indexSoal, 1];
                txtOpsiB.text = bagianSoal[indexSoal, 2];

                ambilSoal = false;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
