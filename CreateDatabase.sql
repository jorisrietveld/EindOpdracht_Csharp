DROP SCHEMA IF EXISTS `StendenWeather`;
CREATE SCHEMA `StendenWeather`;

USE `StendenWeather`;

CREATE TABLE `WeatherData` (
  `id`            INT UNSIGNED UNIQUE AUTO_INCREMENT   NOT NULL,
  `country`       VARCHAR(50)                          NOT NULL,
  `province`      VARCHAR(50)                          NOT NULL,
  `city`          VARCHAR(50)                          NOT NULL,
  `created`       DATETIME DEFAULT CURRENT_TIMESTAMP() NOT NULL,
  `temparature`   TINYINT                              NOT NULL,
  `humididy`      TINYINT UNSIGNED                     NOT NULL,
  `windDirection` SMALLINT UNSIGNED                    NOT NULL,
  `windSpeed`     SMALLINT UNSIGNED                    NOT NULL,
  `text`          VARCHAR(50)                          NOT NULL,
  `code`          TINYINT UNSIGNED                     NOT NULL,

  CONSTRAINT PRIMARY KEY WeatherDataCondition(`id`)
);