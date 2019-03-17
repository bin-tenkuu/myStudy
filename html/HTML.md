# HTML 的简介

## 什么是 HTML

### Hypertext Markup Language: 超文本标记语言，网页语言

- 超文本：超出文本，使用 HTML 可以轻松实现
- 标记：HTML 所有操作使用标记实现，标记就是标签，如：`<html>`
- 网页语言：

### 第一个 HTML

- 创建 html 文件：后缀 `.html`
	> - 通过浏览器直接运行
- 代码：`<font size="5" color="red">第一个</font> html 程序`

示例：
<html><font size="5" color="red">第一个</font> html 程序</html>

### HTML 规范（遵循）

1. 一个 html 文件开始和结束标签：`<html>` `</html>`
2. html 包含两部分内容：
	1. \<head>设置相关信息 \</head>
	2. \<body>显示在页面上的内容 \</body>
3. html 的标签有开始也要有结束：
	- \<head>\</head>
4. html 代码不区分大小写
5. 有些标签没有结束标签，在标签内结束，如：
	- 换行标签：`<br\>`
	- 分水平线标签：`<hr\>`

### HTML 操作思想

网页中有很多数据，不同的数据会有不同的显示效果，使用标签封装要操作的数据，通过修改标签的属性实现数据样式的变化
> 一个标签相当于一个容器，想要修改容器内的数据样式，只需要修改容器的属性值，就可以实现容器内数据样式的变化

### HTML 常用标签

#### 文字标签

修改文字样式

- `<font> </font>`
- 属性：
	- size: 文字大小，取值范围：Z[1,7]
	- color: 文字颜色，两种表示方式：
		- 英文单词：`red`,`green`,`black`,...
		- 十六进制数：`#ffffff` (RGB)

#### 注释标签

- `<!-- HTML 的注释 -->`

#### 标题标签

- `<h1> </h1>`,`<h2> </h2>`...`<h6> </h6>`

> 从 1-6 字体大小依次变小，并且标题标签会自动换行

#### 水平线标签

- `<hr/>`
- 属性：
	- size: 水平线的粗细，取值范围：Z[1,7]
	- color: 颜色，同 ->文字标签

#### 特殊字符

- 需要显示特殊字符时需要进行转义：
	- `<` : `&lt;`
	- `>` : `&gt;`
	- `&` : `&amp;`
	- ` `（空格） : `&nbsp;`
	- `"` : `&quot;`
	- `®` : `&reg;`
	- `©` : `&copy;`
	- ... 等

#### 列表标签

