using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GM : MonoBehaviour
{
    
    //public GM gameManager; ����

    public int Gold = 0; // ������ ���
    public int Crystal = 0; // ������ ũ����Ż
    public float GetCrystal = 1; // ũ����Ż Ȯ��
  //  public float percent = Random.Range(0, 100);

    public int ClickPclick = 0; // �߰� Ŭ��
    public int GetMoreGold = 1; // ŉ�� ��差 ����

    public int Up1Cost = 0; // ��� ŉ�淮 ���� 
    public int Up2Cost = 0; // �߰� Ŭ�� / �ִ� ���� 4ȸ
    public int Up3Cost = 0; // ���̾� Ȯ�� ���� / �ִ� ���� 25ȸ

    public int Up2Pr = 1; // ���� �����, �߰� Ŭ��
    public int Up3Pr = 0; // ���� �����, ���̾�

    public bool PSound = true; // ȿ���� ���� Ű��
    public bool shop = false; // ����
    public bool Ending = false;
   
}