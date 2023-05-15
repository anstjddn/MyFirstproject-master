using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityScripts : MonoBehaviour
{
    /************************************************************************
      * ������Ʈ (Component)
      * 
      * Ư���� ����� ������ �� �ֵ��� ������ ���� ����� ����
      * ���ӿ�����Ʈ�� �۵��� ������ ��ǰ
      * ���ӿ�����Ʈ�� �߰�, �����ϴ� ����� ������ ��ǰ
      ************************************************************************/

    // Component>Behaviour>MonoBehaviour  ������ ��������
    // Component�ȿ� Behaviour �ְ� Behaviour �ȿ�  MonoBehaviour �ִ�.

    /************************************************************************
	 * MonoBehaviour
	 * 
	 * ��ũ��Ʈ�� ������ ���ԵǾ��ִ�.
	 * ������Ʈ�� �⺻Ŭ������ �ϴ� Ŭ������ ����Ƽ ��ũ��Ʈ�� �Ļ��Ǵ� �⺻ Ŭ����
	 * ���� ������Ʈ�� ��ũ��Ʈ�� ������Ʈ�μ� ������ �� �ִ� ������ ����
	 * ��ũ��Ʈ ����ȭ ���, ����Ƽ�޽��� �̺�Ʈ�� �޴� ���, �ڷ�ƾ ����� ������
	 ***********************************************************************/
    // �����̸��� Ŭ���� �̸� �ٸ��� ��������.
    // �����̸� �ٲٸ� Ŭ���� �̸��� �ٲ�����.

    // <��ũ��Ʈ ����ȭ ���>
    // �ν����� â���� ������Ʈ�� �ɹ����� ���� Ȯ���ϰų� �����ϴ� ���
    // ������Ʈ�� ������ �����͸� Ȯ���ϰų� ����
    // ������Ʈ�� �������� �����͸� �巡�� �� ��� ������� ����
    // ���߿� ����Ƽ �󿡼� �ٲٸ� �װ� �켱��
    // 
    // <�ν�����â ����ȭ�� ������ �ڷ���>
    [Header("C# Type")]
    public bool boolValue;          // ����Ƽ �󿡼� üũ�ϸ� true
    public int intValue;
    public float floatValue;
    public string stringValue;
    // �� �� �⺻ �ڷ���

    // �⺻ �ڷ����� �����ڷᱸ��       // �ؽ����̺� �ȵ�
    public int[] array;
    public List<int> list;

    [Header("Unity Type")]
    public Vector3 vector3;             // 2D vector2 3D vector3 ���´�. ������ 2d�����̶� vector3 ������ �ֵ�.
    public Color color;
    public LayerMask layerMask;
    public AnimationCurve curve;
    public Gradient gradient;       // �׶��̼�

    [Header("Unity GameObject")]        // Ŭ������ ����ȭ ���� none == null;
    public GameObject obj;
    public Rigidbody rb;

    [Header("Unity Component")]
    public new Transform transform;
    public new Rigidbody rigidbody;
    public new Collider collider;

    [Header("Unity Event")]   //��������Ʈ ����ȭX ��������� UnityAction �����
    public UnityEvent OnEvent;

    // ����ȭ private�� inspectorâ���� �Ⱥ��δ�


    // priavte�� inspectorâ���� ��Ʈ���ϰ������ ��Ʈ����Ʈ ���

    // <��Ʈ����Ʈ>(�Ӽ�)
    // Ŭ����, ������Ƽ �Ǵ� �Լ� ���� ����Ͽ� Ư���� ������ ��Ÿ�� �� �ִ� ��Ŀ

    [Space(30)]         //���ȣ�� ����

    [Header("Unity Attribute")]
    [SerializeField]            // priavte���� ���δ�.
    private int privateValue;
    [HideInInspector]   //pbulic ������ �Ⱥ��̰� ������.
    public int publicValue;

    [Range(0, 10)]          // �����̺�� ���� �ּ�0 �ִ� 10
    public float rangeValue;

    [TextArea(3, 5)]      // �Է°����� �ؽ�Ʈ �ڽ� ����
    public string textField;
}
