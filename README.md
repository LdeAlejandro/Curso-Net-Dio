#net #netfundamentos #Dio #Doc #programming #bootcamp #bootcampAvanade #avanade #curso
# Categorización y Documentación del Código

En este documento se presenta una categorización y documentación detallada del código proporcionado, que abarca diversos ejemplos de funcionalidades y conceptos en C#.

## Deserialización JSON

### Descripción
Este bloque de código se encarga de deserializar un archivo JSON llamado "vendasDeserialize.json", que contiene datos de ventas. Luego, muestra la información de cada venta en la consola.

```c#
using Newtonsoft.Json;

string jsonFile = File.ReadAllText("Arquivos/vendasDeserialize.json");

List<VendaDeserialize> listDeVendas = JsonConvert.DeserializeObject<List<VendaDeserialize>>(jsonFile);

foreach (VendaDeserialize venda in listDeVendas)
{
    Console.WriteLine($"Venda:\n Id: {venda.Id} Product: {venda.ProductName} preço: {venda.Preco} hora da venda: {venda.dataDeVenda.ToString("dd/MM/yyy HH:mm")}");
}
```


### Funcionalidad

1. Lee el archivo JSON.
2. Deserializa su contenido en una lista de objetos `VendaDeserialize`.
3. Muestra la información de cada venta, incluyendo ID, nombre del producto, precio y hora de la venta.

## Ejemplos de Funcionalidades y Conceptos

### Desestructuración

Este ejemplo muestra cómo se puede utilizar la desestructuración para extraer valores de un objeto en variables individuales.

```c#
// Ejemplo de desestructuración
Pessoa p1 = new Pessoa("Alejandro", "Garcia");
(string nome, string sobrenome) = p1;
Console.WriteLine($"{nome} {sobrenome}");
```


### Operador Ternario

Ilustra el uso del operador ternario para tomar decisiones basadas en una condición.

```c#
// Ejemplo de operador ternario
int numero = 10;
bool esPar = numero % 2 == 0;
Console.WriteLine($"El número {numero} es " + (esPar ? "par" : "impar"));
```

### Tuplas

Proporciona ejemplos de diferentes formas de declarar y utilizar tuplas en C#, tanto accediendo a los elementos por posición como por nombre de variable.

```c#
// Ejemplo de tuplas
(int id, string Nome, string Sobre, decimal Altura) tupla = (1, "Alejandro", "Garcia", 1.83M);
Console.WriteLine($"Id: {tupla.id}, Nome: {tupla.Nome}, Sobrenome: {tupla.Sobre}, Altura: {tupla.Altura}");
```

### Diccionarios

Muestra cómo trabajar con diccionarios en C#, incluyendo agregar, eliminar y modificar elementos, así como verificar la existencia de una clave específica.

```c#
// Ejemplo de diccionarios
Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
Console.WriteLine($"Estado de SP: {estados["SP"]}");
```


### Pilas (Stack) y Colas (Queue)

Este bloque presenta cómo trabajar con pilas (LIFO) y colas (FIFO) en C# utilizando las clases `Stack` y `Queue`.

```c#
// Ejemplo de pila (Stack)
Stack<int> pila = new Stack<int>();
pila.Push(1);
int elemento = pila.Pop();
Console.WriteLine($"Elemento desapilado: {elemento}");

// Ejemplo de cola (Queue)
Queue<int> cola = new Queue<int>();
cola.Enqueue(1);
int elemento = cola.Dequeue();
Console.WriteLine($"Elemento desencolado: {elemento}");
```

### Manejo de Excepciones

Muestra cómo manejar excepciones en C# utilizando bloques `try`, `catch` y `finally`, y cómo especificar diferentes tipos de excepciones para manejar.

```c#
// Ejemplo de manejo de excepciones
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error genérico: {ex.Message}");
}
finally
{
    Console.WriteLine("Operación finalizada");
}
```

### Otros Ejemplos

Incluye ejemplos adicionales, como conversión de fechas, formatos de números y cadenas, y llamadas a métodos de otras clases.

