
namespace ModelFun.Models
{
   public class User
{  
    public string[] users {get;set;}
    public string userOne{get;set;}
        public User(string[] allusers){
            users= allusers;
    }
        public User(string allusers){
            userOne= allusers;
        }
}






}