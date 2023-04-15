using InformationPersonel.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DbMainContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));
});



var app = builder.Build();

#region Pipeline

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

//  Controller/Action/id?

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


#endregion



app.Run();
