- 👋 Hi, I’m @MuhammetKubat
- 👀 I’m interested in ...
- 🌱 I’m currently learning ...
- 💞️ I’m looking to collaborate on ...
- 📫 How to reach me ...


1.Install .NET on Windows|
	✔️ Supported	 |
          7 (STS)	 |
          6 (LTS)	 |
-------------------------|

1.VSCode - https://code.visualstudio.com/Download
2.NET Coding Pack - https://aka.ms/dotnet-coding-pack-win
3.NET Extension Pack - vscode:extension/ms-dotnettools.vscode-dotnet-pack
4.NET SDK-x64 - https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-7.0.101-windows-x64-installer
5.SQL2019-SSEI-Expr-https://www.cozumpark.com/sql-server-2019-kurulumu/
-----------------------------------------------------------------------------------
package list for sqlServer----
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="6.0.2" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.2" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.2">
    <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="6.0.2" />
-------------------------------------------------------------------------------------
 dotnet new mvc -o ProjectName 
----------------------------------------------------------------------------------- 
 dotnet build 
 dotnet run 
 dotnet ef migrations add CreateGazliIcecekDb
 dotnet ef dbcontext scaffold "Server=MAMIOFFICAL\SQLEXPRESS;Database=GazliIcecek;Trusted_Connection=True;Encrypt=False;" Microsoft.EntityFrameworkCore.SqlServer -o Models
 dotnet ef database update

<!---
MuhammetKubat/MuhammetKubat is a ✨ special ✨ repository because its `README.md` (this file) appears on your GitHub profile.
You can click the Preview link to take a look at your changes.
--->
