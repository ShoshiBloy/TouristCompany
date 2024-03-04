using TouristCompany;
using Microsoft.EntityFrameworkCore;
using BlTour;
using DalTour;

using TouristCompany.DALModels;

var builder = WebApplication.CreateBuilder(args);


//app.MapGet("/", () => "Hello World!");
builder.Services.AddSingleton<BLManager>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
DBActions db = new DBActions(builder.Configuration);
string connStr = db.GetConnectionString("TourComp");
builder.Services.AddDbContext<TouristContext>(opt => opt.UseSqlServer(connStr));

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();


