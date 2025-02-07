using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    Animator animator;

    public void Attack() 
    {
        animator.SetBool("IsAttacking", true);
    }

    public void ResetAttack() 
    {
        animator.SetBool("IsAttacking", false);
    }
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {

    }
}
