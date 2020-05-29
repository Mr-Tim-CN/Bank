/*
 Navicat MySQL Data Transfer

 Source Server         : win_local
 Source Server Type    : MySQL
 Source Server Version : 80020
 Source Host           : localhost:3306
 Source Schema         : bankdb1

 Target Server Type    : MySQL
 Target Server Version : 80020
 File Encoding         : 65001

 Date: 29/05/2020 14:54:09
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for creditcardinfo
-- ----------------------------
DROP TABLE IF EXISTS `creditcardinfo`;
CREATE TABLE `creditcardinfo`  (
  `手机号` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `信用额度` decimal(32, 2) NULL DEFAULT NULL,
  `已用额度` decimal(32, 2) NULL DEFAULT NULL,
  `可用额度` decimal(32, 2) NULL DEFAULT NULL,
  PRIMARY KEY (`手机号`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of creditcardinfo
-- ----------------------------

-- ----------------------------
-- Table structure for debitcardinfo
-- ----------------------------
DROP TABLE IF EXISTS `debitcardinfo`;
CREATE TABLE `debitcardinfo`  (
  `手机号` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `活期存款余额` decimal(32, 2) NULL DEFAULT NULL,
  PRIMARY KEY (`手机号`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of debitcardinfo
-- ----------------------------

-- ----------------------------
-- Table structure for foreignexchange
-- ----------------------------
DROP TABLE IF EXISTS `foreignexchange`;
CREATE TABLE `foreignexchange`  (
  `手机号` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `货币种类` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `货币持有量` decimal(32, 2) NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of foreignexchange
-- ----------------------------

-- ----------------------------
-- Table structure for timedeposit
-- ----------------------------
DROP TABLE IF EXISTS `timedeposit`;
CREATE TABLE `timedeposit`  (
  `手机号` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `额度` decimal(32, 2) NULL DEFAULT NULL,
  `存期` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `购买日期` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `到期时间` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of timedeposit
-- ----------------------------

-- ----------------------------
-- Table structure for userinfo
-- ----------------------------
DROP TABLE IF EXISTS `userinfo`;
CREATE TABLE `userinfo`  (
  `姓名` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `手机号` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `密码` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`手机号`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of userinfo
-- ----------------------------

SET FOREIGN_KEY_CHECKS = 1;
