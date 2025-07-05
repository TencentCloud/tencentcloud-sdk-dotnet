/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductPrivilegeUnit : AbstractModel
    {
        
        /// <summary>
        /// 权限名称，当前可选：
        /// GlobalPrivileges
        /// DatabasePrivileges
        /// TablePrivileges
        /// ColumnPrivileges
        /// 
        /// 当权限为DatabasePrivileges时，必须通过参数Database指定数据库名；
        /// 
        /// 当权限为TablePrivileges时，必须通过参数Database和TableName指定数据库名以及数据库中的表名；
        /// 
        /// 当权限为ColumnPrivileges时，必须通过参数Database、TableName和CoulmnName指定数据库、数据库中的表名以及表中的列名。
        /// </summary>
        [JsonProperty("PrivilegeName")]
        public string PrivilegeName{ get; set; }

        /// <summary>
        /// 权限列表。
        /// 对于Mysql产品来说，可选权限值为：
        /// 
        /// 1. GlobalPrivileges 中权限的可选值为："SELECT","INSERT","UPDATE","DELETE","CREATE", "PROCESS", "DROP","REFERENCES","INDEX","ALTER","SHOW DATABASES","CREATE TEMPORARY TABLES","LOCK TABLES","EXECUTE","CREATE VIEW","SHOW VIEW","CREATE ROUTINE","ALTER ROUTINE","EVENT","TRIGGER"。
        /// 注意，不传该参数表示清除该权限。
        /// 
        /// 2. DatabasePrivileges 权限的可选值为："SELECT","INSERT","UPDATE","DELETE","CREATE", "DROP","REFERENCES","INDEX","ALTER","CREATE TEMPORARY TABLES","LOCK TABLES","EXECUTE","CREATE VIEW","SHOW VIEW","CREATE ROUTINE","ALTER ROUTINE","EVENT","TRIGGER"。
        /// 注意，不传该参数表示清除该权限。
        /// 
        /// 3. TablePrivileges 权限的可选值为：权限的可选值为："SELECT","INSERT","UPDATE","DELETE","CREATE", "DROP","REFERENCES","INDEX","ALTER","CREATE VIEW","SHOW VIEW", "TRIGGER"。
        /// 注意，不传该参数表示清除该权限。
        /// 
        /// 4. ColumnPrivileges 权限的可选值为："SELECT","INSERT","UPDATE","REFERENCES"。
        /// 注意，不传该参数表示清除该权限。
        /// </summary>
        [JsonProperty("Privileges")]
        public string[] Privileges{ get; set; }

        /// <summary>
        /// 仅当PrivilegeName为DatabasePrivileges时这个值才有效。
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// 仅当PrivilegeName为TablePrivileges时这个值才有效，并且此时需要填充Database显式指明所在的数据库实例。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 仅当PrivilegeName为ColumnPrivileges时这个值才生效，并且此时必须填充：
        /// Database - 显式指明所在的数据库实例。
        /// TableName - 显式指明所在表
        /// </summary>
        [JsonProperty("ColumnName")]
        public string ColumnName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrivilegeName", this.PrivilegeName);
            this.SetParamArraySimple(map, prefix + "Privileges.", this.Privileges);
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "ColumnName", this.ColumnName);
        }
    }
}

