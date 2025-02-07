using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mauve : MonoBehaviour
{
    float temps = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        print(temps);
    }
      
    void OnCollisionEnter(Collision collision){
        print(collision.gameObject.name + " : " + collision.gameObject.tag);
        if(collision.gameObject.CompareTag("Terminus")){
          for(int i=1; i<6; i++){
            temps += Time.deltaTime;}
        Debug.Log(temps);
        if(temps == 5)
        {
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);
          print("alo");
        }
        }
    }
      
    }

