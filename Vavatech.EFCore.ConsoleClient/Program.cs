using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Vavatech.EFCore.DbServices;
using Vavatech.EFCore.FakeServices;
using Vavatech.EFCore.IServices;

namespace Vavatech.EFCore.ConsoleClient
{
    class MyProgressBar : Progress<int>
    {
        protected override void OnReport(int value)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"#{Thread.CurrentThread.ManagedThreadId} Started");
            //SyncTest();
            //ContinueWithTest();

            CancellationTokenTest();

             AsyncAwaitTest();

            //  TasksTest();

            // TaskTest();

            // ThreadTest();

            Console.WriteLine("Press any key to exit.");

            Console.ReadLine();

        }

        //private static void SyncTest()
        //{
        //    decimal amount = Calculate();
        //    Print(amount);
        //    Send();
        //}

        //private static void ContinueWithTest()
        //{
        //    CalculateAsync()
        //         .ContinueWith(t => PrintAsync(t.Result))
        //             .ContinueWith(t => Send());
        //}

        private static void CancellationTokenTest()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            CancellationToken cancellationToken = cancellationTokenSource.Token;

            //   Progress<int> progress = new Progress<int>(step => Console.Write($"#{step}"));

            IProgress<int> progress = new MyProgressBar();


            CalculateAsync(cancellationToken, progress);

            cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(4));

            Console.WriteLine("Press Esc to cancel");

            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.Escape)
            {
                cancellationTokenSource.Cancel();
            }




            
        }

        private static async void AsyncAwaitTest()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            CancellationToken cancellationToken = cancellationTokenSource.Token;

            // Progress<int> progress = new Progress<int>(step => Console.Write($"#{step}"));

            IProgress<int> progress = new MyProgressBar();


            decimal amount = await CalculateAsync(cancellationToken, progress);
            

            await PrintAsync(amount);

            Send();
        }

        private static Task<decimal> CalculateAsync(CancellationToken cancellationToken, IProgress<int> progress)
        {
            return Task.Run(() => Calculate(cancellationToken, progress));
        }

        private static decimal Calculate(CancellationToken cancellationToken, IProgress<int> progress)
        {
            Console.WriteLine($"#{Thread.CurrentThread.ManagedThreadId} Calculating...");

            for (int i = 0; i < 10; i++)
            {
                // cancellationToken.ThrowIfCancellationRequested();

                

                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }

                Thread.Sleep(TimeSpan.FromSeconds(1));

                // Console.Write(i);

                progress.Report(i);


            }


            Console.WriteLine($"#{Thread.CurrentThread.ManagedThreadId} Calculated.");

            return 100;
        }


        private static Task PrintAsync(decimal amount)
        {
            return Task.Run(() => Print(amount));
        }

        private static void Print(decimal amount)
        {
            Console.WriteLine($"#{Thread.CurrentThread.ManagedThreadId} Printing {amount}...");

            Thread.Sleep(TimeSpan.FromSeconds(3));

            Console.WriteLine($"#{Thread.CurrentThread.ManagedThreadId} Printed.");

        }



        private static void TasksTest()
        {
            IList<Task> tasks = new List<Task>();

            tasks.Add(Task.Run(() => Send()));
            tasks.Add(Task.Run(() => Send()));
            tasks.Add(Task.Run(() => Send()));
            tasks.Add(Task.Run(() => Send()));

            // Task.WaitAll(tasks);

            Task.WhenAll(tasks).Wait();

            Console.WriteLine("next job");






        }

        private static void TaskTest()
        {


            for (int i = 0; i < 100; i++)
            {
                //Task task = new Task(Send);
                //task.Start();

                //Task task = new Task(Send);
                //task.Start();

                //Task task1 = Task.Run(()=>Send());
                //Task task2 = Task.Run(() => Send());




            }


        }

        private static void ThreadTest()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread thread1 = new Thread(Send);
                thread1.Start();
            }
        }

       
        private static void Send()
        {
            Console.WriteLine($"#{Thread.CurrentThread.ManagedThreadId} Sending...");

            Thread.Sleep(TimeSpan.FromSeconds(5));

            Console.WriteLine($"#{Thread.CurrentThread.ManagedThreadId} Sent.");
        }


        static void GenerateCustomers()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddScoped<ICustomerService, DbCustomerService>();
            string connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyEfCoreDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            services.AddDbContext<MyContext>(options => options.UseSqlServer(connectionstring));



            ICustomerService customerService = new FakeCustomerService(new CustomerFaker());

            var customers = customerService.Get();

            
            
        }
    }
}
