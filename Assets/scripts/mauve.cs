using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mauve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
      
        private bool isCountingDown = false;
    private float countdownTime = 5f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Terminus") && !isCountingDown)
        {
        isCountingDown = true;}
    }

    private void Update()
    {
        if (isCountingDown)
        {
            countdownTime -= Time.deltaTime;
            if (countdownTime <= 0)
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);}
        }
    }
}


