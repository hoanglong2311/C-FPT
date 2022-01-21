namespace Baitap1
{
    public class Student
    {
        public int Id { get; set; }
        public string SName { get; set; }
        public string SFaculty { get; set; }
        public float SScore { get; set; }

        public Student() { }

        public Student(int id, string sname, string sfaculty, float sscore)
        {
            this.Id = id;
            this.SName = sname;
            this.SFaculty = sfaculty;
            this.SScore = sscore;
        }

        public void Show()
        {
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Name: {0}", this.SName);
            Console.WriteLine("Faculty: {0}", this.SFaculty);
            Console.WriteLine("Score: {0}", this.SScore);
        }


    }
}