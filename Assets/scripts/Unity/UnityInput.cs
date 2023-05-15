using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UnityInput : MonoBehaviour
{
    /************************************************************************
      * ����Ƽ �Է�
      * 
      * ����Ƽ���� ������� ����� ������ �� �ִ� ����
      * ����ڴ� �ܺ� ��ġ�� �̿��Ͽ� ������ ������ �� ����
      * ����Ƽ�� �پ��� Ÿ���� �Է±��(Ű���� �� ���콺, ���̽�ƽ, ��ġ��ũ�� ��)�� ����
      ************************************************************************/

    private void Update()
    {
        InputByDevice();
    }
    // <Device>
    // Ư���� ��ġ�� �������� �Է� ����
    // Ư���� ��ġ�� �Է��� �����ϱ� ������ ���� �÷����� ������ �����
    private void InputByDevice()
    {
        // Ű������ �Է°���
        if (Input.GetKey(KeyCode.Space))    // �������ִ��߿� ��� 
            Debug.Log("Space key is pressing");
        if (Input.GetKeyDown(KeyCode.Space))        //��������
            Debug.Log("Space key is down");
        if (Input.GetKeyUp(KeyCode.Space))          //Ű�� ���� ����
            Debug.Log("Space key is up");

        // ���콺�� �Է°���
        // ���ʸ��콺��:0
        // ������ ���콺��:1
        if (Input.GetMouseButton(0))                // �������ִ��߿� ��� ���
            Debug.Log("Mouse left button is pressing");
        if (Input.GetMouseButtonDown(0))            // ��������
            Debug.Log("Mouse left button is down");
        if (Input.GetMouseButtonUp(0))              //���¼���
            Debug.Log("Mouse left button is up");
    }


    // <InputManager>
    // ������̶�VR�� ���Ѱ� ����
    // ���� �Է¸Ŵ����� �߰����ָ� ��밡��(���½��� �Է¸Ŵ�������)
    // ���� ��ġ�� �Է��� �Է¸Ŵ����� �̸��� �Է��� ����
    // �Է¸Ŵ����� �̸����� ������ �Է��� ��������� Ȯ��
    // ����Ƽ �������� Edit -> Project Settings -> Input Manager ���� ����

    // ��, ����Ƽ ��â���� ����̱� ������ Ű����, ���콺, ���̽�ƽ�� ���� ��ġ���� �����
    // �߰�) VR Oculus Integraion Kit ���� ��� �Է¸Ŵ����� ������ ����� ���
    private void InputByInputManager()
    {
        // ��ư �Է�
        // Fire1 : Ű����(Left Ctrl), ���콺(Left Button), ���̽�ƽ(button0)���� ���ǵ�
        if (Input.GetButton("Fire1"))
            Debug.Log("Fire1 is pressing");
        if (Input.GetButtonDown("Fire1"))
            Debug.Log("Fire1 is down");
        if (Input.GetButtonUp("Fire1"))
            Debug.Log("Fire1 is up");

        //���� ��ư�� ture false �� ����

        // �� �Է�--������ ��ȯ����
        // Horizontal(����) : Ű����(a,d / ��, ��), ���̽�ƽ(���� �Ƴ��α׽�ƽ �¿�)
        float x = Input.GetAxis("Horizontal");
        // Vertical(����) : Ű����(w,s / ��, ��), ���̽�ƽ(���� �Ƴ��α׽�ƽ ����)
        float y = Input.GetAxis("Vertical");
    }

    // <InputSystem>
    //������ �̰����������� ���� ȸ�翡���� input�Ŵ��� ���
    // Unity 2019.1 ���� �����ϰ� �� �Է¹��
    // ������Ʈ�� ���� �Է��� ��������� Ȯ��
    // GamePad, JoyStick, Mouse, Keyboard, Pointer, Pen, TouchScreen, XR ��� ���� ����
    private void InputByInputSystem()
    {
        // InputSystem�� �̺�Ʈ ������� ������
        // Update���� �Էº�������� Ȯ���ϴ� ��� ��� ������ ���� ��� �̺�Ʈ�� Ȯ��
        // �޽����� ���� �޴� ��İ� �̺�Ʈ �Լ��� ���� �����ϴ� ��� ������ ����
        // ���� Move�� �����ҷ��� OnMove�� �����ؾߴ�
    }
    
}
