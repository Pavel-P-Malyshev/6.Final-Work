# Итоговая контрольная работа
## 1. Создать репозиторий на Github
*Имя репозитория*:6.Final-Work.git    
*Ссылка на репозиторий:* https://github.com/Pavel-P-Malyshev/6.Final-Work.git


## 2.Нарисовать блок-схему алгоритма
Получившеяся блок-схема доступна в самом репозитории в виде интегрированного файла DRAWIO.      
Но ее также можно посмотреть **здесь**: 



![блок-схема](FinalWork.drawio.png)

## 3.Снабдить репозиторий оформленным текстовым описанием (readme.md)
*Вы читаете его в данный момент*


## 4.Написать программу, решающую поставленную задачу.
Программа написана на языке **С#**                  
Основной метод программы представлен ниже
```
string[] LeaveShorts(string[] messages)
{
    
    int shorts=0;
    string[] Shorts=new string[messages.Length];

    for (int i = 0; i < messages.Length; i++)
    {
        if (messages[i].Length<=3)
        {
            Shorts[shorts]=messages[i];
            shorts++;
        }
    }
    
    string[] result=new string [shorts];
    for (int i = 0; i < result.Length; i++)
    {
        result[i]=Shorts[i];
    }

    return result;

}

````
Результат работы программы:
```
Введите строки через запятую:
system,:),123,33333
Ваш массив строк:
[ "system", ":)", "123",  "33333"]
Получившийся массив строк с длиной не более 3 символов:
[ ":)",  "123"]
```

## 5.Использовать контроль версий, разные этапы должны быть в разных коммитах
Лог коммитов данного проекта:
```
 D:\Обучение GB digital master\Основной курс\6-Выбор специализации\6.Контрольная работа> git log --graph --all
* commit b9bf9ea13e791ec8669cda57d9aa8aa915174428 (HEAD -> master)
| Author: Pavel <m83819@gmail.com>
| Date:   Mon Sep 19 11:16:26 2022 +0700
|
|     Filled readme.md
|
* commit 26ab3e06a608ed1115633bbe570081fa2b92980f (origin/master)
| Author: Pavel <m83819@gmail.com>
| Date:   Mon Sep 19 10:47:06 2022 +0700
|
|     Added drawio diagram4
|
* commit 50eafea5b2d5eec36592aafb177cc46f7e4204a7
| Author: Pavel <m83819@gmail.com>
| Date:   Sun Sep 18 20:08:40 2022 +0700
|
|     Added drawio diagram3
|
* commit 562c7eb5863627aaaa722815a81e3358624f7f0b
:...skipping...
* commit b9bf9ea13e791ec8669cda57d9aa8aa915174428 (HEAD -> master)
| Author: Pavel <m83819@gmail.com>
| Date:   Mon Sep 19 11:16:26 2022 +0700
|
|     Filled readme.md
|
* commit 26ab3e06a608ed1115633bbe570081fa2b92980f (origin/master) 
| Author: Pavel <m83819@gmail.com>
| Date:   Mon Sep 19 10:47:06 2022 +0700
|
|     Added drawio diagram4
|
* commit 50eafea5b2d5eec36592aafb177cc46f7e4204a7
| Author: Pavel <m83819@gmail.com>
| Date:   Sun Sep 18 20:08:40 2022 +0700
| 
|     Added drawio diagram3
|
* commit 562c7eb5863627aaaa722815a81e3358624f7f0b
| Author: Pavel <m83819@gmail.com>
| Date:   Sun Sep 18 20:06:33 2022 +0700
|
|     Added drawio diagram2
|
* commit bde009a7f3422e8161085e99877c18fcfd8d4303
| Author: Pavel <m83819@gmail.com>
| Date:   Sun Sep 18 20:00:58 2022 +0700
|
|     Added drawio diagram
|
* commit 533523393f26e0b84bf6c16aeb6102043d6f0384
| Author: Pavel <m83819@gmail.com>
| Date:   Sun Sep 18 19:08:53 2022 +0700
|
|     Final version
|
* commit 801ead61ef58084dc81e3df3d22294cd1a225f2c
| Author: Pavel <m83819@gmail.com>
| Date:   Sun Sep 18 19:04:09 2022 +0700
|
|     remove excess, minor changes
|
* commit 6f8cc48b60fd6a8303e6ea2d68ff487c79841c7c
| Author: Pavel <m83819@gmail.com>
| Date:   Sun Sep 18 18:04:14 2022 +0700
|
|     added double quotes shielding
|
* commit 97614e466726bb7b1ae6a63709ac5d1e4c4aa135
| Author: Pavel <m83819@gmail.com>
| Date:   Sun Sep 18 17:50:49 2022 +0700
|
|     added string array print method
|
* commit 425e84b1fa11f86abd33e4e8069cb9e837143e68
  Author: Pavel <m83819@gmail.com>
  Date:   Sun Sep 18 17:19:51 2022 +0700

      initial commit
(END)

```

