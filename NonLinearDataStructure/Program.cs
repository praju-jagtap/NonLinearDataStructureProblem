namespace NonLinearDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, int> hash = new MyMapNode<string, int>(6);
            string words = "to be or not to be"; 
            string[] arr = words.Split(' ');
            LinkedList<string> checkForDuplication = new LinkedList<string>();
            foreach (string element in arr)
            {
                int count = 0;
                foreach (string match in arr)
                {
                    if (element == match)
                    {
                        count++;
                        if (checkForDuplication.Contains(element))
                        {
                            break;
                        }
                    }
                }
                if (checkForDuplication.Contains(element))
                {
                    continue;
                }
                checkForDuplication.AddLast(element);
                hash.Add(element, count);
            }
            Console.WriteLine("Frequency of the word");
            hash.Display();
        }
    }
}