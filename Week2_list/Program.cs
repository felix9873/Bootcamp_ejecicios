
List<Libro> libros = new List<Libro>()
{
    new Libro
    {
        Nombre = "El hobbit",
        Precio = 70,
        Stock = 10
    },

    new Libro
    {
        Nombre = "El señor de los anillos la comunidad del anillo" ,
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
        Nombre = "El señor de los anillos" ,
        Precio = 120.40,
        Stock = 10
    },
    new Libro
    {
        Nombre = "El señor de los anillos la 2 torres" ,
        Precio = 120.40,
        Stock = 20
    }
};


Console.WriteLine();

var filterStock = libros.Where(libro => libro.Stock > 10).ToList();

foreach (var item in filterStock)
{
    Console.WriteLine($"stock con mas de 10: {item.Stock} nombre: {item.Nombre}");
}

var filterPrice = libros.Where(libro => libro.Precio > 10.99).ToList();

Console.WriteLine();

foreach (var item in filterPrice)
{
    Console.WriteLine($"libros con menor precio de: {item.Precio}  nombre: {item.Nombre}");
}

Console.WriteLine();

var findWith = libros.FindIndex(libro => libro.Nombre.StartsWith("El"));

Console.WriteLine($"el primer libro encontrado con la inicial el: {libros[findWith].Nombre}");

class Libro
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Stock { get; set; }
}



