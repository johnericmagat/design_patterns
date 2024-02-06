//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using design_patterns.Adapter;
using design_patterns.Singleton;

//Thread t1 = new Thread(() =>
//{
//	var instance = UploadFileService.Instance(1);
//	Console.WriteLine(instance.Id);
//});

//Thread t2 = new Thread(() =>
//{
//	var instance = UploadFileService.Instance(2);
//	Console.WriteLine(instance.Id);
//});

//t1.Start();
//t2.Start();

//t1.Join();
//t2.Join();

IEmployeeTarget target = new EmployeeAdapter(new EmployeeService());
BonusClient bonus = new BonusClient(target);
bonus.ShowEmployees();