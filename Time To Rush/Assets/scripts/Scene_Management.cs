using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_Management : MonoBehaviour
{
    public Toggle mode , controlls;
       
    public GameObject Home , Settings ;
    // Start is called before the first frame update

    void quit()
    {
        PlayerPrefs.Save();
        Application.Quit();
    }
     void  Start()
    {
        Home.SetActive(true);
        Settings.SetActive(false);
       
    }



    public void  play ()
    {
        SceneManager.LoadScene(sceneBuildIndex : 1);
    }
    public void  settings()
    {
        Home.SetActive(false);
        Settings.SetActive(true);
    }

    public void  back()
    {
        Home.SetActive(true);
        Settings.SetActive(false);
    }

}
