using UnityEngine;
using UnityEngine.UI;

public class ButtonsHandler : MonoBehaviour
{
    public Button buttonMenu;
    public Button buttonSound;
    public Button buttonNotes;
    
    void Start()
    {
        buttonMenu.onClick.AddListener(MenuButtonClicked);
        buttonSound.onClick.AddListener(SoundButtonClicked);
        buttonNotes.onClick.AddListener(NotesButtonClicked);
    }
    
    void MenuButtonClicked()
    {
        // İşlemler burada yapılır
    }
    
    void SoundButtonClicked()
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }
    
    void NotesButtonClicked()
    {
        // İşlemler burada yapılır
    }

    void WrongAnswersButton()
    {
        
    }
}