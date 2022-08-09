-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 21-Nov-2019 às 09:54
-- Versão do servidor: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `partynerdb`
--
CREATE DATABASE IF NOT EXISTS `partynerdb` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `partynerdb`;

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `cadConvidado`(`nomeP` VARCHAR(60), `idEventoP` INT, `presencaP` BOOL)
begin
	Insert into Convidados values(null, nomeP, idEventoP, presencaP);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `cadFuncionario`(`nomeP` VARCHAR(60), `cpfP` VARCHAR(11), `rgP` VARCHAR(9), `telefoneP` VARCHAR(15), `enderecoP` VARCHAR(60))
begin
    Insert into funcionarios values(null,nomeP,cpfP,rgP,telefoneP,enderecoP);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `cad_add`(`nomeP` VARCHAR(60), `precoP` DECIMAL(5,2))
BEGIN
INSERT INTO Adicionais VALUES(null,nomeP, precoP);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `cad_cli`(`pnomeCli` VARCHAR(60), `pcpf` VARCHAR(11))
BEGIN
INSERT INTO Clientes VALUES(null,pnomeCli,pcpf);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `cad_eve`(`dataeve` DATETIME, `descricao` TEXT, `valorT` DECIMAL(6,2), `custos` DECIMAL(6,2), `numCon` INT(10), `idCli` INT, `idtipo` INT)
BEGIN
INSERT into eventos values(null,dataeve,descricao,valor_Total,custos,numCon,idCli,idtipo);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `cad_pro`(`nomeP` VARCHAR(60), `categoriaP` VARCHAR(60), `preco` DECIMAL(5,2), `idEve` INT)
begin
	insert into produtos values(null, nomeP,categoriaP,preco,idEve);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `cad_tipo`(`nomeP` VARCHAR(60), `precoP` DECIMAL(6,2))
BEGIN
INSERT INTO tipo VALUES(nomeP, precoP);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `cad_user`(`loginP` VARCHAR(50), `adminP` BOOLEAN, `senha` VARCHAR(20))
begin
	insert into usuario values(null,loginP,adminP,senha);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `del_user`(`pidUser` INT)
begin
	delete from usuario where id_usuario = pidUser;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `d_add`(`pidadd` INT)
BEGIN
DELETE FROM Adicionais WHERE id_adicional = pidadd;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `d_cli`(`pidCli` INT)
BEGIN
DELETE FROM Clientes WHERE id_cliente = pidCli;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `d_con`(`pidcon` INT)
begin
delete from convidados where id_Convidado = pidcon;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `d_eve`(`ideve` INT)
BEGIN
INSERT INTO eventos VALUES(ideve);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `d_fun`(`pidFun` INT)
BEGIN
DELETE FROM funcionarios WHERE id_funcionario = pidFun;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `d_pro`(`pidPro` INT)
begin
delete from produtos where id_Produto = pidPro;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `d_tipo`(`idtipo` INT)
BEGIN
INSERT INTO tipo VALUES(idtipo);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `up_add`(`idadd` INT, `nomeP` VARCHAR(60), `precoP` DECIMAL(5,2))
BEGIN
UPDATE Adicionais SET preco = preco, Pnome = nomeP WHERE id_adicional = idadd;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `up_cli`(`idCli` INT, `nomeCli` VARCHAR(60), `pcpf` VARCHAR(11))
BEGIN
UPDATE Clientes SET nome = nomeCli, cpf = pcpf  WHERE id_cliente = idCli;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `up_eve`(`ideve` INT, `dataeve` DATETIME, `descricaop` TEXT, `valorT` DECIMAL(6,2), `custosp` DECIMAL(6,2), `numCon` INT(10), `idCli` INT, `idtipo` INT)
BEGIN
UPDATE eventos SET data_Evento = dataeve, descricao = descricaop, valor_Total = valorT,custos = custosp, num_conv = numCon, id_Cliente_fk = idCli, id_Tipo_fk = idtipo WHERE id_evento = ideve;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `up_fun`(`idFun` INT, `nomeP` VARCHAR(60), `cpfP` VARCHAR(11), `rgP` VARCHAR(9), `telefoneP` VARCHAR(15), `enderecoP` VARCHAR(60))
BEGIN
UPDATE funcionarios SET nome = nomeP, cpf = cpfP, rg = rgP, telefone = telefoneP, endereco = enderecoP WHERE id_funcionario = idFun;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `up_pro`(`idPro` INT, `nomeP` VARCHAR(60), `categoriaP` VARCHAR(60), `precoP` DECIMAL(5,2), `idEve` INT)
begin
	update Produtos set nome = nomeP, categoria = categoriaP,preco = precoP,idEvento_fk = idEve = id where id_Produto = idPro;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `up_tipo`(`idtipo` INT, `nomeP` VARCHAR(60), `precoP` DECIMAL(6,2))
