using Homework_E_4_task_1;

internal class Program
{
    private static void Main(string[] args)
    {
        string documentType;

        do
        {
            Console.Write("Please enter youre document type(XML/TXT/DOC): ");
            documentType = Console.ReadLine();
        } while (documentType == null);

        if (documentType.Equals("XML"))
        {
            AbstractHandler xmlHandler = new XMLHandler();
            PrintHandler(xmlHandler);
        } 
        else if (documentType.Equals("TXT"))
        {
            AbstractHandler txtHandler = new TXTHandler();
            PrintHandler(txtHandler);
        }
        else if (documentType.Equals("DOC"))
        {
            AbstractHandler docHandler = new DOCHandler();
            PrintHandler(docHandler);
        } 
        else
        {
            Console.WriteLine("Sorry we can`t handle such document type");
        }
    }

    private static void PrintHandler(AbstractHandler handler)
    {
        handler.Open();
        handler.Create();
        handler.Change();
        handler.Save();
    }
}