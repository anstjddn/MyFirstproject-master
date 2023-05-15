using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playercon : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 movedir;


    [SerializeField]
    private float Moverpower;
    [SerializeField]
    private float Jumppower;
    [SerializeField]
    private float Rotatepower;
    // 포스모드 포스 
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
        Rotate();
       // LookAt();

    }
    private void Move()
    {
        // rb.AddForce(movedir*Moverpower,ForceMode.Force);
        transform.Translate(Vector3.forward*Moverpower * movedir.z * Time.deltaTime); //누르면 움직이고 떼면 멈춤
        // x:1m/s      deltaTime == 단위시간개념// 한프레임당 걸리는시간
        // transform.Translate(movedir * Time.deltaTime); 위에랑 똑같다.
        // Translate 플레이어가 바라보는 방향을 기준으로 움직인다;
       // transform.Translate(movedir * Time.deltaTime,Space.World); world 기준으로 상하좌우
        //transform.Translate(movedir * Time.deltaTime, Space.Self);자기 기준으로 상하좌우
       
        
    }
    public void Rotate()
    {
        transform.Rotate(Vector3.up, movedir.x *Rotatepower * Time.deltaTime,Space.Self);
    }

    public void LookAt()
    {
        transform.LookAt(new Vector3(0, 0, 0));
    }

    // <Quarternion & Euler>
    // Quarternion	: 유니티의 게임오브젝트의 3차원 방향을 저장하고 이를 방향에서 다른 방향으로의 상대 회전으로 정의
    //				  기하학적 회전으로 짐벌락 현상이 발생하지 않음
    // EulerAngle	: 3축을 기준으로 각도법으로 회전시키는 방법
    //				  직관적이지만 짐벌락 현상이 발생하여 회전이 겹치는 축이 생길 수 있음
    // 짐벌락		: 같은 방향으로 오브젝트의 두 회전 축이 겹치는 현상

    // Quarternion을 통해 회전각도를 계산하는 것은 직관적이지 않고 이해하기 어려움
    // 보통의 경우 쿼터니언 -> 오일러각도 -> 연산진행 -> 결과오일러각도 -> 결과쿼터니언 과 같이 연산의 결과 쿼터니언을 사용함
    public void Rotation()
    {
        // 트랜스폼의 회전값은 Euler각도 표현이 아닌 Quaternion을 사용함
        transform.rotation = Quaternion.identity; //identity 회전 안한 000상태

        // Euler각도를 Quaternion으로 변환
        transform.rotation = Quaternion.Euler(0, 90, 0);
      //  transform.rotation.ToEulerAngles(); 오일러 앵글로변화
    }
    public void Jump()
    {
       // rb.AddForce(Vector3.up * Jumppower,ForceMode.Impulse);
    }
    private void OnMove(InputValue Value)
    {
        movedir.x = Value.Get<Vector2>().x;
        movedir.z = Value.Get<Vector2>().y;     // y축은 상하라서 z
      
    }
    private void OnJump(InputValue Value)
    {
        Jump();
    }
}