BEGIN
UPDATE tipo SET nome = nomeP, preco = precoP WHERE id_tipo = idtipo;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `up_user`(`senhaP` VARCHAR(60))
begin
	update usuario set senha = senhaP;
end$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `ad_evento`
--

CREATE TABLE IF NOT EXISTS `ad_evento` (
  `id_eta` int(11) NOT NULL AUTO_INCREMENT,
  `id_adicionais_fk` int(11) DEFAULT NULL,
  `id_evento_fk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_eta`),
  KEY `id_adicionais_fk` (`id_adicionais_fk`),
  KEY `id_evento_fk` (`id_evento_fk`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Extraindo dados da tabela `ad_evento`
--

INSERT INTO `ad_evento` (`id_eta`, `id_adicionais_fk`, `id_evento_fk`) VALUES
(1, 1, 3);

-- --------------------------------------------------------

--
-- Estrutura da tabela `adicionais`
--

CREATE TABLE IF NOT EXISTS `adicionais` (
  `id_adicional` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(60) DEFAULT NULL,
  `preco` double(5,2) DEFAULT NULL,
  PRIMARY KEY (`id_adicional`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Extraindo dados da tabela `adicionais`
--

INSERT INTO `adicionais` (`id_adicional`, `nome`, `preco`) VALUES
(1, 'Balões', 15.50),
(2, 'Mouse Pad', 10.00);

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
  `id_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(60) NOT NULL,
  `cpf` char(11) DEFAULT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`id_cliente`, `nome`, `cpf`) VALUES
(1, 'Luís Inácio', '30918703085'),
(2, 'Jennifer Nunes', '29174257099'),
(3, 'Bruno Gomes', '64048889044'),
(4, 'Gustavo Santos', '60872911055'),
(5, 'Patrick Viera', '78426345050');

-- --------------------------------------------------------

--
-- Estrutura da tabela `convidados`
--

CREATE TABLE IF NOT EXISTS `convidados` (
  `id_Convidado` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(60) NOT NULL,
  `idEvento_fk` int(11) DEFAULT NULL,
  `presenca` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_Convidado`),
  KEY `idEvento_fk` (`idEvento_fk`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Extraindo dados da tabela `convidados`
--

INSERT INTO `convidados` (`id_Convidado`, `nome`, `idEvento_fk`, `presenca`) VALUES
(1, 'Lucas', 1, 0),
(2, 'Marcelo', 1, 0),
(3, 'Patrick', 1, 0),
(4, 'Ronaldo', 1, 0),
(5, 'Enzo', 1, 1),
(6, 'Josevaldo', 1, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `eventos`
--

CREATE TABLE IF NOT EXISTS `eventos` (
  `id_evento` int(11) NOT NULL AUTO_INCREMENT,
  `data_Evento` datetime NOT NULL,
  `descricao` text,
  `valor_Total` decimal(20,2) DEFAULT NULL,
  `custos` decimal(8,2) DEFAULT NULL,
  `num_conv` int(10) DEFAULT NULL,
  `id_Cliente_fk` int(11) DEFAULT NULL,
  `id_Tipo_fk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_evento`),
  KEY `id_Tipo_fk` (`id_Tipo_fk`),
  KEY `id_Cliente_fk` (`id_Cliente_fk`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Extraindo dados da tabela `eventos`
--

INSERT INTO `eventos` (`id_evento`, `data_Evento`, `descricao`, `valor_Total`, `custos`, `num_conv`, `id_Cliente_fk`, `id_Tipo_fk`) VALUES
(1, '2019-12-03 00:00:00', 'Jennifer Nunes vait fazer uma festa de 15 anos para sua filha', '1700.00', '224.00', 17, 2, 2),
(2, '2020-01-08 00:00:00', 'Patrick vai se casar com a nicoly', '4800.00', '0.00', 30, 5, 1),
(3, '2019-11-29 00:00:00', 'Bruno quer sextar', '465.50', '400.00', 15, 3, 3),
(4, '2019-11-20 00:00:00', 'Gustavo vai celebrar o casamento de sua irmã; 08/01/2020', '5600.00', '0.00', 35, 4, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario_evento`
--

CREATE TABLE IF NOT EXISTS `funcionario_evento` (
  `id_evento_fk` int(11) NOT NULL,
  `id_funcionario_fk` int(11) NOT NULL,
  `pagamento` decimal(6,2) DEFAULT NULL,
  PRIMARY KEY (`id_evento_fk`,`id_funcionario_fk`),
  KEY `id_funcionario_fk` (`id_funcionario_fk`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `funcionario_evento`
--

INSERT INTO `funcionario_evento` (`id_evento_fk`, `id_funcionario_fk`, `pagamento`) VALUES
(1, 2, '200.00'),
(3, 2, '200.00'),
(3, 3, '200.00'),
(4, 1, '400.00'),
(4, 2, '1000.00'),
(4, 3, '200.00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE IF NOT EXISTS `funcionarios` (
  `id_funcionario` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(60) DEFAULT NULL,
  `cpf` char(11) DEFAULT NULL,
  `rg` char(11) DEFAULT NULL,
  `telefone` varchar(15) DEFAULT NULL,
  `endereco` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`id_funcionario`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`id_funcionario`, `nome`, `cpf`, `rg`, `telefone`, `endereco`) VALUES
(1, 'Takazaki', '30236832042', '167366713', '12997547832', 'Boituva'),
(2, 'Enzo Augusto', '46318856021', '453787113', '1140028922', 'Pereiras'),
(3, 'Luís Chifrácio', '43107455040', '361924574', '15998545687', 'Tatuí');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto_evento`
--

CREATE TABLE IF NOT EXISTS `produto_evento` (
  `id_etp` int(11) NOT NULL AUTO_INCREMENT,
  `qtd` int(10) DEFAULT NULL,
  `id_evento_fk` int(11) DEFAULT NULL,
  `id_produto_fk` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_etp`),
  KEY `id_evento_fk` (`id_evento_fk`),
  KEY `id_produto_fk` (`id_produto_fk`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Extraindo dados da tabela `produto_evento`
--

INSERT INTO `produto_evento` (`id_etp`, `qtd`, `id_evento_fk`, `id_produto_fk`) VALUES
(1, 2, 1, 1),
(2, 2, 4, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE IF NOT EXISTS `produtos` (
  `id_Produto` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(60) NOT NULL,
  `categoria` varchar(50) DEFAULT NULL,
  `preco` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`id_Produto`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`id_Produto`, `nome`, `categoria`, `preco`) VALUES
(1, 'Saco de pão', '', '12.00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tipo`
--

CREATE TABLE IF NOT EXISTS `tipo` (
  `id_tipo` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(60) DEFAULT NULL,
  `preco` decimal(6,2) DEFAULT NULL,
  PRIMARY KEY (`id_tipo`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Extraindo dados da tabela `tipo`
--

INSERT INTO `tipo` (`id_tipo`, `nome`, `preco`) VALUES
(1, 'Casamento', '160.00'),
(2, 'Festa de 15 Anos', '100.00'),
(3, 'Sextou', '30.00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(60) NOT NULL,
  `admin_usuario` tinyint(1) DEFAULT NULL,
  `senha` varchar(20) NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `login`, `admin_usuario`, `senha`) VALUES
(1, 'Admin', 1, 'Admin'),
(2, 'Enzo', 0, '12345');

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `ad_evento`
--
ALTER TABLE `ad_evento`
  ADD CONSTRAINT `ad_evento_ibfk_1` FOREIGN KEY (`id_adicionais_fk`) REFERENCES `adicionais` (`id_adicional`),
  ADD CONSTRAINT `ad_evento_ibfk_2` FOREIGN KEY (`id_evento_fk`) REFERENCES `eventos` (`id_evento`);

--
-- Limitadores para a tabela `convidados`
--
ALTER TABLE `convidados`
  ADD CONSTRAINT `convidados_ibfk_1` FOREIGN KEY (`idEvento_fk`) REFERENCES `eventos` (`id_evento`);

--
-- Limitadores para a tabela `eventos`
--
ALTER TABLE `eventos`
  ADD CONSTRAINT `eventos_ibfk_1` FOREIGN KEY (`id_Tipo_fk`) REFERENCES `tipo` (`id_tipo`),
  ADD CONSTRAINT `eventos_ibfk_2` FOREIGN KEY (`id_Cliente_fk`) REFERENCES `clientes` (`id_cliente`);

--
-- Limitadores para a tabela `funcionario_evento`
--
ALTER TABLE `funcionario_evento`
  ADD CONSTRAINT `funcionario_evento_ibfk_1` FOREIGN KEY (`id_evento_fk`) REFERENCES `eventos` (`id_evento`),
  ADD CONSTRAINT `funcionario_evento_ibfk_2` FOREIGN KEY (`id_funcionario_fk`) REFERENCES `funcionarios` (`id_funcionario`);

--
-- Limitadores para a tabela `produto_evento`
--
ALTER TABLE `produto_evento`
  ADD CONSTRAINT `produto_evento_ibfk_1` FOREIGN KEY (`id_evento_fk`) REFERENCES `eventos` (`id_evento`),
  ADD CONSTRAINT `produto_evento_ibfk_2` FOREIGN KEY (`id_produto_fk`) REFERENCES `produtos` (`id_Produto`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
