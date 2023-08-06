using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseStaticFiles(new StaticFileOptions
{
	FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "UploadFiles")),
	RequestPath = "/UploadFiles",
});

// ³]©w CORS ¬Fµ¦
app.UseCors(builder =>
{
	builder.WithOrigins("https://6cb5-2402-7500-5d1-3aa5-109c-b58f-22c0-a00d.ngrok-free.app")
		   .AllowAnyHeader()
		   .AllowAnyMethod();
});

app.MapControllers();

app.Run();
