using LMS_Project.Data;
using LMS_Project.Mapper;
using LMS_Project.Repository;
using LMS_Project.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>
    (
    options => options.UseSqlServer
    (
        builder.Configuration.GetConnectionString("dbconn")
    )
    );

builder.Services.AddAutoMapper(typeof(MappingData));
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IUserRolesService, UserRoleService>();
builder.Services.AddScoped<IRolesService, RolesService>();
builder.Services.AddScoped<ICountriesService, CountriesService>();
builder.Services.AddScoped<IStatesService, StatesService>();
builder.Services.AddScoped<ICitiesService, CitiesService>();
builder.Services.AddScoped<IPincodesService, PincodesService>();
builder.Services.AddScoped<IRejectionReasonService, RejectionReasonService>();
builder.Services.AddScoped<IEmploymentTypeService, EmploymentTypeService>();
builder.Services.AddScoped<IBankService, BankService>();
builder.Services.AddScoped<IOccupationTypeService, OccupationTypeService>();
builder.Services.AddScoped<IDocumentTypeService, DocumentTypeService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IBranchService, BranchService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
