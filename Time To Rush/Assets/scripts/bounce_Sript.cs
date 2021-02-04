
using UnityEngine;

public class bounce_Sript : MonoBehaviour
{
    public Rigidbody cube ;
    public float force ;
   
    public void  OnCollisionEnter()
    {
        cube.AddForce(0,force* Time.deltaTime , 0) ;
    }
  
}
