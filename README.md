Unidad 6: Métodos de búsqueda

Aplicación de escritorio (Windows Forms, C#, .NET 10) que implementa tres técnicas de búsqueda y las compara con un experimento sobre datos generados al azar, midiendo el número de comparaciones e iteraciones de cada una.

Técnicas implementadas:

Búsqueda secuencial: recorre el arreglo sin necesitar orden previo.
Búsqueda binaria: divide el intervalo a la mitad; requiere un arreglo ordenado.
Tabla hash: función de dispersión por división (clave mod m) con resolución de colisiones por encadenamiento.
Requisitos
Windows 10 u 11.
SDK de .NET 10.
Visual Studio 2022 (17.14 o superior) o Visual Studio 2026 con la carga de trabajo Desarrollo de escritorio con .NET. También se puede usar solo el SDK desde la terminal.
Cómo abrirlo y ejecutarlo

Con Visual Studio

Descomprimir el zip.
Abrir MetodosBusqueda.sln con doble clic.
Pulsar F5 para compilar y ejecutar.
Para ver el diseñador, abrir Form1.cs desde el Explorador de soluciones.

Con la terminal

cd MetodosBusqueda
dotnet run
Uso de la aplicación
Capturar los parámetros en el panel superior (o dejar los valores iniciales).
Pulsar Ejecutar experimento. Cada corrida agrega una fila por técnica en la pestaña Resultados.
Repetir con distintos valores de N para comparar cómo crece cada técnica.
Revisar las otras pestañas y, si se desea, pulsar Exportar a CSV.
Parámetros
Parámetro	Valor inicial	Descripción
Cantidad de datos (N)	10,000	Tamaño del conjunto de claves únicas.
Consultas por técnica	1,000	Cuántas claves se buscan con cada técnica.
Búsquedas exitosas (%)	50	Porcentaje de consultas con clave existente; el resto son claves ausentes.
Factor del rango de valores	10	Las claves se generan en el rango [0, N × factor).
Factor de carga hash	0.75	Define el tamaño de la tabla: el primo más cercano por arriba a N / factor.
Semilla	2026	Con la misma semilla se obtienen siempre los mismos datos. La casilla Semilla aleatoria usa el reloj.
Pestañas
Resultados: tabla con promedios y máximos de comparaciones e iteraciones, más tiempos en milisegundos.
Detalle y conclusiones: parámetros de la corrida, estadísticas de la tabla hash (colisiones, cubos ocupados, cadena más larga) y conclusiones calculadas con los datos, comparadas con los valores teóricos.
Búsqueda individual: busca una clave concreta con las tres técnicas y muestra el costo de cada una.
Qué significan las métricas
Comparación: cada vez que se compara una clave del conjunto con la buscada. En la binaria se cuentan por separado la comparación de igualdad y la de «menor que».
Iteración: cada vuelta del ciclo principal. En la binaria es el número de veces que se divide el intervalo.
Colisión: inserción en un cubo de la tabla hash que ya tenía al menos una clave.
Estructura del proyecto
MetodosBusqueda/
├── MetodosBusqueda.sln
├── MetodosBusqueda.csproj
├── Program.cs                      Punto de entrada
├── Form1.cs                        Lógica de la ventana
├── Form1.Designer.cs               Controles del diseñador
├── Form1.resx
├── Textos.cs                       Mensajes y plantillas de texto de la interfaz
├── Algoritmos/
│   ├── ResultadoBusqueda.cs        Resultado de una búsqueda (posición, comparaciones, iteraciones)
│   ├── BusquedaSecuencial.cs
│   ├── BusquedaBinaria.cs
│   └── TablaHash.cs
└── Experimentos/
    ├── GeneradorAleatorio.cs       Generador SplitMix64 con semilla
    ├── Primos.cs                   Siguiente primo para el tamaño de la tabla
    ├── Modelos.cs                  Parámetros, conjunto de datos y estadísticas
    └── Experimento.cs              Genera datos y consultas, ejecuta y resume
Cómo funciona el experimento
Se generan N claves enteras únicas al azar con la semilla indicada.
Se preparan las estructuras: el arreglo original (secuencial), una copia ordenada (binaria) y la tabla hash.
Se generan las consultas: una parte con claves existentes y el resto con claves que seguro no existen.
Las tres técnicas reciben exactamente las mismas consultas y se calculan promedios y máximos.

El experimento se ejecuta en un hilo aparte para que la ventana no se congele. Si N × consultas es muy grande, la aplicación pide confirmación antes de continuar.

Resultados de referencia

Con semilla 2026, 1,000 consultas, 50 % de exitosas, factor de rango 10 y factor de carga 0.75 (comparaciones promedio globales):

N	Secuencial	Binaria	Hash
1,000	756.64	18.47	1.02
10,000	7,532.60	25.86	1.03
100,000	74,217.26	32.21	1.02

Estos valores se obtuvieron con una réplica de la misma lógica fuera de la aplicación. Si los números en pantalla difieren ligeramente, prevalecen los de la aplicación.

Notas
Los tiempos en milisegundos dependen del equipo; el análisis se apoya en comparaciones e iteraciones, que no dependen del hardware.
El HashSet de .NET se usa solo para descartar claves repetidas al generar los datos; no participa en ninguna búsqueda medida.
