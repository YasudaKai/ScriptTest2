using System.Collections;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた")
    }


    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic()
    {
        mp = this.mp - 5;

        if (mp < 0)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else
        {
            Debug.Log("魔法攻撃をした。残りのMPは" + mp + "。");
        }
        
    }
}

public class Test : MonoBehaviour

{
    
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);

        }

        for(int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }



        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);

        lastboss.Magic();

        for (int i = 0; i < 10; i++){
            lastboss.Magic();
        }

        lastboss.Magic();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
