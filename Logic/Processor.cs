class Processor
{
    public void WriteToFile()
    {
        File.AppendAllLines("/home/dvcky/c#/Logs/Background.txt", new[] { DateTime.Now.ToString()+": "+"My name is Ssembatya Isaac" });
    }
}