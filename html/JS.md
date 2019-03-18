# JavaScript

基于对象和事件驱动的脚本语言，主要应用在客户端
- 基于对象：提供现有对象，可直接使用
- 事件驱动：html 做静态效果，js 做动态效果
- 客户端：指浏览器

## JS 的特点

1. 交互性
	- 信息的动态交互
2. 安全性
	- js 不能访问本地磁盘的文件
3. 跨平台性
	- 只要能够支持 js 的浏览器，都可以运行

## JS 和 Java 的区别

1. java 时 sun 公司，现被 oracle 公司收购；js 是网景公司

2. js 是基于对象的，java 是面向对象的

3. java 是强类型语言，js 是弱类型的语言

4. js 只需解析就可以执行，而 java 需要先编译成字节码文件，再执行

## JS 的组成

三部分：
1. ECMAScript
	- ECMA: 欧洲计算机协会，由 ECMA 组织制定的 js 语法 / 语句
2. BOM
	- broswer object model: 浏览器对象模型
3. DOM
	- document object model: 文档对象模型

## JS 和 HTML 的结合方式

两种：
1. 使用一个标签
`<script type="text/javascript">代码</script>`

2. 使用 script 标签，引入一个外部的 js 文件
`<script type="text/javascript" src="url"></script>`

注：使用第二种方式时候，script 标签内的代码不会执行

## JS 的原始类型和声明变量

定义变量都使用关键字：`var`

五个：

1. `string`: 字符串
2. `number`: 数字类型
3. `boolean`: 布尔类型
4. `null`: 表示对象引用为空
5. `undifined`: 定义一个变量没有赋值

注：typeof(null) = 'object'

## JS 的语句

注：`i++`和`++i`同 java

### if 语句

同 java

### swith 语句

同 java, 且支持全部数据类型

```js
swith(arg){
	case 1://number
	break;
	case '1'://string
	break;
	case true ://boolean
	break;
	...
	default:
}
```

### for 语句

同 java, 除中间语句外都可省略

```js
for(;(boolean);){
}
```

### while 语句

同 java

### JS 的运算符

大部分同 java
不同点：
1. js 里不区分整数和小数

```java
// java
system.out.println(123 / 1000 * 1000);
// 0
```

```js
// js
alert(123 / 1000 * 1000);
// 123
```

2. 字符串操作

```js
// js
alert('123' + 1);
// 1231
alert('123' - 1);
// 122
alert('abc' - 1);
// NaN : 表示不是一个数值
```

3. 布尔运算
在 js 中，boolean 类型可以被自动类型转换成数值类型：
true=1
false=0

4. 判断运算符
	- `==` 表示弱类型判断，不判断类型
	- `===` 表示强类型判断，类型必须相等才可能返回 `true`

> document.write() 可以向页面输出文本
>> 乘法表
>```js
> document.write('<table>');
> for(var i; i <= 9; i++){
> 	document.write('<tr>');
> 	for(var j; j <= i; j++){
> 		document.write('<td>');
> 		document.write(j + '×' + i + '=' + (i * j));
> 		document.write('</td>');
> 	}
> 	document.write('</tr>');
> }
> document.write('</table>');
> ```

## JS 的数组

- 定义
	三种：
	1. `var arr = [1,'2',true]`
	2. 使用内置对象 Array
`var arr = new Array(3)`( 长度为 3)
	3. 使用内置对象 Array
`var arr = new Array(1,2,3)`( 数组元素为 1,2,3)
- 属性
	- length: 表示数组的长度

## JS 的函数

三种方式：

1. 使用关键字 `function`

```js
funtion 方法名(参数列表){
	方法体;
	(返回值;)
}
```

2. 匿名函数

```js
var name = funtion (参数列表){
	方法体;
	(返回值;)
}
```

3. 使用 `Funtion`（动态函数）

```js
var name = new Funtion('参数列表','方法体,返回值')
```

```js
// 应用
var arg1 = '参数列表';
var arg2 = '方法体,返回值';
var name = new Funtion(arg1,arg2)
```

## JS 的全局变量和局部变量

### 全局变量

含义：在 script 标签内定义一个变量，这个变量在页面中的全部 js 中都可以使用

### 局部变量

含义：在方法内部定义一个变量，这个变量只能在方法内部使用

## Script 标签存放位置

有特殊要求时，一般放在 body 标签之后 (html 标签中的最后一个标签）
无特殊要求时，可放在任意位置
> html 解析时从上至下的，如果需要取某个标签的值时还未加载到这个标签，则会报错
