-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 10-Jan-2022 às 13:11
-- Versão do servidor: 10.4.21-MariaDB
-- versão do PHP: 7.3.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `projecto_website1`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `sumarios`
--

CREATE TABLE `sumarios` (
  `ID_Sumario` int(3) NOT NULL,
  `Sumario` varchar(250) NOT NULL,
  `Disciplina` varchar(75) NOT NULL,
  `Alunos_Presented` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `sumarios`
--

INSERT INTO `sumarios` (`ID_Sumario`, `Sumario`, `Disciplina`, `Alunos_Presented`) VALUES
(1, 'Introdução à disciplina', 'Programação 1', 15),
(2, 'Tipos de dados', 'Programação 2', 13),
(3, 'Programação estruturada', 'Programação 3', 16);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `sumarios`
--
ALTER TABLE `sumarios`
  ADD PRIMARY KEY (`ID_Sumario`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `sumarios`
--
ALTER TABLE `sumarios`
  MODIFY `ID_Sumario` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
