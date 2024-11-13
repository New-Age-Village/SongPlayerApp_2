using Assignement_3;

public class Program
{
    public static void Main()
    {
        // Create a song instance with title, artist, and duration
        Song mySong = new Song("Imagine", "John Lennon", 3.1);

        // Display the app's welcome message
        Console.WriteLine("Welcome to the Song Player App!");

        while (true)
        {
            // Show options to the user
            Console.WriteLine("Options:");
            Console.WriteLine("1. Play the song");
            Console.WriteLine("2. Show song info");
            Console.WriteLine("3. Exit");

            Console.Write("Choose an option (1-3): ");
            string choice = Console.ReadLine();

            // Check the user's choice and perform the action
            if (choice == "1")
            {
                // Play the song
                mySong.Play();
            }
            else if (choice == "2")
            {
                // Show song information
                mySong.ShowInfo();
            }
            else if (choice == "3")
            {
                // Exit the app
                Console.WriteLine("Exiting the app...");
                break;
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
            }
        }
    }
}