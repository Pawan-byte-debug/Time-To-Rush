
using UnityEngine;

public class destroyer : MonoBehaviour
{
    
    public void  OnTriggerEnter(Collider other) {
        
        Destroy(other.gameObject);
    }
}