using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerControl : MonoBehaviour
{
    [SerializeField] internal float movespeed;
    [SerializeField] GameObject timerTxtParent;
    [SerializeField] ParticleSystem playerburst;

    internal static bool left = false;
    internal static bool right = false;

    private bool StartTimer = false;
    private float timer = 5f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * movespeed);

        if(left && transform.position.x >= -1.45f)
        {
            transform.Translate(Vector3.left * Time.deltaTime * movespeed);
        }
        else if(right && transform.position.x <= 1.45f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * movespeed);
        }

        if(StartTimer)
        {
            timer -= Time.deltaTime;
            timerTxtParent.transform.GetChild(0).gameObject.GetComponent<Text>().text = ((int)timer).ToString();
        }
        if(timer <= 0)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            movespeed = 0;
            StartTimer = false;
            playerburst.Play();
            playerburst = null;
            Invoke("GameOver", 1.5f);

        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            movespeed = 0;
            playerburst.Play();
            playerburst = null;
            Invoke("GameOver", 1.5f);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "wall")
        {
            StartTimer = true;
            timer = 5f;
            timerTxtParent.SetActive(true);
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene(2);
    }
}
