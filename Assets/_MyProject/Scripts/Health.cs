using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [Header("Health Properties")]
    public Slider slider;

    [SerializeField] private int maxHealth = 100;

    public int currentHealth;
    public HealthBar healthBar;
    public Text HealthText; 
    
    /*public void update()
    {
        Debug.Log(currentHealth);
    }*/

    public void TakeDamage(int amount)
    {
        Debug.Log(currentHealth);
        Debug.Log("TakeDamage");
        currentHealth -= amount;

        HealthText.text = currentHealth.ToString();
        if (currentHealth <= 0)
        {
            //return;
            //Destroy(this.gameObject);
            GameManager.instance.Lose ();
            SceneManager.LoadScene("LoseMenu 1");
            Debug.Log("Died");
        }
        
        //healthBar.setHealth(currentHealth);

        //UpdateHealth();
    }

    private void OnEnable()
    {
        UpdateHealth();
    }

    private void UpdateHealth()
    {
        Debug.Log("UpdateHealth");
        currentHealth = maxHealth;
        //slider.value = currentHealth;
        //Debug.Log(currentHealth);
    }

}