```c#
// Ejemplo de formateo de fecha y hora
DateTime fecha = DateTime.Now;
Console.WriteLine($"Fecha actual: {fecha.ToString("dd/MM/yyyy HH:mm:ss")}");

// Ejemplo de formateo de números
decimal valorMonetario = 82.40M;
Console.WriteLine($"Valor monetario: {valorMonetario:C2}");

// Ejemplo de llamada a método de otra clase
Pessoa p1 = new Pessoa("Alejandro", "Garcia");
p1.Apresentar();
```

Este documento proporciona una descripción detallada de cada bloque de código, categorizando y documentando sus funcionalidades y conceptos asociados. Es útil para comprender y aplicar estos conceptos en proyectos de desarrollo en C#.


Este documento incluye el código proporcionado, categorizado y documentado según su funcionalidad y conceptos asociados. Puede ser utilizado como referencia para entender y aplicar estos conceptos en proyectos de desarrollo en C#.


#net #netfundamentos #Dio #Doc #programming #bootcamp #bootcampAvanade #avanade #curso
# Categorización y Documentación del Código

En este documento se presenta una categorización y documentación detallada del código proporcionado, que abarca diversos ejemplos de funcionalidades y conceptos en C#.

## Clase Curso

### Descripción
La clase `Curso` representa un curso y contiene propiedades y métodos relacionados con la gestión de alumnos en el curso.

### Propiedades

- **Nome**: Representa el nombre del curso.
- **Alunos**: Lista de objetos `Pessoa` que representan los alumnos matriculados en el curso.

### Métodos

- **AdicionarAluno**: Agrega un nuevo alumno a la lista de alumnos matriculados en el curso.
- **ObterQuantidadeDeAlunosMatriculados**: Retorna la cantidad de alumnos matriculados en el curso.
- **RemoverAluno**: Elimina un alumno de la lista de alumnos matriculados en el curso.
- **ListarAlunos**: Muestra en la consola la lista de alumnos matriculados en el curso.

## Ejemplos de Funcionalidades y Conceptos

El código proporcionado muestra ejemplos de cómo trabajar con clases, propiedades, métodos, bucles `for` y `foreach`, y formatos de cadena en C#. También muestra cómo interactuar con objetos de otras clases, en este caso, la clase `Pessoa`.

Este documento proporciona una descripción detallada de la clase `Curso` y sus funcionalidades asociadas, facilitando la comprensión y aplicación de estos conceptos en proyectos de desarrollo en C#.


#net #netfundamentos #Dio #Doc #programming #bootcamp #bootcampAvanade #avanade #curso
# Categorización y Documentación del Código

En este documento se presenta una categorización y documentación detallada del código proporcionado, que muestra un ejemplo de manejo de excepciones en C#.

## Clase ExemploExcecao

### Descripción
La clase `ExemploExcecao` contiene una serie de métodos que se llaman entre sí y generan y manejan una excepción.


### Métodos

- **Metodo1**: Este método llama a `Metodo2` dentro de un bloque `try-catch`. Si se produce una excepción en alguno de los métodos llamados, se captura en el bloque `catch` y se imprime el stack trace de la excepción.
- **Metodo2**: Llama al método `Metodo3`.
- **Metodo3**: Llama al método `Metodo4`.
- **Metodo4**: Genera una excepción de tipo `Exception` con un mensaje específico.

## Ejemplo de Manejo de Excepciones

El código proporcionado muestra un ejemplo de cómo se puede usar un bloque `try-catch` para manejar excepciones en C#. En este caso, se crea intencionalmente una excepción en el método `Metodo4`, y se captura y maneja en el método `Metodo1`. La captura de la excepción permite imprimir información adicional, como el stack trace, para ayudar en la depuración del problema.

Este documento proporciona una descripción detallada del ejemplo de manejo de excepciones en la clase `ExemploExcecao`, facilitando la comprensión de este importante concepto en la programación en C#.



#net #netfundamentos #Dio #Doc #programming #bootcamp #bootcampAvanade #avanade #curso
# Categorización y Documentación del Código

En este documento se presenta una categorización y documentación detallada del código proporcionado, que muestra un ejemplo de lectura de archivos y retorno de tuplas en C#.

## Clase LeituraArquivo

