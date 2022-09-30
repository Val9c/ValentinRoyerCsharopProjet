-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 30 sep. 2022 à 13:24
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `valentin-royer-csharp-projet`
--

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `idClient` int(11) NOT NULL AUTO_INCREMENT,
  `prenom` varchar(100) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `adresse` varchar(255) NOT NULL,
  PRIMARY KEY (`idClient`)
) ENGINE=MyISAM AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`idClient`, `prenom`, `nom`, `adresse`) VALUES
(1, 'Valentin', 'Royer', '28 rue mail jacquard'),
(3, 'Anaïs', 'Changrenier', '18 rue des champs'),
(4, 'Thomas', 'Decorps', '49 Rue du Four'),
(5, 'Lucas', 'Mendes', '89 rue de la paix'),
(6, 'William', 'Tuil', ' 8 rue des fées '),
(7, 'Cottino', 'Kool', '2 rue de montparnasse'),
(8, 'Rachid', 'Beder', '15 allé de la fée'),
(9, 'Mathis', 'Almeida', '2 chemin des fées'),
(10, 'Clara', 'Doré', '3bis chemin des fées'),
(11, 'Ines', 'Mouchou', '5 rue yves léger'),
(12, 'Fati', 'kayn', '45 rue de l\'automne'),
(13, 'Fatou', 'Loichet', '27 chemin de l\'amour'),
(14, 'Emeraude', 'Simonin', 'plus d idées'),
(15, 'Alice', 'Israel', 'plus d idées');

-- --------------------------------------------------------

--
-- Structure de la table `compte`
--

DROP TABLE IF EXISTS `compte`;
CREATE TABLE IF NOT EXISTS `compte` (
  `idCompte` int(11) NOT NULL AUTO_INCREMENT,
  `Solde` int(11) NOT NULL,
  `Decouvert` int(11) DEFAULT '0',
  `idClient` int(11) NOT NULL,
  `Type` varchar(100) NOT NULL,
  `Taux` int(11) DEFAULT '0',
  PRIMARY KEY (`idCompte`),
  KEY `FK_Client` (`idClient`)
) ENGINE=MyISAM AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `compte`
--

INSERT INTO `compte` (`idCompte`, `Solde`, `Decouvert`, `idClient`, `Type`, `Taux`) VALUES
(1, 8200, 0, 1, 'Epargne', 3),
(2, 15915, 100, 1, 'Courant', 0),
(3, 0, 392, 5, 'Courant', 0),
(4, 364, 125, 3, 'Courant', 0),
(5, 1258, 0, 5, 'Epargne', 4),
(6, 0, 0, 2, 'Epargne', 3),
(7, 126, 0, 9, 'Epargne', 5),
(8, 365, 0, 8, 'Epargne', 3),
(9, 0, 1500, 8, 'Courant', 0),
(10, 894, 0, 4, 'Epargne', 3),
(11, 6654, 1500, 11, 'Courant', 0),
(12, 30264, 0, 14, 'Epargne', 3),
(13, 693, 1, 12, 'Courant', 0),
(14, 0, 3215, 2, 'Courant', 0),
(15, 4679, 1500, 15, 'Courant', 0),
(16, 27214, 0, 4, 'Epargne', 1),
(17, 7812, 0, 7, 'Epargne', 2),
(18, 78120, 0, 7, 'Epargne', 3),
(19, 4242, 1569, 7, 'Courant', 0),
(20, 7812, 0, 1, 'Epargne', 1),
(21, 241, 1500, 4, 'Courant', 0);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
