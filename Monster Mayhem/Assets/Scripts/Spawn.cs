using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy, enemy1;

    // Start is called before the first frame update
    void Start()
    {
        enemy.SetActive(true);
        enemy1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
