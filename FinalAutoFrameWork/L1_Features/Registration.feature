Feature: Create Account on Online Shopping Site
  As a new user
  I want to create an account on the online shopping site
  So that I can make purchases and manage my orders
 
 
@registration
Scenario: User successfully creates an account
    Given the user is on the registration page
    When the user enters valid registration details
    Then the user should be redirected to the home page