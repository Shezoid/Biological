CREATE TABLE "Plants"
(
    "Id"          UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    "NameRu"      TEXT NOT NULL,
    "NameLatin"   TEXT NOT NULL,
    "HeightMax"   DOUBLE PRECISION NOT NULL,
    "GrowthRate"  DOUBLE PRECISION NOT NULL,
    "Lifespan"    INTEGER,
    "CreatedAt"   TIMESTAMP DEFAULT NOW()
);

CREATE INDEX "IdxPlantsNameRu"
    ON "Plants" ("NameRu");

CREATE INDEX "IdxPlantsNameLatin"
    ON "Plants" ("NameLatin");

CREATE TABLE "LeafTraits"
(
    "Id" UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    "PlantId" UUID NOT NULL UNIQUE
        REFERENCES "Plants" ("Id")
            ON DELETE CASCADE,
    "LeafArea"                 DOUBLE PRECISION NOT NULL,
    "LeafThickness"            DOUBLE PRECISION NOT NULL,
    "LeafOrientation"          DOUBLE PRECISION NOT NULL,
    "LeafDensity"              DOUBLE PRECISION NOT NULL,
    "SurfaceTexture"           DOUBLE PRECISION NOT NULL,
    "Hairiness"                DOUBLE PRECISION NOT NULL,
    "Wax"                      DOUBLE PRECISION NOT NULL,
    "StomataDensity"           DOUBLE PRECISION NOT NULL,
    "WaterContent"             DOUBLE PRECISION NOT NULL,
    "PhotosyntheticPlasticity" DOUBLE PRECISION NOT NULL,
    "LeafLightness"                DOUBLE PRECISION NOT NULL,
    "Reflectivity"             DOUBLE PRECISION NOT NULL
);

CREATE TABLE "CrownTraits"
(
    "Id" UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    "PlantId" UUID NOT NULL UNIQUE
        REFERENCES "Plants" ("Id")
            ON DELETE CASCADE,
    "CrownDensity"   DOUBLE PRECISION NOT NULL,
    "CoverageDegree" DOUBLE PRECISION NOT NULL,
    "Multilayer"     DOUBLE PRECISION NOT NULL,
    "GreenMass"      DOUBLE PRECISION NOT NULL,
    "Branching"      DOUBLE PRECISION NOT NULL
);

CREATE TABLE "RootTraits"
(
    "Id" UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    "PlantId" UUID NOT NULL UNIQUE
        REFERENCES "Plants" ("Id")
            ON DELETE CASCADE,
    "RootDepth"           DOUBLE PRECISION NOT NULL,
    "RootBranching"       DOUBLE PRECISION NOT NULL,
    "RootSurfaceArea"     DOUBLE PRECISION NOT NULL,
    "RhizosphereActivity" DOUBLE PRECISION NOT NULL,
    "WaterAbsorption"     DOUBLE PRECISION NOT NULL,
    "WaterStorage"        DOUBLE PRECISION NOT NULL,
    "Phytoextraction"     DOUBLE PRECISION NOT NULL,
    "Phytostimulation"    DOUBLE PRECISION NOT NULL
);

CREATE TABLE "EcologicalTraits"
(
    "Id" UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    "PlantId" UUID NOT NULL UNIQUE
        REFERENCES "Plants" ("Id")
            ON DELETE CASCADE,
    "PollutionTolerance"  DOUBLE PRECISION NOT NULL,
    "DustCapture"         DOUBLE PRECISION NOT NULL,
    "CO2Absorption"       DOUBLE PRECISION NOT NULL,
    "GasAbsorption"       DOUBLE PRECISION NOT NULL,
    "BiodiversitySupport" DOUBLE PRECISION NOT NULL,
    "PollinatorSupport"   DOUBLE PRECISION NOT NULL,
    "FoodValue"           DOUBLE PRECISION NOT NULL,
    "ShelterValue"        DOUBLE PRECISION NOT NULL
);

CREATE TABLE "ClimateTraits"
(
    "Id" UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    "PlantId" UUID NOT NULL UNIQUE
        REFERENCES "Plants" ("Id")
            ON DELETE CASCADE,
    "HumidityAdaptation" DOUBLE PRECISION NOT NULL,
    "ShadeTolerance"     DOUBLE PRECISION NOT NULL,
    "LightRequirement"   DOUBLE PRECISION NOT NULL
);

CREATE TABLE "AhpWeights"
(
    "Id" UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    "GoalType"  INT NOT NULL,
    "FactorName" INT NOT NULL,
    "Weight" DOUBLE PRECISION NOT NULL
        CHECK ("Weight" >= 0)
);

CREATE TABLE "EnvironmentModifiers"
(
    "Id" UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    "ConditionType" INT NOT NULL,
    "ConditionValue" DOUBLE PRECISION NOT NULL,
    "FactorName" INT NOT NULL,
    "Modifier" DOUBLE PRECISION NOT NULL
);