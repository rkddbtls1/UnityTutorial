using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters : MonoBehaviour
{
    // 클래스: 사용자 정의의 데이터유형으로 속성, 함수 포함
    // 클래스를 통해 객체를 생성해 접근. 사용 가능

    Item item = new Item();

    public GameObject prefab;

    public void creat()
    {
        // prefab: 생성하고싶은 걔임 오브젝트
        // new Vector (좌표) 옵젝 생성위치
        // Quaternion.Euler 옵젝 생성시 회전

        int x = Random.Range(0, 10); // 0~10 랜덤 x값
        int y = Random.Range(0, 5);
        int z = Random.Range(-5, 0);

            
            Instantiate(prefab,new Vector3(x,y,z), Quaternion.Euler(0,180,0));
    }

    public void Delete()
    {
        Destroy(prefab);
    }
}
public class Item
{
    //생성자는 클래스의 인스턴스가 생성되는
    //시점에서 자동으로 호출되는 특수한 멤버 함수
    //옵젝 생성 유무도 확인 가능한 좋은 아이

    public Item()
    {
        Debug.Log("아이템이 생성되었습니다.");
    }


}