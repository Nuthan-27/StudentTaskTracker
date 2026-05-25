using StudentTaskTracker.Models;
using StudentTaskTracker.Data;
using Microsoft.EntityFrameworkCore;

namespace StudentTaskTracker.Services;

public class AuthService
{
    public bool IsLoggedIn { get; private set; }

    public string UserEmail { get; private set; } = "";

    private readonly AppDbContext _context;

    public AuthService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Register(string email, string password)
    {
        if (await _context.Users
            .AnyAsync(u => u.Email == email))
        {
            return false;
        }

        var user = new UserModel
        {
            Email = email,
            Password = password
        };

        _context.Users.Add(user);

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<bool> Login(string email, string password)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(u =>
                u.Email == email &&
                u.Password == password);

        if (user != null)
        {
            IsLoggedIn = true;

            UserEmail = email;

            return true;
        }

        return false;
    }

    public void Logout()
    {
        IsLoggedIn = false;

        UserEmail = "";
    }
}