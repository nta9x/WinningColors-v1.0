using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour
{
    public float jumpForce = 7f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    public string currentColor;

    public Color colorBlue;
    public Color colorYellow;
    public Color colorPurple;
    public Color colorPink;
    private void Start()
    {
        setRandomColor();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
        //if()
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != currentColor)
        {
            Debug.Log("game over");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void setRandomColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0:
                currentColor = "Blue";
                sr.color = colorBlue;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Purple";
                sr.color = colorPurple;
                break;
            case 3:
                currentColor = "Pink";
                sr.color = colorPink;
                break;

        }
    }
}
