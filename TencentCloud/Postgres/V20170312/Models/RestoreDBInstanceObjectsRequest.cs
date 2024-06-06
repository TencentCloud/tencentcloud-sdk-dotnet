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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestoreDBInstanceObjectsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// 需要恢复的对象列表。假设需要恢复的对象名为test，则恢复后的名称为test_bak_${LinuxTime}。${LinuxTime}无法指定，由系统根据任务发起的linux时间设定。
        /// </summary>
        [JsonProperty("RestoreObjects")]
        public string[] RestoreObjects{ get; set; }

        /// <summary>
        /// 恢复所用备份集。BackupSetId与RestoreTargetTime有且只能传一个。
        /// </summary>
        [JsonProperty("BackupSetId")]
        public string BackupSetId{ get; set; }

        /// <summary>
        /// 恢复目标时间，北京时间。BackupSetId与RestoreTargetTime有且只能传一个。
        /// </summary>
        [JsonProperty("RestoreTargetTime")]
        public string RestoreTargetTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamArraySimple(map, prefix + "RestoreObjects.", this.RestoreObjects);
            this.SetParamSimple(map, prefix + "BackupSetId", this.BackupSetId);
            this.SetParamSimple(map, prefix + "RestoreTargetTime", this.RestoreTargetTime);
        }
    }
}

