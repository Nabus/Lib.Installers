Утилита для настройки строки соединения в конфигурационном файле приложения

Это приложение на .NET4 
1. сканирует серверы SQL, 
2. дает пользователю выбрать один из экземпляров, 
3. генерирует правильный ConnectionString
4. записывает его в указанный App.config

Подложить его надо рядом с целевым .net приложением, которое требуется настроить, и запустить с помощью скрипта установки.

Приложение настраивается в файле Program.Cs путем установки статических переменных:
- AppConfigName - файл конфигурации целевого приложения (например exampleApp.exe.config);
- DatabaseName - имя базы данных, которое копируется в параметр Database у строки соединения
- DatabaseContextName - имя контекста, которое объявлено в файле exampleApp.exe.config. 

В целевом конфигурационном файле должна присутствовать строка соединения которая применялась, например, в разработке. 
Конфигуратор найдет xml-атрибут с указанным именем контекста и просто подменит строку соединения на ту, которая подходит пользователю.

Конфигуратор желательно собирать в цельную exe-шку, иначе инсталлятор может потерять дополнительные файлы, которые требуются для запуска конфигуратора (например exe.config).



Пример:
Пусть написан проект DatabaseServer. В папке релиза лежат все необходимые dll, exe и exe.config для запуска этого проекта:
\DatabaseServer
	DatabaseServer.exe
	DatabaseServer.exe.config
	DatabaseServer.Core.dll
	...

В файле DatabaseServer.exe.config присутствует такой элемент:
	<connectionStrings>
	    <add name="DatabaseServerContext" providerName="System.Data.SqlClient" connectionString="Data Source = (local); Database=DatabaseServer; Integrated Security = False; User Id=sa; Password=testtest;" />
	</connectionStrings>
Самое главное - это наличие xml элемента с именем DatabaseServerContext и свойства connectionString.

Открываем решение с конфигуратором CondigApp.sln
В файле Program.cs редактируем статические переменные:

	public static string AppConfigFile { get { return "DatabaseServer.exe.config"; } }
	public static string DatabaseName { get { return "DatabaseServer"; } }
	public static string DatabaseContextName { get { return "DatabaseServerContext"; } }

Билдим проект в Release, и если конфигурация проекта не затерлась, то в папке Release будет единственный файл ConfigApp.exe.
Если конфигурация потерялась, то в свойствах проекта ConfigApp.csproj нужно прописать Post-build event примерно так: $(ProjectDir)\merge_all.bat  "$(SolutionDir)" "$(TargetPath)" $(ConfigurationName)
И рядом с .csproj положить merge_all.bat, который можно скачать здесь, например: https://github.com/gzvulon/ILMerge-Example/blob/master/ILMerge/merge_all.bat

Дальше подкладываем ConfigApp.exe в папку с релизом нашего проекта
\DatabaseServer
	DatabaseServer.exe
	DatabaseServer.exe.config
	DatabaseServer.Core.dll
+	ConfigApp.exe
	...

И упаковываем это все в инсталлятор, указывая ему после установки запустить ConfigApp.exe.
Кроме того, можно запускать эту утилиту и в процессе работы целевого проекта, при желании, но потребуется перезапуск приложения.

На момент написания данного мануала использовался бесплатный инсталлятор Inno Setup 5.