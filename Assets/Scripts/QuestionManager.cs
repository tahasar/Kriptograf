using System;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    public List<Question> questions;
    private Question activeQuestion;

    void Start()
    {
        // başlangıçta soruları ayarlama
        if (questions.Count > 0)
        {
            activeQuestion = questions[0];
        }
    }

    public void NextQuestion()
    {
        int index = questions.IndexOf(activeQuestion);

        if (index < questions.Count - 1)
        {
            activeQuestion = questions[index + 1];
        }
        else
        {
            Debug.Log("End of Questions");
        }
    }
    
    // ... other game management code goes here
}