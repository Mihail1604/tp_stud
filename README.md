<h1 align="center">Аренда и прокат автомобилей</h1>

**1 Описание предметной области**
----------------------------------------------

Аренда и прокат автомобилей - весьма распространенная и востребованная услуга. В любом городе работает множество авто прокатных контор - от крупных до самых маленьких. Процедура аренды автомобиля проста. От клиента требуется, чтобы его возраст был не менее 21 года и не превышал 70 лет. Служащему арендной компании надо предъявить паспорт и водительское удостоверение (международное). К моменту заключения договора удостоверение должно быть действительно не менее 2 лет. В некоторых странах обслуживание клиента производится только при наличии кредитной карты, в большинстве же стран оплата за услуги проводится наличными, но необходимо внести небольшой залог. В стоимость арендной платы должно входить следующее

- неограниченный пробег автомобиля;

- доставка клиенту автомобиля;

- ремонт или замена автомобиля в случае технической неисправности, кроме повреждения покрышек и ветрового стекла;

- полная страховка на случай ДТП, произошедшего не по вине клиента;

- страховка, покрывающая ущерб, нанесенный автомобилю в ДТП по вине клиента, сверх определенной суммы (но если на момент ДТП водитель находился в состоянии алкогольного опьянения, страховка не выплачивается);

- страховка пассажиров (кроме водителя) от несчастных случаев (себя водитель может застраховать за дополнительную плату);

- налоги, аренда прокат автомобиль инфологический моделирование

Обычно машину доставляют с полным баком, но и вернуть в авто прокатную контору ее нужно также с полным баком. Аренду автомобиля в месте отдыха можно заказать еще во время покупки тура в своем агентстве, включив ее в пакет услуг. Автомобили застрахованы от всех рисков на условиях КАСКО и ОСАГО. В случае ДТП ответственность клиента составляет залог, весь остальной ущерб, нанесённый автомобилю, покрывает страховая компания

### **1.2 BPMN-диаграмма** 

BPMN (Business Process Model and Notation) - это язык моделирования бизнес-процессов, который является промежуточным звеном между формализацией/визуализацией и воплощением бизнес-процесса. С помощью моделирования мы можем описать любые бизнес-процессы, и они могут выполняться в самых разных системах управления.

![диаграмма](https://user-images.githubusercontent.com/113554318/198143675-e0f4d98d-1538-47ef-bb63-12de4c1c018b.png)

<div align="center">Рисунок 1 - BPMN-диаграмма </div>

### **1.3 Описание бизнес-процесса**
  -------------------------------------------------

Участниками бизнес-процесса «Аренда автомобиля»  являются компания по прокату транспортных средств, клиент и сотрудники компании: менеджер по работе с клиентами и менеджер по доставки транспортных средств.

Данный бизнес-процесс включает в себя несколько подпроцессов:

«Обработка заявки клиента». Этот подпроцесс включает обработку требований клиента, в соответствии с заявкой, запрос в фирму по прокату, согласование с клиентом всех деталей заказа и получением от клиента предоплаты.

«Подтверждение и оплата аренды автомобиля». Подпроцесс включает работу с фирмой по прокату: бронирование транспортного средства, уточнение даты и времени аренды, а так же его оплату.

«Подготовка и проверка автомобиля к сдаче в аренду». Подпроцесс включает действия фирмы по прокату по подготовке транспортного средства для сдачи в аренду.
Так же бизнес-процесс содержит два действия компенсации, т.к. нельзя исключать вероятность того, что при проверке доставленного транспорта клиент может, обнаружить неисправность или несоответствие заявленных параметров транспорта. А так же необходимо предусмотреть вероятность того, что клиент мог указать неправильный адрес доставки транспорта.

### **1.4 USE CASE модель**
-------------------------------------------------------

Use Case  — это сценарная техника описания взаимодействия. С помощью Use Case может быть описано и пользовательское требование, и требование к взаимодействию систем, и описание взаимодействия людей и компаний в реальной жизни.

![Снимок](https://user-images.githubusercontent.com/113554318/198144474-31b3357b-920c-4d57-bc71-1dcc78e06b1a.PNG)

![Снимок2](https://user-images.githubusercontent.com/113554318/198144854-c76a64bb-0354-4e9f-9bcb-4f7d272b20d0.PNG)

<div align="center">Рисунок 2 - Use Case модель </div>

### **1.5 Проблематика предметной области**
  ----------------------
  
  Данная информационная система прокат автомобилей поможет ускорить проверку занятости автомобилей (как свободных, так и арендованных). Учитываются автомобили в разрезе их характеристик, по личным данным и индивидуальные технические характеристики. Увеличится экономия времени при заключении договора с клиентами обратившимися в Прокат автомобилей повторно, так как при первом обращении клиентов в любой филиал проката автомобилей они в обязательной форме проходят регистрацию, при повторном обращении они уже будут зарегистрированы в базе данных.


