using System;
public class MyVector{
    private int[] arr; // array which stores elements in the vector
    private int countOfElements;
    private void resize(){
        int newCount = arr.Length * 2; // debug
        int[] newArr = new int[newCount];
        for(int i=0; i<countOfElements; i++){
            newArr[i] = arr[i];
        }
        arr = newArr;
    }
    public MyVector(int countOfElements = 5){
        arr = new int[countOfElements];
        countOfElements = 0;
    }
    public void add(int val){
        if(countOfElements == arr.Length){
            resize();
        }
        arr[countOfElements++] = val;
    }
    public void pop_back(){
        if(countOfElements == 0){
            Console.WriteLine("Vector Empty");
        }
        countOfElements--;
    }
    public bool remove(int value)
    {
        int index = Array.IndexOf(arr, value, 0, arr.Length);
        if (index == -1)
            return false;

        for (int i = index; i < countOfElements - 1; i++)
        {
            arr[i] = arr[i + 1];
        }

        countOfElements--;
        return true;
    }
    public int size(){
        return countOfElements;
    }
    public void print(){
        for(int i=0; i<countOfElements; i++){
            Console.WriteLine(arr[i] + " ");
        }
    }
}

public class Test
{
	public static void Main()
	{
		MyVector vec = new MyVector();
		vec.add(1);

	   // vec.pop_back();
	  vec.pop_back();
	  vec.add(1);
	  vec.pop_back();
    vec.pop_back();
	  vec.pop_back();
		vec.print();
	}
}