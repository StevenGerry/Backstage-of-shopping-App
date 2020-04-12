-- phpMyAdmin SQL Dump
-- version 4.8.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 2020-01-15 19:54:23
-- 服务器版本： 5.5.60-log
-- PHP Version: 5.6.36

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `domypc`
--

-- --------------------------------------------------------

--
-- 表的结构 `cart`
--

CREATE TABLE `cart` (
  `username` varchar(20) NOT NULL,
  `itemid` varchar(10) NOT NULL,
  `number` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `cart`
--

INSERT INTO `cart` (`username`, `itemid`, `number`) VALUES
('srf', '1', 1),
('test', '1', 3);

-- --------------------------------------------------------

--
-- 表的结构 `info`
--

CREATE TABLE `info` (
  `userid` varchar(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `userphone` varchar(20) NOT NULL,
  `useraddress` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `info`
--

INSERT INTO `info` (`userid`, `username`, `userphone`, `useraddress`) VALUES
('3', '孙云涛', '1391611611', '上海市沪城环路1111号'),
('4', '孙云涛', '1391611611', '上海市沪城环路1111号');

-- --------------------------------------------------------

--
-- 表的结构 `item`
--

CREATE TABLE `item` (
  `itemid` int(10) NOT NULL,
  `itemname` varchar(50) NOT NULL,
  `itemabout` text NOT NULL,
  `itemcost` varchar(20) NOT NULL,
  `imageurl` varchar(200) NOT NULL,
  `itemnumber` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `item`
--

INSERT INTO `item` (`itemid`, `itemname`, `itemabout`, `itemcost`, `imageurl`, `itemnumber`) VALUES
(1, '微星 GeForce RTX 2080 SUPER', '微星 GeForce RTX 2080 SUPER GAMING X TRIO 8G 2080S旗舰版 OC版电竞游戏台式电脑显卡\r\nRTX 2080 SUPER核心是英伟达这一代图灵架构中最后放出来的一款核心，采用RTX 2080 SUPER核心的显卡都用上了全新规格的显存芯片，默认等效速率可以达到15.5Gbps，加上RTX 2080 SUPER用的是完整的TU104核心，使得RTX 2080 SUPER系列显卡也可以冲击4K游戏体验。之前我们评测了微星家的RTX 2070 SUPER GAMING X TRIO魔龙显卡，可以看到其相对于微星RTX 2070 GAMING Z 魔龙具有多方面的提升，而在RTX 2080 SUPER核心推出之后，微星也推出了RTX 2080 SUPER GAMING X TRIO魔龙。\r\n微星RTX 2080 SUPER GAMING X TRIO魔龙采用了三风扇的Tri-Frozr散热器，具有3072个CUDA单元，核心频率1650MHz，Boost频率可以达到1845MHz，并且英伟达还具有GPU Boost技术，故实际频率还会高于这个数。有些RTX 2080 SUPER非公显卡在接口方面省掉了USB-C接口，但是微星这张魔龙完整的保留了USB-C接口.\r\n微星RTX 2080 SUPER GAMING X TRIO魔龙采用的三风扇Tri-Frozr散热器我们之前已经见识过它的厉害，该散热器通过刀锋5代风扇， 使用两种不同扇叶优化组合的特殊设计——特殊弧度和宽幅设计的引流扇叶可以引入更多气流，全新设计的龙鳍扇叶则具备更高的风压——能将更多气流下压后吹到散热鳍片上，快速带走散热鳍片上的热量，在之前的评测中采用三风扇Tri-Frozr散热器的微星显卡相比大多数别家的三风扇显卡，不管是在温度控制上还是噪音控制上都更有优势。\r\n微星RTX 2080 SUPER GAMING X TRIO魔龙的背板也是这一代魔龙系列一贯的背板设计，具有精致的拉丝效果，并且呈现两种颜色。而且这块金属背板的厚度也很足，给人感觉非常扎实，背板上的镂空设计既是出于美观也是利于散热表现。', '6499', 'http://hwhhome.net/syt/item_image/item_1.jpg', 91),
(2, 'NVIDIA TITAN RTX', '英伟达将TITAN RTX定位于2080 Ti公版智商，增加了CUDA内核，纹理单元，Tensor内核和RT内核。TITAN RTX具有与2080 Ti相同的GPU基准频率，但其最大频率比2080 Ti高225 Mhz，以及更高的内存总线，和更大的内存带宽。此外，英伟达还为TITAN RTX配备了24 GB GDDR6 VRAM，这是2080 Ti的两倍还多。然而，功耗也随之上升了30W，使得TITAN RTX的功耗达到了280W，比2070高出近100W，比1080 Ti高出65W。\r\nTITAN RTX具有与2080 Ti公版相同的散热器设计，但与银色的2080 Ti相比，TITAN RTX使用了金色表面。我们的评测卡上面，金色的TITAN RTX字样熠熠生辉，与中间的黑色面板相映。与TITAN X的风扇相比，英伟达用两个轴流风扇取代了单径风扇。英伟达表示，两个风扇在冷却方面比单个风扇更加有效，这样可以使显卡在高负载下低温运行，更好的保持其性能。\r\nTITAN RTX使用两个8针电源口进行供电，后部端口也很多：包括三个DP 1.4端口，一个HDMI 2.0以及一个USB Type-C接口。如果您的预算还有多5000美元的话，您还可以使用NVLink Bridge组成双路泰坦SLI。', '21999', 'http://hwhhome.net/syt/item_image/item_2.jpg', 99),
(3, 'intel core i7-9700k cpu', '在酷睿i9处理器来到桌面消费级CPU市场之前，英特尔旗舰处器的名头一直被酷睿i7占据。英特尔从一开始就给酷睿i7处理器下过定义：专为游戏而生，因此酷睿i7在游戏方面具有频率高、单核性能强以及兼容性好等天生优势，这给因游戏而生的电竞提供了更好的支持。\r\n\r\n因为游戏性能强劲，酷睿i7处理器被广泛认可，在2018平昌冬奥会期间，英特尔曾经进行过赞助，英特尔酷睿i7处理器因此也成为了奥运会指定处理器，为电竞项目做出了很大贡献。\r\n\r\n虽然电竞项目还没有正式纳入奥运会，但英特尔也在积极推进中。加上如今电竞发展越来越快，各项规则、制度趋于完善。也是在电竞迅猛发展的这几年中，产生了无数电竞精英，让电竞已经进入了亚运会的舞台，电竞加入奥运项目指日可待。\r\n\r\n02 专为游戏发烧友准备的英特尔酷睿i7-9700K\r\n\r\n目前最高端的酷睿i7处理器是第九代英特尔酷睿i7-9700K，这款处理器拥有3.6GHz的CPU主频，最大睿频可达4.9GHz，仅次于i9-9900K的5.0GHz，i7-9700K核心线程数为8核心8线程，比上代i7要多出两个物理核心，更专注于游戏领域。\r\n\r\n\r\n', '2899', 'http://hwhhome.net/syt/item_image/item_3.jpg', 98),
(4, 'intel core i9 9900k cpu', 'Intel第九代酷睿系列处理器又一次将焊接热界面材料（STIM）带回了公众的视野，相比较我们俗称的“硅脂”散热，这项被我们称作“钎焊”的手段可以更好地帮助核心将热量导出到顶盖上，以便热量快速传导到散热器之中。\r\n除了桌面级的处理器以外，Intel还带来了一款特殊的至强处理器，W-3175X，配置了28颗物理核心56个线程，3.1-4.3的频率设置，这款处理器还是首个官方解锁倍频限制的至强处理器，使用C621服务器主板。最高六通道的DDR4内存扩展，支持到68条PCI-E通道。\r\n第九代的X-series处理器也同步来临，依然使用X299芯片组的主板，型号从之前的7XXX直接提升至9XXX，核心数量从8核16线到18核36线不等，4通道内存，68条PCI-E通道。需要注意的是其中有一颗名为i9-9900X的产品与桌面级的i9-9900K只有一个字母的差别，但其实是两款产品。', '4499', 'http://hwhhome.net/syt/item_image/item_4.jpg', 100),
(5, 'HyperX掠食者DDR4 RGB', '作为HyperX的品牌形象大使——演员魏大勋的专业之选，HyperX的电竞装备不仅种类丰富，更重要的是可以为玩家提供专业的支持，帮助玩家获得出色的游戏体验和傲人的战绩。\r\n\r\n　　目前内存市场上主流最快的内存当属DDR4，起始频率2400MHz，稍微好一点的可以达到3000MHz，更好的基本在3600MHz，再高频率的只能说是凤毛麟角。内存的频率主要取决了颗粒，优质颗粒可以稳定在更高频率。而HyperX最新的HyperX Predator掠食者DDR4 RGB骇客神条，起始频率从2966MHz开始，最高达到了惊人的4000MHz。\r\n\r\n如果说发光内存，其实并不是新鲜事，前前后后至今大概经历了四代。第一代是单一光源，插上就亮，颜色也单一，第二代属于不受控制的自主变换，不会因为用户想变什么色彩就变什么色彩，第三代终于可以自主选择变换色彩，需要搭配专门的内存调色软件，并且要通过线材与主板相连，虽然内存色彩是可以随心变换，但是线材也让内部空间更凌乱，并且也不是所有主板都支持这样的内存。\r\n\r\n　　终于来到了第四代，也就是HyperX Predator掠食者DDR4 RGB骇客神条的红外同步技术，该内存在每个内存模组上都设计了红外信道，从而实现多个模组之间LED光源的同步，也就是说这款产品不需要额外线材接入主板也能轻松实现RGB灯光同步，只要直接使用主板的RGB灯光控制软件就可以。', '699', 'http://hwhhome.net/syt/item_image/item_5.jpg', 99),
(6, '海盗船白金统治者DDR4  16GB', '界顶级的铝制散热片、无可挑剔的精细做工、12颗可单独寻址的CAPELLIX LED再配以美商海盗船的iCUE软件可以实现几乎梦幻级别的灯效，当然，第一梯队水准的4800MHz已经足以让它傲视群雄，所以如果你钱够，那么只管买，错不了。\r\n首先要提的是它搭载了海盗船独家定制的10层高性能PCB板，散热片部分由阳极氧化锻造铝材质组成，导光条的保护甲由压铸微弧氧化锌合金组成。内置12个可单独寻址的美商海盗船CAPELLIX LED，，所有颗粒均为手工挑选以确保可靠性。\r\n\r\n    每一颗LED均带有专业的保护罩，提升颜值的同时兼顾产品安全，一举两得，产品尺寸为136 x 8 x 51mm。\r\n灯效做为它最重要的亮点之一，海盗船此次在软件支持方面下足了功夫，自带了十六种灯效模式，12种硬件记忆，4种软件记忆，并且全面解锁了自定义灯效模式，玩法更加多样，当然作为自家全新发售的顶级旗舰产品，这样的表现也是海盗船作为业界龙头应该有的水准。\r\n\r\n    彩虹波模式– 你所选的内存将按照色谱顺序单向循环，速度和方向支持自定义。\r\n\r\n    螺旋彩虹模式– 你所选的内存将实现螺旋彩虹的效果，速度和方向支持自定义。\r\n\r\n    颜色变化模式 – 你所选择内存将在不同颜色间逐渐转换，颜色和速度支持自定义。\r\n\r\n   彩色脉冲模式 – 你所选择内存将在变换颜色时呈现渐变脉冲效果，颜色和速度支持自定义。\r\n\r\n    色波模式– 你所选择内存将呈现单向色彩波浪效果，颜色和速度、方向支持自定义。\r\n\r\n    下雨模式 – 你所选择内存将单方向呈现下雨效果，颜色和速度、方向支持自定义。\r\n\r\n    跑马灯模式 - 你所选择内存将常亮同一颜色，辅以白色闪光在其中穿插、切割，颜色和速度支持自定义。', '1200', 'http://hwhhome.net/syt/item_image/item_6.jpg', 99),
(7, 'rtx1070', '123456', '500', 'http://hwhhome.net/syt/item_image/item_7.jpg', 100),
(8, '海盗船H100i PRO RGB 240MM', '美商海盗船Hydro H100系列水冷散热器作为高端产品一直是游戏发烧友的最爱，而这一系列的产品也在不断推陈出新，搭载RGB光效的H100i Pro作为新品和玩家见面了。\r\n和此前的H115i Pro相比，H100i Pro的冷排缩小为240毫米，可以兼容在几乎所有主流机箱中，搭配Corsair Link软件能够实现更炫酷的光效，零转速模式也为玩家体验更加安静的环境提供了好基础，下面我们就为您带来美商海盗船H100i Pro水冷散热器的评测。\r\n\r\n海盗船H100i Pro一体式水冷散热器沿用了Hydro H100系列的包装设计风格，黑色和黄色搭配的设计也是经典的海盗船风格。产品包装上有产品外观图，并明显标明了产品型号，在侧面和背面有不同语言的产品参数和特性说明。\r\nH100i Pro水冷散热器仍然采用了经典的银色和黑色的搭配，也是Hydro系列的一贯风格，冷头和冷排上的海盗船logo非常亮眼，在整机平台中也可以作为很好的点缀。\r\n', '899', 'http://hwhhome.net/syt/item_image/item_8.jpg', 100);

-- --------------------------------------------------------

--
-- 表的结构 `likelist`
--

CREATE TABLE `likelist` (
  `username` varchar(20) NOT NULL,
  `itemid` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `likelist`
--

INSERT INTO `likelist` (`username`, `itemid`) VALUES
('test', '1');

-- --------------------------------------------------------

--
-- 表的结构 `news`
--

CREATE TABLE `news` (
  `newsid` varchar(10) NOT NULL,
  `newstitle` varchar(100) NOT NULL,
  `newscontent` varchar(10000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `news`
--

INSERT INTO `news` (`newsid`, `newstitle`, `newscontent`) VALUES
('1', '科普：超频后电脑开不开机了怎么办？', '超频是DIY玩家的进阶玩法，通过解锁CPU和内存的频率，来获得更高的性能。很多老用户会选择体质强的低价CPU来通过超频媲美高价的CPU性， 当年“奔腾秒i7”也是这么来的，不仅省钱而且还很有乐趣。超频需要在BIOS里进行操控，由于BIOS是基本输入输出系统，会在正式进入Windows等系统之前运行，所以超频设置有问题的话根本不会进入系统， 而在CPU超频时出现问题，就会出现电脑没反应的情况，也就是自检过不去，造成屏幕无法点亮。\r\n\r\n一般出现这种情况，电脑都会黑屏，毫无反应，而解决方法也很简单，一般分为三种:\r\n1、扣主板电池\r\n2、CMOS重置按钮\r\n3、切换BIOS'),
('2', '高端游戏主机该用什么配置？', '首先是CPU和主板，在CPU上笔者推荐的是英特尔九代酷睿i7-9700KF搭配华硕（ASUS）TUF Z370-PLUS GAMING II 电竞特工主板。酷睿i7-9700KF是没有核显的版本，其他与i7-9700K并未任何差别，而价格相对便宜一些。而主板选择华硕（ASUS）TUF Z370-PLUS GAMING II 电竞特工主板的原因就是这款主板用料扎实，且只要升级BIOS就可直接支持九代酷睿，非常合适。\r\n\r\n接下来是显卡，目前市面上可选的显卡非常多，笔者在这里推荐iGame的RTX 2080 SUPER Advanced OC，首先是这款显卡的外观非常有特点，Advanced系列显卡中间炫酷的能量核心非常吸引人眼球，并且性能非常强悍。\r\n\r\n如果觉得价格偏高那么这款铭瑄的RTX2070 Super iCraft显卡就非常合适。整体外观延续了电竞之心系列的设计风格，银色与黑色相间的搭配外观上非常稳重，散热方面采用3风扇+5热管设计，而且性价比同样出众。\r\n\r\n当然，如果玩家们喜欢A卡，那么蓝宝石的RX 5700 XT超白金就是你不能错过的产品，7nm工艺制程的RDNA架构性能非常强悍，而蓝宝石的超白金系列一直是以强悍的性能著称，同时蓝宝石的TriXX软件还为这款显卡带来了非常有趣的黑科技！非常值得入手。\r\n\r\n接下来是硬盘，笔者推荐的是三星970 EVO PLUS的250G版本，作为系统盘绝对非常的出色，超高的读写速度可以满足几乎任何挑剔玩家。搭配上一块大容量的机械硬盘绝对是非常好的组合。当然如果玩家们想要纯固态，七彩虹的SL 500固态硬盘的1TB版本售价为609元。作为SATA接口的硬盘自然比不上顶级的Nvme M.2接口的固态，结合这个售价可以说是非常的香了！'),
('3', '英特尔酷睿i9-9900KS评测', '英特尔近日高调发布了一颗引以为傲的处理器：酷睿i9-9900KS，这款处理器拥有恐怖的全核5.0GHz睿频，在英特尔CPU历史上， 只有去年发布的限量版i7-8086K才能与之媲美，毫无疑问英特尔酷睿i9-9900KS将是英特尔新的里程碑之作，目前英特尔酷睿i9-9900KS已经在京东正式开卖，售价4299元。\r\n01 英特尔酷睿i9-9900KS规格参数\r\n\r\n    英特尔酷睿i9-9900KS与英特尔酷睿i9-9900K规格基本相同，都是14nm工艺制造，同样是八核心十六线程处理器，三级缓存为16MB，区别是英特尔酷睿i9-9900KS的基本频率为4.0GHz，英特尔酷睿i9-9900K为3.6GHz，英特尔酷睿i9-9900KS的全核频率为5.0GHz，英特尔酷睿i9-9900K单核是5.0GHz，全核睿频为4.7GHz。\r\n    在功耗上两者也有所区别，英特尔酷睿i9-9900KS的TDP为127W，而英特尔酷睿i9-9900K为95W，这意味着英特尔酷睿i9-9900KS的发热更高，对散热的要求也会更苛刻，面向的用户也是真正的高端游戏玩家，因此你还需要一款拥有强力供电和散热设计的主板与之相配。\r\n02 英特尔酷睿i9-9900KS睿频5.0GHz强在那？\r\n英特尔酷睿i9-9900KS最大特色就是全核5.0GHz睿频，这里为广大朋友们先解释一下英特尔独特的睿频功能，睿频是英特尔之前为酷睿高端i7、i9系列准备的准数技术，当然自九代“F“系列登场以后现在已经平铺到了入门级i3。这项技术是为了更好的保护和使用CPU，睿频能自动的让CPU在低负载下降低频率节电，在高负载下自动提高频率增强性能，也就是让英特尔酷睿i9-9900KS根据平台的不同情况自动在4.0的CPU基本频率和5.0睿频频率之间调整。 与英特尔酷睿i9-9900KS全核5.0睿频相比，通过超频的手段英特尔酷睿i9-9900K也可以达到全核5.0GHz的水平，但它会一直维持这个频率，保持着超高电压。而英特尔酷睿i9-9900KS不需超频就能达到这一成绩，同时没有超频的风险，还因为睿频能根据整机运行情况调整频率，也就比单纯超频上来的CPU更稳定。'),
('4', '科普：超频后电脑开不开机了怎么办？', '超频是DIY玩家的进阶玩法，通过解锁CPU和内存的频率，来获得更高的性能。很多老用户会选择体质强的低价CPU来通过超频媲美高价的CPU性， 当年“奔腾秒i7”也是这么来的，不仅省钱而且还很有乐趣。超频需要在BIOS里进行操控，由于BIOS是基本输入输出系统，会在正式进入Windows等系统之前运行，所以超频设置有问题的话根本不会进入系统， 而在CPU超频时出现问题，就会出现电脑没反应的情况，也就是自检过不去，造成屏幕无法点亮。\r\n\r\n一般出现这种情况，电脑都会黑屏，毫无反应，而解决方法也很简单，一般分为三种:\r\n1、扣主板电池\r\n2、CMOS重置按钮\r\n3、切换BIOS'),
('5', '高端游戏主机该用什么配置？', '首先是CPU和主板，在CPU上笔者推荐的是英特尔九代酷睿i7-9700KF搭配华硕（ASUS）TUF Z370-PLUS GAMING II 电竞特工主板。酷睿i7-9700KF是没有核显的版本，其他与i7-9700K并未任何差别，而价格相对便宜一些。而主板选择华硕（ASUS）TUF Z370-PLUS GAMING II 电竞特工主板的原因就是这款主板用料扎实，且只要升级BIOS就可直接支持九代酷睿，非常合适。\r\n\r\n接下来是显卡，目前市面上可选的显卡非常多，笔者在这里推荐iGame的RTX 2080 SUPER Advanced OC，首先是这款显卡的外观非常有特点，Advanced系列显卡中间炫酷的能量核心非常吸引人眼球，并且性能非常强悍。\r\n\r\n如果觉得价格偏高那么这款铭瑄的RTX2070 Super iCraft显卡就非常合适。整体外观延续了电竞之心系列的设计风格，银色与黑色相间的搭配外观上非常稳重，散热方面采用3风扇+5热管设计，而且性价比同样出众。\r\n\r\n当然，如果玩家们喜欢A卡，那么蓝宝石的RX 5700 XT超白金就是你不能错过的产品，7nm工艺制程的RDNA架构性能非常强悍，而蓝宝石的超白金系列一直是以强悍的性能著称，同时蓝宝石的TriXX软件还为这款显卡带来了非常有趣的黑科技！非常值得入手。\r\n\r\n接下来是硬盘，笔者推荐的是三星970 EVO PLUS的250G版本，作为系统盘绝对非常的出色，超高的读写速度可以满足几乎任何挑剔玩家。搭配上一块大容量的机械硬盘绝对是非常好的组合。当然如果玩家们想要纯固态，七彩虹的SL 500固态硬盘的1TB版本售价为609元。作为SATA接口的硬盘自然比不上顶级的Nvme M.2接口的固态，结合这个售价可以说是非常的香了！'),
('6', '英特尔酷睿i9-9900KS评测', '英特尔近日高调发布了一颗引以为傲的处理器：酷睿i9-9900KS，这款处理器拥有恐怖的全核5.0GHz睿频，在英特尔CPU历史上， 只有去年发布的限量版i7-8086K才能与之媲美，毫无疑问英特尔酷睿i9-9900KS将是英特尔新的里程碑之作，目前英特尔酷睿i9-9900KS已经在京东正式开卖，售价4299元。\r\n01 英特尔酷睿i9-9900KS规格参数\r\n\r\n    英特尔酷睿i9-9900KS与英特尔酷睿i9-9900K规格基本相同，都是14nm工艺制造，同样是八核心十六线程处理器，三级缓存为16MB，区别是英特尔酷睿i9-9900KS的基本频率为4.0GHz，英特尔酷睿i9-9900K为3.6GHz，英特尔酷睿i9-9900KS的全核频率为5.0GHz，英特尔酷睿i9-9900K单核是5.0GHz，全核睿频为4.7GHz。\r\n    在功耗上两者也有所区别，英特尔酷睿i9-9900KS的TDP为127W，而英特尔酷睿i9-9900K为95W，这意味着英特尔酷睿i9-9900KS的发热更高，对散热的要求也会更苛刻，面向的用户也是真正的高端游戏玩家，因此你还需要一款拥有强力供电和散热设计的主板与之相配。\r\n02 英特尔酷睿i9-9900KS睿频5.0GHz强在那？\r\n英特尔酷睿i9-9900KS最大特色就是全核5.0GHz睿频，这里为广大朋友们先解释一下英特尔独特的睿频功能，睿频是英特尔之前为酷睿高端i7、i9系列准备的准数技术，当然自九代“F“系列登场以后现在已经平铺到了入门级i3。这项技术是为了更好的保护和使用CPU，睿频能自动的让CPU在低负载下降低频率节电，在高负载下自动提高频率增强性能，也就是让英特尔酷睿i9-9900KS根据平台的不同情况自动在4.0的CPU基本频率和5.0睿频频率之间调整。 与英特尔酷睿i9-9900KS全核5.0睿频相比，通过超频的手段英特尔酷睿i9-9900K也可以达到全核5.0GHz的水平，但它会一直维持这个频率，保持着超高电压。而英特尔酷睿i9-9900KS不需超频就能达到这一成绩，同时没有超频的风险，还因为睿频能根据整机运行情况调整频率，也就比单纯超频上来的CPU更稳定。');

-- --------------------------------------------------------

--
-- 表的结构 `orderlist`
--

CREATE TABLE `orderlist` (
  `orderid` varchar(10) NOT NULL,
  `orderitemid` int(11) NOT NULL,
  `ordernumber` int(11) NOT NULL,
  `orderidname` varchar(200) NOT NULL,
  `ordername` varchar(20) NOT NULL,
  `orderphone` varchar(20) NOT NULL,
  `orderaddress` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `orderlist`
--

INSERT INTO `orderlist` (`orderid`, `orderitemid`, `ordernumber`, `orderidname`, `ordername`, `orderphone`, `orderaddress`) VALUES
('1', 1, 1, 'test', '孙云涛', '1391611611', '上海市沪城环路1111号'),
('10', 5, 1, 'test', '孙云涛', '1391611611', '上海市沪城环路1111号'),
('2', 1, 2, 'test', '孙云涛', '1391611611', '上海市沪城环路1111号'),
('3', 1, 1, 'test', '孙云涛', '1391611611', '上海市沪城环路1111号'),
('4', 6, 1, 'test', '孙云涛', '1391611611', '上海市沪城环路1111号'),
('5', 2, 1, 'test', '孙云涛', '1391611611', '上海市沪城环路1111号'),
('6', 1, 1, 'test', '孙云涛', '1391611611', '上海市沪城环路1111号'),
('7', 1, 1, 'syt', '孙云涛', '1391611611', '上海市沪城环路1111号'),
('8', 3, 1, 'syt', '孙云涛', '1391611611', '上海市沪城环路1111号'),
('9', 1, 1, 'test', '王晓峰', '1391611611', '上海市沪城环路1111号');

-- --------------------------------------------------------

--
-- 表的结构 `users`
--

CREATE TABLE `users` (
  `userid` int(11) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(20) NOT NULL,
  `phone` varchar(15) NOT NULL,
  `address` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `users`
--

INSERT INTO `users` (`userid`, `username`, `password`, `phone`, `address`) VALUES
(1, 'admin', 'admin', '000', '000'),
(2, 'huayuwenhao', '961115', '13916817108', 'Shanghai'),
(3, 'test', 'test', '123', '123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`username`,`itemid`);

--
-- Indexes for table `info`
--
ALTER TABLE `info`
  ADD PRIMARY KEY (`userid`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`itemid`);

--
-- Indexes for table `likelist`
--
ALTER TABLE `likelist`
  ADD PRIMARY KEY (`username`,`itemid`),
  ADD KEY `username` (`username`),
  ADD KEY `itemid` (`itemid`);

--
-- Indexes for table `news`
--
ALTER TABLE `news`
  ADD PRIMARY KEY (`newsid`);

--
-- Indexes for table `orderlist`
--
ALTER TABLE `orderlist`
  ADD PRIMARY KEY (`orderid`),
  ADD KEY `orderid` (`orderid`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
