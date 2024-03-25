using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddScoped<blogService>();
builder.Services.AddScoped<userService>();
builder.Services.AddScoped<passwordService>();

var connectionString = builder.Configuration.GetConnectionString("MyBlogString");

// configures entity framework core to use sql server as the database provider for a datacontext DbContext in our project
builder.Services.AddDbContext<DataContext>(Options => Options.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => options.AddPolicy("BlogPolicy", builder =>
{
    builder.WithOrigins("http://localhost:5243")
    .AllowAnyHeader()
    .AllowAnyMethod();
}
));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();
app.UseCors("BlogPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
