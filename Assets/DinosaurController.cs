using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DinosaurController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce = 5f;
    private bool isGameOver = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!isGameOver && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        isGameOver = true;
        rb.velocity = Vector2.zero; // Detiene el movimiento del dinosaurio

        // Reinicia la escena después de un breve retraso
        Invoke("RestartGame", 1f);
    }

    private void RestartGame()
    {
        // Recarga la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


