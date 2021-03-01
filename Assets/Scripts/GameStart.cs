using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}