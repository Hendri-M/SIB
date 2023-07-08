using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [Header("Karakter Guru")]
    [SerializeField] private Image guru;
    [SerializeField] private Sprite[] poseGuru;

    [Header("Button")]
    [SerializeField] private Button[] soalBtn;

    [Header("Quiz")]
    [SerializeField] private List<GameObject> soalBank;
    [SerializeField] private List<GameObject> soalMuncul;

    int nomorSoal = 0;
    int random;
    void Start()
    {
        guru.sprite = poseGuru[0];
        ambilSoal();
    }

    private void Update() {
        ambilSoal();
    }

    private void ambilSoal()
    {
        for (int i = 0; i < soalBank.Count; i++)
        {
            random = Random.Range(0, soalBank.Count);
            soalMuncul.Add(soalBank[random]);
            soalBank.Remove(soalBank[random]);
        }

        soalMuncul[nomorSoal].gameObject.SetActive(true);
        soalBtn = soalMuncul[nomorSoal].GetComponentsInChildren<Button>();
    }

    private void soalSelanjutnya()
    {
        soalMuncul[nomorSoal].gameObject.SetActive(false);
        nomorSoal++;

        if (nomorSoal >= soalMuncul.Count)
        {
            Debug.Log("Quiz Selesai");
        }
        else
            soalMuncul[nomorSoal].gameObject.SetActive(true);
    }

    public void jawabBenar()
    {
        poseGuruBenar();
        StartCoroutine(delayQuiz());

        soalBtn[0].interactable = false;
        soalBtn[1].interactable = false;
    }
    public void jawabSalah()
    {
        poseGuruSalah();
        StartCoroutine(delayQuiz());

        soalBtn[0].interactable = false;
        soalBtn[1].interactable = false;
    }

    private void poseGuruBenar()
    {
        guru.sprite = poseGuru[1];
    }

    private void poseGuruSalah()
    {
        guru.sprite = poseGuru[2];
    }

    IEnumerator delayQuiz()
    {
        yield return new WaitForSeconds(5f);
        
        guru.sprite = poseGuru[0];
        soalSelanjutnya();
    }
}
