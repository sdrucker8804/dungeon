using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public bool up = true;
    public bool down = true;
    public bool right = true;
    public bool left = true;
    public bool MoveUp = false;
    public bool MoveDown = false;
    public bool MoveRight = false;
    public bool MoveLeft = false;
    public bool CanMove = true;
    public int HasKey = 0;
    public Sprite[] DownSprite;
    public Sprite[] UpSprite;
    public Sprite[] LeftSprite;
    public Sprite[] RightSprite;
    [HideInInspector]
    public bool moving = false;

    private enum Direction
    {
        Up = 0,
        Down = 1,
        Left = 2,
        Right = 3
    }

    public Sprite[][] PlayerSprites = new Sprite[4][];

    private Direction DirectionValue = Direction.Up;

    public int health = 100;
    BoxUp boxRestrictionUp;
    BoxDown boxRestrictionDown;
    BoxLeft boxRestrictionLeft;
    BoxRight boxRestrictionRight;
    Camara CamaraScript;
    private SpriteRenderer RendererSprite; 
    //  public float speed = 1;
    // public float xDirection;
    //  public float xVector;
    // public float yDirection;
    // public float yVector;
    // public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        PlayerSprites[(int)Direction.Up] = UpSprite;
        PlayerSprites[(int)Direction.Down] = DownSprite;
        PlayerSprites[(int)Direction.Left] = LeftSprite;
        PlayerSprites[(int)Direction.Right] = RightSprite;
        // rb = GetComponent<Rigidbody2D>();
        //rb.gravityScale = 0;
        boxRestrictionUp = FindObjectOfType<BoxUp>();
        boxRestrictionDown = FindObjectOfType<BoxDown>();
        boxRestrictionLeft = FindObjectOfType<BoxLeft>();
        boxRestrictionRight = FindObjectOfType<BoxRight>();
        RendererSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RendererSprite.sprite = PlayerSprites[(int)DirectionValue][HasKey];
        if (health == 0)
        {
            print("Game Over!!");
            Destroy(gameObject);
        }
        if (CanMove & !moving)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && up && (boxRestrictionDown == null || boxRestrictionDown.DownPlayerStop == false))
            {
                MoveUp = true;
                DirectionValue = Direction.Up;
                CanMove = false;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && down && (boxRestrictionDown == null || boxRestrictionUp.UpPlayerStop == false))
            {
                MoveDown = true;
                DirectionValue = Direction.Down;
                CanMove = false;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && right && (boxRestrictionDown == null || boxRestrictionLeft.LeftPlayerStop == false))
            {
                MoveRight = true;
                DirectionValue = Direction.Right;
                CanMove = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && left && (boxRestrictionDown == null || boxRestrictionRight.RightPlayerStop == false))
            {
                MoveLeft = true;
                DirectionValue = Direction.Left;
                CanMove = false;
            }
        }
        /// xDirection = Input.GetAxis("Horizontal") * speed;
        // yDirection = Input.GetAxis("Vertical") * speed;
        // xVector = speed * xDirection * Time.deltaTime;
        // yVector = speed * yDirection * Time.deltaTime;
        // transform.Translate(xDirection * speed, yDirection * speed, 0);
        // transform.position = transform.position + new Vector3(xDirection * speed, yDirection * speed, 0);
        //  rb.AddForce(new Vector2(xDirection * speed, yDirection * speed));
    }

    private void FixedUpdate()
    {
        if (MoveUp == true)
        {
            transform.position += new Vector3(0, 2, 0);
           
            MoveUp = false;
            CanMove = true;
        }

        if (MoveDown == true)
        {
            transform.position += new Vector3(0, -2, 0);
            
            MoveDown = false;
            CanMove = true;

        }

        if (MoveRight == true)
        {
            transform.position += new Vector3(2, 0, 0);
            
            MoveRight = false;
            CanMove = true;

        }

        if (MoveLeft == true)
        {
            transform.position += new Vector3(-2, 0, 0);
            

           
            MoveLeft = false;
            CanMove = true;

        }
    }
}
