using Clases;
using diseño;
using INTERFAZBIBLIOTECA;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace diseño
{
    public partial class Form1 : Form
    {
        private ListaSimple usuarios = new ListaSimple();
        private ListaDoble catalogo = new ListaDoble();
        private ArbolLibros arbol = new ArbolLibros();
        private Pila historial = new Pila();
        private Cola cola = new Cola();
        private BIcola bicola = new BIcola();
        private ListaCircular recomendados = new ListaCircular();

        private string usuarioActual = "";

        public Form1()
        {
            InitializeComponent();
            InicializarDatos();
        }

        // INICIALIZACIÓN

        private void InicializarDatos()
        {
            // Nuevos libros del catálogo
            catalogo.Agregar("Los ríos profundos", "José María Arguedas");
            catalogo.Agregar("El Sexto", "José María Arguedas");
            catalogo.Agregar("La casa verde", "Mario Vargas Llosa");
            catalogo.Agregar("Conversación en La Catedral", "Mario Vargas Llosa");
            catalogo.Agregar("Pantaleón y las visitadoras", "Mario Vargas Llosa");
            catalogo.Agregar("El pez en el agua", "Mario Vargas Llosa");
            catalogo.Agregar("Redoble por Rancas", "Manuel Scorza");
            catalogo.Agregar("Garabombo el invisible", "Manuel Scorza");
            catalogo.Agregar("Historia de Mayta", "Mario Vargas Llosa");
            catalogo.Agregar("Yawar Fiesta", "José María Arguedas");
            catalogo.Agregar("Todas las sangres", "José María Arguedas");
            catalogo.Agregar("Los perros hambrientos", "Ciro Alegría");
            catalogo.Agregar("El mundo es ancho y ajeno", "Ciro Alegría");
            catalogo.Agregar("Duque", "José Diez Canseco");
            catalogo.Agregar("El Tungsteno", "César Vallejo");

            // Insertar en el árbol (usando ref como en tu código original)
            arbol.Insertar(ref arbol.raiz, "Los ríos profundos", "José María Arguedas");
            arbol.Insertar(ref arbol.raiz, "El Sexto", "José María Arguedas");
            arbol.Insertar(ref arbol.raiz, "La casa verde", "Mario Vargas Llosa");
            arbol.Insertar(ref arbol.raiz, "Conversación en La Catedral", "Mario Vargas Llosa");
            arbol.Insertar(ref arbol.raiz, "Pantaleón y las visitadoras", "Mario Vargas Llosa");
            arbol.Insertar(ref arbol.raiz, "El pez en el agua", "Mario Vargas Llosa");
            arbol.Insertar(ref arbol.raiz, "Redoble por Rancas", "Manuel Scorza");
            arbol.Insertar(ref arbol.raiz, "Garabombo el invisible", "Manuel Scorza");
            arbol.Insertar(ref arbol.raiz, "Historia de Mayta", "Mario Vargas Llosa");
            arbol.Insertar(ref arbol.raiz, "Yawar Fiesta", "José María Arguedas");
            arbol.Insertar(ref arbol.raiz, "Todas las sangres", "José María Arguedas");
            arbol.Insertar(ref arbol.raiz, "Los perros hambrientos", "Ciro Alegría");
            arbol.Insertar(ref arbol.raiz, "El mundo es ancho y ajeno", "Ciro Alegría");
            arbol.Insertar(ref arbol.raiz, "Duque", "José Diez Canseco");
            arbol.Insertar(ref arbol.raiz, "El Tungsteno", "César Vallejo");

            // Recomendados del mes (lista circular)
            recomendados.Agregar("Los ríos profundos - José María Arguedas");
            recomendados.Agregar("Rosa Cuchillo - Óscar Colchado Lucio");
            recomendados.Agregar("La casa verde - Mario Vargas Llosa");
            recomendados.Agregar("Un mundo para Julius - Alfredo Bryce Echenique");
            recomendados.Agregar("Abril rojo - Santiago Roncagliolo");
        }



        //  UTILIDADES 

        private bool VerificarUsuario()
        {
            if (string.IsNullOrWhiteSpace(usuarioActual))
            {
                MessageBox.Show("Debe registrarse primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private string ObtenerTituloDesdeSeleccion()
        {
            string criterio = ObtenerTituloDesdeSeleccion();

            // Asegurar que haya selección
            if (ltsSalida == null || ltsSalida.SelectedItem == null)
                return null;

            string linea = ltsSalida.SelectedItem.ToString().Trim();

            // Si el formato es "Título - Autor", extraemos el título
            if (linea.Contains(" - "))
            {
                string[] partes = linea.Split(new[] { " - " }, StringSplitOptions.None);
                if (partes.Length > 0)
                    return partes[0].Trim();
            }

            // Si no tiene " - ", devolvemos la línea completa
            return linea;
        }

        private void EjecutarBusquedaRapida()
        {
            string criterio = btnBuscar.Text.Trim();
            ltsSalida.Items.Clear();

            if (string.IsNullOrEmpty(criterio))
            {
                ltsSalida.Items.Add("Ingrese un título o autor para buscar.");
                return;
            }

            var resultados = arbol.BuscarLibroPorTituloOAutor(arbol.raiz, criterio);

            if (resultados != null && resultados.Count > 0)
            {
                ltsSalida.Items.Add("Resultados de búsqueda:");
                foreach (var libro in resultados)
                {
                    ltsSalida.Items.Add($"Título: {libro.Titulo} | Autor: {libro.Autor}");
                }
            }
            else
            {
                ltsSalida.Items.Add("No se encontró ningún libro con ese título o autor.");
            }
        }

        // EVENTOS (MENÚ EN BOTONES) 

        // Ver catálogo de libros
        private void btnCatalogo_Click_1(object sender, EventArgs e)
        {
            ltsSalida.Items.Clear();
            catalogo.MostrarAdelante(ltsSalida);
        }

        // Pedir préstamo de libro
        private void btnPrestamo_Click_1(object sender, EventArgs e)
        {
            if (!VerificarUsuario())
                return;

            string criterio = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el título o autor del libro que desea pedir:",
                "Préstamo de libro").Trim();

            if (string.IsNullOrEmpty(criterio))
                return;

            // Buscar en el árbol por título o autor
            var resultados = arbol.BuscarLibroPorTituloOAutor(arbol.raiz, criterio);

            if (resultados != null && resultados.Count > 0)
            {
                var libro = resultados[0]; // Toma el primero si hay más de uno
                historial.Apilar($"Préstamo: '{libro.Titulo}' de {libro.Autor} por {usuarioActual}");
                ltsSalida.Items.Clear();
                ltsSalida.Items.Add($" Préstamo registrado con éxito: '{libro.Titulo}' de {libro.Autor}");
            }
            else
            {
                cola.Encolar($"{usuarioActual} (espera '{criterio}')");
                ltsSalida.Items.Clear();
                ltsSalida.Items.Add($"Libro no disponible. '{criterio}' agregado a la cola de espera.");
            }
        }

        // Devolver libro
        private void btnDevolver_Click_1(object sender, EventArgs e)
        {
            if (!VerificarUsuario())
                return;

            string criterio = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el título o autor del libro a devolver:",
                "Devolución de libro").Trim();

            if (string.IsNullOrEmpty(criterio))
                return;

            // Buscar libro en el árbol antes de devolver
            var resultados = arbol.BuscarLibroPorTituloOAutor(arbol.raiz, criterio);

            if (resultados != null && resultados.Count > 0)
            {
                var libro = resultados[0];
                historial.Apilar($"Devolución: '{libro.Titulo}' de {libro.Autor} por {usuarioActual}");
                ltsSalida.Items.Clear();
                ltsSalida.Items.Add($" Devolución registrada con éxito: '{libro.Titulo}' de {libro.Autor}");
            }
            else
            {
                ltsSalida.Items.Clear();
                ltsSalida.Items.Add($" El libro '{criterio}' no está registrado en el catálogo.");
            }
        }

        // Ver historial
        private void btnHistorial_Click_1(object sender, EventArgs e)
        {
            ltsSalida.Items.Clear();
            ltsSalida.Items.Add("=== HISTORIAL DE ACCIONES ===");
            historial.Mostrar(ltsSalida);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!VerificarUsuario())
                return;

            string criterio = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el título o autor del libro que desea solicitar:",
                "Solicitud de préstamo").Trim();

            if (string.IsNullOrEmpty(criterio))
                return;

            // Buscar libro en el árbol
            var resultados = arbol.BuscarLibroPorTituloOAutor(arbol.raiz, criterio);

            if (resultados != null && resultados.Count > 0)
            {
                var libro = resultados[0];
                cola.Encolar($"{usuarioActual} solicitó '{libro.Titulo}' de {libro.Autor}");
                ltsSalida.Items.Clear();
                ltsSalida.Items.Add($" Solicitud registrada: '{libro.Titulo}' de {libro.Autor}");
                ltsSalida.Items.Add($"El libro está en espera para el usuario {usuarioActual}.");
            }
            else
            {
                cola.Encolar($"{usuarioActual} solicitó '{criterio}' (libro no encontrado)");
                ltsSalida.Items.Clear();
                ltsSalida.Items.Add($" Libro '{criterio}' no existe en el catálogo.");
                ltsSalida.Items.Add($"La solicitud se agregó igualmente a la lista de espera.");
            }
        }
        // Ver recomendados
        private void btnRecomendados_Click_1(object sender, EventArgs e)
        {
            ltsSalida.Items.Clear();
            recomendados.Mostrar(ltsSalida);
        }

        // Ver solicitudes en espera
        private void btnEspera_Click_1(object sender, EventArgs e)
        {
            ltsSalida.Items.Clear();
            cola.Mostrar(ltsSalida);
        }
        // Búsqueda rápida (textbox + botón)
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            EjecutarBusquedaRapida();
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            // Validar que el usuario no esté vacío
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                Text = "Ingrese su nombre para registrarse.";
            }
            else
            {
                Text = "";
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ltsSalida.Items.Clear();
            ltsSalida.Items.Add("Bienvenido al sistema de biblioteca.");
        }

        private void LstSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Por ahora no hace nada, pero podrías mostrar detalles del libro seleccionado
            // Ejemplo:
            if (ltsSalida.SelectedItem != null)
            {
                string seleccionado = ltsSalida.SelectedItem.ToString();
                Console.WriteLine($"Seleccionado: {seleccionado}");
            }
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese su nombre para registrarse.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            usuarios.Agregar(nombre);
            usuarioActual = nombre;

            ltsSalida.Items.Clear();
            ltsSalida.Items.Add($"Usuario registrado correctamente: {usuarioActual}");
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            EjecutarBusquedaRapida();
        }

        private void btnRecomendados_Click(object sender, EventArgs e)
        {
            ltsSalida.Items.Clear();
            recomendados.Mostrar(ltsSalida);
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            ltsSalida.Items.Clear();
            catalogo.MostrarAdelante(ltsSalida);
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            if (!VerificarUsuario())
                return;

            string criterio = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el título o autor del libro que desea pedir:",
                "Préstamo de libro").Trim();

            if (string.IsNullOrEmpty(criterio))
                return;

            // Buscar en el árbol por título o autor
            var resultados = arbol.BuscarLibroPorTituloOAutor(arbol.raiz, criterio);

            if (resultados != null && resultados.Count > 0)
            {
                var libro = resultados[0]; // Toma el primero si hay más de uno
                historial.Apilar($"Préstamo: '{libro.Titulo}' de {libro.Autor} por {usuarioActual}");
                ltsSalida.Items.Clear();
                ltsSalida.Items.Add($" Préstamo registrado con éxito: '{libro.Titulo}' de {libro.Autor}");
            }
            else
            {
                cola.Encolar($"{usuarioActual} (espera '{criterio}')");
                ltsSalida.Items.Clear();
                ltsSalida.Items.Add($"Libro no disponible. '{criterio}' agregado a la cola de espera.");
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (!VerificarUsuario())
                return;

            string criterio = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el título o autor del libro a devolver:",
                "Devolución de libro").Trim();

            if (string.IsNullOrEmpty(criterio))
                return;

            // Buscar libro en el árbol antes de devolver
            var resultados = arbol.BuscarLibroPorTituloOAutor(arbol.raiz, criterio);

            if (resultados != null && resultados.Count > 0)
            {
                var libro = resultados[0];
                historial.Apilar($"Devolución: '{libro.Titulo}' de {libro.Autor} por {usuarioActual}");
                ltsSalida.Items.Clear();
                ltsSalida.Items.Add($" Devolución registrada con éxito: '{libro.Titulo}' de {libro.Autor}");
            }
            else
            {
                ltsSalida.Items.Clear();
                ltsSalida.Items.Add($" El libro '{criterio}' no está registrado en el catálogo.");
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            ltsSalida.Items.Clear();
            ltsSalida.Items.Add("=== HISTORIAL DE ACCIONES ===");
            historial.Mostrar(ltsSalida);
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            if (!VerificarUsuario())
                return;

            string criterio = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el título o autor del libro que desea pedir:",
                "Préstamo de libro").Trim();

            if (string.IsNullOrEmpty(criterio))
                return;

            // Buscar en el árbol por título o autor
            var resultados = arbol.BuscarLibroPorTituloOAutor(arbol.raiz, criterio);

            if (resultados != null && resultados.Count > 0)
            {
                var libro = resultados[0]; // Toma el primero si hay más de uno
                historial.Apilar($"Préstamo: '{libro.Titulo}' de {libro.Autor} por {usuarioActual}");
                ltsSalida.Items.Clear();
                ltsSalida.Items.Add($" Préstamo registrado con éxito: '{libro.Titulo}' de {libro.Autor}");
            }
            else
            {
                cola.Encolar($"{usuarioActual} (espera '{criterio}')");
                ltsSalida.Items.Clear();
                ltsSalida.Items.Add($"Libro no disponible. '{criterio}' agregado a la cola de espera.");
            }
        }

        private void btnEspera_Click(object sender, EventArgs e)
        {
            ltsSalida.Items.Clear();
            cola.Mostrar(ltsSalida);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}

