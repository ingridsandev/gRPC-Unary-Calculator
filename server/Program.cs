﻿using Calculator;
using Grpc.Core;
using System;
using System.IO;

namespace server
{
    class Program
    {
        const int Port = 50051;

        static void Main(string[] args)
        {
            Server server = null;

            try
            {
                server = new Server()
                {
                    Services = { CalculatorService.BindService(new CalculatorServiceImplementation()) },
                    Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
                };

                server.Start();
                Console.WriteLine("The server is listening on the port: 50051");
                Console.ReadKey();
            }
            catch (IOException e)
            {
                Console.WriteLine($"Something went wrong - {e.Message}");
                throw;
            }
            finally
            {
                if (server != null)
                    server.ShutdownAsync().Wait();
            }
        }
    }
}
