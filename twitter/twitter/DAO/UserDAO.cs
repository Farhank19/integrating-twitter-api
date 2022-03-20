using twitter.Model;

namespace twitter.DAO
{
    public interface UserDAO
    {
        Task<Response> GetAllUserDetaile();
        Task<Response> GetUserDetaile(int id);
        Task<Response> SignUp(User obj);
        Task<Response> Login(User obj);
        Task<Response> GetUserTweets(string data);
        Task<Response> GetTweet(long id);
        Task<Response> DeleteTweet(long id);
        Task<Response> PostTweet(string data);
    }
}
