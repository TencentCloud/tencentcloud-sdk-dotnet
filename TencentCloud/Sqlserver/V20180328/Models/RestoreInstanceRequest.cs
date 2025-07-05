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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestoreInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID，形如mssql-j8kv137v
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 备份文件ID，该ID可以通过DescribeBackups接口返回数据中的Id字段获得
        /// </summary>
        [JsonProperty("BackupId")]
        public long? BackupId{ get; set; }

        /// <summary>
        /// 备份恢复到的同一个APPID下的实例ID，不填则恢复到原实例ID
        /// </summary>
        [JsonProperty("TargetInstanceId")]
        public string TargetInstanceId{ get; set; }

        /// <summary>
        /// 按照ReNameRestoreDatabase中的库进行恢复，并重命名，不填则按照默认方式命名恢复的库，且恢复所有的库。
        /// </summary>
        [JsonProperty("RenameRestore")]
        public RenameRestoreDatabase[] RenameRestore{ get; set; }

        /// <summary>
        /// 回档类型，0-覆盖方式；1-重命名方式，默认1
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 需要覆盖回档的数据库，只有覆盖回档时必填
        /// </summary>
        [JsonProperty("DBList")]
        public string[] DBList{ get; set; }

        /// <summary>
        /// 备份任务组ID，在单库备份文件模式下
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
            this.SetParamSimple(map, prefix + "TargetInstanceId", this.TargetInstanceId);
            this.SetParamArrayObj(map, prefix + "RenameRestore.", this.RenameRestore);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "DBList.", this.DBList);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
        }
    }
}

