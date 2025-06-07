using System;
// coded on Visual studio
MyMap map = new MyMap();

map.insert(1, "one");
map.insert(2, "two");
map.insert(3, "three");

//map.print();

//map.delete(1);
//map.print();
if (map.containsKey(3))
{
    Console.WriteLine("present");
}

class MyMap
{
    private string[] values = new string[100];
    private bool[] vis = new bool[100];
    public void insert(int key, string value)
    {
        if(key < 0 || key >= 100)
        {
            Console.WriteLine("out of bounds");
            return;
        }
        values[key] = value;
        vis[key] = true;
    }

    public void delete(int key)
    {
        if (key < 0 || key >= 100) { Console.WriteLine("out of bounds"); return; }
        values[key] = null;
        vis[key] = false;
    }
    public bool containsKey(int key) {
        return values[key] != null;
    }
    public bool containsValue(string val)
    {
        for (int i = 0; i < 100; i++)
        {
            if(values[i] == val)
            {
                return true;
            }
        }
        return false;
    }
    public void print()
    {
        for(int i = 0;i < 100; i++)
        {
            if (vis[i]  == true)
            {
                Console.WriteLine(i + " " + values[i]);
            }
        }
    }
}