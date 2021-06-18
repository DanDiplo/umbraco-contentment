<img src="../docs/assets/img/logo.png" alt="Contentment for Umbraco Logo" title="A state of Umbraco happiness." height="130" align="right">

# Ideas for Contentment


## Data Editors

- TinyMCE - push the boundaries beyond Umbraco's defaults?
  - How's about a TinyMCE that is 30px height, Distraction Free mode, all menu items disabled.
  - Only keyboard shortcuts would be enabled. Try to make it become a single-line rich-textbox.

- Data List: Groups
  - https://github.com/leekelleher/umbraco-contentment/issues/51

- Data List: Value Converters
  - https://github.com/leekelleher/umbraco-contentment/issues/29

- Text Input - Change Font-Size within Input Field Based on Length (similar to Facebook's post experience, after 85 chars)
  - https://web-design-weekly.com/snippets/change-font-size-within-input-field-based-on-length/

- Nested Content - Reimagined. Reach for its heart, imagine a new landscape, another atmosphere, and see how it goes.


### Internally used editors

Could these internally used editors have potential as standalone property editors?

- Cascading Dropdown List - _(try replacing the DropdownList with any Data List editor)__
- Configuration Editor
- Data Table
- Macro Picker


### Validation

None of the editors have explicit validation implemented, (only because I've never researched it). Let's explore the validation approaches for the editors.


## Localization

Remove hard-coded English labels, move them to the language XML file.


## Tracking

- v8.6+ `IDataValueReferenceFactory`, `IDataValueReference`


## Deprecation considerations

It's good to re-evaluate whether certain features are still relevant.

- Icon Picker editor. The more I think about it, the more I don't see it being relevant as a standalone editor.
  - For internal Umbraco use - yes; For external public (outside Umbraco) use - no.
