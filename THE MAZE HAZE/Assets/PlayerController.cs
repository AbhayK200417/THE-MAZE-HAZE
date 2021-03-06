using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public Rigidbody rb;
    public LayerMask layerMask;
    public bool grounded;
    // Start is called before the first frame update
    void Start()
    {
      this.rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
 void Update()
    {
        Grounded();
        Jump();
        Move();
    }

    private void Jump()
    {

       if(Input.GetKeyDown(KeyCode.Space) && this.grounded)
       {
           this.rb.AddForce(Vector3.up*4, ForceMode.Impulse);

       }
   
    }

private void Grounded()
{
    if (Physics.CheckSphere(this.transform.position + Vector3.down, 0.2f, layerMask))

    {
        this.grounded = true;

    }
    else
    {
        this.grounded = false;

    }
    // this.anim.SetBool("jump2", !this.grounded);

}
   private void Move()
   {
       float verticalAxis = Input.GetAxis("Vertical");
       float horizontalAxis = Input.GetAxis("Horizontal");

       Vector3 movement = this.transform.forward*verticalAxis + this.transform.right*horizontalAxis;
       movement.Normalize();

       this.transform.position += movement*0.09f;
    //    this.transform.position += movement;
       this.anim.SetFloat("vertical", verticalAxis);
       this.anim.SetFloat("horizontal",horizontalAxis);

   }
   void OnCollisionEnter(Collision collision) 
 {
         if((collision.gameObject.name == "end"))  // or if(gameObject.CompareTag("YourWallTag"))
         {
                     rb.velocity = Vector3.zero;
                     SceneManager.LoadScene("YOUWON");
         }
 }










}
