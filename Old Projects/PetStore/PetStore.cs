// using System;
// using System.Collections.Generic;

// namespace petstore
// {
// public class Program 
// {

// static void Main(string[] args)
// {
//     var dogList = new NewPet("cat", 88);
//     var catList = new NewPet("catdog", 153);
//     catList.AddAnimal("Tiger", 3432);
//     catList.AddAnimal("Lion", 525);
//     catList.Walker();
 
//     Console.WriteLine(catList.GetInventory());

//     // Console.WriteLine(Inventory.GetInventory());
// }

// }




//  public class NewPet{
//      public List<PetStoreInventory> inventoryList = new List<PetStoreInventory>();
//     public string Breed {get;}
//     public decimal Price {get;}
//     public int Happiness {get;}
//     public NewPet(string Breed, decimal Price)
//     {
//         AddAnimal(Breed, Price);
//     }
//     public string GetInventory() {
//         string sentence = "Animal:\t \tPrice:\t \t Happiness:";
//         foreach (var item in inventoryList)
//         {
//             sentence+= $"\n{item.Breed}\t\t{item.Price}\t\t{item.Happiness}";
//         }
//         return sentence;
//     }

//     public void AddAnimal(string Breed, decimal Price)
//     {
//         var newAnimal = new PetStoreInventory(Breed, Price);
//         inventoryList.Add(newAnimal);
//     }

//     public void Walker (){
//         foreach (var animal in inventoryList)
//     {

//        animal.Happiness += 30;
//     }
//     }

//  }
// }