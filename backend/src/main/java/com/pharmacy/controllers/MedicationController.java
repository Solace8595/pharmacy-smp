package com.pharmacy.controllers;

import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/medications")
public class MedicationController {
    
    @GetMapping
    public String getMedicationByGtin(@RequestParam String gtin) {
        return "Searching medication with GTIN: " + gtin;
    }
}
