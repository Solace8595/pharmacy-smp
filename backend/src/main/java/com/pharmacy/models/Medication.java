package com.pharmacy.models;

import jakarta.persistence.*;
import java.util.UUID;

@Entity
@Table(name = "medications")
public class Medication {
    @Id
    @GeneratedValue(strategy = GenerationType.UUID)
    private UUID id;
    
    @Column(unique = true)
    private String gtin;
    
    private String name;
    private String description;
    
    public Medication() {}
    
    public Medication(String gtin, String name, String description) {
        this.gtin = gtin;
        this.name = name;
        this.description = description;
    }
    
    public UUID getId() { return id; }
    public void setId(UUID id) { this.id = id; }
    
    public String getGtin() { return gtin; }
    public void setGtin(String gtin) { this.gtin = gtin; }
    
    public String getName() { return name; }
    public void setName(String name) { this.name = name; }
    
    public String getDescription() { return description; }
    public void setDescription(String description) { this.description = description; }
}
