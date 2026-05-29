-- =========================================================
-- LeafTraits (СЫРЫЕ ДАННЫЕ)
-- Единицы измерения:
-- LeafArea (cm²), LeafThickness (mm),
-- LeafOrientation (градусов),
-- LeafDensity (%),
-- SurfaceTexture (%),
-- Hairiness (%),
-- Wax (%),
-- StomataDensity (кол-во / mm²),
-- WaterContent (%),
-- PhotosyntheticPlasticity (%),
-- LeafLightness (%),
-- Reflectivity (%)

INSERT INTO "LeafTraits" ("PlantId",
                          "LeafArea",
                          "LeafThickness",
                          "LeafOrientation",
                          "LeafDensity",
                          "SurfaceTexture",
                          "Hairiness",
                          "Wax",
                          "StomataDensity",
                          "WaterContent",
                          "PhotosyntheticPlasticity",
                          "LeafLightness",
                          "Reflectivity")
VALUES ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Актинидия коломикта'),
        80, 0.25, 35, 60, 40, 20, 15, 420, 65, 85, 60, 18),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Аристолохия маньчжурская'),
        120, 0.35, 30, 70, 50, 15, 10, 380, 60, 75, 55, 20),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Виноград амурский'),
        140, 0.30, 40, 65, 45, 25, 20, 500, 70, 90, 60, 22),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Девичий виноград пятилисточковый'),
        160, 0.32, 45, 68, 50, 30, 20, 460, 68, 88, 65, 25),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Древогубец лазящий'),
        100, 0.28, 38, 60, 45, 20, 12, 390, 60, 82, 58, 18),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Древогубец плетеобразный'),
        95, 0.26, 35, 58, 42, 18, 10, 370, 58, 80, 55, 17),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Жимолость каприфоль'),
        90, 0.27, 37, 62, 48, 22, 15, 360, 62, 81, 58, 19),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Клематис тангутский'),
        70, 0.20, 30, 55, 40, 15, 10, 300, 55, 78, 52, 15),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Княжик сибирский'),
        25, 0.12, 25, 40, 35, 10, 5, 200, 50, 70, 45, 10),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Лимонник китайский'),
        45, 0.18, 35, 55, 45, 20, 10, 320, 60, 75, 55, 18),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Луносемянник даурский'),
        20, 0.10, 28, 35, 30, 10, 5, 180, 45, 65, 40, 10),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Паслен сладко-горький'),
        30, 0.15, 32, 45, 40, 15, 8, 220, 50, 70, 50, 12),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тладианта сомнительная'),
        85, 0.25, 40, 60, 45, 20, 12, 350, 65, 75, 55, 18),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Трехкрыльник Регеля'),
        60, 0.18, 30, 50, 40, 10, 5, 280, 55, 70, 50, 12),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Хмель обыкновенный'),
        110, 0.28, 42, 70, 55, 25, 18, 420, 70, 85, 60, 22),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Помидорное дерево'),
        150, 0.30, 35, 65, 50, 20, 15, 450, 68, 80, 60, 20),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Томат индетерминантный'),
        80, 0.22, 30, 55, 45, 30, 15, 400, 65, 75, 55, 18),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква декоративная'),
        200, 0.40, 50, 75, 60, 35, 25, 500, 75, 80, 65, 25),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква фиголистная'),
        210, 0.42, 52, 78, 62, 38, 25, 520, 78, 82, 68, 28),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Бешеный огурец'),
        90, 0.25, 45, 70, 55, 40, 20, 380, 70, 75, 60, 18),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Кабачок цукини'),
        180, 0.38, 50, 72, 58, 35, 25, 480, 75, 80, 65, 22),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Патиссон'),
        170, 0.36, 48, 70, 55, 30, 22, 460, 73, 78, 63, 20),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква мускатная'),
        220, 0.45, 55, 80, 65, 40, 30, 550, 80, 85, 70, 30);



-- =========================================================
-- ClimateTraits (СЫРЫЕ ДАННЫЕ)
-- Единицы измерения:
-- HumidityAdaptation (%)
-- ShadeTolerance (%)
-- LightRequirement (%)
-- =========================================================

INSERT INTO "ClimateTraits" ("PlantId",
                             "HumidityAdaptation",
                             "ShadeTolerance",
                             "LightRequirement")
