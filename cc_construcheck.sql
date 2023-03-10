-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 09, 2023 at 05:16 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cc_construcheck`
--

-- --------------------------------------------------------

--
-- Table structure for table `cc_asistencias`
--

CREATE TABLE `cc_asistencias` (
  `id` int(11) NOT NULL,
  `id_trabajador` int(11) NOT NULL,
  `horaE` time DEFAULT NULL,
  `horaS` time DEFAULT NULL,
  `totalHoras` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `estado` enum('ASISTIDO','FALTA') DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `cc_casa_comercial`
--

CREATE TABLE `cc_casa_comercial` (
  `id` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Dumping data for table `cc_casa_comercial`
--

INSERT INTO `cc_casa_comercial` (`id`, `name`, `description`) VALUES
(1, 'Mair', ',./;\'[]-='),
(2, 'Adi', 'test⁠test‫'),
(3, 'Patty', '-1E+02'),
(4, 'Rab', '울란바토르'),
(5, 'Cate', 'בְּרֵאשִׁית, בָּרָא אֱלֹהִים, אֵת הַשָּׁמַיִם'),
(6, 'FicticiousCompany', 'This company is totally real');

-- --------------------------------------------------------

--
-- Table structure for table `cc_cotizacion`
--

CREATE TABLE `cc_cotizacion` (
  `id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `adjunto` varchar(255) DEFAULT NULL,
  `valor` int(11) DEFAULT NULL,
  `acargo` varchar(255) DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `cc_pagos`
--

