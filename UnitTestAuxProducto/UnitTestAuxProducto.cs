using System;
using Libreria;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAuxProducto
{
    [TestClass]
    public class UnitTestAuxProducto
    {
        #region Pruebas a Agregar Producto
        [TestMethod]
        public void TestAgregarProductoObjeto()
        {
            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            Producto producto = new Producto();

            producto.IdProducto = 001;
            producto.Nombre = "Shampoo";
            producto.Cat = new Categoria(1, "Capilares", "Lo mejor para el cabello");
            producto.Precio = 2000;
            producto.Stock = 10;
            
            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //Act
            resultadoObtenido = auxProducto.AgregarProducto(producto);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        [TestMethod]
        public void TestAgregarProductoConParametro()
        {
            //Arrange
            AuxProducto auxProduto = new AuxProducto();

            var IdPRoducto = 001;
            var Nombre = "Shampoo";
            var Cat = new Categoria(1, "Capilares", "Lo mejor para el cabello");
            var Precio = 2000;
            var Stock = 10;

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //Act
            resultadoObtenido = auxProduto.AgregarProducto(IdPRoducto, Nombre, Cat, Precio, Stock);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void TestAgregarProductoSinIdProducto()
        {
            //Arrange
            AuxProducto auxProduto = new AuxProducto();
            Producto producto = new Producto();

            producto.Nombre = "Shampoo";
            producto.Cat = new Categoria(1, "Capilares", "Lo mejor para el cabello");
            producto.Precio = 2000;
            producto.Stock = 10;

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //Act
            resultadoObtenido = auxProduto.AgregarProducto(producto);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void TestAgregarProductoSinNombre()
        {
            //Arrange
            AuxProducto auxProduto = new AuxProducto();
            Producto producto = new Producto();

            producto.IdProducto = 001;
            producto.Cat = new Categoria(1, "Capilares", "Lo mejor para el cabello");
            producto.Precio = 2000;
            producto.Stock = 10;

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //Act
            resultadoObtenido = auxProduto.AgregarProducto(producto);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void TestAgregarProductoSinCategoria()
        {
            //Arrange
            AuxProducto auxProduto = new AuxProducto();
            Producto producto = new Producto();

            producto.IdProducto = 001;
            producto.Nombre = "Shampoo";
            producto.Precio = 2000;
            producto.Stock = 10;

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //Act
            resultadoObtenido = auxProduto.AgregarProducto(producto);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void TestAgregarProductoSinPrecio()
        {
            //Arrange
            AuxProducto auxProduto = new AuxProducto();
            Producto producto = new Producto();

            producto.IdProducto = 001;
            producto.Nombre = "Shampoo";
            producto.Cat = new Categoria(1, "Capilares", "Lo mejor para el cabello");
            producto.Stock = 10;

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //Act
            resultadoObtenido = auxProduto.AgregarProducto(producto);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        [TestMethod]
        public void TestAgregarProductoSinStock()
        {
            //Arrange
            AuxProducto auxProduto = new AuxProducto();
            Producto producto = new Producto();

            producto.IdProducto = 001;
            producto.Nombre = "Shampoo";
            producto.Cat = new Categoria(1, "Capilares", "Lo mejor para el cabello");
            producto.Precio = 2000;

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //Act
            resultadoObtenido = auxProduto.AgregarProducto(producto);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        #endregion Pruebas a Agregar Producto

        #region Pruebas a Dar de Baja

        [TestMethod]
        public void TestDarDeBajaPorIdProducto()
        {
            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            int IdProducto = 1;

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            Producto producto = new Producto();
            producto.IdProducto = 001;
            producto.Nombre = "Shampoo";
            producto.Cat = new Categoria(1, "Capilares", "Lo mejor para el cabello");
            producto.Precio = 2000;
            producto.Stock = 10;
            auxProducto.AgregarProducto(producto);

            //Act
            resultadoObtenido = auxProducto.DardeBaja(IdProducto);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        [TestMethod]
        public void TestDarDeBajaPorIdProductoNoExistente()
        {
            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            int IdProductoNoExistente = 1;

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //Act
            resultadoObtenido = auxProducto.DardeBaja(IdProductoNoExistente);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        #endregion Pruebas a Dar de Baja

        [TestMethod]
        #region Pruebas a Actualizar Stock
        public void ActualizarStockPorIdProducto()
        {
            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            int IdProducto = 001;
            int NuevaCantidad = 8;
            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            Producto producto = new Producto();
            producto.IdProducto = 001;
            producto.Nombre = "Shampoo";
            producto.Cat = new Categoria(1, "Capilares", "Lo mejor para el cabello");
            producto.Precio = 2000;
            producto.Stock = 10;
            auxProducto.AgregarProducto(producto);

            //Act
            resultadoObtenido = auxProducto.ActualizarStock(IdProducto, NuevaCantidad);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        [TestMethod]
        public void ActualizaStockConIdNoExistente()
        {
            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            int IdProductoNoexistente = 666;
            int NuevaCantidad = 12;
            int resultadoEsperado = 0;
            int resultadoObtenido = 0;

            //Act
            resultadoObtenido = auxProducto.ActualizarStock(IdProductoNoexistente, NuevaCantidad);

            //Asssert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

        #endregion Pruebas a Actualizar Stock

        #region Pruebas a Modificar Producto

        [TestMethod]
        public void TestModificarProductoConParametros()
        {
            //Arrange
            AuxProducto auxProducto = new AuxProducto();
            Producto producto = new Producto();

            var IdProducto = 001;
            var Nombre = "Shampoo";
            var Cat = new Categoria(1, "Capilares", "Lo mejor para el cabello");
            var Precio = 2000;
            var Stock = 10;

            int resultadoEsperado = 1;
            int resultadoObtenido = 0;

            //Act
            resultadoObtenido = auxProducto.Modificar(IdProducto, Nombre, Cat, Precio, Stock);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoObtenido);

        }

        #endregion Pruebas a Modificar Producto

    }
}
