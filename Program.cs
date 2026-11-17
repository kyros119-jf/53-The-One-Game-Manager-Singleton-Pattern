using System;

class Program
{
    static void Main(string[] args)
    {
        // Access the shared GameManager instance.
        GameManager.Instance.AddScore(100);

        GameManager.Instance.NextLevel();
    }
}