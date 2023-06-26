# Asylum-HeadPlate-Scene Unity Project
  This project is part of the larger "SpatioScholar Project," a Unity simulation of the Istanbul Toptaşı Asylum. The goal of the "Asylum-HeadPlate-Scene" project is to create a model of a multilingual head plate that can be integrated into the "SpatioScholar Project." The head plates, known as "tabela" in Turkish, were used in the Toptaşı Asylum during the early 1900s to record patient information above their beds.

## Project Background
  The "SpatioScholar Project" focuses on the patients and physicians of the Istanbul Toptaşı Asylum and their interactions. It is part of research into Ottoman Asylums, and the simulation aims to provide insights into the historical context of these institutions. Dr. Ozludil's journal article, "Psychiatry, Space, and Time: Case of an Ottoman Asylum," provides valuable information about the practices and procedures followed in the Toptaşı Asylum.

## Historical Notes on the Asylum's Head Plates
  The head plates (tabela) were used to record patient information in the Toptaşı Asylum. When a patient arrived at the asylum, their admission documents were recorded in the registry and inscribed on a plate. The head caretaker of the assigned section received the plate, which included the admission number and the patient's name. Physicians would then update the head plate with relevant health information, such as body temperature and changes in physical health. The focus was on objective recording rather than relying on patients' subjective responses.

## Head Plate Goals and Notes
  The purpose of the head plates in this project is to provide daily updates on the patient's health and treatment, rather than detailed patient history. The exact content of the historical head plates is unknown, so the admission form serves as a basis for creating the head plate design. However, the head plates should not provide extensive medical or mental status information but instead, give users a sense of the patient's general information.
  
  The head plates should be able to switch between English, French, and Ottoman Turkish (Turkish). Since Ottoman Turkish is not available on Google Translate, Modern Turkish is used instead. The "Simple Localization" Unity package with Google Sheets integration was utilized to implement the language translation feature. Localization data is stored in a Google Sheets document, saved in CSV format, and placed in the Resources folder.

## Future Improvements
  To enhance the "SpatioScholar Project," the head plate from the "Asylum-HeadPlate-Scene" project should be added above each patient's bed. Additionally, structural and coloring issues with the head plates should be addressed. To ensure diverse and historically representative patient information, the head plate content should be based on the actual statistics from the "Lucien Libert (Libair) Translated Data" spreadsheet. A Google Spreadsheet named "Head Plate Representative Data (Based on 'Lucien Libert Translated Data')" attempts to match specific categories from the "Lucien Libert Translated Data" spreadsheet to the number of patients in the simulation for more accurate representation.

## Head Plate Structure
  The head plates consist of a larger white (primary) plate located below a black (secondary) plate. The exact purpose of the black plate is unknown and has been left empty in the Unity model. The pole supporting the head plate is connected to the center of the bed's back frame.

## English Version of the Head Plate Content in "Asylum-HeadPlate-Scene"
- Name: Zeyneb Fatma.
- Sex and Age: Female, aged 27.
- Sign of Insanity: Mania.
- Method of Treatment: Herbal medication to reduce stress (take daily).
- Remarks: She had a severe manic episode last week and showed intent to destroy herself, but has improved recently.
- Meal Chart Recommendation: Type 1.

## How to Change the Head Plate Content:
  1. Open the "Multi Language" Google Spreadsheet in the Head Plate folder.
  2. Update the text in the English box with the desired content.
  3. Use Google Translate to translate the English text into French and Turkish.
  4. Paste the translations into the French and Turkish boxes accordingly.
  5. Go to the "Localization Manager" in the Hierarchy section of the Unity project.
  6. Click on "Sync" in the Inspector section to synchronize the updated Google Spreadsheet with the Unity simulation.
  7. You will see a message "Localization sync completed!" in the bottom left of the screen.
  8. You can now view the updated text in the simulation.
