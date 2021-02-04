
using UnityEngine;

public class Obstacle_Movement : MonoBehaviour
{
    public Rigidbody obsctale;


    // Start is called before the first frame update
    public void  Start()
    {
        obsctale = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void  Update()
    {
        obsctale.AddForce(0 , 0 , -500 * Time.deltaTime);
    }
}
