//
// using NHibernate
// using NHibernate.Cfg;

namespace Program;

public class Program {
	public static WebApplication ConfigureProgramBuild(WebApplicationBuilder builder) {
		WebApplication app = builder.Build();

		// Configure the HTTP request pipeline.
		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		app.UseHttpsRedirection();
		
		return app;
	}

	public static WebApplicationBuilder MakeProgramBuilder(string[] args) {
		WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

		// Add services to the container.
		// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();

		return builder;
	}

	public static void Main(string[] args) {
		WebApplicationBuilder builder	= MakeProgramBuilder(args);
		WebApplication app				= ConfigureProgramBuild(builder);

		app.Run();
	}
}
