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
    // ������� ���� 
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
        transform.Translate(Vector3.forward*Moverpower * movedir.z * Time.deltaTime); //������ �����̰� ���� ����
        // x:1m/s      deltaTime == �����ð�����// �������Ӵ� �ɸ��½ð�
        // transform.Translate(movedir * Time.deltaTime); ������ �Ȱ���.
        // Translate �÷��̾ �ٶ󺸴� ������ �������� �����δ�;
       // transform.Translate(movedir * Time.deltaTime,Space.World); world �������� �����¿�
        //transform.Translate(movedir * Time.deltaTime, Space.Self);�ڱ� �������� �����¿�
       
        
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
    // Quarternion	: ����Ƽ�� ���ӿ�����Ʈ�� 3���� ������ �����ϰ� �̸� ���⿡�� �ٸ� ���������� ��� ȸ������ ����
    //				  �������� ȸ������ ������ ������ �߻����� ����
    // EulerAngle	: 3���� �������� ���������� ȸ����Ű�� ���
    //				  ������������ ������ ������ �߻��Ͽ� ȸ���� ��ġ�� ���� ���� �� ����
    // ������		: ���� �������� ������Ʈ�� �� ȸ�� ���� ��ġ�� ����

    // Quarternion�� ���� ȸ�������� ����ϴ� ���� ���������� �ʰ� �����ϱ� �����
    // ������ ��� ���ʹϾ� -> ���Ϸ����� -> �������� -> ������Ϸ����� -> ������ʹϾ� �� ���� ������ ��� ���ʹϾ��� �����
    public void Rotation()
    {
        // Ʈ�������� ȸ������ Euler���� ǥ���� �ƴ� Quaternion�� �����
        transform.rotation = Quaternion.identity; //identity ȸ�� ���� 000����

        // Euler������ Quaternion���� ��ȯ
        transform.rotation = Quaternion.Euler(0, 90, 0);
      //  transform.rotation.ToEulerAngles(); ���Ϸ� �ޱ۷κ�ȭ
    }
    public void Jump()
    {
       // rb.AddForce(Vector3.up * Jumppower,ForceMode.Impulse);
    }
    private void OnMove(InputValue Value)
    {
        movedir.x = Value.Get<Vector2>().x;
        movedir.z = Value.Get<Vector2>().y;     // y���� ���϶� z
      
    }
    private void OnJump(InputValue Value)
    {
        Jump();
    }
}
