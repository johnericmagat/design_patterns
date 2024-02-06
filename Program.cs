//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using design_patterns.Adapter;
using design_patterns.Observer;
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

//IEmployeeTarget target = new EmployeeAdapter(new EmployeeService());
//BonusClient bonus = new BonusClient(target);
//bonus.ShowEmployees();

var shift = new Shift("101", "08:30AM to 05:30PM");
var emailNotification = new EmailNotification();
shift.Subscribe(emailNotification);

shift.UpdateShift("102", "09:00AM to 06:00PM");
Console.ReadLine();