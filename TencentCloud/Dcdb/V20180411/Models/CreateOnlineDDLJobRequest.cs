/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOnlineDDLJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 要执行的 DDL 语句。常用的在线DDL参考此API文档示例部分
        /// </summary>
        [JsonProperty("Alter")]
        public string Alter{ get; set; }

        /// <summary>
        /// 要修改的数据库	
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 要修改的表
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// 指定账号执行DDL，需确保账号有 ALTER, CREATE, INSERT, UPDATE, DROP, DELETE, INDEX, CREATE TEMPORARY TABLES, LOCK TABLES, TRIGGER, REPLICATION CLIENT, REPLICATION SLAVE 等相关权限 （若不填写将默认使用系统账号）
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 指定账号的密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 运行线程数大于此值时，将终止DDL。不填则默认58
        /// </summary>
        [JsonProperty("CriticalLoad")]
        public long? CriticalLoad{ get; set; }

        /// <summary>
        /// 是否检查自增字段。为1则不允许修改自增字段，0或不填写则不检查
        /// </summary>
        [JsonProperty("CheckAutoInc")]
        public long? CheckAutoInc{ get; set; }

        /// <summary>
        /// 允许的主备延迟时间(单位s)，0或不填写则不检查延迟
        /// </summary>
        [JsonProperty("MaxDelay")]
        public long? MaxDelay{ get; set; }

        /// <summary>
        /// 是否使用pt-osc工具做DDL
        /// </summary>
        [JsonProperty("UsePt")]
        public long? UsePt{ get; set; }

        /// <summary>
        /// 开始执行时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Alter", this.Alter);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "CriticalLoad", this.CriticalLoad);
            this.SetParamSimple(map, prefix + "CheckAutoInc", this.CheckAutoInc);
            this.SetParamSimple(map, prefix + "MaxDelay", this.MaxDelay);
            this.SetParamSimple(map, prefix + "UsePt", this.UsePt);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
        }
    }
}

