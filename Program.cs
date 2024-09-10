using System;
using System.Data.SqlClient;
using System.Data;
namespace ADO_Disconnected_Demo
{
    internal class InsertProgram
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt1;
        public static DataTable dt2;
        public static SqlCommandBuilder cb;

        static void Main(string[] args)
{
            try{
                string connect="Data Source =(LocalDB)\\MSSQLLocaldb;initial catalog=MyDatab; integrated security = true;trustservercertificate=true;";
                con = new SqlConnection(connect);//create connect
            //     //create DataAdapter
               da= new SqlDataAdapter("select Id, First_Name , Last_Name,Salary from employee;",con);
                ds=new DataSet();
                da.Fill(ds);
                
             //  dt1=new DataTable();
               dt1=ds.Tables[0];
                // dt1=ds.Tables[1];
                // foreach(DataRow dr in dt1.Rows)
                // {
                //     System.Console.WriteLine(dr[0]+" "+dr[1]+" "+dr[2]+" second table "+dr[0]+" "+dr[1]+" "+dr[2]);
                // }
                cb=new SqlCommandBuilder();
                cb.DataAdapter=da;

                ////insert or add
                // string fname,lname;
                // decimal salary;
                // int Id;
                // System.Console.WriteLine(" To add new employee : \n enter id");
                // Id = Convert.ToInt32(Console.ReadLine());
                // System.Console.WriteLine("To add new employee : \n enter firstname");
                // fname=Console.ReadLine();

                // System.Console.WriteLine("To add new employee : \n enter lastname");
                // lname=Console.ReadLine();

                // System.Console.WriteLine("To add new employee : \n enter salary");
                // salary=Convert.ToDecimal(Console.ReadLine());


                /////update
                string fname,lname;
                decimal salary;
                int Id;
                System.Console.WriteLine(" To update new employee : \n enter id");
                Id = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("To update new employee : \n enter firstname");
                fname=Console.ReadLine();

                System.Console.WriteLine("To addnew employee : \n enter lastname");
                lname=Console.ReadLine();

                System.Console.WriteLine("To add new employee : \n enter salary");
                salary=Convert.ToDecimal(Console.ReadLine());


               /// DataRow row =dt1.NewRow();// dt1 in place of table[0]. .

               foreach(DataRow row in ds.Tables[0].Rows)
               { 
                if(Convert.ToInt32(row["Id"].ToString())==Id)
                {
                   row["First_Name"]=fname;
                   row["Last_Name"]=lname;
                   row["Salary"]=salary;
                   da.Update(ds.Tables[0]);
                   System.Console.WriteLine("Record successfully");
                }
               }
//////////////delete
            //     int Id;
            //     System.Console.WriteLine("To delete Employee :\n enter Id");
            //     Id=Convert.ToInt32(Console.ReadLine());
            //      foreach(DataRow row in ds.Tables[0].Rows)
            //    { 
            //     if(Convert.ToInt32(row["Id"].ToString())==Id)
            //     {
            //         ds.Tables[0].Rows.Remove(row);
            //        da.Update(ds.Tables[0]);
            //        System.Console.WriteLine(" Deleted Record successfully");
            //     }


            //    }
               ////add
                // row["Id"]=Id;
                // row["First_Name"]=fname;
                // row["Last_Name"]=lname;
                // row["Salary"]=salary;
                // dt1.Rows.Add(row);
               
                // da.Update(dt1);

            }
            catch(StackOverflowException ex)
            {
               System.Console.WriteLine(ex.Message);
            }
            // finally{

            // }
        }

    }
}
