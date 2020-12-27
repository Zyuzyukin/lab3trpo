using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public FinalScore ScoreScript;
    // Start is called before the first frame update// Start is called before the first frame update// Start is called before the first frame update
// Start is called before the first frame update
// Start is called before the first frame update// Start is called before the first frame update новая ревизия
    void Start()
    {
        ScoreScript = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<FinalScore>();
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "bird1":
                Debug.Log("+10");
                ScoreScript.sc += 10;
                Destroy(collision.gameObject);
                
                break;

            case "bird2":
                Debug.Log("+20");
                ScoreScript.sc += 20;
                Destroy(collision.gameObject);
                break;

            case "bird3":
                Debug.Log("+30");
                ScoreScript.sc += 30;
                Destroy(collision.gameObject);
                break;

            case "bird4":
                Debug.Log("+40");
                ScoreScript.sc += 40;
                Destroy(collision.gameObject);
                break;

            default:
                break;
        }
    }
}
