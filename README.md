# Biological Scoring Service

## Общая идея

Система предназначена для оценки растений по их пригодности для различных целей (охлаждение, очистка воздуха,
биоразнообразие и т.д.) на основе:

- морфологических характеристик растения (traits)
- весов AHP (Analytic Hierarchy Process)
- модификаторов окружающей среды
- профиля среды (EnvironmentProfile)

---

## Структура данных

### Plants

Базовая таблица растений:

- `NameRu` — русское название
- `NameLatin` — латинское название
- `HeightMax` — максимальная высота (метры)
- `GrowthRate` — скорость роста (метр/год)
- `Lifespan` — продолжительность жизни (лет)

---

## Группы признаков (Traits)

Каждое растение описывается набором численных характеристии.

---

### LeafTraits / Листовые характеристики

| Англ.                    | Рус.                      | Единицы |
|--------------------------|---------------------------|---------|
| LeafArea                 | Площадь листа             | см²     |
| LeafThickness            | Толщина листа             | мм      |
| LeafOrientation          | Ориентация листа          | градусы |
| LeafDensity              | Плотность листа           | %       |
| SurfaceTexture           | Текстура поверхности      | %       |
| Hairiness                | Опушение                  | %       |
| Wax                      | Восковое покрытие         | %       |
| StomataDensity           | Плотность устьиц          | на мм²  |
| WaterContent             | Влажность листа           | %       |
| PhotosyntheticPlasticity | Пластичность фотосинтеза  | %       |
| LeafLightness            | Светлость листа           | %       |
| Reflectivity             | Отражательная способность | %       |

---

### CrownTraits / Крона

| Англ.          | Рус.             | Единицы |
|----------------|------------------|---------|
| CrownDensity   | Плотность кроны  | %       |
| CoverageDegree | Степень покрытия | м²      |
| Multilayer     | Многослойность   | %       |
| GreenMass      | Зелёная масса    | %       |
| Branching      | Ветвистость      | %       |

---

### RootTraits / Корни

| Англ.               | Рус.                       | Единицы |
|---------------------|----------------------------|---------|
| RootDepth           | Глубина корней             | см      |
| RootBranching       | Ветвистость корней         | %       |
| RootSurfaceArea     | Площадь поверхности корней | см²     |
| RhizosphereActivity | Активность ризосферы       | %       |
| WaterAbsorption     | Поглощение воды            | %       |
| WaterStorage        | Запас воды                 | %       |
| Phytoextraction     | Фитоэкстракция             | %       |
| Phytostimulation    | Фитостимуляция             | %       |

---

### EcologicalTraits / Экологические эффекты

| Англ.               | Рус.                       | Единицы         |
|---------------------|----------------------------|-----------------|
| PollutionTolerance  | Устойчивость к загрязнению | %               |
| DustCapture         | Улавливание пыли           | mg / (m² · day) |
| CO2Absorption       | Поглощение CO2             | g / (m² · day)  |
| GasAbsorption       | Поглощение газов           | %               |
| BiodiversitySupport | Поддержка биоразнообразия  | %               |
| PollinatorSupport   | Поддержка опылителей       | %               |
| FoodValue           | Пищевая ценность           | %               |
| ShelterValue        | Укрытие / тень             | %               |

---

### ClimateTraits / Климатическая адаптация

| Англ.              | Рус.                  | Единицы |
|--------------------|-----------------------|---------|
| HumidityAdaptation | Адаптация к влажности | %       |
| ShadeTolerance     | Теневыносливость      | %       |
| LightRequirement   | Требование к свету    | %       |

---

## Цели (GoalType)

| Англ.           | Рус.                    | Значения |
|-----------------|-------------------------|----------|
| Cooling         | Охлаждение              | 0        |
| AirPurification | Очистка воздуха         | 1        |
| NoiseReduction  | Поглощение шума         | 2        |
| Biodiversity    | Биоразнообразие         | 3        |
| SocialSpace     | Социальные пространства | 4        |

---

