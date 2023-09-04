# Backuper
Приложения Backuper представляет собой простую программу для архивирования и копирования файлов, реализованная на графическом интерфейсе Windows Forms.

## Интерфейс
Интерфейс состоит из простых элементов управления, таких как:
* ```Button```
* ```TextBox```
* ```RadioButton```

## Файлы

```Program.cs``` - Главный класс приложения, отвечающий за запуск.

```Compressor.cs``` - Класс архиватора. Содержит методы сжатия файлов в архив, сжатия файлов поштучно, а также метод создания папки с меткой времени.

```Config.cs``` Класс, хранящий основные настройки приложения. В процессе работы может быть сериализован в файл или десериализован из файла. По умолчанию настройки сериализуются из корневого пути приложения, если такой файл существует и корректен.

```MainForm.cs``` -  Файл, содержащий логику работы формы.

```MainForm.Designer.cs``` - Файл, содержащий свойства формы.

### Пару слов
К сожалению, автор не успел доработать и протестировать программу к сроку из-за недостатка времени, но обязательно исправится. Приносим свои извинения!

