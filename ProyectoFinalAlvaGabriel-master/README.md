# Proyecto final del 2do cuatrimestre en programacion laboratorio utilizando C#.
![](https://raw.githubusercontent.com/AlvaGabriell/ProyectoFinalAlvaGabriel/master/ImagenProyectoFinal/ImagenProyecto.png)
- ### Se genera un CRUD para un modelo de comercio tipo GYM. La finalidad del mismo implica abarcar los temas vistos durante la cursada desde la clase 10 a la 20.
- Los temas a desarrollar son :
```
- Excepciones
- Pruebas unitarias
- Generics
- Interfaces
- Archivos y Serializacion
- Introduccion a SQL. y Conexión a bases de datos.
- Delegados
- Programación multi-hilo y concurrencia
- Eventos
- Métodos de extensión
```

- Excepciones :
- Se utilizaron para controlar las posibles excepciones durante la ejecucion ya sea utilizando las consultas a bases de datos, serializando/deserializando o
  asi tambien para relanzarlas con un mensaje mas definido. 
```csharp
 public static List<ModeloCliente> ObtenerTodasLasPersonas()
 {
     try
     {
         using (SqlConnection conection = new SqlConnection(GestorSqlCliente.stringConection))
         {
             List<ModeloCliente> clientes = new List<ModeloCliente>();
             string query = "SELECT * FROM TablaGym";
             SqlCommand command = new SqlCommand(query, conection);
             conection.Open();
             SqlDataReader reader = command.ExecuteReader();
             if (reader.HasRows)
             {
                 while (reader.Read())
                 {
                     ModeloCliente cliente = new ModeloCliente();
                     cliente.IdCliente = reader.GetInt32(0);
                     cliente.Nombre = reader.GetString(1);
                     cliente.Apellido = reader.GetString(2);
                     cliente.Disciplinas = (Edisciplinas)Enum.Parse(typeof(Edisciplinas), reader.GetString(3));
                     cliente.CuotaAbonada = reader.GetString(4);
                     cliente.IdProfesor = reader.GetInt32(5);
                     clientes.Add(cliente);
                 }
                 return clientes;
             }
             else
             {
                 throw new Exception("No se obtuvieron datos");
             }
         }
     }
     catch (Exception)
     {
         throw new SinConexionBaseDeDatosException("Error al conectar a la base de datos");
     }
```
- Pruebas unitarias :
- Se utilizaron para corroborar el funcionamiento de dos metodos, en el caso del codigo la idea es que la persona ingrese un
  nombre o apellido sin burlar las validaciones correspondientes.
```csharp
    [TestMethod]
    public void ValidarString_DeberiaDevolverTrue_CuandoStringNoContieneEspaciosONumerosONoEsNull()
    {
        // Arrange
        string valorPrueba = "PruebaTestUnitario";
    
        // Act
        bool resultado = Cliente.ValidarString(valorPrueba);
    
        // Assert
        Assert.IsTrue(resultado);
    }
    
    [TestMethod]
    public void ValidarString_DeberiaDevolverFalse_CuandoStringEsNullOtieneEspaciosOUnNumero()
    {
        // Arrange
        string valorPrueba1 = " qq";
        string valorPrueba2 = "";
        string valorPrueba3 = "Prueba55ario";
    
        // Act
        bool resultado1 = Cliente.ValidarString(valorPrueba1);
        bool resultado2 = Cliente.ValidarString(valorPrueba2);
        bool resultado3 = Cliente.ValidarString(valorPrueba3);
    
        // Assert
        Assert.IsFalse(resultado1);
        Assert.IsFalse(resultado2);
        Assert.IsFalse(resultado3);
    }
```
  - Generics, Serializacion y Deserializacion:
  - Se generaron dos metodos para Serializar y Deserializar los archivos que sean genericos y reutilizables para las dos clases implementadas en el proyecto.
  ```csharp
          public void ImportarDatos<T>(List<T> lista, string path) where T : class
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;
                string listaJson = JsonSerializer.Serialize(lista, options);
                sw.WriteLine(listaJson);
            }
        }

        public List<T> ExportarDatos<T>(List<T> lista, string path) where T : class
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string listaJson = sr.ReadToEnd();
                    lista = JsonSerializer.Deserialize<List<T>>(listaJson);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("No se obtuvieron datos");
            }
        }
  ```
  - Interfaces :
  - Se establece la firma y restriccion, se llaman en las dos clases respectivas para que implementen los metodos de Serializacion y Deserializacion.
  ```csharp
      public interface ImodelarArchivos
    {
        public void ImportarDatos<T>(List<T> lista, string path) where T : class;
        public List<T> ExportarDatos<T>(List<T> lista, string path) where T : class;
    }
  ```
  - Introduccion a SQL. y Conexión a bases de datos :
  - Se implementa la base de datos desde los gestores respectivos para hacer consultas, modificacion y eliminacion de los datos obtenidos en la misma, asi tambien
  se evita que las querys sean parametrizadas para evitar la injeccion SQL.
  ```csharp
   public static bool BorrarUnClientePorId(int id)
   {
       try
       {
           using (SqlConnection conection = new SqlConnection(GestorSqlCliente.stringConection))
           {
               string query = "DELETE FROM TablaGym WHERE ID_CLIENTE=@id";
               SqlCommand command = new SqlCommand(query, conection);
               command.Parameters.AddWithValue("id", id);
               conection.Open();
               command.ExecuteNonQuery();
               return true;
           }
       }
       catch (Exception)
       {
           throw new SinConexionBaseDeDatosException("No hay conexion a la base de datos para eliminar un cliente.");
       }
   }
  ```
  - Delegados y Eventos :
  - Se utilizaron juntos, la finalidad es simple y se trata de enviar un mensaje al guardar los cambios en los archivos locales (Serialiacion).
  - Se asigna el manejador y el mismo se invoca en el metodo btnGuardarArchivosLocales_Click para dar aviso de haber sido guardados o no los cambios.
 ```csharp 
  public event DelegadoInformarCambios onInformarCambios;

  public void informarCambios(string mensaje)
  {
      MessageBox.Show(mensaje);
  }
  public FormPrincipal()
  {
    InitializeComponent();
    this.onInformarCambios += this.informarCambios;
  }
  this.onInformarCambios.Invoke("No hay cambios para guardar.");
```
- Programación multi-hilo y concurrencia :
- Se utilizan estos conceptos para generar un hilo secundario que de percibir un cambio realizado en el programa , de aviso de lo sucedido y este no se finalice hasta que
sean guardados de manera local (Serializados).
En el siguiente codigo se genera la llamada recursiva hacia el hilo.
```csharp
  Task guardarCambios;
  CancellationTokenSource cancelarHilo;
  private void IniciarAvisoCambios()
  {
      while (!this.cancelarHilo.IsCancellationRequested)
      {
          AvisarCambiosSinGuardar();
          Thread.Sleep(1000);
      }
  }
```

- La idea es que se pueda percibir "al ojo humano" una secuencia o movimiento de un label en el formulario, en el mismo se verifica en que hilo 
se esta corriendo el codigo. 
```csharp
private void AvisarCambiosSinGuardar()
{
    if (this.InvokeRequired)
    {
        this.BeginInvoke(AvisarCambiosSinGuardar);
    }
    else
    {
        switch (this.lblGuardarCambios.Text)
        {
            case "No hay cambios realizados":
                this.lblGuardarCambios.Text = "Tienes datos para guardar .";
                break;
            case "Tienes datos para guardar .":
                this.lblGuardarCambios.Text = "Tienes datos para guardar . .";
                break;
            case "Tienes datos para guardar . .":
                this.lblGuardarCambios.Text = "Tienes datos para guardar . . .";
                break;
            case "Tienes datos para guardar . . .":
                this.lblGuardarCambios.Text = "Tienes datos para guardar .";
                break;
        }
    }
}
```
- El hilo se detiene al haber realizado los cambios.
```csharp
private void btnGuardarArchivosLocales_Click(object sender, EventArgs e)
{
    if (this.onInformarCambios is not null && this.buscarCambios == DialogResult.OK)
    {
        Cliente aux = new Cliente();
        aux.ImportarDatos(GestorSqlCliente.ObtenerTodasLasPersonas(), this.direccion);
        this.onInformarCambios.Invoke("Cambios guardados con exito.");
        if (this.cancelarHilo != null)
        {
            this.cancelarHilo.Cancel();
        }
        this.lblGuardarCambios.Text = "No hay cambios realizados";
    }
    else if (this.onInformarCambios is not null && this.result == DialogResult.No)
    {
        this.onInformarCambios.Invoke("No hay cambios para guardar.");
    }
    this.result = DialogResult.No;
}
```
