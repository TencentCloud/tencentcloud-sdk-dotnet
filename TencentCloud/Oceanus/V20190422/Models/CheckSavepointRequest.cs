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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckSavepointRequest : AbstractModel
    {
        
        /// <summary>
        /// 作业 id
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 快照资源 id
        /// </summary>
        [JsonProperty("SerialId")]
        public string SerialId{ get; set; }

        /// <summary>
        /// 快照类型 1: savepoint；2: checkpoint；3: cancelWithSavepoint
        /// </summary>
        [JsonProperty("RecordType")]
        public long? RecordType{ get; set; }

        /// <summary>
        /// 快照路径，目前只支持 cos 路径
        /// </summary>
        [JsonProperty("SavepointPath")]
        public string SavepointPath{ get; set; }

        /// <summary>
        /// 工作空间 id
        /// </summary>
        [JsonProperty("WorkSpaceId")]
        public string WorkSpaceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "SerialId", this.SerialId);
            this.SetParamSimple(map, prefix + "RecordType", this.RecordType);
            this.SetParamSimple(map, prefix + "SavepointPath", this.SavepointPath);
            this.SetParamSimple(map, prefix + "WorkSpaceId", this.WorkSpaceId);
        }
    }
}

