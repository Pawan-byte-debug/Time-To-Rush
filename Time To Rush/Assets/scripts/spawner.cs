
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject obstacle ;
    public void  Start()
    {
        
        spawn();
        spawn();
        spawn();
        spawn();
    }

    // Update is called once per frame

    int hit_time;
    public void  OnTriggerEnter()
    {
        if (hit_time%3 == 0 )
        {
            spawn();
            spawn();
            spawn();
        }
        hit_time +=1 ;

    }
    public void  spawn()
    {
        Vector3 position = new Vector3 ((Random.Range(-12.2f , 12.2f)) , 1 , Random.Range(0 , 49));
        GameObject obs =  Instantiate(obstacle , position , Quaternion.identity);
        obs.AddComponent<Obstacle_Movement>();
    }
}
