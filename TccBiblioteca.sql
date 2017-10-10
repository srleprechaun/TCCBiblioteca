-- MySQL Workbench Synchronization
-- Generated: 2017-10-05 19:58
-- Model: New Model
-- Version: 1.0
-- Project: Name of the project
-- Author: aluno

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `BdBiblioteca` DEFAULT CHARACTER SET utf8 ;

CREATE TABLE IF NOT EXISTS `BdBiblioteca`.`Aluno` (
  `RM` INT(11) NOT NULL,
  `Digital` LONGTEXT NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `telefone` VARCHAR(15) NULL DEFAULT NULL,
  `Email` VARCHAR(55) NULL DEFAULT NULL,
  `Periodo` VARCHAR(15) NOT NULL,
  `Modulo` VARCHAR(1) NOT NULL,
  PRIMARY KEY (`RM`),
  UNIQUE INDEX `RM_UNIQUE` (`RM` ASC))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `BdBiblioteca`.`MotivoDaVisita` (
  `AlugarLivro` INT(11) NOT NULL,
  PRIMARY KEY (`AlugarLivro`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `BdBiblioteca`.`MotivoVisita` (
  `Id` INT(11) NOT NULL AUTO_INCREMENT,
  `Descricao` VARCHAR(50) NOT NULL,
  `idExcluir` BIT(1) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Login_UNIQUE` (`Id` ASC))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `BdBiblioteca`.`USUARIO` (
  `Digital` INT(11) NOT NULL,
  PRIMARY KEY (`Digital`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `BdBiblioteca`.`Visita` (
  `idEntrada` INT(11) NOT NULL AUTO_INCREMENT,
  `DataEntrada` DATETIME NOT NULL,
  `Aluno_RM` INT(11) NOT NULL,
  `MotivoVisita_Id` INT(11) NOT NULL,
  PRIMARY KEY (`idEntrada`),
  INDEX `fk_Visita_Aluno1_idx` (`Aluno_RM` ASC),
  INDEX `fk_Visita_MotivoVisita1_idx` (`MotivoVisita_Id` ASC),
  CONSTRAINT `fk_Visita_Aluno1`
    FOREIGN KEY (`Aluno_RM`)
    REFERENCES `BdBiblioteca`.`Aluno` (`RM`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Visita_MotivoVisita1`
    FOREIGN KEY (`MotivoVisita_Id`)
    REFERENCES `BdBiblioteca`.`MotivoVisita` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `BdBiblioteca`.`Funcionario` (
  `Login` VARCHAR(50) NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `Senha` VARCHAR(45) NOT NULL,
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `Telefone` VARCHAR(45) NOT NULL,
  `idExcluir` BIT(1) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `Login_UNIQUE` (`Login` ASC))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `BdBiblioteca`.`Curso` (
  `idCurso` INT(11) NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(45) NOT NULL,
  `idExcluir` BIT(1) NOT NULL,
  PRIMARY KEY (`idCurso`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `BdBiblioteca`.`Aluno_has_Curso` (
  `Aluno_RM` INT(11) NOT NULL,
  `Curso_idCurso` INT(11) NOT NULL,
  PRIMARY KEY (`Aluno_RM`, `Curso_idCurso`),
  INDEX `fk_Aluno_has_Curso_Curso1_idx` (`Curso_idCurso` ASC),
  INDEX `fk_Aluno_has_Curso_Aluno1_idx` (`Aluno_RM` ASC),
  CONSTRAINT `fk_Aluno_has_Curso_Aluno1`
    FOREIGN KEY (`Aluno_RM`)
    REFERENCES `BdBiblioteca`.`Aluno` (`RM`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Aluno_has_Curso_Curso1`
    FOREIGN KEY (`Curso_idCurso`)
    REFERENCES `BdBiblioteca`.`Curso` (`idCurso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

insert into Funcionario (login,nome,senha, idExcluir) values ("Admin","Admin",123, 1);