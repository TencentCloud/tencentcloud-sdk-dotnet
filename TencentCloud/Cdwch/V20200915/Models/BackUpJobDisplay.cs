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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackUpJobDisplay : AbstractModel
    {
        
        /// <summary>
        /// 备份任务id
        /// </summary>
        [JsonProperty("JobId")]
        public long? JobId{ get; set; }

        /// <summary>
        /// 备份任务名
        /// </summary>
        [JsonProperty("Snapshot")]
        public string Snapshot{ get; set; }

        /// <summary>
        /// 任务类型(元数据),(数据)
        /// </summary>
        [JsonProperty("BackUpType")]
        public string BackUpType{ get; set; }

        /// <summary>
        /// 备份数据量
        /// </summary>
        [JsonProperty("BackUpSize")]
        public long? BackUpSize{ get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("BackUpTime")]
        public string BackUpTime{ get; set; }

        /// <summary>
        /// 任务过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("JobStatus")]
        public string JobStatus{ get; set; }

        /// <summary>
        /// 处理数据量
        /// </summary>
        [JsonProperty("ProcessSize")]
        public long? ProcessSize{ get; set; }

        /// <summary>
        /// 错误原因
        /// </summary>
        [JsonProperty("ErrorReason")]
        public string ErrorReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "Snapshot", this.Snapshot);
            this.SetParamSimple(map, prefix + "BackUpType", this.BackUpType);
            this.SetParamSimple(map, prefix + "BackUpSize", this.BackUpSize);
            this.SetParamSimple(map, prefix + "BackUpTime", this.BackUpTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "JobStatus", this.JobStatus);
            this.SetParamSimple(map, prefix + "ProcessSize", this.ProcessSize);
            this.SetParamSimple(map, prefix + "ErrorReason", this.ErrorReason);
        }
    }
}

