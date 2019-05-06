using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject treeB;

    public float tTime = 2f;

    public BirdBehaviour doa;

    private Scene scene;

    public Text text;

    public Text sc;

     float score; 
     float pointIncreasePerSecond;
    // Start is called before the first frame update

    void awake()
    {
        text = GetComponent<Text>();
        sc = GetComponent<Text>();
    }
    void Start()
    {
        text.enabled = false;
        score = 0f;
        pointIncreasePerSecond = 100f;
        sc.enabled = true;
        scene = SceneManager.GetActiveScene();
        InvokeRepeating("respawn", 0, tTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        sc.text = "Score= " + score.ToString();
        
        if(doa.dead)
        {
            UpdateScore();
            sc.text = "Score= " + score.ToString();
             text.enabled = true;



            if(Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    void respawn()
    {
        if(doa.dead == false)
        {
            AddScore();
            GameObject tBranch = Instantiate(treeB, new Vector3(24.33f, transform.position.y, transform.position.z),Quaternion.identity);
        }
    }

      public void AddScore ()
    {
        score += pointIncreasePerSecond + Time.deltaTime;
        UpdateScore ();
    }

    void UpdateScore ()
    {
        sc.text = "Score: " + score;
    }
}
