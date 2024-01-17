using BethanysPieShopHRM.HR;

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);

bethany.DisplayEmployeeDetails();
bethany.PerformWork(8);
bethany.PerformWork();
bethany.PerformWork(3);
bethany.ReceiveWage();