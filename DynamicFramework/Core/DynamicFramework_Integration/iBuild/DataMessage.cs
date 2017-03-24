using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iBuild
{
    struct DataMessage
    {
        /// <summary>
        /// SQL查询表结构
        /// </summary>
        public const string TableSQL = @"SELECT ( CASE WHEN a.colorder = 1 THEN d.name ELSE d.name END ) FieldPageName, ( CASE WHEN a.colorder = 1 THEN d.name ELSE d.name END ) FieldPageLabel, a.colorder FieldID, a.name FieldName, ( CASE WHEN COLUMNPROPERTY(a.id, a.name, 'IsIdentity') = 1 THEN 'O' ELSE 'X' END ) FieldIdentity, ( CASE WHEN ( SELECT COUNT (*) FROM sysobjects WHERE ( name IN ( SELECT name FROM sysindexes WHERE (id = a.id) AND ( indid IN ( SELECT indid FROM sysindexkeys WHERE (id = a.id) AND ( colid IN ( SELECT colid FROM syscolumns WHERE (id = a.id) AND (name = a.name) ) ) ) ) ) ) AND (xtype = 'PK') ) > 0 THEN 'O' ELSE 'X' END ) FieldPrimary, b.name FieldType, a.length FieldSize, COLUMNPROPERTY(a.id, a.name, 'PRECISION') AS FieldLength, isnull( COLUMNPROPERTY(a.id, a.name, 'Scale'), 0 ) AS FieldDouble, ( CASE WHEN a.isnullable = 1 THEN 'O' ELSE 'X' END ) FieldIsNull, isnull(e. TEXT, '') FieldDefault, isnull(g.[value], ' ') AS FieldLabel FROM syscolumns a LEFT JOIN systypes b ON a.xtype = b.xusertype INNER JOIN sysobjects d ON a.id = d.id AND d.xtype = 'U' AND d.name <> 'dtproperties' LEFT JOIN syscomments e ON a.cdefault = e.id LEFT JOIN sys.extended_properties g ON a.id = g.major_id AND a.colid = g.minor_id LEFT JOIN sys.extended_properties f ON d.id = f.class AND f.minor_id = 0 WHERE b.name IS NOT NULL {0} ORDER BY d.name";
        public const string ViewSQL = @"SELECT ( CASE WHEN a.colorder = 1 THEN d.name ELSE d.name END ) FieldPageName, ( CASE WHEN a.colorder = 1 THEN d.name ELSE d.name END ) FieldPageLabel, a.colorder FieldID, a.name FieldName, ( CASE WHEN COLUMNPROPERTY(a.id, a.name, 'IsIdentity') = 1 THEN 'O' ELSE 'X' END ) FieldIdentity, ( CASE WHEN ( SELECT COUNT (*) FROM sysobjects WHERE ( name IN ( SELECT name FROM sysindexes WHERE (id = a.id) AND ( indid IN ( SELECT indid FROM sysindexkeys WHERE (id = a.id) AND ( colid IN ( SELECT colid FROM syscolumns WHERE (id = a.id) AND (name = a.name) ) ) ) ) ) ) AND (xtype = 'PK') ) > 0 THEN 'O' ELSE 'X' END ) FieldPrimary, b.name FieldType, a.length FieldSize, COLUMNPROPERTY(a.id, a.name, 'PRECISION') AS FieldLength, isnull( COLUMNPROPERTY(a.id, a.name, 'Scale'), 0 ) AS FieldDouble, ( CASE WHEN a.isnullable = 1 THEN 'O' ELSE 'X' END ) FieldIsNull, isnull(e. TEXT, '') FieldDefault, isnull(g.[value], ' ') AS FieldLabel FROM syscolumns a LEFT JOIN systypes b ON a.xtype = b.xusertype INNER JOIN sysobjects d ON a.id = d.id AND d.xtype = 'V' AND d.name <> 'dtproperties' LEFT JOIN syscomments e ON a.cdefault = e.id LEFT JOIN sys.extended_properties g ON a.id = g.major_id AND a.colid = g.minor_id LEFT JOIN sys.extended_properties f ON d.id = f.class AND f.minor_id = 0 WHERE b.name IS NOT NULL {0} ORDER BY d.name";
        /// <summary>
        /// SQLServer 连接字符串
        /// </summary>
        public const string SQLConnString = @"Data Source={0};Initial Catalog={1};User ID={2};Password={3}";
        /// <summary>
        /// SQLite连接字符串
        /// </summary>
        public const string SQLiteConnString = @"Data Sourcce={0}";
    }
}
