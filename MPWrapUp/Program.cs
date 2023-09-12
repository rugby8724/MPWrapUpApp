using MPWrapUp;

List<PersonModel> people = new List<PersonModel>()
{
    new PersonModel{FirstName = "Tad", LastName="Pole", Email="tp@gmail" },
    new PersonModel{FirstName = "Eric", LastName="Corbert", Email="ec@gmail" },
    new PersonModel{FirstName = "Ben", LastName="Ben", Email="bb@gmail" },
};



List<CarModel> cars = new List<CarModel>()
{
    new CarModel{Manufacturer = "Ford", Model = "Mustang"},
    new CarModel{Manufacturer = "Nissan", Model = "280zx"},
    new CarModel{Manufacturer = "Honda", Model = "accord"}

};

people.SavetoCSV(@"C:\cTest\people.csv");
cars.SavetoCSV(@"C:\cTest\cars.csv");
