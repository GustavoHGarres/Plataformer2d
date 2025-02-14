using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    public float speed;
    public bool ground = true;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public bool facingLeft = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        ground = Physics2D.Linecast(groundCheck.position, transform.position, groundLayer);
        Debug.Log(ground);

        if (ground == false)
        {
            speed *= -1;
        }

        if (speed > 0 && !facingLeft)
        {
            Flip();
        }
        else if (speed < 0 && facingLeft)
        {
            Flip();
        }
    }
    void Flip()
    {
        facingLeft=!facingLeft; // Atribui o contrario dele, quando for verdadeira recebe o valor falso
        Vector3 Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;

    }


}
