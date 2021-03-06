using UnityEngine;

public class character2DController : MonoBehaviour
{
   public float MovementSpeed=1;
   private Rigidbody2D _rigidBody;
   public float JumpForce=1;
    private void Start()
    {
        _rigidBody= GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
     var movement= Input.GetAxis("Horizontal");
     transform.position+=(new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed);
     if(!Mathf.Approximately(0,movement)){
         transform.rotation= movement > 0 ?Quaternion.identity:Quaternion.Euler(0,180,0);
     }

    if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidBody.velocity.y)<0.001f){
        _rigidBody.AddForce(new Vector2(0,JumpForce), ForceMode2D.Impulse);
        //TODO #3 @Alfonzzoj Revisa mi commit issue
    }
    }
}
