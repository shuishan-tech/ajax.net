# Ajax.NET
Ajax.NET for SharePoint
[Ajax.NET](http://ajaxpro.codeplex.com/)是微软开发体系下优秀的Ajax框架，虽然不是轻量级的前端解决方案，但是完美结合了微软开发体系，在服务器端很容易注册Ajax方法，客户端使用也很方便。

Ajax.NET在.NET的反射机制基础上提供的Ajax解决方案，引入到SharePoint项目中后，发现无法在Ajax.NET的后台生命周期中使用SPContext.Curent，这是由于反射机制引起的，因此，对其进行了改造。

