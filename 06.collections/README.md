# Collection

> Stocker, traiter & manipuler des groupes d'objets efficacement.
> Ajouter, supprimer, remplacer, chercher, copier

---

## Types of collections

### Non-Generic

- peu stocker tout type d'objet situé dans le namespace: `System.Collections`

*exemple collection Non-Generic :*

```csharp
int num = 5;
float secondNum = 3.14f;
string myName = "Kevain";

ArrayList myArrList = new ArrayList();
myArrList.Add(num);
myArrList.Add(secondNum);
myArrList.Add(myName);

foreach(object item in myArrList)
{
   Console.WriteLine(item);
}
```

>plusieurs types ont été utilisés

### Generic

- limité a 1 type d'objet situé dans le namespace: `System.Collections.Generic`

*exemple collection Generic :*

```csharp
string firstAnimal = "Cat";
string secondAnimal = "Dog";
string thirdAnimal = "Flamingo";

List<string> animalsList = new List<string>();
animalsList.Add(firstAnimal);
animalsList.Add(secondAnimal);
animalsList.Add(thirdAnimal);

foreach(string animal in animalsList)
{
   Console.WriteLine(animal);
}
```

>un seul type est possible, ici `string`
