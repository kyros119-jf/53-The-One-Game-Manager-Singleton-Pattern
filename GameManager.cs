public class GameManager
{
    // Create the one shared GameManager object.
    private static GameManager instance = new GameManager();

    // Allow other classes to access the shared object.
    public static GameManager Instance
    {
        get { return instance; }
    }

    // Store the player's score and current level.
    public int PlayerScore { get; private set; }
    public int CurrentLevel { get; private set; }

    // Private constructor prevents other classes from creating new GameManager objects.
    private GameManager()
    {
        PlayerScore = 0;
        CurrentLevel = 1;
    }

    // Increase the player's score.
    public void AddScore(int amount)
    {
        PlayerScore += amount;

        Console.WriteLine("Score increased by " + amount);
        Console.WriteLine("Current Score: " + PlayerScore);
    }

    public void NextLevel()
    {
        CurrentLevel++;

        Console.WriteLine("\nLevel advanced!");
        Console.WriteLine("Current Level: " + CurrentLevel);
    }
}
