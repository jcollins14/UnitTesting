﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTesting
{
    public class RomanNumeralTest
    {
        private RomanNumeral rm = new RomanNumeral();

        [Theory]
        [InlineData(1,"I")]
        [InlineData(2,"II")]
        [InlineData(3,"III")]
        [InlineData(4,"IV")]
        [InlineData(5,"V")]
        [InlineData(6,"VI")]
        [InlineData(7,"VII")]
        [InlineData(8,"VIII")]
        [InlineData(9,"IX")]
        [InlineData(10,"X")]
        [InlineData(11,"XI")]
        [InlineData(12,"XII")]
        [InlineData(13,"XIII")]
        [InlineData(14,"XIV")]
        [InlineData(15,"XV")]
        [InlineData(16,"XVI")]
        [InlineData(17,"XVII")]
        [InlineData(18,"XVIII")]
        [InlineData(19,"XIX")]
        [InlineData(20,"XX")]
        [InlineData(21,"XXI")]
        [InlineData(22,"XXII")]
        [InlineData(23,"XXIII")]
        [InlineData(24,"XXIV")]
        [InlineData(25,"XXV")]
        [InlineData(26,"XXVI")]
        [InlineData(27,"XXVII")]
        [InlineData(28,"XXVIII")]
        [InlineData(29,"XXIX")]
        [InlineData(30,"XXX")]
        [InlineData(31, "XXXI")]
        [InlineData(32, "XXXII")]
        [InlineData(33, "XXXIII")]
        [InlineData(34, "XXXIV")]
        [InlineData(35, "XXXV")]
        [InlineData(36, "XXXVI")]
        [InlineData(37, "XXXVII")]
        [InlineData(38, "XXXVIII")]
        [InlineData(39, "XXXIX")]
        [InlineData(40, "XL")]
        [InlineData(41, "XLI")]
        [InlineData(42, "XLII")]
        [InlineData(43, "XLIII")]
        [InlineData(44, "XLIV")]
        [InlineData(45, "XLV")]
        [InlineData(46, "XLVI")]
        [InlineData(47, "XLVII")]
        [InlineData(48, "XLVIII")]
        [InlineData(49, "XLIX")]
        [InlineData(50, "L")]
        [InlineData(51, "LI")]
        [InlineData(52, "LII")]
        [InlineData(53, "LIII")]
        [InlineData(54, "LIV")]
        [InlineData(55, "LV")]
        [InlineData(56, "LVI")]
        [InlineData(57, "LVII")]
        [InlineData(58, "LVIII")]
        [InlineData(59, "LIX")]
        [InlineData(60, "LX")]
        [InlineData(61, "LXI")]
        [InlineData(62, "LXII")]
        [InlineData(63, "LXIII")]
        [InlineData(64, "LXIV")]
        [InlineData(65, "LXV")]
        [InlineData(66, "LXVI")]
        [InlineData(67, "LXVII")]
        [InlineData(68, "LXVIII")]
        [InlineData(69, "LXIX")]
        [InlineData(70, "LXX")]
        [InlineData(71, "LXXI")]
        [InlineData(72, "LXXII")]
        [InlineData(73, "LXXIII")]
        [InlineData(74, "LXXIV")]
        [InlineData(75, "LXXV")]
        [InlineData(76, "LXXVI")]
        [InlineData(77, "LXXVII")]
        [InlineData(78, "LXXVIII")]
        [InlineData(79, "LXXIX")]
        [InlineData(80, "LXXX")]
        [InlineData(81, "LXXXI")]
        [InlineData(82, "LXXXII")]
        [InlineData(83, "LXXXIII")]
        [InlineData(84, "LXXXIV")]
        [InlineData(85, "LXXXV")]
        [InlineData(86, "LXXXVI")]
        [InlineData(87, "LXXXVII")]
        [InlineData(88, "LXXXVIII")]
        [InlineData(89, "LXXXIX")]
        [InlineData(90, "XC")]
        [InlineData(91, "XCI")]
        [InlineData(92, "XCII")]
        [InlineData(93, "XCIII")]
        [InlineData(94, "XCIV")]
        [InlineData(95, "XCV")]
        [InlineData(96, "XCVI")]
        [InlineData(97, "XCVII")]
        [InlineData(98, "XCVIII")]
        [InlineData(99, "XCIX")]
        [InlineData(100, "C")]
        [InlineData(101, "CI")]
        [InlineData(102, "CII")]
        [InlineData(103, "CIII")]
        [InlineData(104, "CIV")]
        [InlineData(105, "CV")]
        [InlineData(106, "CVI")]
        [InlineData(107, "CVII")]
        [InlineData(108, "CVIII")]
        [InlineData(109, "CIX")]
        [InlineData(110, "CX")]
        [InlineData(111, "CXI")]
        [InlineData(112, "CXII")]
        [InlineData(113, "CXIII")]
        [InlineData(114, "CXIV")]
        [InlineData(115, "CXV")]
        [InlineData(116, "CXVI")]
        [InlineData(117, "CXVII")]
        [InlineData(118, "CXVIII")]
        [InlineData(119, "CXIX")]
        [InlineData(120, "CXX")]
        [InlineData(121, "CXXI")]
        [InlineData(122, "CXXII")]
        [InlineData(123, "CXXIII")]
        [InlineData(124, "CXXIV")]
        [InlineData(125, "CXXV")]
        [InlineData(126, "CXXVI")]
        [InlineData(127, "CXXVII")]
        [InlineData(128, "CXXVIII")]
        [InlineData(129, "CXXIX")]
        [InlineData(130, "CXXX")]
        [InlineData(131, "CXXXI")]
        [InlineData(132, "CXXXII")]
        [InlineData(133, "CXXXIII")]
        [InlineData(134, "CXXXIV")]
        [InlineData(135, "CXXXV")]
        [InlineData(136, "CXXXVI")]
        [InlineData(137, "CXXXVII")]
        [InlineData(138, "CXXXVIII")]
        [InlineData(139, "CXXXIX")]
        [InlineData(140, "CXL")]
        [InlineData(141, "CXLI")]
        [InlineData(142, "CXLII")]
        [InlineData(143, "CXLIII")]
        [InlineData(144, "CXLIV")]
        [InlineData(145, "CXLV")]
        [InlineData(146, "CXLVI")]
        [InlineData(147, "CXLVII")]
        [InlineData(148, "CXLVIII")]
        [InlineData(149, "CXLIX")]
        [InlineData(150, "CL")]
        [InlineData(151, "CLI")]
        [InlineData(152, "CLII")]
        [InlineData(153, "CLIII")]
        [InlineData(154, "CLIV")]
        [InlineData(155, "CLV")]
        [InlineData(156, "CLVI")]
        [InlineData(157, "CLVII")]
        [InlineData(158, "CLVIII")]
        [InlineData(159, "CLIX")]
        [InlineData(160, "CLX")]
        [InlineData(161, "CLXI")]
        [InlineData(162, "CLXII")]
        [InlineData(163, "CLXIII")]
        [InlineData(164, "CLXIV")]
        [InlineData(165, "CLXV")]
        [InlineData(166, "CLXVI")]
        [InlineData(167, "CLXVII")]
        [InlineData(168, "CLXVIII")]
        [InlineData(169, "CLXIX")]
        [InlineData(170, "CLXX")]
        [InlineData(171, "CLXXI")]
        [InlineData(172, "CLXXII")]
        [InlineData(173, "CLXXIII")]
        [InlineData(174, "CLXXIV")]
        [InlineData(175, "CLXXV")]
        [InlineData(176, "CLXXVI")]
        [InlineData(177, "CLXXVII")]
        [InlineData(178, "CLXXVIII")]
        [InlineData(179, "CLXXIX")]
        [InlineData(180, "CLXXX")]
        [InlineData(181, "CLXXXI")]
        [InlineData(182, "CLXXXII")]
        [InlineData(183, "CLXXXIII")]
        [InlineData(184, "CLXXXIV")]
        [InlineData(185, "CLXXXV")]
        [InlineData(186, "CLXXXVI")]
        [InlineData(187, "CLXXXVII")]
        [InlineData(188, "CLXXXVIII")]
        [InlineData(189, "CLXXXIX")]
        [InlineData(190, "CXC")]
        [InlineData(191, "CXCI")]
        [InlineData(192, "CXCII")]
        [InlineData(193, "CXCIII")]
        [InlineData(194, "CXCIV")]
        [InlineData(195, "CXCV")]
        [InlineData(196, "CXCVI")]
        [InlineData(197, "CXCVII")]
        [InlineData(198, "CXCVIII")]
        [InlineData(199, "CXCIX")]
        [InlineData(200, "CC")]


        public void RomanNumberTest(int x, string actual)
        {
            string expected = rm.Convert(x);
            Assert.Equal(expected, actual);
        }
    }
}
