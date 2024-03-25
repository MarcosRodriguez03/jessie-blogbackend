using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;


public class userService
{
    private readonly DataContext _context;
    public userService(DataContext context)
    {
        _context = context;
    }

    public bool DoesUserExist(string username)
    {
        return _context.UserInfo.SingleOrDefault(user => user.Username == username) != null;
    }
    public bool AddUser(CreateAccountDTO UserToAdd)
    {
        bool result = false;
        if (!DoesUserExist(UserToAdd.Username))
        {
            userModel newUser = new userModel();
            result = true;
        }
        return result;
    }

}
