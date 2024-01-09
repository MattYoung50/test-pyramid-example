Feature: Test Pyramid Example Key Presses
  Test happy and bad key presses

  Scenario Outline: When A Key Other Than Enter Is Pressed, A Udp Packet With A Message Goes Out
    Given the app starts
    When the <key> key is pressed
    Then <num_packets> udp packet(s) get sent out
  Examples:
    | key  | num_packets |
    |  a   |      1      |
    |  d   |      1      |
    |  f   |      1      |

  Scenario: When Enter Is Pressed, no packets go out and the program closes with exit code 0
    Given the app starts
    When the Enter key is pressed
    Then 0 udp packet(s) get sent out
    And the program closes with exit code '0'

# TODO MY: Add New BDD Test here for new feature 
# where if they type "Reverse", then we will send a packet with
# the message reversed in it