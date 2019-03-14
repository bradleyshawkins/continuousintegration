CREATE DATABASE IF NOT EXISTS `ContinuousIntegration` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

USE `ContinuousIntegration`;

CREATE TABLE IF NOT EXISTS User
(
    Id VARCHAR(36) NOT NULL,
    Name VARCHAR(100),
    Status INT,
    PRIMARY KEY(Id)
)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci;