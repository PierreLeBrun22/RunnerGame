using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    bool alive = true;
    public float speed = 15;
    [SerializeField] Rigidbody rb;

    float horizontalInput;
    [SerializeField] float horizontalMultiplier = 2;

    [SerializeField] float jumpForce = 600f;
    [SerializeField] LayerMask groundMask;

    public float speedIncreasePerPoint = 0.3f;
    private void FixedUpdate()
    {
        if (!alive) return;
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }
    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.y < -5) Die();
        if(Input.GetKeyDown(KeyCode.Space)){
            Jump();
        }
    }

    public void Die()
    {
        alive = false;
        GameObject thePlayer = GameObject.Find("Player");
        Timer timerScript = thePlayer.GetComponent<Timer>();
        TimerStatic.Timer = timerScript.timer;
        //restart game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Jump(){
        // Check whether we are currently grounded
        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height/2) + 0.1f, groundMask);
        // if we are, jump
        if(isGrounded){
            rb.AddForce(Vector3.up * jumpForce);
        }
    }

}
