// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using System.Linq;
// using UnityEngine.SceneManagement;

// public class QuizManager : MonoBehaviour
// {
//     [SerializeField] GameObject quiz;
//     [SerializeField] GameObject[] questions;

//     private static List<GameObject> unansweredQuestions;
//     private GameObject currentQuestions;


//     void Start()
//     {

//         if (unansweredQuestions == null || unansweredQuestions.Count == 0)
//         {
//             unansweredQuestions = questions.ToList<GameObject>();
//         }

//         randomQuestions();
//     }

//     private void randomQuestions()
//     {
//         int question = Random.Range(0, unansweredQuestions.Count);
//         currentQuestions = unansweredQuestions[question];

//         quiz = currentQuestions;

//         // unansweredQuestions.RemoveAt(question);
//     }

//     IEnumerator nextQuestions()
//     {
//         unansweredQuestions.Remove(currentQuestions);

//         yield return new WaitForSeconds(1f);
//         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//     }

//     public void trueAnswers()
//     {
//         Debug.Log("Jawaban Benar");
    
//         StartCoroutine(nextQuestions());
//     }
//     public void falseAnswers()
//     {
//         Debug.Log("Jawaban Salah");

//         StartCoroutine(nextQuestions());
//     }
// }
