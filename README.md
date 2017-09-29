# ProjectTimeTracker
ProjectTimeTracker is a small tool app to keep records of your time spent on different projects.

Your records are stored in a json file <code>\<UserProfile>\\.project-time-tracker.json</code> or <code>\<UserProfile>\\.project-time-tracker-debug.json</code>.

### Add project
* Type project name in the top most input and commit with <kbd>Enter</kbd>.

### Delete project
* Select a project from the list and press <kbd>Delete</kbd>.

### Track time
* Select a project from the list.
* Click <code>Start</code> or press <kbd>S</kbd> and work on the project.
* Click <code>Stop</code> or press <kbd>S</kbd> again.

### View records
* Double-click on a project from the list or press <kbd>E</kbd> to open a list of project's entries.
* Select a range of entries to be included in the summary.
  * You can use <kbd>Shift</kbd> and <kbd>Ctrl</kbd> to poerform complex selections.
* You can close the window with <kbd>Esc</kbd>.
* To delete selected entries press <kbd>Delete</kbd>.
* To archive selected entries click <kbd>ARCHIVE SELECTED</kbd>.

### View archives
* Select a project from the list.
* Press <kbd>A</kbd> to open a list of project's archives.
* Double-click on an archive from the list to open a list of archive's entries.

### Config
Config file (<code>settings.config.json</code>) is located in the app folder.
#### Options
* LogPath - absolute or if starts with \\ the path will be relative to app directory
* LogLevel - Fatal, Error, Warn, Info, Debug, Trace
