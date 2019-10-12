using System;
using System.Data.SqlClient;

namespace Homework10._10._19
{
	class Program
	{
		/*
		Напишите код с использованием технологии ADO.NET, который создает в базе данных таблицу gruppa. (Id,Name) 
		*/
		static void CreateTable()
		{
			Console.WriteLine("Введите название сервера:");
			string serverName = Console.ReadLine();
			Console.WriteLine("Введите название базы данных:");
			string dataBaseName = Console.ReadLine();
			string connectionString = $"Server={serverName};Database={dataBaseName};Trusted_Connection=True;";
			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand sqlCommand = connection.CreateCommand())
			{
				string query = $"CREATE TABLE gruppa (" +
													$"Id uniqueidentifier," +
													$"Name nvarchar(50)" +
													$");";
				sqlCommand.CommandText = query;

				connection.Open();
				sqlCommand.ExecuteNonQuery();
			}
		}
		static void Main(string[] args)
		{
			try
			{
				CreateTable();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.Message);
			}
			Console.WriteLine("End Of Program!");
			Console.Read();
		}
	}
}
