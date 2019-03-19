# JS 的对象

## String

### 创建

`var 石头人 = 'String'`

### 属性与方法

- 属性
	- `length`

- 方法
	- `bold()` 加粗
	- `fontcolor(color)` 设置字符串颜色
	- `fontsize(num)` 设置字体大小
	- `link(url)` 设置字符串的超链接
	- `sub()` 显示成下标
	- `sup()` 显示成上标
	- `concat(str)` 连接字符串
	- `charAt(num)` 根据位置返回字符串
	- `insexOf(str)` 检索字符串位置
	- `aplit(str)` 根据字符串切分字符串
	- `replace(str,str2)` str2 替换字符串中的 str
	- `substr(num,num2)` 从 num 开始截取 num2 个字符
	- `substring(num,num2)` 从 num 开始截取到 num2,[num,num2)

## Array

### 创建

`var arr = [1,'2',true]`
`var arr = new Array(3)`
`var arr = new Array(1,2,3)`

### 属性与方法

- 属性
	- `length`
- 方法
	- `concat(array)` 连接数组
	- `join(str)` 显示时使用 str 字符分割
	- `push(...arg)` 向数组末尾添加元素，返回新的数组长度
	- `pop()` 删除并返回最后一个元素
	- `reverse()` 颠倒数组顺序

## Date

### 创建

`var date = new Date()`

### 属性与方法

- 方法
	- `toLocaleString()`
	- `getFullYear()` 年
	- `getMonth()+1` 月
	- `getDay()` 周日 - 周六
	- `getDate()` 天
>>>>>>>>>>>>>>>>>>>>date 对象 2
