using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    Rigidbody2D rb;
    public bool isDead;
    public GameObject restartButton; 
    [SerializeField] float forceSpeed;
    public GameObject gameOver;
    public GameObject menuBut;
    int score;
    public TMP_Text scoreText;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        isDead = false;
        gameOver.SetActive(false);
        restartButton.SetActive(false);
        menuBut.SetActive(false);
    }

    
    void Update()
    {
        scoreText.text = score.ToString();
        if (!isDead)
        {
            if (Input.GetButtonDown("Jump"))
            {
                Jumping();
            }
        }
        else
        {
            gameOver.SetActive(true);
            restartButton.SetActive(true);
            menuBut.SetActive(true);
        }
    }
    void Jumping()
    {
        rb.AddForce(Vector2.up * forceSpeed,ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ground" || other.gameObject.tag == "Pipe")
        {
            isDead = true;
        }
        if(other.gameObject.tag == "ScoreArea")
        {
            score++;
        }
    }
    public void RestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

}
