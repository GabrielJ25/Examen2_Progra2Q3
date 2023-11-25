CREATE TABLE usuarios (
  id INT PRIMARY KEY IDENTITY,
  nombre VARCHAR(100),
  email VARCHAR(100)
);

CREATE TABLE productos (
  id INT PRIMARY KEY IDENTITY,
  nombre VARCHAR(100),
  precio DECIMAL(10,2),
  descripcion TEXT
);

CREATE TABLE orders (
  id INT PRIMARY KEY IDENTITY, 
  usuario_id INT FOREIGN KEY REFERENCES usuarios(id),
  total DECIMAL(10,2)
);

CREATE TABLE order_items (
  orden_id INT FOREIGN KEY REFERENCES orders(id),
  producto_id INT FOREIGN KEY REFERENCES productos(id),
  cantidad INT,
  PRIMARY KEY (orden_id, producto_id) 
);