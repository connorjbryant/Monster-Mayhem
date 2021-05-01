using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public Animator animator;
    public GameObject[] explosion;
    public GameObject currentExplosion;

    private AudioSource audioSource;
    public AudioClip[] bounce;
    private AudioClip bounceClip;

    private void Start()
    {
        animator = animator.GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            //Destroy(this.gameObject);
            GameControlScript.health -= 1;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SOIC"))
        {
            animator.SetTrigger("Attack");
            print("SOIC");
            int index = Random.Range(0, 2);
            bounceClip = bounce[index];
            audioSource.clip = bounceClip;
            audioSource.Play();
        }

        else if (other.gameObject.CompareTag("Bomb"))
        {
            StartCoroutine(Explosion());
            print("Bomb");
            int index = Random.Range(0, 2);
            bounceClip = bounce[index];
            audioSource.clip = bounceClip;
            audioSource.Play();
        }
    }

    private void Update()
    {
        if(GameControlScript.health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public IEnumerator Explosion()
    {
        int index = Random.Range(0, 2);
        currentExplosion = explosion[index];
        explosion[index].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        GameControlScript.health -= 1;
    }
}
