var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


// Controller: Gelen HTTP isteklerini alır, uygun modeli kullanarak verileri işler ve sonunda bir View'e yönlendirerek kullanıcıya bir yanıt verir.
// Action : Bir kontrolcünün içerisinde bulunan, belirli bir görevi yerine getiren metodlardır.
// Model: Veritabanı tablolarına karşılık gelen veya iş mantığına özgü verileri içerir.
// View: Genellikle Razor syntax ile yazılır ve Model'deki verileri kullanarak dinamik içerik oluşturur.
// Razor: HTML kodları içerisine C# kodları ekleyerek dinamik web sayfaları oluşturmamızı sağlar.
// RazorView: Razor syntax ile yazılmış bir view dosyasını temsil eder.
// wwwroot: Uygulamanın statik dosyalarının (CSS, JavaScript, resimler) tutulduğu klasördür.
// builder.Build() : ASP.NET Core uygulamasının yapılandırma işlemini tamamlayan ve uygulamanın çalışmaya hazır hale gelmesini sağlayan metottur.
// app.Run() : Uygulamanın HTTP isteklerini almaya ve işleme başlamasını sağlayan metottur.

