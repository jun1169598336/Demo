use master
go

if exists(select * from sys.databases where name ='trash')
drop database trash
go

create database trash
go

use trash
go
--ְ���
create table DutyInfo
(
   DutyId int primary key identity(1,1),--ְ��id
   DutyName varchar(20),				--ְ������
)

insert into DutyInfo values('����Ա')
insert into DutyInfo values('�û�')

--��Ա��
create table usertable
(
	userId int primary key identity(1,1),
	userName varchar(20),
	userWord varchar(20),
	DutyId int references DutyInfo(DutyId)
)

insert into usertable values('����','123456',1)
insert into usertable values('����','123456',2)
select * from usertable


--�������ͱ�
create table trashtype								
(
	typeId int primary key identity(1,1),			--���
	typeName varchar(20),							--��������
	typeHarm varchar(50),							--Σ��
	typeWay varchar(50)								--����ʽ
)

insert into trashtype values('��������','���ܲ����������ó�','�������＼�������ɹ����ѷ�')
insert into trashtype values('��������','��Ⱦ����','ͨ���������񡢷��յȴ���')
insert into trashtype values('�ɻ�����','�����Դ���˷�','�ۺϴ���ʹ��õ����պ�����')
insert into trashtype values('�к�����','��Ⱦ���ؼ�ˮ��','�������ⷽ�����Դ���')

--���������
create table information							
(
	infoId int primary key identity(1,1),			--���
	infoName varchar(20),							--��������
	infoImg varchar(20),							--����ͼƬ
	typeid int references trashtype(typeid),		--��������
)

insert into information values('ʣ��','',1)
insert into information values('���ϴ�','',2)
insert into information values('��ֽ','',3)
insert into information values('���','',4)

select information.*,trashtype.* from information,trashtype where trashtype.typeId=information.typeId
