// See https://aka.ms/new-console-template for more information
namespace Exercise_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           // input number of song
           Console.WriteLine("Enter number of song");
            int number = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < number; i++)
            {
                string[] data = Console.ReadLine().Split("_");
                
                string type = data[0];
                string name = data[1];
                string time = data[2];
                
                Song song = new Song();
                song.Time = time;
                song.Name = name;
                song.TypeList = type;
                
                songs.Add(song);



                string typeList = Console.ReadLine();
                if (typeList == "all")
                {
                    foreach (var VARIABLE in songs)
                    {
                        Console.WriteLine(VARIABLE.Name);
                    }
                }
                else
                {
                    foreach (var VARIABLE in songs)
                    {
                        if (VARIABLE.TypeList == typeList)
                        {
                            Console.WriteLine(VARIABLE.Name);
                        }
                    }
                }
            }
        }
    }
}