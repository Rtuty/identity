using Microsoft.AspNetCore.Mvc;
using Identity;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var userlist = new List<User>();

app.UseSwagger();
app.UseSwaggerUI();

app.MapPost("/register", (RegisterBody User) =>
{
    if (userlist.Count == 0)
    {
        userlist.Add(item: new User()
        {
            Id = userlist.Count,
            Login = User.Login,
            Password = User.Password,
        });
    }
    else
    {
        userlist.Add(new User()
        {
            Id = userlist.Last().Id + 1,
            Login = User.Login,
            Password = User.Password,
        });
    }
});

app.MapPost("/authorization", (AuthorizationBody User) =>
{
});

app.Run();