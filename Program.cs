using AutoMapper;
using DataTransferObjectIntro.Dtos;
using DataTransferObjectIntro.Profiles;
using DataTransferObjectIntro.Repositories;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(UserProfile));

builder.Services.AddTransient<IUserRepository, UserRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/user", async ([FromServices] IUserRepository repository,
                           [FromServices] IMapper mapper) =>
{
    return mapper.Map<IEnumerable<UserDto>>(await repository.GetAllAsync());
});

app.Run();
