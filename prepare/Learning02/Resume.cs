    public class Resume
    {
        public string _name;
        public List<Job> _jobs;

        public void DisplayResume()
        {
            foreach (string job in _jobs)
            {
                Console.WriteLine($"Name: {_name}");
                Console.WriteLine($"Jobs: {job}");
            }
        }
    }