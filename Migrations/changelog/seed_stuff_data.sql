INSERT INTO "AhpWeights"
    ("GoalType", "FactorName", "Weight")
VALUES
    -- Cooling
    (0, 0, 0.25),  --  Transpiration
    (0, 2, 0.30),  --  Shading
    (0, 3, 0.20),  --  Thermoregulation
    (0, 10, 0.10), --  HumidityIncrease
    (0, 13, 0.15), --  Reflectivity

    -- AirPurification
    (1, 8, 0.30),  --  CO2Absorption
    (1, 9, 0.30),  --  DustCapture
    (1, 6, 0.20),  --  PhytoExtraction
    (1, 7, 0.20),  --  PhytoStimulation
    -- NoiseReduction
    (2, 14, 0.50), --  NoiseReduction
    (2, 16, 0.25), --  ContinuousGreenCoverage
    (2, 2, 0.15),  --  Shading
    (2, 15, 0.10), --  HabitatSupport
    -- Biodiversity
    (3, 15, 0.40), --  HabitatSupport
    (3, 16, 0.20), --  ContinuousGreenCoverage
    (3, 10, 0.10), --  HumidityIncrease
    (3, 7, 0.15),  --  PhytoStimulation
    (3, 5, 0.15),  --  WaterStorage
    -- SocialSpace
    (4, 12, 0.30), --  Functionality
    (4, 11, 0.30), --  Socialization
    (4, 2, 0.15); --   Shading


INSERT INTO "EnvironmentModifiers"
    ("ConditionType", "ConditionValue", "FactorName", "Modifier")
VALUES

    -- WallOrientation,
    -- Север
    (0, 0, 1, 1.30),    -- SolarAbsorption
    (0, 0, 13, 0.90),   -- Reflectivity

    -- Восток
    (0, 90, 2, 1.20),   -- Shading
    (0, 90, 0, 1.10),   -- Transpiration

    -- Юг    
    (0, 180, 10, 1.15), -- HumidityIncrease
    (0, 180, 3, 1.10),  -- Thermoregulation

    -- Запад
    (0, 270, 0, 1.25),  -- Transpiration 
    (0, 270, 2, 1.15),  -- Shading

    -- Pollution
    (1, 0.2, 8, 1.05),  --  CO2Absorption
    (1, 0.2, 9, 1.00),  --  DustCapture

    (1, 0.5, 9, 1.20),  --  DustCapture
    (1, 0.5, 6, 1.15),  --  PhytoExtraction

    (1, 0.8, 9, 1.40),  --  DustCapture
    (1, 0.8, 6, 1.35),  --  PhytoExtraction
    (1, 0.8, 7, 1.25),  --  PhytoStimulation

    -- Humidity
    (2, 0.2, 5, 1.40),  --  WaterStorage
    (2, 0.2, 4, 1.30),  --  WaterAbsorption

    (2, 0.5, 10, 1.10), --  HumidityIncrease

    (2, 0.8, 10, 0.85), --  HumidityIncrease
    (2, 0.8, 5, 0.80),  --  WaterStorage

    -- Temperature
    (3, 15, 3, 1.00),   --  Thermoregulation

    (3, 35, 0, 1.30),   --  Transpiration
    (3, 35, 2, 1.25),   --  Shading
    (3, 35, 10, 1.20),  --  HumidityIncrease

    -- Wind
    (4, 0.2, 16, 1.10), --  ContinuousGreenCoverage

    (4, 0.5, 14, 1.15), --  NoiseReduction

    (4, 0.9, 14, 1.30), --  NoiseReduction
    (4, 0.9, 15, 0.80); --  HabitatSupport