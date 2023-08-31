# Lab: RogueLike - Complete

<!--- naming convention: lab-name.md -->

## Metadata

### Average Time to Complete

03:00

### How to Submit

> Labs are not always submitted for review. Still, include what the submission would look like if the learner were to submit to the LMS.

// This information is used in the `Submit` element in the Learning Management System (LMS).

### Instructor Guide

This Lab will serve as a project to check the learner's comprehension of lesson content. The guidance below should assist the instructor with final preparations before setting the learners to work on the Lab assignment.

Encourage the learners to journal during the process of working on this project.

#### How does this Lab Relate to the Preceding Content?

We worked with objects in the previous lesson(s) and Lab. This Lab incorporates these elements to create an interactive game to engage the learner's understanding. We will allow the user to move through a fixed-sized 2D map and wait for user input. Methods and classes should are used to keep the code clean.

#### What Resources Does the Learner Have Available to Them

Open the final version of your roguelike project or download a curriculum copy and open it.

> Download the curriculum version: [RogueLike files](https://aa-online.s3.us-west-1.amazonaws.com/htd-assets/csfd/object-oriented-programming/roguelike.zip]

#### What is the Recommended Plan of Attack

* Learners should start with the starter file(s) code. It is recommended that they start by listing out the steps the user should take.

#### What Questions can You Expect from Learners?

* NA

#### Stretch Goals

* Allow the user to choose their hero's symbol.
* Add a random number of treasures per level.
* Add a random number between zero and three monsters per level.

## Introduction

You have a request to enhance a RogueLike game. This roguelike game allows the user to play until their character dies. Once a player dies, they are allowed to play again with increased stats such as more starting health. Each play-through is known as a 'run.'

The starting code has a basic 2D map and controls to allow the user to press the keys WASD to move around on the map. However, the game is incomplete and missing some requirements to be an actual RogueLike game.

## Learning Outcomes

By the end of this Lab, you will be able to:

## Starter Files

Use the solution to the Code-Along Roguelike.

## Instructions

The starter project will include a map and basic character movement. Implement the following to create an actual RogueLike game:

* The treasure chest should be locked when a monster is on the map.
* A player attacks a monster by moving onto the monster's location. Each character loses two health points.
* Each time a treasure chest is open, spawn a new monster with greater strength and a new treasure chest.
* Each time a player clears a new floor, raise their max health by 10. Note: New floors are considered the highest level a player has reached across all runs.

## Deliverables

Include your journal and your working tested the program in the submission.

## Conclusion

In this Lab, we have extended a game to include several additional features of a RogueLike game.
