﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Db_1Entities : DbContext
    {
        public Db_1Entities()
            : base("name=Db_1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminLoginInfo> AdminLoginInfoes { get; set; }
        public virtual DbSet<DeveloperLoginInfo> DeveloperLoginInfoes { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<GetSubtaskInfo> GetSubtaskInfoes { get; set; }
        public virtual DbSet<GetTaskInfo> GetTaskInfoes { get; set; }
        public virtual DbSet<ManagerLoginInfo> ManagerLoginInfoes { get; set; }
        public virtual DbSet<Subtask> Subtasks { get; set; }
    
        public virtual ObjectResult<string> GetLoginInfo(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetLoginInfo", userNameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<Admin_Home_Result> Admin_Home()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Admin_Home_Result>("Admin_Home");
        }
    
        public virtual int Change_Password_Developer(Nullable<int> id, string previous, string @new, string confirmNew)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var previousParameter = previous != null ?
                new ObjectParameter("Previous", previous) :
                new ObjectParameter("Previous", typeof(string));
    
            var newParameter = @new != null ?
                new ObjectParameter("New", @new) :
                new ObjectParameter("New", typeof(string));
    
            var confirmNewParameter = confirmNew != null ?
                new ObjectParameter("ConfirmNew", confirmNew) :
                new ObjectParameter("ConfirmNew", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Change_Password_Developer", idParameter, previousParameter, newParameter, confirmNewParameter);
        }
    
        public virtual int Change_Password_Manager(Nullable<int> id, string previous, string @new, string confirmNew)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var previousParameter = previous != null ?
                new ObjectParameter("Previous", previous) :
                new ObjectParameter("Previous", typeof(string));
    
            var newParameter = @new != null ?
                new ObjectParameter("New", @new) :
                new ObjectParameter("New", typeof(string));
    
            var confirmNewParameter = confirmNew != null ?
                new ObjectParameter("ConfirmNew", confirmNew) :
                new ObjectParameter("ConfirmNew", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Change_Password_Manager", idParameter, previousParameter, newParameter, confirmNewParameter);
        }
    
        public virtual ObjectResult<Current_Task_Manager_Result> Current_Task_Manager(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Current_Task_Manager_Result>("Current_Task_Manager", idParameter);
        }
    
        public virtual int Feedback_Manager(Nullable<int> developerId)
        {
            var developerIdParameter = developerId.HasValue ?
                new ObjectParameter("DeveloperId", developerId) :
                new ObjectParameter("DeveloperId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Feedback_Manager", developerIdParameter);
        }
    
        public virtual ObjectResult<My_developers_ratings_Result> My_developers_ratings(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<My_developers_ratings_Result>("My_developers_ratings", idParameter);
        }
    
        public virtual ObjectResult<My_PreviousSubtasks_Result> My_PreviousSubtasks(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<My_PreviousSubtasks_Result>("My_PreviousSubtasks", idParameter);
        }
    
        public virtual ObjectResult<Nullable<double>> My_Rating(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("My_Rating", idParameter);
        }
    
        public virtual ObjectResult<My_Subtasks_Result> My_Subtasks(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<My_Subtasks_Result>("My_Subtasks", idParameter);
        }
    
        public virtual ObjectResult<Previous_Task_Manager_Result> Previous_Task_Manager(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Previous_Task_Manager_Result>("Previous_Task_Manager", idParameter);
        }
    
        public virtual ObjectResult<Nullable<double>> My_Rating1(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("My_Rating1", idParameter);
        }
    
        public virtual ObjectResult<View_MyRatings_Result> View_MyRatings(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<View_MyRatings_Result>("View_MyRatings", idParameter);
        }
    }
}