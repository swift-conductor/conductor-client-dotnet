using csharp_examples;

class Program
{
    static void Main()
    {
        Runner runner = new Runner();

        // call specific method based on testing scenario
        runner.RunMultipleWorkers();
        //runner.RunCustomTask();
    }
}