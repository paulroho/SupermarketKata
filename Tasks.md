# Supermarket Kata


## The Situation

Your team is building a system for managing a supermarket.
Your job is to implement features around the **cash register**.
The next backlog items are about supporting the **scanning** of the products (via the product's EAN code) and compiling information for the **receipt**.

Acceptance tests with supporting infrastructure exist as a guidance for implementation.

### Hint
Withstand the temptation to just hack the implementation until the acceptance test passes or to try to implement everything at once (*"... shouldn't be that hard ..."*).

Especially
* use **TDD**, so do not write production code if there is not a focused **failing unit** test expressing the need.
* progress in **small steps**


---

## Task 0 - Make yourself familiar with the existing code

You should have a basic idea
- of the existing domain model
- how the glueing for the specs works

---

## Task 1 - Define the API for the cash register

- The interface for the cash register should be defined
- The TODOs in the spec-driver should be done.

---

## Task 2 - Implement a simple checkout feature

> **Bring the "Simple checkout" feature to green**  

The receipt should have
- one booking line per product
- a single tax line
- the correct sum (incl. VAT).

---

## Task 3 - Support different tax rates

> **Bring the "Advanced checkout" feature to green**  

The receipt should have
- one booking line per product
- **NEW:** one line per tax rate used
- the correct sum (incl. VAT).

---
