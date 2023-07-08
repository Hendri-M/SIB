using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PilihKarakter : MonoBehaviour
{
    [SerializeField] Image karakterCowo;
    [SerializeField] Image karakterCewe;
    public Sprite[] karakter;
    [SerializeField] Animator animateCowo;
    [SerializeField] Animator animateCewe;
    [SerializeField] Button btnNext;

    int pilihKarakter;

    bool karakterTerpilih;
    bool isIdle;

    private void Start()
    {
        if (!karakterTerpilih)
            btnNext.interactable = false;

        karakterCowo.sprite = karakter[pilihKarakter];
        karakterCewe.sprite = karakter[pilihKarakter+4];

        isIdle = false;
    }

    public void pilihCowo()
    {
        pilihKarakter = 0;

        isIdle = true;
        karakterTerpilih = true;
        btnNext.interactable = true;

        animateCewe.SetBool("IdleCewe", false);
        animateCowo.SetBool("IdleCowo", isIdle);

        karakterCowo.sprite = karakter[1];
        karakterCewe.sprite = karakter[4];

        saveKarakter();
    }
    
    public void pilihCewe()
    {
        pilihKarakter = 1;

        isIdle = true;
        karakterTerpilih = true;
        btnNext.interactable = true;

        animateCowo.SetBool("IdleCowo", false);
        animateCewe.SetBool("IdleCewe", isIdle);

        karakterCewe.sprite = karakter[5];
        karakterCowo.sprite = karakter[0];

        saveKarakter();
    }

    public void saveKarakter()
    {
        PlayerPrefs.SetInt("Karakter", pilihKarakter);
    }
}