### Descripción
La clase `LeituraArquivo` contiene un método que lee el contenido de un archivo y devuelve una tupla con el resultado de la operación, las líneas leídas y el número total de líneas.

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_Net_2.Models
{
    public class LeituraArquivo
    {
        // Método para retornar tuplas
        public (bool sucessfullRead, string[] textInLine, int totalLines) readFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                return (true, lines, lines.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}
```

### Métodos

- **readFile**
    - **Descripción**: Este método intenta leer todas las líneas de un archivo especificado por la ruta `filePath`. Devuelve una tupla con tres elementos:
        - **sucessfullRead** (`bool`): Indica si la lectura del archivo fue exitosa (`true`) o no (`false`).
        - **textInLine** (`string[]`): Un array de strings con las líneas leídas del archivo. Si la lectura falla, este array estará vacío.
        - **totalLines** (`int`): El número total de líneas leídas. Si la lectura falla, este valor será `0`.
    - **Parámetros**:
        - `filePath` (`string`): La ruta del archivo a leer.
    - **Retorno**: Una tupla (`bool`, `string[]`, `int`) que indica el resultado de la lectura del archivo.


Este documento proporciona una descripción detallada del método `readFile` en la clase `LeituraArquivo`, facilitando la comprensión y aplicación del manejo de lectura de archivos y retorno de tuplas en proyectos de desarrollo en C#.

#net #netfundamentos #Dio #Doc #programming #bootcamp #bootcampAvanade #avanade #curso
# Categorización y Documentación del Código

En este documento se presenta una categorización y documentación detallada del código proporcionado, que muestra un ejemplo de una clase `Pessoa` en C# con diversas funcionalidades incluyendo constructores, destructores, propiedades y métodos.

## Clase Pessoa

### Descripción
La clase `Pessoa` representa una persona con propiedades de nombre, apellido y edad. También incluye métodos para presentar la información de la persona y un destructor para obtener las propiedades por separado.

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_Net_2.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        // Exemplo de constructor
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Exemplo de destructor, a declaração da variáveis é inversa e tem os parâmetros out
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome;
        private int _idade;

        public string Nome
        {
            // Usando expressão lambda para get
            get => _nome.ToUpper();

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public int Idade
        {
            get => _idade;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A idade não pode ser menor ou igual a zero");
                }
                _idade = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}
```


### Propiedades

- **Nome** (`string`)
    
    - **Descripción**: Nombre de la persona. No puede ser una cadena vacía.
    - **Getter**: Devuelve el nombre en mayúsculas.
    - **Setter**: Establece el nombre. Si es una cadena vacía, lanza una excepción `ArgumentException`.
- **Sobrenome** (`string`)
    
    - **Descripción**: Apellido de la persona. Se establece y se obtiene directamente.
- **Idade** (`int`)
    
    - **Descripción**: Edad de la persona. Debe ser mayor que 0.
    - **Getter**: Devuelve la edad.
    - **Setter**: Establece la edad. Si es menor o igual a 0, lanza una excepción `ArgumentException`.
- **NomeCompleto** (`string`)
    
    - **Descripción**: Devuelve el nombre completo (nombre y apellido) en mayúsculas.

### Métodos

- **Pessoa()**
    
    - **Descripción**: Constructor por defecto.
- **Pessoa(string nome, string sobrenome)**
    
    - **Descripción**: Constructor que inicializa las propiedades `Nome` y `Sobrenome`.
    - **Parámetros**:
        - `nome` (`string`): El nombre de la persona.
        - `sobrenome` (`string`): El apellido de la persona.
- **Deconstruct(out string nome, out string sobrenome)**
    
    - **Descripción**: Destructor que devuelve el nombre y el apellido como variables separadas.
    - **Parámetros**:
        - `nome` (`string`): Variable de salida que contendrá el nombre.
        - `sobrenome` (`string`): Variable de salida que contendrá el apellido.
- **Apresentar()**
    
    - **Descripción**: Imprime el nombre completo y la edad de la persona en la consola.


Este documento proporciona una descripción detallada de la clase `Pessoa`, sus propiedades y métodos, facilitando la comprensión y aplicación del manejo de objetos de persona en proyectos de desarrollo en C#.

#net #netfundamentos #Dio #Doc #programming #bootcamp #bootcampAvanade #avanade #curso
# Categorización y Documentación del Código

En este documento se presenta una categorización y documentación detallada del código proporcionado, que muestra un ejemplo de una clase `Venda` en C# con sus respectivas propiedades y constructor.

## Clase Venda

### Descripción
La clase `Venda` representa una venta con propiedades de identificación, nombre del producto, precio y fecha de venta. También incluye un constructor para inicializar estas propiedades.

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_Net_2.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, DateTime datadevenda)
        {
            Id = id;
            ProductName = produto;
            Preco = preco;
            dataDeVenda = datadevenda;
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Preco { get; set; }
        public DateTime dataDeVenda { get; set; }
    }
}
```


### Propiedades

- **Id** (`int`)
    
    - **Descripción**: Identificación única de la venta.
    - **Getter/Setter**: Obtiene o establece el identificador de la venta.
- **ProductName** (`string`)
    
    - **Descripción**: Nombre del producto vendido.
    - **Getter/Setter**: Obtiene o establece el nombre del producto.
- **Preco** (`decimal`)
    
    - **Descripción**: Precio del producto vendido.
    - **Getter/Setter**: Obtiene o establece el precio del producto.
- **dataDeVenda** (`DateTime`)
    
    - **Descripción**: Fecha y hora de la venta.
    - **Getter/Setter**: Obtiene o establece la fecha y hora de la venta.

### Constructor

- **Venda(int id, string produto, decimal preco, DateTime datadevenda)**
    - **Descripción**: Constructor que inicializa las propiedades `Id`, `ProductName`, `Preco` y `dataDeVenda`.
    - **Parámetros**:
        - `id` (`int`): Identificación de la venta.
        - `produto` (`string`): Nombre del producto vendido.
        - `preco` (`decimal`): Precio del producto vendido.
        - `datadevenda` (`DateTime`): Fecha y hora de la venta.

#net #netfundamentos #Dio #Doc #programming #bootcamp #bootcampAvanade #avanade #curso
# Categorización y Documentación del Código

En este documento se presenta una categorización y documentación detallada del código proporcionado, que muestra un ejemplo de una clase `VendaDeserialize` en C# con sus respectivas propiedades y configuración para la deserialización de JSON usando el paquete `Newtonsoft.Json`.

## Clase VendaDeserialize

### Descripción
La clase `VendaDeserialize` representa una venta deserializada de un archivo JSON, con propiedades para la identificación, nombre del producto, precio y fecha de venta. Usa el atributo `JsonProperty` para mapear las propiedades JSON a las propiedades de la clase.

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Curso_Net_2.Models
{
    public class VendaDeserialize
    {
        public int Id { get; set; }

        // Como o arquivo vendasDeserialize.json tem o nome da variável Product_Name diferente de ProductName
        // na declaração deste arquivo, com o pacote Newtonsoft.Json, podemos fazer a seguinte declaração
        // para que a variável ProductName receba o valor da variável Product_Name no JSON.
        [JsonProperty("Product_Name")]
        public string ProductName { get; set; }
        public decimal Preco { get; set; }
        public DateTime dataDeVenda { get; set; }
    }
}
```

### Propiedades

- **Id** (`int`)
    
    - **Descripción**: Identificación única de la venta.
    - **Getter/Setter**: Obtiene o establece el identificador de la venta.
- **ProductName** (`string`)
    
    - **Descripción**: Nombre del producto vendido, mapeado desde el nombre de propiedad `Product_Name` en el JSON.
    - **Getter/Setter**: Obtiene o establece el nombre del producto.
    - **Atributo**: `[JsonProperty("Product_Name")]` indica que esta propiedad se deserializa desde la propiedad `Product_Name` del JSON.
- **Preco** (`decimal`)
    
    - **Descripción**: Precio del producto vendido.
    - **Getter/Setter**: Obtiene o establece el precio del producto.
- **dataDeVenda** (`DateTime`)
    
    - **Descripción**: Fecha y hora de la venta.
    - **Getter/Setter**: Obtiene o establece la fecha y hora de la venta.

Este documento proporciona una descripción detallada de la clase `VendaDeserialize`, sus propiedades y la configuración necesaria para deserializar objetos desde un archivo JSON utilizando el paquete `Newtonsoft.Json`.

