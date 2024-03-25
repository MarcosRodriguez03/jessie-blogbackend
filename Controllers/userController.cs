using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class userController : ControllerBase
{
    //we need this to pass data into the userService so no logic in here
    private readonly userService _data;
    public userController(userService data)
    {
        _data = data;
    }
    //login 
    //add user
    //if user already exist 
    //if user does not exist, create new account 
    //else return false
    public bool AddUser(CreateAccountDTO UserToAdd)
    {
        return _data.AddUser(UserToAdd);
    }


    //update user
    //delete user
}
