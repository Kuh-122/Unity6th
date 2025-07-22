using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GM : MonoBehaviour
{
    
    //public GM gameManager; ㅅㅂ

    public int Gold = 0; // 소지한 골드
    public int Crystal = 0; // 소지한 크리스탈
    public float GetCrystal = 1; // 크리스탈 확률
  //  public float percent = Random.Range(0, 100);

    public int ClickPclick = 0; // 추가 클릭
    public int GetMoreGold = 1; // 흭득 골드량 증가

    public int Up1Cost = 0; // 골드 흭득량 증가 
    public int Up2Cost = 0; // 추가 클릭 / 최대 업글 4회
    public int Up3Cost = 0; // 다이아 확률 증가 / 최대 업글 25회

    public int Up2Pr = 1; // 업글 진행률, 추가 클릭
    public int Up3Pr = 0; // 업글 진행률, 다이아

    public bool PSound = true; // 효과음 껐다 키기
    public bool shop = false; // 상점
    public bool Ending = false;
   
}