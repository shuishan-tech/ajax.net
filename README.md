# Ajax.NET for SharePoint

## Ajax.Net介绍
[Ajax.NET](http://ajaxpro.codeplex.com/)是微软开发体系下优秀的Ajax框架，虽然不是轻量级的前端解决方案，但是完美结合了微软开发体系，在服务器端很容易注册Ajax方法，客户端使用也很方便。

## 问题
Ajax.NET在.NET的反射机制基础上提供的Ajax解决方案，引入到SharePoint项目中后，发现无法在Ajax.NET的后台生命周期中使用SPContext.Curent。这是由于反射机制引起的，客户端的每一次Ajax请求通过Ajax.NET服务器端解析后，Ajax.NET在Web应用根路径直接反射对应的服务器端方法，所以，SPContext.Current为空。常见的解决办法是在SharePoint中引用原生的Ajax.NET，每次客户端请求过来的数据需要携带SiteId，WebId，ListId，ItemId等一系列参数，使用这些参数在服务器端方法中重新构造SPSite，SPWeb，SPList，SPListItem实例，然后再处理业务代码。这是一条可行的路，而且我自己很长时间也在这么使用。但是一旦上了大规模的应用，对Ajax依赖较多，这样的处理方式就显得繁琐，于是冒出想让Ajax.NET支持SharePoint的想法。在Ajax.NET基础上修改后，我们已经在产品和项目中使用了一年多的时间，考虑到Ajax.NET本身来至于开源社区，于是不敢独享，也分享出来给有需要的同学。

## 解决方案
1. 修改RegisterTypeForAjax方法代码
2. 修改TypeJavaScriptHandler中的ProcessRequest方法代码
3. 修改AjaxHandlerFactory中的GetHandler方法代码

## 版本说明
	
* Ajax.Net：9.2.17.1
* .Net Framework 4.5
* SharePoint 2013

## 示例
参考[Demo](deom)
