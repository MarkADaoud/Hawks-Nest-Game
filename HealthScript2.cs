using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript2 : MonoBehaviour
{
    public Image healthBar;
    public float max_health = 100f;
    public float cur_health = 0f;
    public bool alive = true;

    // Use this for initilization
    void Start()
    {
        cur_health = max_health;
        SetHealthBar();
    }
    void DoDamage()
    {
        TakeDamage(10f);
    }
    public void TakeDamage(float amount)
    {
        if (!alive)
        {
            return;
        }

        if ((cur_health <= 0) && (gameObject.name == "Player 2"))
        {
            cur_health = 0;
            alive = false;
            //gameObject.SetActive (false);
         
        }
        cur_health -= amount;
        SetHealthBar();
        
    }
    void Update()
    {
      
    }

    public void SetHealthBar()
    {
        float my_health = cur_health / max_health;
        healthBar.transform.localScale = new Vector3(Mathf.Clamp(my_health, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
}

