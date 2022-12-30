
## Table of contents
* [ Genel Bilgi ](#Genel-Bilgi )
* [Teknoloji Pac.](#Teknoloji-Pac.)
* [Setup | Kurulum](#Setup-Kurulum)
* [Dotnet-Run-Sureci](#Dotnet-Run-Sureci)
* [Support-Destek](#Support-Destek)
* [Detail | Design |Açıklama ](#Detail-Design-Açıklama )

## Genel Bilgi 
Bu proje C# & Visual Code ile GazlicecekEnverter app yapılmıştır.
	
## Teknoloji-Pac.
Proje aşağıdaki packages onuşturulmuştur;
package list for sqlServer
    *"Microsoft.EntityFrameworkCore" Version="6.0.2"
   *"Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.2" 
   *"Microsoft.EntityFrameworkCore.Tools" Version="6.0.2"
   *"Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="6.0.2"


## Setup-Kurulum
Tüm Kurulum adım adım proje debug süreci aşağıdaki adımları izleyebilirsiniz?
*VSCode - https://code.visualstudio.com/Download
*NET Coding Pack - https://aka.ms/dotnet-coding-pack-win
*NET Extension Pack - vscode:extension/ms-dotnettools.vscode-dotnet-pack
*NET SDK-x64 - https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.101-windows-x64-installer
*SQL2019-SSEI-Expr-https://www.cozumpark.com/sql-server-2019-kurulumu/
	


## Dotnet-Run-Sureci
```
 $dotnet new mvc -o GazliIcecekProject
 $dotnet build 
 $dotnet run 
 $dotnet ef migrations add CreateGazliIcecekDb
 $dotnet ef dbcontext scaffold "Server=MAMIOFFICAL\SQLEXPRESS;Database=GazliIcecek;Trusted_Connection=True;Encrypt=False;" Microsoft.EntityFrameworkCore.SqlServer -o Models
 $dotnet ef database update
```
	
## Support-Destek 
1.Install .NET on Windows|
	✔️ Supported	 |
          7 (STS)	 |
          6 (LTS)	 |
-------------------------|


![WhatsApp Image 2022-12-24 at 1 45 28 PM](https://user-images.githubusercontent.com/38388188/210081736-af9125cb-b19d-4acf-8a65-1e5bf38258a9.jpeg)
![WhatsApp Image 2022-12-24 at 1 45 00 PM](https://user-images.githubusercontent.com/38388188/210081738-f40a6569-d2ab-4af0-ab68-d59026267f77.jpeg)
![WhatsApp Image 2022-12-24 at 1 44 49 PM](https://user-images.githubusercontent.com/38388188/210081740-cbf464ca-7fdd-4f4f-817a-2695c17cea32.jpeg)
![WhatsApp Image 2022-12-24 at 1 44 37 PM](https://user-images.githubusercontent.com/38388188/210081743-aa31e57e-1ce7-412d-afe8-80c38ce9ea2b.jpeg)

![image](https://user-images.githubusercontent.com/38388188/210082048-5f4a18c8-f17d-4494-ac9f-58da66dc6ef5.png)
![image](https://user-images.githubusercontent.com/38388188/210082119-655c8be8-14ec-4991-abb7-d5a9c0091a79.png)
![image](https://user-images.githubusercontent.com/38388188/210082348-6dfbaa27-fd23-4d46-a8bc-45d290fa3ebb.png)
- 👋 Hi, I’m @MuhammetKubat
- 👀 I’m interested in VsCode 
- 🌱 I’m currently learning C#
- 💞️ I’m looking to collaborate on __-
- 📫 How to reach me @

## Detail-Design-Açıklama  
![image](https://user-images.githubusercontent.com/38388188/210100624-159d6470-f056-4a6f-b55e-86d7e4fb3a49.png)
