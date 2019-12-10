use master
go

create database trash
go

use trash
go
--职务表
create table DutyInfo
(
   DutyId int primary key identity(1,1),--职务id
   DutyName varchar(20),				--职务名称
)

insert into DutyInfo values('管理员')
insert into DutyInfo values('用户')

--人员表
create table usertable
(
	userId int primary key identity(1,1),
	userName varchar(20),
	userWord varchar(20),
	userDuty int references DutyInfo(DutyId)
)

insert into usertable values('张三','123456',1)
insert into usertable values('李四','123456',2)

select * from usertable

--垃圾类型表
create table trashtype								
(
	typeId int primary key identity(1,1),			--编号
	typeName varchar(20),							--类型名称
	typeHarm varchar(50),							--危害
	typeWay varchar(50)								--处理方式
)

insert into trashtype values('厨余垃圾','腐败产生病菌及蚊虫','经过生物技术处理后可供作堆肥')
insert into trashtype values('其他垃圾','污染环境','通过卫生填埋、焚烧等处理')
insert into trashtype values('可回收物','造成资源的浪费','综合处理，使其得到回收和利用')
insert into trashtype values('有害垃圾','污染土地及水体','利用特殊方法加以处理')

--垃圾详情表
create table information							
(
	infoId int primary key identity(1,1),			--编号
	infoName varchar(20),							--垃圾名称
	infoImg varchar(20),							--垃圾图片
	infoType int references trashtype(typeid),		--垃圾类型
)

insert into information values('剩菜','',1)
insert into information values('塑料袋','',2)
insert into information values('废纸','',3)
insert into information values('电池','',4)

select information.*,trashtype.* from information,trashtype where trashtype.typeId=information.infoType
