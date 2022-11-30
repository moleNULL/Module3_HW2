# &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;NIX Solutions Module #3 Homework #2

Описати class 1, який містить:\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1) делегат, який нічого не повертає, але приймає bool (делегат посилається на метод "Show")\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2) метод "Pow", який приймає як аргумент 2 числа і повертає результат множення\
\
Описати class 2, який містить:\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1) метод "Calc", який приймає на вхід делегат для методу "Pow", а також параметри для розрахунку.\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Метод "Calc" виконує виклик делегата для методу "Pow" і зберігає значення результату усередині класу.\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Повертаючим типом методу "Calc" є делегат. Цей делегат повинен приймати 1 число як параметр,\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;а як результат повертати значення bool. Цей делегат посилається на метод "Result".\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2) метод "Result", який приймає як аргумент 1 число і повертає bool. Поточний метод повинен порахувати\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;залишок від ділення результат виконання виклику делегата на метод "Pow" і числа що прийшов в метод\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; чк параметр. Зробити перевірку на те, що чи ділитися число у нас без залишку або ж немає і повернути\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;це як результат методу "Result"\
\
Клас Program містить:\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1) метод "Show", приймає на вхід результат виконання делегата на метод "Result" і відображує його в консоль.