VALUES ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Актинидия коломикта'), 70, 60, 80),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Аристолохия маньчжурская'), 65, 55, 75),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Виноград амурский'), 60, 50, 85),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Девичий виноград пятилисточковый'), 55, 45, 90),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Древогубец лазящий'), 60, 50, 80),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Древогубец плетеобразный'), 58, 48, 78),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Жимолость каприфоль'), 62, 52, 82),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Клематис тангутский'), 55, 50, 80),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Княжик сибирский'), 50, 40, 70),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Лимонник китайский'), 65, 55, 85),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Луносемянник даурский'), 45, 35, 60),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Паслен сладко-горький'), 50, 45, 75),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тладианта сомнительная'), 55, 50, 70),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Трехкрыльник Регеля'), 60, 55, 80),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Хмель обыкновенный'), 65, 60, 85),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Помидорное дерево'), 60, 50, 90),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Томат индетерминантный'), 55, 45, 85),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква декоративная'), 70, 60, 95),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква фиголистная'), 72, 62, 90),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Бешеный огурец'), 65, 55, 88),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Кабачок цукини'), 70, 60, 92),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Патиссон'), 68, 58, 90),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква мускатная'), 75, 65, 95);



-- =========================================================
-- EcologicalTraits (СЫРЫЕ ДАННЫЕ)
-- PollutionTolerance (%)
-- DustCapture (mg / (m² · day))
-- Co2Absorption (g / (m² · day))
-- GasAbsorption (%)
-- BiodiversitySupport (%)
-- PollinatorSupport (%)
-- FoodValue (%)
-- ShelterValue (%)
-- =========================================================

INSERT INTO "EcologicalTraits" ("PlantId",
                                "PollutionTolerance",
                                "DustCapture",
                                "CO2Absorption",
                                "GasAbsorption",
                                "BiodiversitySupport",
                                "PollinatorSupport",
                                "FoodValue",
                                "ShelterValue")
VALUES ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Актинидия коломикта'), 70, 180, 35, 60, 12 * 5, 85, 95, 80),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Аристолохия маньчжурская'), 50, 120, 20, 40, 10 * 5, 30, 10, 70),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Виноград амурский'), 80, 220, 45, 75, 15 * 5, 70, 90, 85),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Девичий виноград пятилисточковый'), 85, 250, 50, 80, 16 * 5, 75,
        20, 90),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Древогубец лазящий'), 60, 150, 30, 55, 12 * 5, 40, 5, 75),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Древогубец плетеобразный'), 58, 140, 28, 50, 11 * 5, 38, 5, 72),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Жимолость каприфоль'), 75, 200, 40, 70, 14 * 5, 90, 80, 85),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Клематис тангутский'), 65, 160, 32, 60, 10 * 5, 60, 10, 70),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Княжик сибирский'), 55, 90, 18, 45, 8 * 5, 50, 0, 60),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Лимонник китайский'), 78, 210, 42, 78, 15 * 5, 85, 95, 80),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Луносемянник даурский'), 45, 100, 15, 35, 6 * 5, 40, 0, 55),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Паслен сладко-горький'), 65, 130, 25, 55, 10 * 5, 60, 20, 70),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тладианта сомнительная'), 60, 170, 28, 60, 12 * 5, 65, 30, 75),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Трехкрыльник Регеля'), 70, 140, 22, 65, 9 * 5, 50, 5, 65),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Хмель обыкновенный'), 85, 240, 55, 85, 18 * 5, 90, 15, 95),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Помидорное дерево'), 60, 200, 40, 70, 12 * 5, 75, 100, 80),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Томат индетерминантный'), 50, 180, 35, 65, 10 * 5, 70, 100, 75),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква декоративная'), 70, 260, 60, 80, 15 * 5, 85, 30, 90),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква фиголистная'), 72, 280, 62, 82, 16 * 5, 88, 40, 92),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Бешеный огурец'), 65, 190, 30, 60, 10 * 5, 60, 5, 80),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Кабачок цукини'), 68, 230, 55, 78, 14 * 5, 82, 95, 88),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Патиссон'), 66, 220, 52, 76, 13 * 5, 80, 95, 85),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква мускатная'), 75, 300, 65, 85, 16 * 5, 90, 100, 95);


-- =========================================================
-- RootTraits (СЫРЫЕ ДАННЫЕ)
-- RootDepth (cm)
-- RootBranching (%)
-- RootSurfaceArea (cm²)
-- RhizosphereActivity (%) 
-- WaterAbsorption (%) 
-- WaterStorage (%) 
-- Phytoextraction (%)
-- Phytostimulation (%)
-- =========================================================

