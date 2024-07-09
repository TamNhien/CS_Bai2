using CS_Bai2;

public class Program
{
    static List<Video> videos = new List<Video>();
    static List<LichChieuPhim> schedules = new List<LichChieuPhim>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add a new movie");
            Console.WriteLine("2. List movies by genre");
            Console.WriteLine("3. List movies by main actor");
            Console.WriteLine("4. List movies by director");
            Console.WriteLine("5. Add movie schedules");
            Console.WriteLine("6. List all schedules");
            Console.WriteLine("7. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddNewMovie();
                    break;
                case 2:
                    ListMoviesByGenre();
                    break;
                case 3:
                    ListMoviesByActor();
                    break;
                case 4:
                    ListMoviesByDirector();
                    break;
                case 5:
                    AddMovieSchedules();
                    break;
                case 6:
                    ListAllSchedules();
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void AddNewMovie()
    {
        Console.WriteLine("Enter movie title: ");
        string title = Console.ReadLine();

        Console.WriteLine("Enter genre (hinh su, hanh dong, tinh cam, hai): ");
        string genre = Console.ReadLine();

        Console.WriteLine("Enter director: ");
        string director = Console.ReadLine();

        Console.WriteLine("Enter main actor: ");
        string mainActor = Console.ReadLine();

        Console.WriteLine("Enter main actress: ");
        string mainActress = Console.ReadLine();

        Console.WriteLine("Enter year of production: ");
        int yearOfProduction = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter production company: ");
        string productionCompany = Console.ReadLine();

        videos.Add(new Video(title, genre, director, mainActor, mainActress, yearOfProduction, productionCompany));
        Console.WriteLine("Movie added successfully.");
    }

    static void ListMoviesByGenre()
    {
        Console.WriteLine("Enter genre: ");
        string genre = Console.ReadLine();

        var filteredMovies = videos.FindAll(movie => movie.Genre == genre);
        foreach (var movie in filteredMovies)
        {
            Console.WriteLine($"Title: {movie.Title}, Director: {movie.Director}, Main Actor: {movie.MainActor}, Main Actress: {movie.MainActress}, Year: {movie.YearOfProduction}, Production: {movie.ProductionCompany}");
        }
    }

    static void ListMoviesByActor()
    {
        Console.WriteLine("Enter main actor name: ");
        string actorName = Console.ReadLine();

        var filteredMovies = videos.FindAll(movie => movie.MainActor == actorName);
        foreach (var movie in filteredMovies)
        {
            Console.WriteLine($"Title: {movie.Title}, Genre: {movie.Genre}, Director: {movie.Director}, Main Actress: {movie.MainActress}, Year: {movie.YearOfProduction}, Production: {movie.ProductionCompany}");
        }
    }

    static void ListMoviesByDirector()
    {
        Console.WriteLine("Enter director name: ");
        string directorName = Console.ReadLine();

        var filteredMovies = videos.FindAll(movie => movie.Director == directorName);
        foreach (var movie in filteredMovies)
        {
            Console.WriteLine($"Title: {movie.Title}, Genre: {movie.Genre}, Main Actor: {movie.MainActor}, Main Actress: {movie.MainActress}, Year: {movie.YearOfProduction}, Production: {movie.ProductionCompany}");
        }
    }

    static void AddMovieSchedules()
    {
        Console.WriteLine("Enter movie title: ");
        string title = Console.ReadLine();

        var movie = videos.Find(m => m.Title == title);
        if (movie == null)
        {
            Console.WriteLine("Movie not found.");
            return;
        }

        Console.WriteLine("Enter show date (e.g., Monday, Tuesday, etc.): ");
        string showDate = Console.ReadLine();

        Console.WriteLine("Enter show time: ");
        string showTime = Console.ReadLine();

        Console.WriteLine("Enter start time: ");
        string startTime = Console.ReadLine();

        Console.WriteLine("Enter end time: ");
        string endTime = Console.ReadLine();

        Console.WriteLine("Enter ticket price: ");
        double ticketPrice = double.Parse(Console.ReadLine());

        var schedule = new LichChieuPhim(movie.Title, movie.Genre, movie.Director, movie.MainActor, movie.MainActress, movie.YearOfProduction, movie.ProductionCompany, showDate, showTime, startTime, endTime, ticketPrice);
        schedule.ApplyDiscount();

        schedules.Add(schedule);
        Console.WriteLine("Schedule added successfully.");
    }

    static void ListAllSchedules()
    {
        foreach (var schedule in schedules)
        {
            Console.WriteLine(schedule);
        }
    }
}