## Факторы (FactorType / Факторы)

| Англ.                   | Рус.                         | Значения |
|-------------------------|------------------------------|----------|
| Transpiration           | Транспирация                 | 0        |
| Shading                 | Затенение                    | 1        |
| Thermoregulation        | Терморегуляция               | 2        |
| HumidityIncrease        | Увлажнение воздуха           | 3        |
| Reflectivity            | Отражательная способность    | 4        |
| CO2Absorption           | Поглощение CO2               | 5        |
| DustCapture             | Поглощение пыли              | 6        |
| PhytoExtraction         | Фитоэкстракция               | 7        |
| PhytoStimulation        | Фитостимуляция               | 8        |
| WaterStorage            | Запас воды                   | 9        |
| HabitatSupport          | Поддержка среды обитания     | 10       |
| NoiseReduction          | Снижение шума                | 11       |
| ContinuousGreenCoverage | Непрерывное зеленое покрытие | 12       |

---

## AHP веса (AhpWeights)

Каждая цель содержит набор факторов с весами:

GoalType + FactorName => Weight

Вес показывает важность фактора внутри цели.

Пример:

- Cooling:
    - Shading => 0.30
    - Transpiration => 0.25
    - Thermoregulation => 0.20

---

## EnvironmentModifiers

Модификаторы изменяют вклад факторов в зависимости от условий среды:

ConditionType + ConditionValue + FactorName => Modifier

### ConditionType:

| Англ.           | Рус.                | Значение |
|-----------------|---------------------|----------|
| WallOrientation | Ориентация Стены    | 0        |
| Pollution       | Загрязнение воздуха | 1        |
| Humidity        | Влажность           | 2        | 
| Temperature     | Температура         | 3        |
| Wind            | Направление ветра   | 4        |

---
## EnvironmentProfile (Запрос)
| Поле        | Тип      | Описание                                                                           |
|-------------|----------|------------------------------------------------------------------------------------|
| Goal        | GoalType | Цель расчёта (Cooling, AirPurification, NoiseReduction, Biodiversity, SocialSpace) |
| Wall        | double   | Ориентация стены в градусах (0–360), отсчитывается от севера по часовой стрелке    |
| Pollution   | double   | Уровень загрязнения среды          (%)                                             |
| Humidity    | double   | Влажность воздуха                  (%)                                             |
| Temperature | double   | Температура окружающей среды       (градусы)                                       |
| Wind        | double   | Интенсивность / скорость ветра     (м/с)                                           |

### Принцип работы

Если условие среды удовлетворяет порогу:

profile.Value >= ConditionValue

то применяется множитель:

Модификаторы могут накладываться (перемножаются).

---

## Профиль среды (EnvironmentProfile)

Используется для расчёта итогового скоринга:

- Goal — цель оценки
- Wall — ориентация стены
- Pollution — уровень загрязнения
- Humidity — влажность
- Temperature — температура
- Wind — скорость ветра

---

## Алгоритм расчёта очков

### 1. Получение растений

Берутся все растения из базы:

plants = PlantRepository.GetAll()

---

### 2. Выбор весов AHP

Фильтрация по цели:

weights = AhpWeights.Where(GoalType == profile.Goal)

---

### 3. Построение вектора признаков

Для каждого растения:

vector = FactorFactory.Create(plant)

---

### 4. Расчёт базового скоринга

score = SUM(factorValue × weight × modifier)

где:

- factorValue — значение фактора у растения
- weight — AHP вес
- modifier — поправка среды

---

### 5. Модификаторы среды

Для каждого фактора:

modifier = Произведение всех примененных модификаторов

---

### 6. Итог

Растения сортируются по убыванию score:

OrderByDescending(score)

---

## Итоговая формула

Score(plant) =
Σ over factors [FactorValue(plant, f) × AHPWeight(goal, f) × Π EnvironmentModifiers(profile, f)]

---

## Примечания

- Все значения факторов должны быть заранее нормализованы
- AHP веса должны суммироваться в пределах каждой цели