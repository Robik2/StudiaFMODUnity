using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Animator anim;
    
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update() {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        rb.linearVelocity = new Vector2(x, y).normalized * speed;
        
        anim.SetFloat("velocity", rb.linearVelocity.magnitude);
        anim.SetInteger("dirX", (int)x);
        anim.SetInteger("dirY", (int)y);
    }
}
