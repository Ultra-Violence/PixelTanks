using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private Text resultTextUI;

    private void Start() {
        Time.timeScale = 0;
    }

    public void End(string result){
        
        resultTextUI.text = result;
    }

    public void RetryBtn(){
        
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitBtn(){
        Application.Quit();
    }
}
