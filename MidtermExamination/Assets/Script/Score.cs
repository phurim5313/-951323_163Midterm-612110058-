using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : Singleton<Score>
{
    public Text scoreText;
    public static int score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : "+score;
        score = 0;
        
    }
    //private void OnCollisionEnter(Collision other)
    //{
      //  if (other.gameObject.name == "Ch08_nonPBR")
      //  {
     //       Destroy(gameObject);
      //      Debug.Log("coli");
      //      score += 1000;

       // }
    //}


}
