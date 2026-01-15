# Kiki Courier Service – Delivery Cost & Time Estimation

This is a console-based Courier Service application built using **C#** and **SOLID principles**, designed to match typical **EverestCoding technical challenges**.

The application calculates:
- Delivery cost
- Discount based on offer codes
- Final delivery cost
- Estimated delivery time (in hours)

---

## 📦 Features

### Phase 1 – Delivery Cost Estimation
- Base delivery cost calculation
- Supports 3 offer codes:
  - OFR001
  - OFR002
  - OFR003
- Only **one offer per package**
- If offer code is:
  - Invalid
  - Not found
  - Criteria not satisfied  
  → **Discount = 0**

### Phase 2 – Delivery Time Estimation
- Multiple vehicles
- Each vehicle has:
  - Max weight capacity
  - Speed (km/hr)
  - Availability time (hours)
- Delivery time calculated strictly in **hours**
- Vehicle availability updated after round trip

---

## 🧮 Cost Calculation Formula

Delivery Cost =
Base Cost + (Weight × CostPerKg) + (Distance × CostPerKm)

Base Cost = 100
CostPerKg = 10
CostPerKm = 5
