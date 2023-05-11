# lab4_Behavioral_DP

# În ingineria software , modelele de proiectare comportamentală sunt modele de proiectare care identifică modele comune de comunicare între obiecte. 

# Modele de design Comportamental sunt:
•	Chain of Responsibility - obiectele de comandă sunt gestionate sau transmise altor obiecte de obiecte de procesare care conțin logică.
•	Command - obiectele de comandă încapsulează o acțiune și parametrii acesteia.
•	Interpreter - implementați un limbaj de calculator specializat pentru a rezolva rapid un anumit set de probleme.
•	Iterator - iteratorii sunt utilizați pentru a accesa secvențial elementele unui obiect agregat fără a expune reprezentarea de bază.
•	Mediator - oferă o interfață unificată unui set de interfețe dintr-un subsistem.
•	Observer - Obiectele se înregistrează pentru a observa un eveniment care poate fi ridicat de un alt obiect.
•	Strategy - algoritmii pot fi selectați din mers, folosind compoziția.
  
In aceasta lucrare am folosit doua modele de design de tip comportamental precum Observer si Strategy.
	Model de observator: clasa Student acționează ca un observator și se înregistrează/se anulează înregistrarea la un obiect Examen pentru a primi 
  notificări despre modificările din examen.
	Model de strategie: interfața IExamEvaluationStrategy este utilizată pentru a defini o strategie abstractă pentru evaluarea examenelor și sunt create
  două clase concrete ExamEvaluationStrategy1 și ExamEvaluationStrategy2 care implementează această interfață pentru a oferi diferiți algoritmi de evaluare. Acest lucru permite ca algoritmul de evaluare să fie comutat în timpul execuției fără a afecta clienții care folosesc algoritmul.

Codul furnizat este scris în C# și constă din patru clase: Program, Student, IExamEvaluationStrategy, ExamEvaluationStrategy1 și ExamEvaluationStrategy2.
Clasa Program conține metoda Main care creează o instanță a unui examen, înregistrează doi studenți la examen, schimbă data și locația examenului și evaluează examenul folosind două strategii diferite.

Clasa Student reprezintă un student și conține numele, prenumele și ID-ul acestuia. Clasa conține, de asemenea, metode de abonare și dezabonare la un examen și de a primi notificări despre modificările examenului.
	Interfața IExamEvaluationStrategy definește contractul pentru strategiile de evaluare a examenelor. Conține două metode care acceptă o listă de note și returnează scorul mediu al examenului.

Clasele ExamEvaluationStrategy1 și ExamEvaluationStrategy2 implementează interfața IExamEvaluationStrategy și conțin logica pentru evaluarea unui examen 
folosind două strategii diferite. ExamEvaluationStrategy1 calculează scorul mediu și rotunjește rezultatul la două zecimale. Apoi tipărește un mesaj bazat
pe scorul calculat. ExamEvaluationStrategy2 calculează scorul mediu excluzând notele cele mai mari și cele mai mici și rotunjește rezultatul la două zecimale.
Apoi tipărește un mesaj bazat pe scorul calculat.

Clasa principală este clasa Program, care creează o instanță a clasei Exam, înregistrează două obiecte Student și demonstrează utilizarea a două implementări 
diferite IExamEvaluationStrategy pentru a evalua rezultatele examenului.

Clasa de examen gestionează înregistrarea și notificarea studenților, precum și posibilitatea de a schimba data și locația examenului. Implementează interfața 
ISubject, care definește metodele de abonare și dezabonare a observatorilor, precum și de notificare a acestora cu privire la modificări.

Clasa Student reprezintă un elev, cu nume și ID. Implementează interfața IObserver, care definește metoda de primire a notificărilor de la un subiect.
Interfața IExamEvaluationStrategy definește metodele de evaluare a unui examen, cu două supraîncărcări pentru a suporta diferite tipuri de intrare (listă de 
duble sau listă de numere întregi).

Clasele ExamEvaluationStrategy1 și ExamEvaluationStrategy2 implementează interfața IExamEvaluationStrategy cu o logică de evaluare diferită pentru rezultatele
examenului.

# Concluzie:
În concluzie, utilizarea modelelor de proiectare în dezvoltarea de software oferă mai multe beneficii, inclusiv vizibilitatea, mentenabilitatea și 
scalabilitatea îmbunătățite ale codului. Urmând cele mai bune practici dovedite, dezvoltatorii pot proiecta soluții software care sunt mai ușor de înțeles, 
modificat și extins în timp. Deși există multe modele de proiectare disponibile, alegerea modelului potrivit pentru o anumită problemă poate fi o provocare 
și necesită o analiză atentă a diferiților factori, cum ar fi natura problemei, arhitectura sistemului și abilitățile și experiența echipei de dezvoltare. 
În cele din urmă, utilizarea eficientă a modelelor de design poate ajuta dezvoltatorii să creeze sisteme software robuste și fiabile, care să răspundă nevoilor
utilizatorilor și ale părților interesate.
