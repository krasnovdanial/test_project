/* В базе данных MS SQL Server есть продукты и категории.
 * Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
 * Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
 * Если у продукта нет категорий, то его имя все равно должно выводиться.
 */

CREATE TABLE products (
	id INT PRIMARY KEY NOT NULL,
	product_name VARCHAR (255)
);

INSERT INTO products
VALUES
	(1, 'Jeans'),
	(2, 'Lemon'),
	(3, 'Drill');

CREATE TABLE categories (
	id INT PRIMARY KEY,
	categorie_name VARCHAR (255)
);

INSERT INTO categories
VALUES
	(1, 'Clothes'),
	(2, 'Groceries'),
	(3, 'Instruments');

CREATE TABLE products_categories (
	product_id INT FOREIGN KEY REFERENCES products(id),
	category_id INT FOREIGN KEY REFERENCES categories(id),
	PRIMARY KEY (product_id, category_id)
);

INSERT INTO products_categories
VALUES
	(1, 1),
	(2, 2),
	(3, 3);

SELECT p.product_name, c.categorie_name
FROM products p
LEFT JOIN products_categories p_c
	ON p.id = p_c.product_id
LEFT JOIN categories c
	ON p_c.category_id = c.id;