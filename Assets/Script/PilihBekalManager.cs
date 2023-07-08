using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PilihBekalManager : MonoBehaviour
{
    [Header("Game Object")] 
    [SerializeField] UnityEngine.GameObject panelGizi;
    [SerializeField] TMP_Text[] nilaiGizi;

    float energi;
    float protein;
    float karbohidrat;
    float lemak;

    void Start()
    {
        energi = PlayerPrefs.GetFloat("Energi");
        protein = PlayerPrefs.GetFloat("Protein");
        karbohidrat = PlayerPrefs.GetFloat("Karbohidrat");
        lemak = PlayerPrefs.GetFloat("Lemak");

        nilaiGizi[0].text = "" + energi;
        nilaiGizi[1].text = "" + protein;
        nilaiGizi[2].text = "" + karbohidrat;
        nilaiGizi[3].text = "" + lemak;
        
    }

    public void pilihBekal1()
    {
        float energiTambah = 53.2f;
        float proteinTambah = 20.5f;
        float karbohidratTambah = 80f;
        float lemakTambah = 10.5f;

        nilaiGizi[0].text = "" + (energi + energiTambah);
        nilaiGizi[1].text = "" + (protein + proteinTambah);
        nilaiGizi[2].text = "" + (karbohidrat + karbohidratTambah);
        nilaiGizi[3].text = "" + (lemak + lemakTambah);

        panelGizi.SetActive(true);
    }

}
