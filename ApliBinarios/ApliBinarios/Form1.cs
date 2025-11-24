using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApliBinarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
			using (NorthwindEntities northwind = new NorthwindEntities())
            {
				var consulta1 = from O in northwind.Orders
								where O.CustomerID == "ALFKI"
								select new
								{
									O.CustomerID,
									O.OrderDate,
									O.EmployeeID
								};

				var consulta2 = from O in northwind.Orders
								where O.CustomerID == "ANATR"
								select new
								{
									O.CustomerID,
									O.OrderDate,
									O.EmployeeID
								};

				var consulta = consulta1.Union(consulta2);

				dgvConsultas.DataSource = consulta.ToList();
			}

		}

        private void btn2_Click(object sender, EventArgs e)
        {
			using (pubsEntities1 pubs = new pubsEntities1())
			{
				var consulta1 = from E in pubs.employee
								select new
								{
									Id = E.emp_id,
									Nombre = E.fname,
									Apellido = E.lname
								};

				var consulta2 = from A in pubs.authors
								select new
								{
									Id = A.au_id,
									Nombre = A.au_fname,
									Apellido = A.au_lname
								};

				var consulta = consulta1.Union(consulta2);

				dgvConsultas.DataSource = consulta.ToList();
			}

		}

        private void btn3_Click(object sender, EventArgs e)
        {
			using(pubsEntities1 pubs = new pubsEntities1())
			{
				var q1 = from S in pubs.stores
						 select new
						 {
							 Nombre = S.stor_name,
							 Ciudad = S.city
						 };

				var q2 = from P in pubs.publishers
						 select new
						 {
							 Nombre = P.pub_name,
							 Ciudad = P.city
						 };

				var consulta = q1.Union(q2);

				dgvConsultas.DataSource = consulta.ToList();
			}

		}

        private void btnConsultaI_Click(object sender, EventArgs e)
        {
			using (NorthwindEntities northwind = new NorthwindEntities())
			{
				var clientes1 = from C in northwind.Customers
								where C.Country == "France"
								select new
								{
									Codigo = C.CustomerID,
									Nombre = C.CompanyName
								};

				var clientes2 = from O in northwind.Orders
								where O.ShipCountry == "France"
								select new
								{
									Codigo = O.CustomerID,
									Nombre = O.Customers.CompanyName
								};

				var consulta = clientes1.Intersect(clientes2);

				dgvConsultasI.DataSource = consulta.ToList();
			}

		}

        private void btnConsultaI2_Click(object sender, EventArgs e)
        {
			using (NorthwindEntities northwind = new NorthwindEntities())
			{
				var productos = from P in northwind.Products
								select new
								{
									Codigo = P.ProductID,
									Nombre = P.ProductName
								};

				var productosVendidos = from OD in northwind.Order_Details
										select new
										{
											Codigo = OD.ProductID,
											Nombre = OD.Products.ProductName
										};

				var consulta = productos.Intersect(productosVendidos);

				dgvConsultasI.DataSource = consulta.ToList();
			}

		}

        private void btnConsultaI3_Click(object sender, EventArgs e)
        {
			using (pubsEntities1 pubs = new pubsEntities1())
			{
				var autores = from A in pubs.authors
							  select new
							  {
								  Codigo = A.au_id,
								  Nombre = A.au_lname
							  };

				var autoresConLibros = from TA in pubs.titleauthor
									   select new
									   {
										   Codigo = TA.au_id,
										   Nombre = TA.authors.au_lname
									   };

				var consulta = autores.Intersect(autoresConLibros);

				dgvConsultasI.DataSource = consulta.ToList();
			}

		}

        private void btnConsultaD_Click(object sender, EventArgs e)
        {
			using(NorthwindEntities northwind = new NorthwindEntities())
			{
				var clientes = from C in northwind.Customers
							   select new
							   {
								   Codigo = C.CustomerID,
								   Nombre = C.CompanyName,
								   Pais = C.Country
							   };

				var clientesConPedidos = from O in northwind.Orders
										 select new
										 {
											 Codigo = O.CustomerID,
											 Nombre = O.Customers.CompanyName,
											 Pais = O.ShipCountry
										 };

				var consulta = clientes.Except(clientesConPedidos);

				dgvConsultasD.DataSource = consulta.ToList();
			}

		}

        private void btnConsultaD2_Click(object sender, EventArgs e)
        {
			using (pubsEntities1 pubs = new pubsEntities1())
			{
				var autores = from A in pubs.authors
							  select new
							  {
								  Codigo = A.au_id,
								  Nombre = A.au_lname,
								  Estado = A.state
							  };

				var autoresConLibros = from TA in pubs.titleauthor
									   select new
									   {
										   Codigo = TA.au_id,
										   Nombre = TA.authors.au_lname,
										   Estado = TA.authors.state
									   };

				var consulta = autores.Except(autoresConLibros);

				dgvConsultasD.DataSource = consulta.ToList();
			}

		}

        private void btnConsultaD3_Click(object sender, EventArgs e)
        {
			using (pubsEntities1 pubs = new pubsEntities1())
			{
				var titulos = from T in pubs.titles
							  select new
							  {
								  Codigo = T.title_id,
								  Titulo = T.title,
								  Tipo = T.type,
								  Precio = T.price
							  };

				var titulosVendidos = from S in pubs.sales
									  select new
									  {
										  Codigo = S.title_id,
										  Titulo = S.titles.title,
										  Tipo = S.titles.type,
										  Precio = S.titles.price
									  };

				var consulta = titulos.Except(titulosVendidos);

				dgvConsultasD.DataSource = consulta.ToList();
			}

		}
    }
}
