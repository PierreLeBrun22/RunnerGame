
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint : MonoBehaviour
{
    PlayerVelocity player;
    [SerializeField] KeyCode keyRestart;
    public Rigidbody rb;
    ConstantVelocity constantVelo;

    public void Start()
    {
        player = GameObject.FindObjectOfType<PlayerVelocity>();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            player.lastCheckPointPosition = rb.position;
            player.lastSpeedRegister = rb.velocity;
            player.lastCheckPointPosition.x -= 20;
            Debug.Log("Position" + player.lastCheckPointPosition);
            Debug.Log("Vitesse" + player.lastSpeedRegister);
        }
    }

    void Update()
    {
        if (Input.GetKey(keyRestart) || GameObject.Find("Player").transform.position.y < -70)
        {
            if (player.lastSpeedRegister != new Vector3())
            {
                rb.position = player.lastCheckPointPosition;
                rb.velocity = player.lastSpeedRegister;
            }
            else
            {
                GameObject thePlayer = GameObject.Find("Player");
                Timer timerScript = thePlayer.GetComponent<Timer>();
                TimerStatic.Timer = timerScript.timer;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

}