INSERT INTO "RootTraits" ("PlantId",
                          "RootDepth",
                          "RootBranching",
                          "RootSurfaceArea",
                          "RhizosphereActivity",
                          "WaterAbsorption",
                          "WaterStorage",
                          "Phytoextraction",
                          "Phytostimulation")
VALUES ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Актинидия коломикта'), 80, 70, 1200, 60, 70, 60, 40, 50),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Аристолохия маньчжурская'), 60, 80, 1000, 50, 60, 50, 30, 40),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Виноград амурский'), 150, 90, 1800, 80, 90, 70, 60, 70),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Девичий виноград пятилисточковый'), 180, 0.9, 2000, 85, 90, 75, 65,
        80),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Древогубец лазящий'), 120, 75, 1400, 65, 70, 60, 50, 55),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Древогубец плетеобразный'), 110, 70, 1300, 60, 65, 55, 45, 50),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Жимолость каприфоль'), 100, 80, 1500, 70, 75, 65, 55, 60),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Клематис тангутский'), 90, 60, 1100, 55, 60, 50, 40, 45),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Княжик сибирский'), 70, 50, 900, 50, 55, 45, 35, 40),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Лимонник китайский'), 130, 85, 1700, 75, 85, 70, 60, 70),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Луносемянник даурский'), 60, 60, 800, 45, 50, 40, 30, 35),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Паслен сладко-горький'), 100, 70, 1200, 60, 65, 55, 50, 55),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тладианта сомнительная'), 110, 75, 1300, 65, 70, 60, 55, 60),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Трехкрыльник Регеля'), 90, 65, 1000, 60, 60, 50, 60, 55),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Хмель обыкновенный'), 160, 90, 2100, 85, 90, 80, 70, 85),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Помидорное дерево'), 140, 85, 1900, 70, 85, 75, 60, 70),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Томат индетерминантный'), 120, 80, 1600, 65, 80, 70, 55, 65),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква декоративная'), 150, 85, 2200, 75, 90, 85, 65, 80),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква фиголистная'), 160, 90, 2400, 80, 90, 90, 70, 85),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Бешеный огурец'), 90, 70, 1200, 60, 75, 65, 60, 70),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Кабачок цукини'), 130, 80, 2000, 75, 85, 80, 65, 80),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Патиссон'), 120, 75, 1900, 70, 80, 75, 60, 75),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква мускатная'), 170, 90, 2500, 85, 95, 90, 75, 90);

-- =========================================================
-- CrownTraits (ПЕРЕВЕДЕНО В ПРОЦЕНТЫ)
-- CrownDensity   (%)
-- CoverageDegree (m²)
-- Multilayer     (%)
-- GreenMass      (%)
-- Branching      (%)
-- =========================================================

INSERT INTO "CrownTraits" ("PlantId",
                           "CrownDensity",
                           "CoverageDegree",
                           "Multilayer",
                           "GreenMass",
                           "Branching")
VALUES ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Актинидия коломикта'), 65, 8, 60, 43, 70),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Аристолохия маньчжурская'), 85, 10, 70, 50, 80),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Виноград амурский'), 90, 18, 80, 71, 90),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Девичий виноград пятилисточковый'), 95, 25, 90, 86, 95),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Древогубец лазящий'), 75, 15, 70, 57, 80),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Древогубец плетеобразный'), 72, 14, 70, 50, 75),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Жимолость каприфоль'), 80, 16, 80, 64, 85),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Клематис тангутский'), 60, 9, 60, 36, 65),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Княжик сибирский'), 50, 6, 50, 21, 55),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Лимонник китайский'), 85, 17, 85, 79, 90),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Луносемянник даурский'), 45, 5, 40, 14, 50),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Паслен сладко-горький'), 65, 8, 60, 36, 70),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тладианта сомнительная'), 70, 12, 65, 43, 75),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Трехкрыльник Регеля'), 55, 7, 50, 29, 60),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Хмель обыкновенный'), 92, 22, 95, 93, 98),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Помидорное дерево'), 70, 14, 60, 64, 75),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Томат индетерминантный'), 60, 10, 50, 50, 65),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква декоративная'), 88, 20, 85, 86, 90),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква фиголистная'), 90, 22, 90, 93, 92),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Бешеный огурец'), 75, 12, 70, 43, 80),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Кабачок цукини'), 80, 18, 80, 71, 85),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Патиссон'), 78, 17, 75, 64, 83),
       ((SELECT "Id" FROM "Plants" WHERE "NameRu" = 'Тыква мускатная'), 92, 24, 95, 100, 96);