# C #

installer .net ([dotnet](https://dotnet.microsoft.com/en-us/download))
> *il est possible que certaines extentions / installations soient necessaire.
> notament pour le debugger*

<u>sous mac :</u>

`brew install mono-libgdiplus mono`

pour lancer le program nouvellement developé :

```shell
csc "00.init.OLD/Program.cs"
mono "00.init.OLD/Program.exe"
```

## OR

```shell
cd 00.init.OLD
dotnet run 
```

*fonctionne aussi sous mac si tout est bien configuré*

verifier dans [*.csproj](00.init.OLD/init.csproj)

que la ligne `Include` correspond bien au fichier que vous voulez executer:

```xml
  <ItemGroup>
    <Compile Include="Age.cs"/>
  </ItemGroup>
```
