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
