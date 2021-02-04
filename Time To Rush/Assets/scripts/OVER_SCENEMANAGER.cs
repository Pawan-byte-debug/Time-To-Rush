using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class OVER_SCENEMANAGER : MonoBehaviour
{

    public Text Score , HighScore ;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            Score.text = PlayerPrefs.GetInt("Score").ToString();
            HighScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
        catch (System.Exception)
        {
            Debug.Log("Wow One More Error ");
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene(sceneBuildIndex : 1);
    }
    public void Home ()
    {
        SceneManager.LoadScene(sceneBuildIndex : 0);
    }

    public void Quit()
    {
        PlayerPrefs.Save();
        Application.Quit();
    }
}
