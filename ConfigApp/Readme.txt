������� ��� ��������� ������ ���������� � ���������������� ����� ����������

��� ���������� �� .NET4 
1. ��������� ������� SQL, 
2. ���� ������������ ������� ���� �� �����������, 
3. ���������� ���������� ConnectionString
4. ���������� ��� � ��������� App.config

��������� ��� ���� ����� � ������� .net �����������, ������� ��������� ���������, � ��������� � ������� ������� ���������.

���������� ������������� � ����� Program.Cs ����� ��������� ����������� ����������:
- AppConfigName - ���� ������������ �������� ���������� (�������� exampleApp.exe.config);
- DatabaseName - ��� ���� ������, ������� ���������� � �������� Database � ������ ����������
- DatabaseContextName - ��� ���������, ������� ��������� � ����� exampleApp.exe.config. 

� ������� ���������������� ����� ������ �������������� ������ ���������� ������� �����������, ��������, � ����������. 
������������ ������ xml-������� � ��������� ������ ��������� � ������ �������� ������ ���������� �� ��, ������� �������� ������������.

������������ ���������� �������� � ������� exe-���, ����� ����������� ����� �������� �������������� �����, ������� ��������� ��� ������� ������������� (�������� exe.config).



������:
����� ������� ������ DatabaseServer. � ����� ������ ����� ��� ����������� dll, exe � exe.config ��� ������� ����� �������:
\DatabaseServer
	DatabaseServer.exe
	DatabaseServer.exe.config
	DatabaseServer.Core.dll
	...

� ����� DatabaseServer.exe.config ������������ ����� �������:
	<connectionStrings>
	    <add name="DatabaseServerContext" providerName="System.Data.SqlClient" connectionString="Data Source = (local); Database=DatabaseServer; Integrated Security = False; User Id=sa; Password=testtest;" />
	</connectionStrings>
����� ������� - ��� ������� xml �������� � ������ DatabaseServerContext � �������� connectionString.

��������� ������� � �������������� CondigApp.sln
� ����� Program.cs ����������� ����������� ����������:

	public static string AppConfigFile { get { return "DatabaseServer.exe.config"; } }
	public static string DatabaseName { get { return "DatabaseServer"; } }
	public static string DatabaseContextName { get { return "DatabaseServerContext"; } }

������ ������ � Release, � ���� ������������ ������� �� ���������, �� � ����� Release ����� ������������ ���� ConfigApp.exe.
���� ������������ ����������, �� � ��������� ������� ConfigApp.csproj ����� ��������� Post-build event �������� ���: $(ProjectDir)\merge_all.bat  "$(SolutionDir)" "$(TargetPath)" $(ConfigurationName)
� ����� � .csproj �������� merge_all.bat, ������� ����� ������� �����, ��������: https://github.com/gzvulon/ILMerge-Example/blob/master/ILMerge/merge_all.bat

������ ������������ ConfigApp.exe � ����� � ������� ������ �������
\DatabaseServer
	DatabaseServer.exe
	DatabaseServer.exe.config
	DatabaseServer.Core.dll
+	ConfigApp.exe
	...

� ����������� ��� ��� � �����������, �������� ��� ����� ��������� ��������� ConfigApp.exe.
����� ����, ����� ��������� ��� ������� � � �������� ������ �������� �������, ��� �������, �� ����������� ���������� ����������.

�� ������ ��������� ������� ������� ������������� ���������� ����������� Inno Setup 5.