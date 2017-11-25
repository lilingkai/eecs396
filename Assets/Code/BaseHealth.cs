using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BaseHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;

    // Use this for initialization
    void Start()
    {
        healthSlider.value = startingHealth;
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage (int amount)
    {
        currentHealth -= amount;
        healthSlider.value = currentHealth;
        print(currentHealth);
    }
}
