-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 18-10-2019 a las 02:34:17
-- Versión del servidor: 5.7.26
-- Versión de PHP: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `ideas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `idC` int(11) NOT NULL AUTO_INCREMENT,
  `nombreC` varchar(32) CHARACTER SET ascii NOT NULL,
  `telefonoC` varchar(10) CHARACTER SET ascii NOT NULL,
  `email` varchar(60) CHARACTER SET ascii NOT NULL,
  PRIMARY KEY (`idC`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dispositivo`
--

DROP TABLE IF EXISTS `dispositivo`;
CREATE TABLE IF NOT EXISTS `dispositivo` (
  `idD` int(11) NOT NULL AUTO_INCREMENT,
  `modelo` varchar(30) CHARACTER SET ascii NOT NULL,
  `bateria` bit(1) DEFAULT NULL,
  `sim` bit(1) DEFAULT NULL,
  `cargador` bit(1) DEFAULT NULL,
  `tapa` bit(1) DEFAULT NULL,
  `estuche` bit(1) DEFAULT NULL,
  `tmemoria` bit(1) DEFAULT NULL,
  `pin` int(4) DEFAULT NULL,
  `idC` int(11) NOT NULL,
  PRIMARY KEY (`idD`),
  KEY `idC` (`idC`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `orden`
--

DROP TABLE IF EXISTS `orden`;
CREATE TABLE IF NOT EXISTS `orden` (
  `idO` int(11) NOT NULL AUTO_INCREMENT,
  `detalle` varchar(140) CHARACTER SET ascii DEFAULT NULL,
  `resolucion` varchar(140) CHARACTER SET ascii DEFAULT NULL,
  `importe` int(11) DEFAULT NULL,
  `dolar` bit(1) DEFAULT NULL,
  `garantia` date DEFAULT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `estado` varchar(20) CHARACTER SET ascii NOT NULL,
  `idU` int(11) NOT NULL,
  `idC` int(11) NOT NULL,
  `idD` int(11) NOT NULL,
  PRIMARY KEY (`idO`),
  KEY `idU` (`idU`),
  KEY `idC` (`idC`),
  KEY `idD` (`idD`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `repuesto`
--

DROP TABLE IF EXISTS `repuesto`;
CREATE TABLE IF NOT EXISTS `repuesto` (
  `idR` int(11) NOT NULL AUTO_INCREMENT,
  `nombreR` varchar(32) CHARACTER SET ascii NOT NULL,
  `cantidad` int(5) NOT NULL,
  `costoRepuesto` int(11) DEFAULT NULL,
  PRIMARY KEY (`idR`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `idU` int(11) NOT NULL AUTO_INCREMENT,
  `user` varchar(15) CHARACTER SET ascii NOT NULL,
  `pass` varchar(16) CHARACTER SET ascii NOT NULL,
  `nombreU` varchar(32) CHARACTER SET ascii NOT NULL,
  `telefonoU` varchar(10) CHARACTER SET ascii DEFAULT NULL,
  `costoServicio` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idU`),
  UNIQUE KEY `user` (`user`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`idU`, `user`, `pass`, `nombreU`, `telefonoU`, `costoServicio`) VALUES
(1, 'admin', 'admin', 'Juan Andiarena', '47311111', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `utiliza`
--

DROP TABLE IF EXISTS `utiliza`;
CREATE TABLE IF NOT EXISTS `utiliza` (
  `idO` int(11) DEFAULT NULL,
  `idR` int(11) DEFAULT NULL,
  `cuantos` int(10) NOT NULL,
  KEY `idO` (`idO`),
  KEY `idR` (`idR`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
