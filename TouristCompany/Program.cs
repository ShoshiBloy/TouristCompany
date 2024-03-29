using TouristCompany;
using Microsoft.EntityFrameworkCore;
using BlTour;
using DalTour;


using DalTour.DalModels;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//app.MapGet("/", () => "Hello World!");
builder.Services.AddSwaggerGen();





DBActions db=new DBActions(builder.Configuration);
string connStr = db.GetConnectionString("TourComp");
builder.Services.AddDbContext<TouristContext>(opt=>opt.UseSqlServer(connStr));
builder.Services.AddSingleton<BLManager>();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseCors();
app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();

