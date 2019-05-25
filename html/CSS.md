# CSS

CSS 参考手册：
1. [翻墙版](http://css.doyoe.com/)
2. [github版](https://github.com/doyoe/css-handbook)

## CSS 的简介

层叠样式表
- 层叠：一层一层的
- 样式表：更多属性和属性值

css 将网页内容和显示样式进行了分离，提高了后期样式代码的可维护性，并增强了网页的显示效果

## CSS 的结合方式

一共四种方式：

1. 在每个 html 标签上的属性 style 内写，把 css 和 html 结合在一起

> `<div style="color:red;"></div>`

2. 使用 html 头标签里的`<style>`标签，写在 head 里面

> ```css
> <style type="text/css">
> 	div{
> 		background-color:red;
> 	}
> </style>
> ```

3. 在 style 标签内使用语句

> @import url(css.filepath)

4. 使用头标签`<link>`, 引入外部 css 文件

> `<link rel="stylesheet" type="text/css" href="css.filepath"/>`

**注：在某些浏览器下，第三种结合方式不起作用 ( 如 IE5,IE6), 故一般使用第四种方式**

## CSS 的优先级

**一般情况：**
由上到下，由外到内，优先级由低到高
（就近原则）
后加载的优先级高

## CSS 的格式

选择器名称{
	属性名：属性值；
	属性名：属性值；
	........
}

## CSS 的选择器

要对哪个标签里的数据进行操作
一共三种：
1. 标签选择器

> div{}

2. class 选择器

每个 html 标签都有一个属性 class

>```html
><style type="text/css">
> 	div.name1{
> 		background-color:red;
> 	}
> </style>
><div class="name1"></div>
>```

>注：以上 style 中的 `div.name1`，div 可省略，表示其他标签也可使用本 class

3. id 选择器

每个 html 标签都有一个属性 id

>```html
><style type="text/css">
> 	div#name2{
> 		background-color:red;
> 	}
> </style>
><div id="name2"></div>
>```

>注：以上 style 中的 `div#name2`，div 可省略，表示其他标签也可使用本 class

## CSS 选择器的优先级

`style` > `id 选择器` > `class 选择器` > `标签选择器`

## CSS 的拓展选择器

>**<font size=4>注：此类选择器可能非最终版本</font>**

1. 关联选择器

>```html
><style type="text/css">
> 	div p{
> 		background-color:red;
> 	}
> </style>
><div><p>text</p></div>
>```

2. 组合选择器

把不同的标签设置成相同的样式

>```html
><style type="text/css">
> 	div,p{
> 		background-color:red;
> 	}
> </style>
><div>text</div>
><p>text</p>
>```

3. 伪元素选择器

css 内提供了一些定义好的样式，可以直接使用

例：超链接：
|原始状态|悬停状态|点击|点击后|
|-|-|-|-|
|:link|:hover|:active|:visited|

>```html
><style type="text/css">
> 	a:link{
> 		background-color:red;
> 	}
> </style>
><a href="#">超链接</a>
>```

## CSS 的盒子模型

1. 边框

边框属性
{
	border: 统一设置
	border-top: 上
	border-bottom: 下
	border-left: 左
	border-right: 右
}
2. 内边距

文本内容距离边框
{
	padding: 统一设置
	（或上下左右分别设置）
}
3. 外边距

边框距离其他元素
{
	margin: 统一设置
	（或上下左右分别设置）
}
4. 展示模式
{
	display: inline/inline-block/block
	(行内元素/行内块级元素/块级元素)
}
## CSS 布局的漂浮

（不常用）
让元素流向一个方向
{
	/*
	none: 不浮动
	left: 向左浮动
	right: 向右浮动
	*/
	float: 值；
}

## CSS 布局的定位

{
	/*
	static: 默认定位
	absolute: 使用绝对定位，不再主动与其他元素判断距离，并覆盖其他元素
	relative: 使用相对定位，但不会影响其他元素的位置
	*/
	position: 值；
}
