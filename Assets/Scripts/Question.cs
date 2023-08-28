using UnityEngine;

[CreateAssetMenu(fileName = "NewQuestion", menuName = "Question")]
public class Question : ScriptableObject
{
    
    public string questionText;
    public string[] possibleAnswers;
    public Texture2D questionImage;
    public string[] hintTexts;
    public Texture2D[] hintImages;
}