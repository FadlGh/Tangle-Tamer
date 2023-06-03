using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jetpackForce = 10f;

    private Rigidbody2D rb;
    private Animator am;
    private bool isUsingJetpack;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        am = GetComponent<Animator>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isUsingJetpack = true;
            rb.AddForce(Vector2.up * jetpackForce, ForceMode2D.Impulse);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            isUsingJetpack = false;
        }
    }

    private void FixedUpdate()
    {
        if (isUsingJetpack)
        {
            rb.AddForce(Vector2.up * jetpackForce * Time.fixedDeltaTime, ForceMode2D.Force);
            am.SetBool("Fly", true);
        }
        else
        {
            am.SetBool("Fly", false);
        }
    }
}