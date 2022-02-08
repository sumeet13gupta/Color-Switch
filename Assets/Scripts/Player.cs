using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Player : MonoBehaviour
{
    public float jumpForce = 10f;
 
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    public string currentColor;
	public Color colorRed;
	public Color colorGreen;
	public Color colorBlue;
	public Color colorPink;
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("bm");
        SetRandomColor();
    }
    // Update is called once per frame
    void Update()
    {
        if ( Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            FindObjectOfType<AudioManager>().Play("thrust");
            rb.velocity = Vector2.up * jumpForce;
        }
    }
    void OnTriggerEnter2D(Collider2D cd)
    {
        Debug.Log(cd.tag);
        if(cd.tag == "ColorChanger")
        {
            SetRandomColor();
            Destroy(cd.gameObject);
            return;
        }
        if(cd.tag == "Finish")
        {
            //SceneManager.LoadScene(0);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            return;
        }
        if(cd.tag != currentColor )
        {
            Debug.Log("GAME OVER !");
            FindObjectOfType<AudioManager>().Play("gameover");
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void SetRandomColor()
    {
        int index = Random.Range(0, 4);
       
        switch (index)
        {
            case 0:
                currentColor = "Pink";
                sr.color = sr.color == colorPink ? colorGreen : colorPink;
                break;
            case 1:
                currentColor = "green";
                sr.color = sr.color == colorGreen ? colorRed : colorGreen;
                break;
            case 2:
                currentColor = "red";
                sr.color = sr.color == colorRed ? colorBlue : colorRed;
                break;
            case 3:
                currentColor = "blue";
                sr.color = sr.color == colorBlue ? colorPink : colorBlue;
                break;
        }
    }


    
} 
