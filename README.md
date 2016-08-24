Исходная точка – [статья](http://martinfowler.com/articles/injection.html) 
Мартина Фаулера о паттерне Dependency Injection.

Для дизайна программного обеспечения главными являются 
[экономические аргументы](http://martinfowler.com/videos.html#economics-software-design).

Экономическая цель для 
[примера](http://martinfowler.com/articles/injection.html#ANaiveExample) 
из описания патерна Dependency Injection:
> This allows me to give listers to friends and for them to plug in 
>a suitable implementation for their own environment.

[Первая версия примера](https://github.com/AVPolyakov/FowlerDependencyInjection/blob/7a77b9a673917bb3d367c40ea06ec2b68e2f88f4/FowlerDependencyInjection/MovieLister.cs#L15) 
из статьи Фаулера, коммит
[First version](https://github.com/AVPolyakov/FowlerDependencyInjection/commit/7a77b9a673917bb3d367c40ea06ec2b68e2f88f4).

Делаем простые шаги авторефакторинга:  
![Refactoring commits](Images/RefactoringCommits.png?raw=true "Refactoring commits")  
Ссылки на команды ReSharper 
[[1](https://www.jetbrains.com/help/resharper/2016.1/Refactorings__Replace_Constructor_with_Factory_Method.html),
 [2](https://www.jetbrains.com/help/resharper/2016.1/Refactorings__Introduce_Variable.html),
 [3](https://www.jetbrains.com/help/resharper/2016.1/Refactorings__Introduce_Parameter.html),
 [4](https://www.jetbrains.com/help/resharper/2016.1/Refactorings__Extract_Method.html)].

Экономическая цель достигнута.