using System;
namespace advancejavaanimals.Services
{
	public class FileInputService
	{
        private StreamReader input = null;
        private string _fileName;

        public FileInputService(string fileName)
		{
			this._fileName = fileName;

            try
            {
                FileStream fs = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
                input = new StreamReader(fs);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File Open Error: {_fileName} {e}");
            }
        }

		public void FileRead()
		{
            string? line = String.Empty;

            try
            {
                 while ((line = input.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Read Error: {_fileName} {e}");
            }
        }

		public string? FileReadLine()
		{
			try
             {
                 string? line = input.ReadLine();
                 return line;
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Read Error: {_fileName} {e}");
                return null; 
            }
		}

		public void FileClose()
		{
            if (input != null)
            {
                try
                {
                    input.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
		}
	}
}

