using ContactsEFCoreInMemory.Context.Seeders;

var builder = WebApplication.CreateBuilder(args);

#region Services Configurations

// Register InMemory database context
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()),
        ServiceLifetime.Singleton,
        ServiceLifetime.Singleton
    );


// Add services to the container.
builder.Services.AddRazorPages();

#endregion

# region App Configurations
var app = builder.Build();

// Seed Datbase
var context = app.Services.GetRequiredService<DatabaseContext>();
DBSeeder.Initialize(context);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

#endregion