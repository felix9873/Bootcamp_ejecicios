
List<Libro> libros = new List<Libro>()
{
    new Libro
    {
        Nombre = "el hobbit",
        Precio = 70,
        Stock = 10
    },

    new Libro
    {
        Nombre = "el señor de los anillos la comunidad del anillo" ,
        Precio = 120.40,
        Stock = 10
    },
    new Libro
    {
        Nombre = "la torre oscura vol 1" ,
        Precio = 20,
        Stock = 5
    },
    new Libro
    {
        Nombre = "el señor de los anillos" ,
        Precio = 120.40,
        Stock = 10
    },
    new Libro
    {
        Nombre = "el señor de los anillos la 2 torres" ,
        Precio = 120.40,
        Stock = 10
    }
};


var filterStock = libros.Where(libro => libro.Stock > 10).ToList();

foreach (var item in filterStock)
{
    Console.WriteLine($"stock con mas de 10 {item}");
}

var filterPrice = libros.Where(libro => libro.Precio > 10.99).ToList();

var findIndex = libros.FindIndex(libro => libro.Nombre.StartsWith("El"));


class Libro
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Stock { get; set; }
}



