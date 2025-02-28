using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class score_manager : MonoBehaviour
{
    public static score_manager instance;
    public TMP_Text score_text;
    // public Text score_text;
    int score = 0;

    // MY VARIABLES//
    public TMP_Text life_text;
    public int life = 3;
    public GameObject player;

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //score_text.text = "Points: " + score.ToString();
        //life_text.text = "Lives: " + life.ToString();

        // MY FUNC //
        updateUI();
    }

    public void addPoints()
    {
        score++;
        //score_text.text = "Points: " + score.ToString();
        
        // MY FUNC //
        updateUI();
    }
    /*
    // Update is called once per frame
    void Update(){}
    */


    // MY FUNCTIONS //
    public void addLife()
    {
        life++;
        //life_text.text = "Lives: " + score.ToString();

        // MY FUNC //
        updateUI();
    }

    // MY FUNCTIONS //
    public void subLife()
    {
        life--;
        updateUI();
        if(life <= 0)
        {
            Destroy(player);  // Hides the player
            // Alternatively: player.SetActive(false);
        }
    }
    public void updateUI()
    {
        score_text.text = "Points: " + score.ToString();
        life_text.text = "Lives: " + life.ToString();
    }
}



