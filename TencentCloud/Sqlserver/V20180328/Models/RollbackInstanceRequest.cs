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

    public class RollbackInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 回档类型，0-回档的数据库覆盖原库；1-回档的数据库以重命名的形式生成，不覆盖原库
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 回档目标时间点
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 需要回档的数据库
        /// </summary>
        [JsonProperty("DBs")]
        public string[] DBs{ get; set; }

        /// <summary>
        /// 备份恢复到的同一个APPID下的实例ID，不填则恢复到原实例ID
        /// </summary>
        [JsonProperty("TargetInstanceId")]
        public string TargetInstanceId{ get; set; }

        /// <summary>
        /// 按照ReNameRestoreDatabase中的库进行重命名，仅在Type = 1重命名回档方式有效；不填则按照默认方式命名库，DBs参数确定要恢复的库
        /// </summary>
        [JsonProperty("RenameRestore")]
        public RenameRestoreDatabase[] RenameRestore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamArraySimple(map, prefix + "DBs.", this.DBs);
            this.SetParamSimple(map, prefix + "TargetInstanceId", this.TargetInstanceId);
            this.SetParamArrayObj(map, prefix + "RenameRestore.", this.RenameRestore);
        }
    }
}

