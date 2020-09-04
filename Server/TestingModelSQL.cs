namespace Server
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {
        // Your context has been configured to use a 'TestingModelSQL' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Server.TestingModelSQL' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TestingModelSQL' 
        // connection string in the application configuration file.
        public ModelContext()
            : base("name=TestingModelSQL")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Result> Results { get; set; }
    }

    public class Group
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<User> UUsers { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
        public string GroupTitle
        {
            get
            {
                return Group.Title;
            }
            set
            {
                Group.Title = GroupTitle;
            }
        }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual List<Test> Tests { get; set; }
        public virtual List<Result> Results { get; set; }

    }
    public class Test
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        public string Path { get; set; }
        public virtual User User { get; set; }
        public string UserName
        {
            get
            {
                return User.Name;
            }
            set
            {
                User.Name = UserName;
            }
        }
        public DateTime DateTime { get; set; }
        public int PassTimeSec { get; set; }

    }
    public class Result
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public string UserName
        {
            get
            {
                return User.Name;
            }
            set
            {
                User.Name = UserName;
            }
        }
        public int TestId { get; set; }
        public virtual Test Test { get; set; }
        public string TestTitle
        {
            get
            {
                return Test.Theme;
            }
            set
            {
                Test.Theme = TestTitle;
            }
        }
        public DateTime DateTime { get; set; }
        public double Rating { get; set; }
    }
}