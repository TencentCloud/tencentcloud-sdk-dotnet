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

namespace TencentCloud.Tdcpg.V20211118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Backup : AbstractModel
    {
        
        /// <summary>
        /// 备份集ID，集群内唯一
        /// </summary>
        [JsonProperty("BackupId")]
        public long? BackupId{ get; set; }

        /// <summary>
        /// 备份集类型，目前只支持 SNAPSHOT：快照
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// 备份集产生的方案，目前只支持 AUTO：自动
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// 备份集对应的数据时间。按照RFC3339标准表示，并且使用东八区时区时间，格式为：YYYY-MM-DDThh:mm:ss+08:00。
        /// </summary>
        [JsonProperty("BackupDataTime")]
        public string BackupDataTime{ get; set; }

        /// <summary>
        /// 备份集数据大小，单位GiB
        /// </summary>
        [JsonProperty("BackupDataSize")]
        public long? BackupDataSize{ get; set; }

        /// <summary>
        /// 备份集对应的任务开始时间。按照RFC3339标准表示，并且使用东八区时区时间，格式为：YYYY-MM-DDThh:mm:ss+08:00。
        /// </summary>
        [JsonProperty("BackupTaskStartTime")]
        public string BackupTaskStartTime{ get; set; }

        /// <summary>
        /// 备份集对应的任务结束时间。按照RFC3339标准表示，并且使用东八区时区时间，格式为：YYYY-MM-DDThh:mm:ss+08:00。
        /// </summary>
        [JsonProperty("BackupTaskEndTime")]
        public string BackupTaskEndTime{ get; set; }

        /// <summary>
        /// 备份集对应的任务状态  SUCCESS：成功
        /// </summary>
        [JsonProperty("BackupTaskStatus")]
        public string BackupTaskStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BackupDataTime", this.BackupDataTime);
            this.SetParamSimple(map, prefix + "BackupDataSize", this.BackupDataSize);
            this.SetParamSimple(map, prefix + "BackupTaskStartTime", this.BackupTaskStartTime);
            this.SetParamSimple(map, prefix + "BackupTaskEndTime", this.BackupTaskEndTime);
            this.SetParamSimple(map, prefix + "BackupTaskStatus", this.BackupTaskStatus);
        }
    }
}

