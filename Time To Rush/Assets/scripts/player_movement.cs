using UnityEngine.SceneManagement ;
using UnityEngine;
using UnityEngine.UI;
public class player_movement : MonoBehaviour
{
    public Rigidbody player ;
    public float force ;
    public RectTransform Centre; 
    int points;
    public Text Score;
    
    // Update is called once per frame
    public void  Update()
    {
        
        // ? Keaboard  Controlls
        player.AddForce(Input.GetAxisRaw("Horizontal") * force * Time.deltaTime  , 0 , 0 );

        // ? Touch Controlls
        if (Input.touchCount > 0  )
        {
            Touch touch = Input.GetTouch(0);
            
            int Way =  touch.position.x  > Centre.position.x ? 1 : -1 ;
            player.AddForce( force * Time.deltaTime * Way , 0, 0);

        }

        // ? Score Counter
        points = (int) (points + (1 + Time.deltaTime));
        PlayerPrefs.SetInt("Score" , points);
        Score.text = points.ToString();
        if (PlayerPrefs.GetInt("HighScore") < points)
        {
            PlayerPrefs.SetInt("HighScore" , points);
        }
    }

    void OnCollisionExit()
    {
        SceneManager.LoadScene(sceneBuildIndex : 2 );
    }
}
