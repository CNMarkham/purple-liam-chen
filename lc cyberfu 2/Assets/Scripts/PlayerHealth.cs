using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxPlayerHealth = 20;
    public int currentPlayerHealth;
    public int enemyDamage = 1;

    public PlayerExplosionParticles particles;

    private Animator playerAnimator;
   
    void Start()
    {
        currentPlayerHealth = maxPlayerHealth;
        playerAnimator = GetComponent<Animator>();
        particles = GetComponent<PlayerExplosionParticles>();
    }
    
    public void HurtPlayer()
    {
        currentPlayerHealth -= enemyDamage;
        playerAnimator.SetTrigger("Hit");

        if (currentPlayerHealth <= 0)
        {
            particles.Explode();
            Invoke("ReloadScene", 2);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene("CyberFu");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HitCollider"))
        {
            HurtPlayer();
        }
    }
}
