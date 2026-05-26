CREATE TABLE plants
(
    id          BIGSERIAL PRIMARY KEY,

    name_ru     TEXT NOT NULL,

    name_latin  TEXT NOT NULL,

    plant_type  TEXT,

    height_max  DOUBLE PRECISION,

    growth_rate DOUBLE PRECISION,

    lifespan    INTEGER,

    created_at  TIMESTAMP DEFAULT NOW()
);

CREATE INDEX idx_plants_name_ru
    ON plants (name_ru);

CREATE INDEX idx_plants_name_latin
    ON plants (name_latin);

CREATE TABLE leaf_traits
(
    plant_id                  BIGINT PRIMARY KEY
        REFERENCES plants (id)
            ON DELETE CASCADE,
    leaf_area                 DOUBLE PRECISION,

    leaf_thickness            DOUBLE PRECISION,

    leaf_orientation          DOUBLE PRECISION
        CHECK (leaf_orientation BETWEEN 0 AND 1),


    leaf_density              DOUBLE PRECISION
        CHECK (leaf_density BETWEEN 0 AND 1),

    surface_texture           DOUBLE PRECISION
        CHECK (surface_texture BETWEEN 0 AND 1),

    hairiness                 DOUBLE PRECISION
        CHECK (hairiness BETWEEN 0 AND 1),

    wax                       DOUBLE PRECISION
        CHECK (wax BETWEEN 0 AND 1),

    stomata_density           DOUBLE PRECISION,

    water_content             DOUBLE PRECISION,

    photosynthetic_plasticity DOUBLE PRECISION
        CHECK (photosynthetic_plasticity BETWEEN 0 AND 1),

    leaf_color                DOUBLE PRECISION
        CHECK (leaf_color BETWEEN 0 AND 1),

    reflectivity              DOUBLE PRECISION
);

CREATE TABLE crown_traits
(
    plant_id        BIGINT PRIMARY KEY
        REFERENCES plants (id)
            ON DELETE CASCADE,

    crown_density   DOUBLE PRECISION
        CHECK (crown_density BETWEEN 0 AND 1),

    coverage_degree DOUBLE PRECISION,

    multilayer      DOUBLE PRECISION
        CHECK (multilayer BETWEEN 0 AND 1),

    green_mass      DOUBLE PRECISION,

    branching       DOUBLE PRECISION
        CHECK (branching BETWEEN 0 AND 1)
);

CREATE TABLE root_traits
(
    plant_id             BIGINT PRIMARY KEY
        REFERENCES plants (id)
            ON DELETE CASCADE,

    root_depth           DOUBLE PRECISION,

    root_branching       DOUBLE PRECISION
        CHECK (root_branching BETWEEN 0 AND 1),

    root_surface_area    DOUBLE PRECISION,

    rhizosphere_activity DOUBLE PRECISION
        CHECK (rhizosphere_activity BETWEEN 0 AND 1),

    water_absorption     DOUBLE PRECISION
        CHECK (water_absorption BETWEEN 0 AND 1),

    water_storage        DOUBLE PRECISION
        CHECK (water_storage BETWEEN 0 AND 1),

    phytoextraction      DOUBLE PRECISION
        CHECK (phytoextraction BETWEEN 0 AND 1),

    phytostimulation     DOUBLE PRECISION
        CHECK (phytostimulation BETWEEN 0 AND 1)
);

CREATE TABLE ecological_traits
(
    plant_id             BIGINT PRIMARY KEY
        REFERENCES plants (id)
            ON DELETE CASCADE,

    pollution_tolerance  DOUBLE PRECISION
        CHECK (pollution_tolerance BETWEEN 0 AND 1),

    dust_capture         DOUBLE PRECISION
        CHECK (dust_capture BETWEEN 0 AND 1),

    co2_absorption       DOUBLE PRECISION,

    gas_absorption       DOUBLE PRECISION
        CHECK (gas_absorption BETWEEN 0 AND 1),

    biodiversity_support DOUBLE PRECISION
        CHECK (biodiversity_support BETWEEN 0 AND 1),

    pollinator_support   DOUBLE PRECISION
        CHECK (pollinator_support BETWEEN 0 AND 1),

    food_value           DOUBLE PRECISION
        CHECK (food_value BETWEEN 0 AND 1),

    shelter_value        DOUBLE PRECISION
        CHECK (shelter_value BETWEEN 0 AND 1)
);

CREATE TABLE climate_traits
(
    plant_id            BIGINT PRIMARY KEY
        REFERENCES plants (id)
            ON DELETE CASCADE,

    winter_hardiness    DOUBLE PRECISION,

    humidity_adaptation DOUBLE PRECISION
        CHECK (humidity_adaptation BETWEEN 0 AND 1),

    wind_resistance     DOUBLE PRECISION
        CHECK (wind_resistance BETWEEN 0 AND 1),

    shade_tolerance     DOUBLE PRECISION
        CHECK (shade_tolerance BETWEEN 0 AND 1),

    light_requirement   DOUBLE PRECISION
);

CREATE TABLE ahp_weights
(
    id             BIGSERIAL PRIMARY KEY,

    indicator_name TEXT             NOT NULL,

    factor_name    TEXT             NOT NULL,

    weight         DOUBLE PRECISION NOT NULL,

    CHECK (weight >= 0)
);

CREATE TABLE environment_modifiers
(
    id              BIGSERIAL PRIMARY KEY,

    condition_type  TEXT             NOT NULL,

    condition_value TEXT             NOT NULL,

    indicator_name  TEXT             NOT NULL,

    modifier        DOUBLE PRECISION NOT NULL
);