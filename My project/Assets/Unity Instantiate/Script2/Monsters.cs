using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters : MonoBehaviour
{
    // Ŭ����: ����� ������ �������������� �Ӽ�, �Լ� ����
    // Ŭ������ ���� ��ü�� ������ ����. ��� ����

    Item item = new Item();

    public GameObject prefab;

    public void creat()
    {
        // prefab: �����ϰ���� ���� ������Ʈ
        // new Vector (��ǥ) ���� ������ġ
        // Quaternion.Euler ���� ������ ȸ��

        int x = Random.Range(0, 10); // 0~10 ���� x��
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
    //�����ڴ� Ŭ������ �ν��Ͻ��� �����Ǵ�
    //�������� �ڵ����� ȣ��Ǵ� Ư���� ��� �Լ�
    //���� ���� ������ Ȯ�� ������ ���� ����

    public Item()
    {
        Debug.Log("�������� �����Ǿ����ϴ�.");
    }


}