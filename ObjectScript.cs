using UnityEngine;
using System.Collections;

public class ObjectScript : MonoBehaviour
{
    float speed = 200f;
   float damage = 10f;
    // Use this for initialization
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<HealthScript2> ().TakeDamage (damage);
    }
}
