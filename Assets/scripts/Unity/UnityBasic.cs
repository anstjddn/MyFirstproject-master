using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class UnityBasic : MonoBehaviour
{
    public GameObject Player;

    public void Start()
    {
        GameObjectBasic();
    }
    public void GameObjectBasic()
    {

        // <���ӿ�����Ʈ ����>
        // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ�� gameObject �Ӽ��� �̿��Ͽ� ���ٰ���
        // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ
        // gameObject.name;                 // ���ӿ�����Ʈ�� �̸� ����
        // gameObject.active;         // ���ӿ�����Ʈ�� Ȱ��ȭ ���� ����
        // gameObject.tag;                   // ���ӿ�����Ʈ�� �±� ����
        // gameObject.layer;               // ���ӿ�����Ʈ�� ���̾� ����


        // <�� ���� ���ӿ�����Ʈ Ž��>
       // GameObject.Find("Player");             // ���� ���������
       //  GameObject.FindGameObjectWithTag("MainCamera");    // �±׷� �ϳ� ã��
        //GameObject.FindGameObjectsWithTag("MyTag");	// �±׷� ��� ã��    // ������ ������ �迭�� ã����

        // <���ӿ�����Ʈ ����>
		GameObject newGameObject = new GameObject();
        

        // <���ӿ�����Ʈ ����>
        //Destroy(gameObject.name, 5f); ///�ڿ� ����f�� 5�ʵڿ� ����(��������)
                                        // �ȳ����� �׳� ����

    }

    public void ComponentBasic()
    {
        // <���ӿ�����Ʈ �� ������Ʈ ����>
        // GetComponent�� �̿��Ͽ� ���ӿ�����Ʈ �� ������Ʈ ����
        // gameObjectGetComponent = GetComponent<AudioSource>();
        // ������Ʈ���� GetComponent�� ����� ��� �����Ǿ� �ִ� ���ӿ�����Ʈ�� �������� ����
        //gameObjectGetComponent =gameObject.GetComponent<AudioSource>(); //���ӿ�����Ʈ���� �����Ҽ�������

        //GetComponents<AudioSource>() // ������Ʈ �������� ����������Ʈ ���� �迭�� ��ȯ��
        //GetComponetInChildren //�ڽİ��ӿ�����Ʈ ���� ������Ʈ ����
        //GetComponetsInChildren //�ڽİ��ӿ�����Ʈ ���� ���� ������Ʈ ����
        // �翬�� ���ӿ�����Ʈ���� �����Ҽ����մ�.
        //otherGameObject.GetComponentInParent<AudioSource>();        // �θ� ���ӿ�����Ʈ ���� ������Ʈ ����
        //otherGameObject.GetComponentsInParent<AudioSource>();       // �θ� ���ӿ�����Ʈ ���� ������Ʈ�� ����


        // <�� ���� ������Ʈ Ž��>
        // FindObjectOfType<Rigidbody>();           // �� ���� ������Ʈ �ϳ� ã��
        // FindObjectsOfType<Rigidbody>();			// �� ���� ������Ʈ ��� ã��

        // <������Ʈ �߰�>
        // Rigidbody rigid = new Rigidbody();	// �����ϳ� �ǹ̾���, ������Ʈ�� ���ӿ�����Ʈ�� �����Ǿ� �����Կ� �ǹ̰� ����
        // ���ӿ�����Ʈ�� ������Ʈ �߰�
        //gameObject.AddComponent<AudioSoure>();  // ���ӿ�����Ʈ�� ������Ʈ �߰�

        // <������Ʈ ����>
       // Destroy(destroyComponent);
    }
}
