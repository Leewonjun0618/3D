using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float JumpPower;
    public GameObject GameOverText;
    // Start is called before the first frame update
    void Start()
    {
        GameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)){
            GetComponent<Rigidbody>().velocity = new Vector3(0,JumpPower,0);
        }
        if (this.transform.position.y > 20 || this.transform.position.y < -20)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnCollisionEnter()
    {
        GameOverText.SetActive(true);
        //SceneManager.LoadScene("GameOver");
        //Time.timeScale = 0;
    }
}
