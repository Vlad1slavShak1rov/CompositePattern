using CompositePattern;

IDocumentComponent head = new Document("Очень важный документ");
IDocumentComponent branch1 = new Section("Паттерн Composite");
IDocumentComponent branch2 = new Section("Паттерн Bridge");
IDocumentComponent leaf1 = new Paragraph("Паттерн Composite – составляет из объектов древовидные структуры");
IDocumentComponent leaf2 = new Paragraph("Паттерн Bridge – позволяет отделить абстракцию от элементов ее реализации");

head.Add(branch1);
head.Add(branch2);
branch1.Add(leaf1);
branch2.Add(leaf2);

head.Display();
