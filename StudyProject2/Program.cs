using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder();

// �������� ������ ����������� �� ����� ������������
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

// ��������� �������� ApplicationContext � �������� ������� � ����������
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

var app = builder.Build();

// ��������� ������
app.MapGet("/", (ApplicationContext db) => db.Users.ToList());

app.Run();