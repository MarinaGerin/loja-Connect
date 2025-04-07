use loja
go

-- Comandos DML - Data Manipulation Language
-- inserir dados

insert into Categoria(Nome, ExibirHome) values
('Folhagens', 1), ('Plantas de interior', 1), ('Vasos',1)

insert into Produto(Nome, Descricao, QtdeEstoque,
ValorCusto, ValorVenda, Destaque, CategoriaId) values
('Platycerum (Platycerum bifurcatum)', 
'Imagens meramente ilustrativas. 
Dimens�es da planta e do vaso podem sofrer altera��es de acordo com a produ��o. 
Nome Popular: Platycerum, Chifre de veado. 
Nome Cient�fico: Platycerum bifurcatum. 
Origem: Oceania. 
Fam�lia Bot�nica: Polypodiaceae. 
Dimens�o (m): 0.6 
Luminosidade: Meia Sombra. 
Rega: 1 a 2 vezes por semana',
10, 20.00, 45.00, 1, 1),

('Filodendro Birkin (Philodendron birkin)',
'Imagens meramente ilustrativas.
Dimens�es da planta e do vaso podem sofrer altera��es de acordo com a produ��o.
Nome Popular: Filodendro Birkin.
Nome Cient�fico: Philodendron birkin.
Origem: Hibrido.
Fam�lia Bot�nica: Araceae.
Dimens�o(m): 0.7
Luminosidade: Meia sombra.
Rega: 1 a 2 vezes por semana', 8, 15.99, 69.90, 1, 1),

('Beg�nia Prateada (Begonia aconitifolia)',
'Imagens meramente ilustrativas.
Dimens�es da planta e do vaso podem sofrer altera��es de acordo com a produ��o.
Nome Popular: Beg�nia Prateada. 
Nome Cient�fico: Begonia aconitifolia.
Origem: Brasil.
Fam�lia Bot�nica: Begoniaceae.
Dimens�o (m): 1.5
Luminosidade: Meia sombra e Sol direto.
Rega: 2 a 3 vezes por semana', 7, 7.90, 24.90, 1, 1),

('Beg�nia Cruz de Ferro (Begonia masoniana)', 'Imagens meramente ilustrativas.
Dimens�es da planta e do vaso podem sofrer altera��es de acordo com a produ��o.
Nome Popular: Beg�nia Cruzl de Ferro. 
Nome Cient�fico: Begonia masoniana.
Origem: �sia Tropical.
Fam�lia Bot�nica: Begoniaceae.
Dimens�o (m): 0.1 a 0.3 
Luminosidade: Meia sombra.
Rega: 2 a 3 vezes por semana, evitando molhar as folhas', 5, 5.00, 20.00, 1, 1),

('Calat�ia Rufibarba (Calathea rufibarba)',
'Imagens meramente ilustrativas. 
Dimens�es da planta e do vaso podem sofrer altera��es de acordo com a produ��o.
Nome Popular: Calat�ia Rufibarba/Calat�ia Peluda.
Nome Cient�fico: Calathea rufibarba.
Origem: Brasil.
Fam�lia Bot�nica: Marantaceae.  
Dimens�o (m): 0.2 a 0.3
Luminosidade: Meia sombra.
Rega: 1 a 3 vezes por semana', 3, 20.00, 39.90, 1, 1),

('Beg�nia Sementacea (Begonia x sementaceae)',
'Imagens meramente ilustrativas. 
Dimens�es da planta e do vaso podem sofrer altera��es de acordo com a produ��o.
Nome Popular: Beg�nia Sementacea.
Nome Cient�fico: Begonia x sementaceae.
Origem: Brasil.
Fam�lia Bot�nica: Begoniaceae.
Dimens�o (m): 0.3 
Luminosidade: Meia sombra.
Rega: 2 a 3 vezes por semana', 9, 10.00, 22.00, 1, 1),

('Calat�ia Tricolor (Sromanthe sanguinea variegata)', 
'Imagens meramente ilustrativas. 
Dimens�es da planta e do vaso podem sofrer altera��es de acordo com a produ��o.
Nome Popular: Maranta-variegata.
Nome Cient�fico: Sromanthe sanguinea variegata.
Origem: Brasil/Hibrido.
Fam�lia Bot�nica: Araceae.  
Dimens�o(m): 0.3 a 0.6 
Luminosidade: Meia sombra.
Rega: 1 a 2 vezes por semana', 1, 30.00, 44.00, 1, 1 ),

('Aspl�nio (Asplenium nidus)',
'magens meramente ilustrativas.
Dimens�es da planta e do vaso podem sofrer altera��es de acordo com a produ��o.
Nome Popular: Aspl�nio, Ninho de P�ssaro.
Nome Cient�fico: Asplenium nidus.
Origem: �sia.
Fam�lia Bot�nica: Aspleniaceae.  
Dimens�o (m): 0.3 a 0.5 
Luminosidade: Meia sombra.
Rega: 1 a 2 vezes por semana', 5, 8.00, 22.00, 1, 1);

insert into ProdutoFoto (ProdutoId, Foto, Descricao) values 
(1, '/img/produtos/1/Platycerum.png', null),
(2, '/img/produtos/2/birkin.png', null),
(3, '/img/produtos/3/begonia prateada.png', null),
(4, '/img/produtos/4/begonia cruz.png', null),
(5, '/img/produtos/5/calateia.png', null),
(6, '/img/produtos/6/begonia sementacea.png', null),
(7, '/img/produtos/7/tricolor.png', null),
(8, '/img/produtos/8/asplenio.png', null);