CREATE TABLE `cc_pagos` (
  `id` int(11) NOT NULL,
  `id_trabajador` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  `categoria` enum('ADELANTO','QIUNCENA','MES','DIA') NOT NULL,
  `comentario` varchar(255) DEFAULT NULL,
  `comprobante` varchar(255) DEFAULT NULL,
  `estado` enum('PAGADO','EDITADO','ELIMINADO') DEFAULT NULL,
  `monto` int(11) NOT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `cc_productos`
--

CREATE TABLE `cc_productos` (
  `id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `price` int(11) DEFAULT NULL,
  `link` varchar(255) DEFAULT NULL,
  `casaComercial` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Dumping data for table `cc_productos`
--

INSERT INTO `cc_productos` (`id`, `name`, `description`, `price`, `link`, `casaComercial`) VALUES
(1, 'Wood', 'condimentum id luctus nec molestie sed justo pellentesque viverra pede ac', 0, 'http://last.fm/nulla/pede.html?pellentesque=et&eget=eros&nunc=vestibulum&donec=ac&quis=est&orci=lacinia&eget=nisi&orci=venenatis&vehicula=tristique&condimentum=fusce&curabitur=congue&in=diam&libero=id&ut=ornare&massa=imperdiet&volutpat=sapien&convallis=ur', 4),
(2, 'Stone', 'justo etiam pretium iaculis justo in hac habitasse platea dictumst etiam', 0, 'https://marketwatch.com/leo/odio/condimentum/id/luctus.jsp?eget=quam&rutrum=fringilla&at=rhoncus&lorem=mauris&integer=enim&tincidunt=leo&ante=rhoncus&vel=sed&ipsum=vestibulum&praesent=sit&blandit=amet&lacinia=cursus&erat=id&vestibulum=turpis&sed=integer&m', 4),
(3, 'Steel', 'quisque erat eros viverra eget congue eget semper rutrum nulla nunc purus phasellus in felis', 0, 'http://who.int/maecenas/tincidunt/lacus/at/velit.js?volutpat=nunc&dui=commodo&maecenas=placerat&tristique=praesent&est=blandit&et=nam&tempus=nulla&semper=integer&est=pede&quam=justo&pharetra=lacinia&magna=eget&ac=tincidunt&consequat=eget&metus=tempus&sapi', 1),
(4, 'Brass', 'pharetra magna ac consequat metus sapien ut nunc vestibulum ante ipsum primis', 0, 'https://gnu.org/ipsum/primis/in.json?eu=aliquam&interdum=erat&eu=volutpat&tincidunt=in&in=congue&leo=etiam&maecenas=justo&pulvinar=etiam&lobortis=pretium&est=iaculis&phasellus=justo&sit=in&amet=hac&erat=habitasse&nulla=platea&tempus=dictumst&vivamus=etiam', 3),
(5, 'Vinyl', 'luctus nec molestie sed justo pellentesque viverra pede ac diam', 0, 'https://accuweather.com/nascetur.png?sapien=est&varius=donec&ut=odio&blandit=justo&non=sollicitudin&interdum=ut&in=suscipit&ante=a&vestibulum=feugiat&ante=et&ipsum=eros&primis=vestibulum&in=ac&faucibus=est&orci=lacinia&luctus=nisi&et=venenatis&ultrices=tr', 4),
(6, 'Wood', 'sed tristique in tempus sit amet sem fusce consequat nulla nisl nunc nisl duis bibendum felis', 0, 'https://sciencedaily.com/auctor/gravida.aspx?mauris=vestibulum&enim=vestibulum&leo=ante&rhoncus=ipsum&sed=primis&vestibulum=in&sit=faucibus&amet=orci&cursus=luctus&id=et&turpis=ultrices&integer=posuere&aliquet=cubilia&massa=curae', 4),
(7, 'Rubber', 'eu sapien cursus vestibulum proin eu mi nulla ac enim in tempor', 0, 'http://webnode.com/at/velit.jsp?sapien=amet&in=cursus&sapien=id&iaculis=turpis&congue=integer&vivamus=aliquet&metus=massa&arcu=id&adipiscing=lobortis&molestie=convallis&hendrerit=tortor&at=risus&vulputate=dapibus&vitae=augue&nisl=vel&aenean=accumsan&lectu', 4),
(8, 'Steel', 'mauris enim leo rhoncus sed vestibulum sit amet cursus id turpis integer aliquet massa id lobortis convallis tortor risus', 0, 'http://time.com/fusce/congue.xml?amet=mattis&lobortis=pulvinar&sapien=nulla&sapien=pede&non=ullamcorper', 4),
(9, 'Glass', 'parturient montes nascetur ridiculus mus etiam vel augue vestibulum rutrum rutrum neque', 0, 'https://paypal.com/gravida/sem.aspx?justo=id&eu=massa&massa=id&donec=nisl&dapibus=venenatis&duis=lacinia&at=aenean&velit=sit&eu=amet&est=justo&congue=morbi&elementum=ut&in=odio&hac=cras&habitasse=mi&platea=pede&dictumst=malesuada&morbi=in&vestibulum=imper', 1),
(10, 'Vinyl', 'iaculis justo in hac habitasse platea dictumst etiam faucibus cursus', 0, 'https://noaa.gov/nec/nisi/vulputate/nonummy/maecenas.json?porta=condimentum&volutpat=curabitur&quam=in&pede=libero&lobortis=ut&ligula=massa&sit=volutpat&amet=convallis&eleifend=morbi&pede=odio&libero=odio&quis=elementum&orci=eu&nullam=interdum&molestie=eu', 5),
(11, 'Wood', 'luctus cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus vivamus vestibulum sagittis sapien cum', 0, 'http://gmpg.org/morbi/odio/odio/elementum/eu/interdum/eu.js?id=sit&turpis=amet&integer=lobortis&aliquet=sapien&massa=sapien&id=non&lobortis=mi&convallis=integer&tortor=ac&risus=neque&dapibus=duis&augue=bibendum&vel=morbi&accumsan=non&tellus=quam&nisi=nec&', 1),
(12, 'Aluminum', 'pede libero quis orci nullam molestie nibh in lectus pellentesque at nulla suspendisse potenti cras in purus eu', 0, 'https://independent.co.uk/mi/nulla/ac/enim.jpg?amet=aliquam&turpis=convallis&elementum=nunc&ligula=proin&vehicula=at&consequat=turpis&morbi=a&a=pede&ipsum=posuere&integer=nonummy&a=integer&nibh=non&in=velit&quis=donec&justo=diam&maecenas=neque&rhoncus=ves', 2),
(13, 'Glass', 'sit amet turpis elementum ligula vehicula consequat morbi a ipsum', 0, 'https://cocolog-nifty.com/hac/habitasse/platea/dictumst/maecenas.js?quam=orci&turpis=luctus&adipiscing=et&lorem=ultrices&vitae=posuere&mattis=cubilia&nibh=curae&ligula=duis&nec=faucibus&sem=accumsan&duis=odio&aliquam=curabitur&convallis=convallis&nunc=dui', 3),
(14, 'Wood', 'nisi nam ultrices libero non mattis pulvinar nulla pede ullamcorper augue a suscipit nulla elit ac nulla sed vel', 0, 'http://indiatimes.com/consequat/in.xml?ipsum=diam&primis=vitae&in=quam&faucibus=suspendisse&orci=potenti&luctus=nullam&et=porttitor&ultrices=lacus&posuere=at&cubilia=turpis&curae=donec&donec=posuere&pharetra=metus&magna=vitae&vestibulum=ipsum&aliquet=aliq', 1),
(15, 'Plastic', 'in quam fringilla rhoncus mauris enim leo rhoncus sed vestibulum', 0, 'http://gnu.org/primis/in.jsp?risus=nulla&dapibus=dapibus&augue=dolor&vel=vel&accumsan=est&tellus=donec&nisi=odio&eu=justo&orci=sollicitudin&mauris=ut&lacinia=suscipit&sapien=a&quis=feugiat&libero=et&nullam=eros&sit=vestibulum&amet=ac&turpis=est&elementum=', 4),
(16, 'Stone', 'turpis elementum ligula vehicula consequat morbi a ipsum integer a nibh in quis justo maecenas rhoncus aliquam lacus', 0, 'https://bandcamp.com/eros.js?quis=mattis&justo=nibh&maecenas=ligula&rhoncus=nec&aliquam=sem&lacus=duis&morbi=aliquam&quis=convallis&tortor=nunc&id=proin&nulla=at&ultrices=turpis&aliquet=a&maecenas=pede&leo=posuere&odio=nonummy&condimentum=integer&id=non&l', 3),
(17, 'Plastic', 'turpis a pede posuere nonummy integer non velit donec diam neque vestibulum eget vulputate ut', 0, 'https://exblog.jp/rhoncus.png?cursus=sit&vestibulum=amet&proin=justo&eu=morbi&mi=ut&nulla=odio&ac=cras&enim=mi&in=pede&tempor=malesuada&turpis=in&nec=imperdiet&euismod=et&scelerisque=commodo&quam=vulputate&turpis=justo&adipiscing=in&lorem=blandit&vitae=ul', 4),
(18, 'Granite', 'amet sapien dignissim vestibulum vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere', 0, 'http://google.com.au/tristique.xml?suspendisse=et&accumsan=magnis&tortor=dis&quis=parturient&turpis=montes&sed=nascetur&ante=ridiculus&vivamus=mus&tortor=etiam&duis=vel&mattis=augue&egestas=vestibulum&metus=rutrum&aenean=rutrum&fermentum=neque&donec=aenea', 4),
(19, 'Wood', 'ligula suspendisse ornare consequat lectus in est risus auctor sed tristique in tempus sit', 0, 'http://diigo.com/aliquam/quis/turpis.aspx?non=aliquam&quam=lacus&nec=morbi&dui=quis&luctus=tortor&rutrum=id&nulla=nulla&tellus=ultrices&in=aliquet&sagittis=maecenas&dui=leo&vel=odio&nisl=condimentum&duis=id&ac=luctus&nibh=nec&fusce=molestie&lacus=sed&puru', 5),
(20, 'Plexiglass', 'ipsum dolor sit amet consectetuer adipiscing elit proin interdum mauris', 0, 'https://comsenz.com/ut/nunc/vestibulum/ante/ipsum.xml?orci=ac&pede=est&venenatis=lacinia&non=nisi&sodales=venenatis&sed=tristique&tincidunt=fusce&eu=congue&felis=diam&fusce=id&posuere=ornare&felis=imperdiet&sed=sapien&lacus=urna&morbi=pretium&sem=nisl&mau', 1),
(21, 'Wood', 'metus arcu adipiscing molestie hendrerit at vulputate vitae nisl aenean lectus', 0, 'http://artisteer.com/aliquet/maecenas/leo/odio/condimentum/id/luctus.js?turpis=habitasse&integer=platea&aliquet=dictumst&massa=aliquam&id=augue&lobortis=quam&convallis=sollicitudin&tortor=vitae&risus=consectetuer&dapibus=eget&augue=rutrum&vel=at&accumsan=', 5),
(22, 'Granite', 'rutrum at lorem integer tincidunt ante vel ipsum praesent blandit lacinia erat vestibulum sed magna at nunc commodo placerat praesent', 0, 'http://businesswire.com/eu/felis/fusce/posuere/felis.aspx?turpis=rutrum&eget=rutrum&elit=neque&sodales=aenean&scelerisque=auctor&mauris=gravida&sit=sem&amet=praesent&eros=id&suspendisse=massa&accumsan=id&tortor=nisl&quis=venenatis&turpis=lacinia&sed=aenea', 3),
(23, 'Steel', 'ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae donec pharetra magna vestibulum aliquet ultrices', 0, 'http://tinyurl.com/scelerisque/mauris/sit/amet/eros.xml?lorem=eu&integer=interdum&tincidunt=eu&ante=tincidunt&vel=in&ipsum=leo&praesent=maecenas&blandit=pulvinar&lacinia=lobortis&erat=est&vestibulum=phasellus&sed=sit&magna=amet&at=erat&nunc=nulla&commodo=', 5),
(24, 'Brass', 'aliquet massa id lobortis convallis tortor risus dapibus augue vel accumsan tellus', 0, 'http://ibm.com/pede.jpg?est=in&congue=leo&elementum=maecenas&in=pulvinar&hac=lobortis&habitasse=est&platea=phasellus&dictumst=sit&morbi=amet&vestibulum=erat&velit=nulla&id=tempus&pretium=vivamus&iaculis=in&diam=felis&erat=eu&fermentum=sapien&justo=cursus&', 3),
(25, 'Plexiglass', 'imperdiet et commodo vulputate justo in blandit ultrices enim lorem ipsum dolor sit amet consectetuer adipiscing', 0, 'http://weebly.com/massa/id/lobortis/convallis/tortor/risus.jpg?molestie=fusce&lorem=consequat&quisque=nulla&ut=nisl&erat=nunc&curabitur=nisl&gravida=duis&nisi=bibendum&at=felis&nibh=sed&in=interdum&hac=venenatis&habitasse=turpis', 5),
(26, 'Plexiglass', 'libero non mattis pulvinar nulla pede ullamcorper augue a suscipit', 0, 'http://webeden.co.uk/cubilia/curae/mauris/viverra.html?ac=tempor&consequat=convallis&metus=nulla&sapien=neque&ut=libero&nunc=convallis&vestibulum=eget&ante=eleifend&ipsum=luctus&primis=ultricies&in=eu&faucibus=nibh&orci=quisque&luctus=id&et=justo&ultrices', 3),
(27, 'Granite', 'ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae duis faucibus accumsan odio curabitur convallis duis', 0, 'http://wix.com/lobortis/vel/dapibus/at/diam.html?sed=ac&nisl=neque&nunc=duis&rhoncus=bibendum&dui=morbi&vel=non&sem=quam&sed=nec&sagittis=dui&nam=luctus&congue=rutrum&risus=nulla&semper=tellus&porta=in&volutpat=sagittis&quam=dui', 5),
(28, 'Wood', 'risus dapibus augue vel accumsan tellus nisi eu orci mauris', 0, 'http://craigslist.org/nibh/in/hac/habitasse.js?tempor=vel&convallis=sem&nulla=sed&neque=sagittis&libero=nam&convallis=congue&eget=risus&eleifend=semper&luctus=porta&ultricies=volutpat&eu=quam&nibh=pede&quisque=lobortis&id=ligula&justo=sit&sit=amet&amet=el', 3),
(29, 'Stone', 'sagittis dui vel nisl duis ac nibh fusce lacus purus aliquet at feugiat non pretium quis lectus', 0, 'https://baidu.com/dolor/quis/odio/consequat.png?gravida=in&nisi=felis&at=donec&nibh=semper&in=sapien&hac=a&habitasse=libero&platea=nam&dictumst=dui&aliquam=proin&augue=leo&quam=odio&sollicitudin=porttitor&vitae=id&consectetuer=consequat&eget=in&rutrum=con', 1),
(30, 'Aluminum', 'pede justo lacinia eget tincidunt eget tempus vel pede morbi porttitor lorem id ligula suspendisse', 0, 'https://rediff.com/dapibus/at/diam/nam/tristique/tortor.json?nam=rhoncus&congue=aliquet&risus=pulvinar&semper=sed&porta=nisl&volutpat=nunc&quam=rhoncus&pede=dui&lobortis=vel&ligula=sem&sit=sed&amet=sagittis&eleifend=nam&pede=congue&libero=risus&quis=sempe', 1),
(31, 'Plastic', 'posuere cubilia curae nulla dapibus dolor vel est donec odio justo sollicitudin', 0, 'https://vkontakte.ru/ut/dolor.xml?tempor=imperdiet&convallis=et&nulla=commodo&neque=vulputate&libero=justo&convallis=in&eget=blandit&eleifend=ultrices&luctus=enim&ultricies=lorem&eu=ipsum&nibh=dolor&quisque=sit&id=amet&justo=consectetuer&sit=adipiscing&am', 3),
(32, 'Vinyl', 'et eros vestibulum ac est lacinia nisi venenatis tristique fusce congue diam id ornare imperdiet sapien urna', 0, 'https://bluehost.com/ac/neque/duis.aspx?lacus=vestibulum&purus=quam&aliquet=sapien&at=varius&feugiat=ut&non=blandit&pretium=non&quis=interdum&lectus=in&suspendisse=ante&potenti=vestibulum&in=ante&eleifend=ipsum&quam=primis&a=in&odio=faucibus&in=orci&hac=l', 3),
(33, 'Steel', 'libero non mattis pulvinar nulla pede ullamcorper augue a suscipit nulla elit ac nulla sed vel enim sit amet nunc', 0, 'http://webmd.com/et/ultrices/posuere/cubilia/curae/duis/faucibus.jsp?nulla=vestibulum&dapibus=sed&dolor=magna&vel=at&est=nunc&donec=commodo&odio=placerat&justo=praesent&sollicitudin=blandit&ut=nam&suscipit=nulla&a=integer&feugiat=pede&et=justo&eros=lacini', 1),
(34, 'Stone', 'quis justo maecenas rhoncus aliquam lacus morbi quis tortor id nulla ultrices', 0, 'https://unicef.org/dolor/vel/est/donec.jsp?parturient=quis&montes=orci&nascetur=nullam&ridiculus=molestie&mus=nibh&etiam=in&vel=lectus&augue=pellentesque&vestibulum=at&rutrum=nulla', 5),
(35, 'Glass', 'in sagittis dui vel nisl duis ac nibh fusce lacus purus aliquet at', 0, 'https://tripod.com/nisl/nunc/nisl.aspx?curabitur=feugiat&gravida=non&nisi=pretium&at=quis&nibh=lectus&in=suspendisse&hac=potenti&habitasse=in&platea=eleifend&dictumst=quam&aliquam=a&augue=odio&quam=in&sollicitudin=hac&vitae=habitasse&consectetuer=platea&e', 4),
(36, 'Stone', 'vulputate justo in blandit ultrices enim lorem ipsum dolor sit amet consectetuer adipiscing elit proin interdum mauris non', 0, 'https://instagram.com/nulla/integer/pede/justo/lacinia.html?proin=morbi&leo=quis&odio=tortor&porttitor=id&id=nulla&consequat=ultrices&in=aliquet&consequat=maecenas&ut=leo&nulla=odio&sed=condimentum&accumsan=id&felis=luctus&ut=nec&at=molestie&dolor=sed&qui', 5),
(37, 'Aluminum', 'maecenas tincidunt lacus at velit vivamus vel nulla eget eros elementum pellentesque quisque porta volutpat erat quisque erat', 0, 'http://washington.edu/augue/vestibulum.js?sem=erat&praesent=id&id=mauris&massa=vulputate&id=elementum&nisl=nullam&venenatis=varius&lacinia=nulla&aenean=facilisi&sit=cras&amet=non&justo=velit&morbi=nec&ut=nisi&odio=vulputate&cras=nonummy&mi=maecenas&pede=t', 3),
(38, 'Plastic', 'amet diam in magna bibendum imperdiet nullam orci pede venenatis non sodales sed tincidunt', 0, 'https://wikipedia.org/metus/aenean/fermentum/donec/ut/mauris.xml?quis=hac&odio=habitasse&consequat=platea&varius=dictumst&integer=maecenas&ac=ut&leo=massa&pellentesque=quis&ultrices=augue&mattis=luctus&odio=tincidunt&donec=nulla&vitae=mollis&nisi=molestie', 5),
(39, 'Plexiglass', 'eget semper rutrum nulla nunc purus phasellus in felis donec semper sapien a libero nam', 0, 'https://jugem.jp/fusce/posuere/felis/sed/lacus/morbi/sem.xml?lectus=et&aliquam=ultrices&sit=posuere&amet=cubilia&diam=curae&in=duis&magna=faucibus&bibendum=accumsan&imperdiet=odio&nullam=curabitur&orci=convallis&pede=duis&venenatis=consequat&non=dui&sodal', 4),
(40, 'Wood', 'luctus cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus vivamus vestibulum', 0, 'http://forbes.com/vitae/mattis/nibh/ligula/nec/sem/duis.jsp?nibh=purus&ligula=aliquet&nec=at&sem=feugiat&duis=non&aliquam=pretium&convallis=quis&nunc=lectus&proin=suspendisse&at=potenti&turpis=in&a=eleifend&pede=quam&posuere=a&nonummy=odio&integer=in&non=', 1),
(41, 'Aluminum', 'sapien cursus vestibulum proin eu mi nulla ac enim in tempor turpis nec euismod scelerisque quam turpis', 0, 'https://nsw.gov.au/ac.xml?volutpat=mi&erat=nulla&quisque=ac&erat=enim&eros=in&viverra=tempor&eget=turpis&congue=nec&eget=euismod&semper=scelerisque&rutrum=quam&nulla=turpis&nunc=adipiscing&purus=lorem&phasellus=vitae&in=mattis&felis=nibh&donec=ligula&semp', 3),
(42, 'Granite', 'ultrices mattis odio donec vitae nisi nam ultrices libero non mattis pulvinar nulla', 0, 'http://samsung.com/nec/nisi/volutpat/eleifend/donec.aspx?convallis=mattis&nulla=nibh&neque=ligula&libero=nec&convallis=sem&eget=duis&eleifend=aliquam&luctus=convallis&ultricies=nunc&eu=proin&nibh=at&quisque=turpis&id=a&justo=pede&sit=posuere&amet=nonummy&', 5),
(43, 'Brass', 'justo nec condimentum neque sapien placerat ante nulla justo aliquam quis turpis eget elit sodales', 0, 'http://smh.com.au/ultrices.html?sem=sed&mauris=lacus&laoreet=morbi&ut=sem&rhoncus=mauris&aliquet=laoreet&pulvinar=ut&sed=rhoncus&nisl=aliquet&nunc=pulvinar&rhoncus=sed&dui=nisl&vel=nunc&sem=rhoncus&sed=dui&sagittis=vel&nam=sem&congue=sed&risus=sagittis&se', 3),
(44, 'Stone', 'libero nullam sit amet turpis elementum ligula vehicula consequat morbi a ipsum integer a', 0, 'https://prweb.com/duis/bibendum/morbi/non/quam/nec/dui.jpg?felis=vulputate&fusce=elementum&posuere=nullam&felis=varius&sed=nulla&lacus=facilisi&morbi=cras&sem=non&mauris=velit&laoreet=nec&ut=nisi&rhoncus=vulputate&aliquet=nonummy&pulvinar=maecenas&sed=tin', 4),
(45, 'Plastic', 'amet diam in magna bibendum imperdiet nullam orci pede venenatis non sodales sed tincidunt', 0, 'http://domainmarket.com/eget/massa/tempor/convallis/nulla/neque/libero.png?lorem=ante&integer=ipsum&tincidunt=primis&ante=in&vel=faucibus&ipsum=orci&praesent=luctus&blandit=et&lacinia=ultrices&erat=posuere&vestibulum=cubilia&sed=curae&magna=donec&at=phare', 2),
(46, 'Steel', 'integer a nibh in quis justo maecenas rhoncus aliquam lacus morbi quis tortor id nulla', 0, 'https://kickstarter.com/venenatis/lacinia.jpg?tristique=vestibulum&in=ac&tempus=est&sit=lacinia&amet=nisi&sem=venenatis&fusce=tristique&consequat=fusce&nulla=congue&nisl=diam&nunc=id&nisl=ornare&duis=imperdiet&bibendum=sapien&felis=urna&sed=pretium&interd', 1),
(47, 'Brass', 'ullamcorper purus sit amet nulla quisque arcu libero rutrum ac lobortis vel dapibus at diam nam tristique tortor eu pede', 0, 'http://furl.net/quam/sapien/varius.jsp?habitasse=porttitor&platea=pede&dictumst=justo&maecenas=eu&ut=massa&massa=donec&quis=dapibus', 5),
(48, 'Glass', 'volutpat convallis morbi odio odio elementum eu interdum eu tincidunt in leo maecenas pulvinar lobortis est phasellus sit amet erat', 0, 'http://blinklist.com/vivamus/metus/arcu.png?lectus=porta&vestibulum=volutpat&quam=erat&sapien=quisque&varius=erat&ut=eros&blandit=viverra&non=eget&interdum=congue&in=eget&ante=semper&vestibulum=rutrum&ante=nulla&ipsum=nunc&primis=purus&in=phasellus&faucib', 4),
(49, 'Vinyl', 'eu est congue elementum in hac habitasse platea dictumst morbi vestibulum', 0, 'https://themeforest.net/ullamcorper/augue/a/suscipit/nulla.js?sed=blandit&sagittis=lacinia&nam=erat&congue=vestibulum&risus=sed&semper=magna&porta=at&volutpat=nunc&quam=commodo&pede=placerat&lobortis=praesent&ligula=blandit&sit=nam&amet=nulla&eleifend=int', 2),
(50, 'Plexiglass', 'nisi vulputate nonummy maecenas tincidunt lacus at velit vivamus vel nulla eget eros elementum pellentesque quisque porta volutpat erat', 0, 'https://deliciousdays.com/aliquam/erat/volutpat/in/congue/etiam/justo.json?ante=quis&vestibulum=justo&ante=maecenas&ipsum=rhoncus&primis=aliquam&in=lacus&faucibus=morbi&orci=quis&luctus=tortor&et=id&ultrices=nulla&posuere=ultrices&cubilia=aliquet&curae=ma', 1);

-- --------------------------------------------------------

--
-- Table structure for table `cc_proyectoencurso`
--

CREATE TABLE `cc_proyectoencurso` (
  `id` int(11) NOT NULL,
  `id_proyecto` int(11) NOT NULL,
  `id_trabajador` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `cc_proyectos`
--

CREATE TABLE `cc_proyectos` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `acargo` varchar(255) DEFAULT NULL,
  `ubicacion` varchar(255) DEFAULT NULL,
  `fechaInicio` date DEFAULT NULL,
  `fechaTermino` date DEFAULT NULL,
  `metros` int(11) DEFAULT NULL,
  `metrosActuales` int(11) DEFAULT NULL,
  `valor` int(11) DEFAULT NULL,
  `estado` enum('PROCESO','FINALIZADO') DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `cc_trabajadores`
--

CREATE TABLE `cc_trabajadores` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `rut` varchar(15) NOT NULL,
  `birthday` date NOT NULL,
  `email` varchar(255) NOT NULL,
  `afp` varchar(255) NOT NULL,
  `salud` enum('FONASA','ISAPRE') NOT NULL,
  `carga` int(11) DEFAULT NULL,
  `talla` int(11) DEFAULT NULL,
  `cargo` varchar(255) DEFAULT NULL,
  `sueldo` varchar(45) DEFAULT NULL,
  `pago` enum('DIARIO','QUINCENAL','MENSUAL','AVANCES') DEFAULT NULL,
  `estado` enum('ACTIVO','INACTIVO','DESVINCULADO') DEFAULT NULL,
  `update_at` timestamp NULL DEFAULT NULL,
  `create_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `cc_users`
--

CREATE TABLE `cc_users` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `rut` varchar(15) DEFAULT NULL,
  `cargo` varchar(255) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cc_asistencias`
--
ALTER TABLE `cc_asistencias`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_trabajador_asistencias_idx` (`id_trabajador`);

--
-- Indexes for table `cc_casa_comercial`
--
ALTER TABLE `cc_casa_comercial`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cc_cotizacion`
--
ALTER TABLE `cc_cotizacion`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cc_pagos`
--
ALTER TABLE `cc_pagos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_trabajador_pagos_idx` (`id_trabajador`);

--
-- Indexes for table `cc_productos`
--
ALTER TABLE `cc_productos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_casa_comercial_productos_idx` (`casaComercial`);

--
-- Indexes for table `cc_proyectoencurso`
--
ALTER TABLE `cc_proyectoencurso`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_proyecto_enCurso_idx` (`id_proyecto`),
  ADD KEY `id_trabajador_encurso_idx` (`id_trabajador`);

--
-- Indexes for table `cc_proyectos`
--
ALTER TABLE `cc_proyectos`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cc_trabajadores`
--
ALTER TABLE `cc_trabajadores`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cc_users`
--
ALTER TABLE `cc_users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cc_asistencias`
--
ALTER TABLE `cc_asistencias`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `cc_casa_comercial`
--
ALTER TABLE `cc_casa_comercial`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `cc_cotizacion`
--
ALTER TABLE `cc_cotizacion`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `cc_pagos`
--
ALTER TABLE `cc_pagos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `cc_productos`
--
ALTER TABLE `cc_productos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `cc_proyectos`
--
ALTER TABLE `cc_proyectos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `cc_trabajadores`
--
ALTER TABLE `cc_trabajadores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `cc_users`
--
ALTER TABLE `cc_users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cc_asistencias`
--
ALTER TABLE `cc_asistencias`
  ADD CONSTRAINT `id_trabajador_asistencias` FOREIGN KEY (`id_trabajador`) REFERENCES `cc_trabajadores` (`id`);

--
-- Constraints for table `cc_pagos`
--
ALTER TABLE `cc_pagos`
  ADD CONSTRAINT `id_trabajador_pagos` FOREIGN KEY (`id_trabajador`) REFERENCES `cc_trabajadores` (`id`);

--
-- Constraints for table `cc_productos`
--
ALTER TABLE `cc_productos`
  ADD CONSTRAINT `id_casa_comercial_productos` FOREIGN KEY (`casaComercial`) REFERENCES `cc_casa_comercial` (`id`);

--
-- Constraints for table `cc_proyectoencurso`
--
ALTER TABLE `cc_proyectoencurso`
  ADD CONSTRAINT `id_proyecto_enCurso` FOREIGN KEY (`id_proyecto`) REFERENCES `cc_proyectos` (`id`),
  ADD CONSTRAINT `id_trabajador_encurso` FOREIGN KEY (`id_trabajador`) REFERENCES `cc_trabajadores` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
