using UnityEngine;

public class RockPaperScissors : MonoBehaviour
{
    public int rock, paper, scissors;
    void Start()
    {
        if(gameObject.tag == "Rock")
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        if(gameObject.tag == "Paper")
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
        if(gameObject.tag == "Scissor")
        {
            GetComponent<SpriteRenderer>().color = Color.yellow;
        }
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject enemy = other.gameObject;
        if(gameObject.tag == "Rock")
        {
            switch(other.gameObject.tag)
            {
                case "Scissor":
                    enemy.GetComponent<SpriteRenderer>().color = Color.red;
                    enemy.tag = "Rock";
                break;
                case "Paper":
                    GetComponent<SpriteRenderer>().color = Color.white;
                    gameObject.tag = "Paper";
                break;

            }
        }
        if(gameObject.tag == "Paper")
        {
            switch(other.gameObject.tag)
            {
                case "Scissor":
                    GetComponent<SpriteRenderer>().color = Color.yellow;
                    gameObject.tag = "Scissor";
                break;

            }
        }
    }
}
