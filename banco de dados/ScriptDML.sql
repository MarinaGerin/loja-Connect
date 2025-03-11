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
Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção. 
Nome Popular: Platycerum, Chifre de veado. 
Nome Científico: Platycerum bifurcatum. 
Origem: Oceania. 
Família Botânica: Polypodiaceae. 
Dimensão (m): 0.6 
Luminosidade: Meia Sombra. 
Rega: 1 a 2 vezes por semana',
10, 20.00, 45.00, 1, 1),

('Filodendro Birkin (Philodendron birkin)',
'Imagens meramente ilustrativas.
Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção.
Nome Popular: Filodendro Birkin.
Nome Científico: Philodendron birkin.
Origem: Hibrido.
Família Botânica: Araceae.
Dimensão(m): 0.7
Luminosidade: Meia sombra.
Rega: 1 a 2 vezes por semana', 8, 15.99, 69.90, 1, 1),

('Begônia Prateada (Begonia aconitifolia)',
'Imagens meramente ilustrativas.
Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção.
Nome Popular: Begônia Prateada. 
Nome Científico: Begonia aconitifolia.
Origem: Brasil.
Família Botânica: Begoniaceae.
Dimensão (m): 1.5
Luminosidade: Meia sombra e Sol direto.
Rega: 2 a 3 vezes por semana', 7, 7.90, 24.90, 1, 1),

('Begônia Cruz de Ferro (Begonia masoniana)', 'Imagens meramente ilustrativas.
Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção.
Nome Popular: Begônia Cruzl de Ferro. 
Nome Científico: Begonia masoniana.
Origem: Ásia Tropical.
Família Botânica: Begoniaceae.
Dimensão (m): 0.1 a 0.3 
Luminosidade: Meia sombra.
Rega: 2 a 3 vezes por semana, evitando molhar as folhas', 5, 5.00, 20.00, 1, 1),

('Calatéia Rufibarba (Calathea rufibarba)',
'Imagens meramente ilustrativas. 
Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção.
Nome Popular: Calatéia Rufibarba/Calatéia Peluda.
Nome Científico: Calathea rufibarba.
Origem: Brasil.
Família Botânica: Marantaceae.  
Dimensão (m): 0.2 a 0.3
Luminosidade: Meia sombra.
Rega: 1 a 3 vezes por semana', 3, 20.00, 39.90, 1, 1),

('Begônia Sementacea (Begonia x sementaceae)',
'Imagens meramente ilustrativas. 
Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção.
Nome Popular: Begônia Sementacea.
Nome Científico: Begonia x sementaceae.
Origem: Brasil.
Família Botânica: Begoniaceae.
Dimensão (m): 0.3 
Luminosidade: Meia sombra.
Rega: 2 a 3 vezes por semana', 9, 10.00, 22.00, 1, 1),

('Calatéia Tricolor (Sromanthe sanguinea variegata)', 
'Imagens meramente ilustrativas. 
Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção.
Nome Popular: Maranta-variegata.
Nome Científico: Sromanthe sanguinea variegata.
Origem: Brasil/Hibrido.
Família Botânica: Araceae.  
Dimensão(m): 0.3 a 0.6 
Luminosidade: Meia sombra.
Rega: 1 a 2 vezes por semana', 1, 30.00, 44.00, 1, 1 ),

('Asplênio (Asplenium nidus)',
'magens meramente ilustrativas.
Dimensões da planta e do vaso podem sofrer alterações de acordo com a produção.
Nome Popular: Asplênio, Ninho de Pássaro.
Nome Científico: Asplenium nidus.
Origem: Ásia.
Família Botânica: Aspleniaceae.  
Dimensão (m): 0.3 a 0.5 
Luminosidade: Meia sombra.
Rega: 1 a 2 vezes por semana', 5, 8.00, 22.00, 1, 1);

insert into ProdutoFoto (ProdutoId, Foto, Descricao) values 
(1, 'img/produtos/1/Platycerum.png', null),
(2, 'img/produtos/2/birkin.png', null),
(3, 'img/produtos/3/begonia prateada.png', null),
(4, 'img/produtos/4/begonia cruz.png', null),
(5, 'img/produtos/5/calateia.png', null),
(6, 'img/produtos/6/begonia sementacea.png', null),
(7, 'img/produtos/7/tricolor.png', null),
(8, 'img/produtos/8/asplenio.png', null);