1. 定义列表 (dl 标签）
- `<dl></dl>` : 表示列表范围
	- `<dt></dt>` : 上层内容
	- `<dd></dd>` : 下层内容

例：

```html
<html>
	<dl>
		<dt>上层内容</dt>
		<dd>内容</dd>
		<dd>内容</dd>
	</dl>
</html>
```

2. 有序列表 (ol 标签）
- `<ol></ol>` : 有序列表范围
	- `<li></li>` : 具体内容
- 属性：
	- type : `1`（默认） , `a` , `i`

例：

```html
<html>
	<ol>
		<li>内容1</li>
		<li>内容2</li>
		<li>内容3</li>
	</ol>
</html>
```

3. 无序列表 (ul 标签）
- `<ul></ul>` : 无序列表范围
	- `<li></li>` : 具体内容
- 属性：
	- type : `disc`（默认）（实心圆） , `circle`（空心圆） , `square`（实心方块）

例：

```html
<html>
	<ul>
		<li>内容1</li>
		<li>内容2</li>
		<li>内容3</li>
	</ul>
</html>
```

#### 图像标签

- `<img src="url"/>`
- 属性：
	- src : 图片路径
	- width : 图片宽度
	- heigth : 图片高度
	- alt : 图片上显示的文字（部分浏览器不兼容）

> 路径 ...
>> 绝对路径
>
>> 相对路径 ...
>>> 同目录
>>> 上层目录
>>> 下层目录

#### 超链接标签

- 链接资源
	- `<a href="">显示的内容</a>`
	- 属性：
		- href : 链接资源的地址，若不需要跳转到任何页面，设置为 "#"
		- target : 设置打开方式，默认在当前页打开
			- _blank : 在新标签页打开
			- _self : 在当前页打开
- 定位资源
	1. 定义一个位置：
		- `<a name="top">顶部</a>`
	2. 回到这个位置
		- `<a href="#top">回到顶部</a>`

例：[什么是-html](./HTML.md#什么是-html)

#### 原样输出标签

- `<pre></pre>`
> 会把缩进等**全部**格式原样输出到网页

#### 表格标签

可以对数据进行格式化，使数据显示更清晰
- `<table></table>` : 表示表格的范围，可省略
	- `<caption></caption>` : 表格的标题
	- `<tr></tr>` : 一行
		- `<td></td>` : 单元格
- 使用`<th></th>`可以实现居中和加粗（表头）
- 属性：
	- border : 边界线
	- borderbolor : 边界线颜色
	- cellspacing : 边界间隔
	- width : 表格宽度
	- heigth : 表格高度
	- align : 设置显示方式：`left`（居左）,`center`（居中）,`right`（居右）
	- 合并单元格：
		- rowspan : 跨行
		- colspan : 跨列
> 注：如果表格内没有内容，使用空格作为占位符
例：
<html>
	<table>
		<!--<caption>
			表格标签的属性
		</caption>
		-->
		<tr align="center">
			<th colspan=3>表格标签的属性</th>
		</tr>
		<tr align="center">
			<th>系列</th>
			<th>属性名</th>
			<th>介绍</th>
		</tr>
		<tr align="center">
			<td rowspan=3>边框</td>
			<td>border</td>
			<td>边界线</td>
		</tr>
		<tr align="center">
			<td>borderbolor</td>
			<td>边界线颜色</td>
		</tr>
		<tr align="center">
			<td>cellspacing</td>
			<td>边界间隔</td>
		</tr>
		<tr align="center">
			<td rowspan=2>大小</td>
			<td>width</td>
			<td>表格宽度</td>
		</tr>
		<tr align="center">
			<td>heigth</td>
			<td>表格高度</td>
		</tr>
		<tr align="center">
			<td>显示方式</td>
			<td>align</td>
			<td>显示方式</td>
		</tr>
		<tr align="center">
			<td rowspan=2>合并单元格</td>
			<td>rowspan</td>
			<td>跨行</td>
		</tr>
		<tr align="center">
			<td>colspan  </td>
			<td>跨列</td>
		</tr>
	</table>
</html>

#### 表单标签

> 提交数据到服务器的过程可以使用表单标签实现
- `<form></form>` : 定义一个表单的范围
	- 属性：
		- action: 提交到的地址，默认提交到当前页面
		- method: 表单提交方式，最常用的两种：`get` , `post`
		> 区别：get 请求地址栏会携带提交的数据，安全性较低，有数据大小的限制
		- `enctype`: 用于文件上传的表单提交方式
- 输入项：
	- 普通输入项
		`<input type="text"/>`
		<input type="text"/>
	- 密码输入项
		`<input type="password"/>`
		<input type="password"/>
	- 单选输入项
		`<input type="radio" name="name1"/>`
		<input type="radio" name="name1" checked/>女 <input type="radio" name="name1"/>男
	> 注：需要默认选中，则添加属性`checked="checked"`
	- 复选输入框
		`<input type="checkbox" name="name2"/>`
		<input type="checkbox" name="name2"/>1<input type="checkbox" name="name2" checked/>2
	> 注：需要默认选中，则添加属性`checked="checked"`
	- 文件输入项
		`<input type="file"/>`
		<input type="file"/>
	- 下拉输入项（不在 input 标签内）

		```html
		<select name="name3">
			<option value="0">请选择</option>
			<option value="1990">1990</option>
			<option value="1991">1991</option>
		</select>
		```

		<select name="name3">
		<option value="0">请选择</option>
		<option value="1990" selected>1990</option>
		<option value="1991" >1991</option>
		</select>
	> 注：需要默认选中，则添加属性`selected="selected"`
	- 文本域
		`<textarea cols=10 rows= 2></textarea>`
		<textarea cols=10 rows= 2></textarea>
	- 隐藏项
		`<input type="hidden"/>`
		<input type="hidden"/>
	- 提交按钮
		`<input type="submit" value="value"/>`
		<input type="submit" value="value"/>
	<b><font size="5">注 1: 只有设置了 name 属性之后才会被提交</font></b>
	**<font size="5">注 2: 单复选框只有设置了 value 属性之后才能识别</font>**
	- 使用图片提交按钮
		`<input type="image" src=""/>`
		<input type="image"
	- 重置按钮
		`<input type="reset" value="value-R"/>`
		<input type="reset" value="value-R"/>
	- 普通按钮（与 js 一起使用）
		`<input type="button" value="value-B"/>`
		<input type="button" value="value-B"/>

#### 字体标签

##### 加粗标签

- `<b></b>`
<b>加粗</b>

##### 下划线

- `<u></u>`
<u>下划线</u>

##### 斜体

- `<i></i>`
<i>斜体</i>

##### 删除线

- `<s></s>`
<s>删除线</s>

##### 下标

- `<sub></sub>`
下<sub>标</sub>

##### 上标

- `<sup></sup>`
上<sup>标</sup>

#### 分支标签

- `<div></div>`
会自动换行
- `<span></span>`
在一行显示

#### 段落标签

- `<p></p>`

### HTML 头标签

#### 指定页面名称

- `<title></title>`

#### 指定页面基本信息

- `<meta/>`（较少使用）
	例：
	1. 3 秒后定时跳转到 xxx.html:
	`<meta http-equiv="refresh" content="3;url=xxx.html"/>`

#### 指定超链接的基本设置

- `<base/>`
	例：
	`<base target="_blank"/>`
	（设置页面内超链接默认全部在新窗口打开）

#### 引入外部文件

- `<link/>`

### HTML 框架标签

- `<frameset>`
	- `<frame>`（具体显示的页面）
- 属性：
	- rows: 按行进行划分
	- cols: 按列进行划分
		- name: 名称
		- src: 页面路径

<b><font size="4">注 : 使用框架标签时,不能写在\<body>内,需要把\<body>标签去除</font></b>

一个应用：可以在超链接中的 target 属性中设置 name, 点击链接在右边的界面中显示，如各大网盘
