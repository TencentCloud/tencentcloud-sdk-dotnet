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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDspmBackupLogListResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>总共多少条</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// <p>备份日志列表</p>
        /// </summary>
        [JsonProperty("List")]
        public BackupLog[] List{ get; set; }

        /// <summary>
        /// <p>当前是否存在恢复中任务</p>
        /// </summary>
        [JsonProperty("HasRestoringTask")]
        public bool? HasRestoringTask{ get; set; }

        /// <summary>
        /// <p>最大恢复空间</p>
        /// </summary>
        [JsonProperty("MaxRestoreSizeInGB")]
        public long? MaxRestoreSizeInGB{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "List.", this.List);
            this.SetParamSimple(map, prefix + "HasRestoringTask", this.HasRestoringTask);
            this.SetParamSimple(map, prefix + "MaxRestoreSizeInGB", this.MaxRestoreSizeInGB);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

