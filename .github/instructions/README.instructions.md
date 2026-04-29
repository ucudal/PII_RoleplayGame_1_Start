---
applyTo: "README.md"
---

# Guidelines for README.md files in repositories used in Programación II

All README.md files in repositories used in the Programación II course must
follow these guidelines to ensure consistent documentation.

* Include the Universidad Católica del Uruguay logo in the first line using an
  `<img>` tag. The logo is at `https://www.ucu.edu.uy/plantillas/images/logo_ucu.svg`.
  It must be 150 pixels wide. It must include the alt text `UCU`.

* Before the logo, disable MD033 and MD041 so the linter does not flag the
  HTML in the markdown file. Immediately after the logo, re-enable MD033 and
  MD041.

* Include an H1 with the text `Universidad Católica del Uruguay`.

* Include an H2 with the text `Facultad de Ingeniería y Tecnologías`.

* Include an H3 with the text `Programación II`.

* Include an H1 with the name of the exercise or project that the repository
  corresponds to.

* There must be a description of the exercise that includes the objectives that
  students must complete.

* If the exercise is complex, there must be a description of each of the parts
  that make up the exercise.

* There must be an evaluation rubric that details how the exercise or project
  will be graded.
