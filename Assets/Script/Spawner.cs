using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject WallPrefab;
    public float Interval;
    float Timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > Interval)
        {
            Timer = 0;
            transform.position = new Vector3(transform.position.x, Random.Range(-10,3), transform.position.z);
            Instantiate(WallPrefab, transform.position, transform.rotation);
            Score.score += 1;
            Interval -= 0.05f;
        }
    }
}
