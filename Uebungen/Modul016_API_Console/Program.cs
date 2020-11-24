using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Modul016_API_Console
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static string apiUrl = "api/todoitems/";
        static void Main(string[] args)
        {
            client.BaseAddress = new Uri("https://das-ist-meine-url.de");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                TodoItem todoitem = new TodoItem()
                {
                    Name = "Mein neues Item",
                    IsComplete = false
                };

                Uri url = Create(todoitem);
                Console.WriteLine($"Erstellt mit Url {url}");
                
                todoitem = Read(url.PathAndQuery);
                TodoItemInfo(todoitem);

                todoitem.Name = "Ich habe einen neuen Namen";
                Update(todoitem);

                todoitem = Read(url.PathAndQuery);
                TodoItemInfo(todoitem);

                HttpStatusCode code = Delete(todoitem.Id);
                Console.WriteLine($"item gelöscht mit Statuscode {(int)code}");

                List<TodoItem> items = Read();


                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static void TodoItemInfo(TodoItem item)
        {
            Console.WriteLine($"Id: {item?.Id}\nName:{item?.Name}\nIdComplete:{item?.IsComplete}");
        }

        static string CreateJson(TodoItem item)
        {
            return JsonSerializer.Serialize(item, typeof(TodoItem));
        }

        static TodoItem CreateTodoItem(string json)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };
                return JsonSerializer.Deserialize<TodoItem>(json, options);
            }
            catch
            {
                return null;
            }
        }
        static List<TodoItem> CreateTodoItems(string json)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };
                return JsonSerializer.Deserialize<TodoItemDTO>(json, options).items;
            }
            catch
            {
                return null;
            }
        }

        static Uri Create(TodoItem item)
        {
            HttpContent content = new StringContent(CreateJson(item), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;

            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }

        static List<TodoItem> Read()
        {
            HttpResponseMessage response = client.GetAsync(apiUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                return CreateTodoItems(response.Content.ReadAsStringAsync().Result);
            }

            return null;
        }

        static TodoItem Read(string path)
        {
            TodoItem item = null;
            HttpResponseMessage response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                item = CreateTodoItem(response.Content.ReadAsStringAsync().Result);
            }
            return item;
        }

        static TodoItem Read(long id)
        {
            return Read($"{apiUrl}{id}");
        }


        static TodoItem Update(TodoItem item)
        {
            HttpContent content = new StringContent(CreateJson(item), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync($"{apiUrl}{ item.Id}", content).Result;

            response.EnsureSuccessStatusCode();

            return CreateTodoItem(response.Content.ReadAsStringAsync().Result);
        }

        static HttpStatusCode Delete(long id)
        {
            HttpResponseMessage response = client.DeleteAsync($"{apiUrl}{id}").Result;
            return response.StatusCode; 
        }
    }
}
