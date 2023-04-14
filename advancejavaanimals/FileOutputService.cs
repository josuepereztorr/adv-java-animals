using System;
namespace advancejavaanimals.Services
{
	public class FileOutputService
	{
		public StreamWriter output = null;
		private string _fileName;

		public FileOutputService(string fileName)
		{
			this._fileName = fileName;

			try
			{
				FileStream fs = new FileStream(_fileName, FileMode.Open);
				output = new StreamWriter(fs);
			}
			catch (FileNotFoundException e)
			{
				Console.WriteLine($"File Open Error: {_fileName} {e}");
			}
		}

		public void FileWrite(string line)
		{
			try
			{
				output.Write(line + "\n");
			}
			catch (Exception e)
			{
				Console.WriteLine($"File Write Error: {_fileName} {e}");
			}
		}

		public void FileClose()
		{
			if (output != null)
			{
				try
				{
					output.Close();
				}
				catch (IOException e)
				{
                    Console.WriteLine(e.StackTrace);
                }
			}
		}
	}
}

