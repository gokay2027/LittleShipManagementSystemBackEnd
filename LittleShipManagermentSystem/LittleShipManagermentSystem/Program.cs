using ListtleShipManagementSystemDomain.Entities;
using LittleShipManagementSystemData;
using LittleShipManagementSystemData.Repositories.Abstract;
using LittleShipManagementSystemData.Repositories.Concrete;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

//Context
builder.Services.AddDbContext<LittleShipManagementContext>();


//Cross origin
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        builder =>
        {
            builder.WithOrigins("http://localhost:3000") // React uygulamanızın adresi
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

//Repositories
builder.Services.AddScoped<IRepository<Captain>, EfCoreCaptainRepository>();
builder.Services.AddScoped<IRepository<Company>, EfCoreCompanyRepository>();
builder.Services.AddScoped<IRepository<Worker>, EfCoreWorkerRepository>();
builder.Services.AddScoped<IRepository<Load>, EfCoreLoadRepository>();
builder.Services.AddScoped<IRepository<Container>, EfCoreContainerRepository>();
builder.Services.AddScoped<IRepository<Ship>, EfCoreShipRepository>();
builder.Services.AddScoped<IRepository<Dock>, EfCoreDockRepository>();
builder.Services.AddScoped<IRepository<Journey>, EfCoreJourneyRepository>();
builder.Services.AddScoped<IRepository<Contract>, EfCoreContractRepository>();
builder.Services.AddScoped<IRepository<Receipt>, EfCoreReceiptRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(MyAllowSpecificOrigins);
app.UseHttpsRedirection();
app.UseCors("AllowReactApp");
app.UseAuthorization();

app.MapControllers();

app.Run();