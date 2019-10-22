-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 22-10-2019 a las 21:50:48
-- Versión del servidor: 5.5.24-log
-- Versión de PHP: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `ideas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `idC` int(11) NOT NULL AUTO_INCREMENT,
  `nombreC` varchar(32) NOT NULL,
  `telefonoC` varchar(10) NOT NULL,
  `email` varchar(60) NOT NULL,
  PRIMARY KEY (`idC`)
) ENGINE=MyISAM  DEFAULT CHARSET=ascii AUTO_INCREMENT=2 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dispositivo`
--

CREATE TABLE IF NOT EXISTS `dispositivo` (
  `idD` int(11) NOT NULL AUTO_INCREMENT,
  `modelo` varchar(30) NOT NULL,
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
) ENGINE=MyISAM DEFAULT CHARSET=ascii AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `orden`
--

CREATE TABLE IF NOT EXISTS `orden` (
  `idO` int(11) NOT NULL AUTO_INCREMENT,
  `detalle` varchar(140) DEFAULT NULL,
  `resolucion` varchar(140) DEFAULT NULL,
  `importe` int(11) DEFAULT NULL,
  `dolar` bit(1) DEFAULT NULL,
  `garantia` bit(1) DEFAULT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `estado` varchar(20) NOT NULL,
  `idU` int(11) NOT NULL,
  `idC` int(11) NOT NULL,
  `idD` int(11) NOT NULL,
  PRIMARY KEY (`idO`),
  KEY `idU` (`idU`),
  KEY `idC` (`idC`),
  KEY `idD` (`idD`)
) ENGINE=MyISAM DEFAULT CHARSET=ascii AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `repuesto`
--

CREATE TABLE IF NOT EXISTS `repuesto` (
  `idR` int(11) NOT NULL AUTO_INCREMENT,
  `nombreR` varchar(32) NOT NULL,
  `cantidad` int(5) NOT NULL,
  `costoRepuesto` int(11) DEFAULT NULL,
  PRIMARY KEY (`idR`)
) ENGINE=MyISAM  DEFAULT CHARSET=ascii AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `repuesto`
--

INSERT INTO `repuesto` (`idR`, `nombreR`, `cantidad`, `costoRepuesto`) VALUES
(1, 'Pantalla J200', 3, 0),
(3, 'Bateria Samsung S9+', 3, 9000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `idU` int(11) NOT NULL AUTO_INCREMENT,
  `user` varchar(15) NOT NULL,
  `pass` varchar(64) NOT NULL,
  `nombreU` varchar(32) NOT NULL,
  `telefonoU` varchar(10) DEFAULT NULL,
  `costoServicio` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idU`),
  UNIQUE KEY `user` (`user`)
) ENGINE=MyISAM  DEFAULT CHARSET=ascii AUTO_INCREMENT=2 ;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`idU`, `user`, `pass`, `nombreU`, `telefonoU`, `costoServicio`) VALUES
(1, 'admin', '8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918', 'Juan Andiarena', '47311111', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `utiliza`
--

CREATE TABLE IF NOT EXISTS `utiliza` (
  `idO` int(11) DEFAULT NULL,
  `idR` int(11) DEFAULT NULL,
  `cuantos` int(10) NOT NULL,
  KEY `idO` (`idO`),
  KEY `idR` (`idR`)
) ENGINE=MyISAM DEFAULT CHARSET=ascii;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
