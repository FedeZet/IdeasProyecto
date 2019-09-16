-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 16-09-2019 a las 19:02:03
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
  `id_cliente` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_cli` varchar(13) NOT NULL,
  `telefono` varchar(10) NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dispositivo`
--

DROP TABLE IF EXISTS `dispositivo`;
CREATE TABLE IF NOT EXISTS `dispositivo` (
  `id_dispositivo` int(11) NOT NULL AUTO_INCREMENT,
  `modelo` varchar(30) NOT NULL,
  `bateria` tinyint(1) DEFAULT NULL,
  `sim` tinyint(1) DEFAULT NULL,
  `cargador` tinyint(1) DEFAULT NULL,
  `tapa` tinyint(1) DEFAULT NULL,
  `estuche` tinyint(1) DEFAULT NULL,
  `T_Memoria` tinyint(1) DEFAULT NULL,
  `pin` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_dispositivo`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `dispositivo`
--

INSERT INTO `dispositivo` (`id_dispositivo`, `modelo`, `bateria`, `sim`, `cargador`, `tapa`, `estuche`, `T_Memoria`, `pin`) VALUES
(2, 'J5 2016', 1, 1, 1, 0, 1, 0, 123);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `orden`
--

DROP TABLE IF EXISTS `orden`;
CREATE TABLE IF NOT EXISTS `orden` (
  `id_orden` int(11) NOT NULL AUTO_INCREMENT,
  `falla` varchar(140) NOT NULL,
  `importe` int(7) NOT NULL,
  `garantia` date NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `estado` varchar(20) NOT NULL,
  `id_usuario` int(11) DEFAULT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `id_dispositivo` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_orden`),
  KEY `id_usuario` (`id_usuario`),
  KEY `id_cliente` (`id_cliente`),
  KEY `id_dispositivo` (`id_dispositivo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `repuesto`
--

DROP TABLE IF EXISTS `repuesto`;
CREATE TABLE IF NOT EXISTS `repuesto` (
  `id_repuesto` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_rep` varchar(32) DEFAULT NULL,
  `cantidad` int(5) NOT NULL,
  PRIMARY KEY (`id_repuesto`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `repuesto`
--

INSERT INTO `repuesto` (`id_repuesto`, `nombre_rep`, `cantidad`) VALUES
(1, 'DISPLAY j2SM-510', 66);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `Nick` varchar(15) NOT NULL,
  `contrasenia` varchar(15) NOT NULL,
  `nombre` varchar(32) NOT NULL,
  `telefono` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `Nick`, `contrasenia`, `nombre`, `telefono`) VALUES
(7, 'Juancho69', 'tuvieja', 'Pedro', '7382468'),
(1, 'FedeCagaTodo', 'Mtatate', 'Federico Coelho', '09289282');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `utiliza`
--

DROP TABLE IF EXISTS `utiliza`;
CREATE TABLE IF NOT EXISTS `utiliza` (
  `id_orden` int(11) DEFAULT NULL,
  `id_repuesto` int(11) DEFAULT NULL,
  `cuantos` int(10) NOT NULL,
  KEY `id_orden` (`id_orden`),
  KEY `id_repuesto` (`id_repuesto`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
