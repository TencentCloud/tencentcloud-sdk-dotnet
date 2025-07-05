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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JobFlowResourceSpec : AbstractModel
    {
        
        /// <summary>
        /// 主节点数量。
        /// </summary>
        [JsonProperty("MasterCount")]
        public long? MasterCount{ get; set; }

        /// <summary>
        /// 主节点配置。
        /// </summary>
        [JsonProperty("MasterResourceSpec")]
        public JobFlowResource MasterResourceSpec{ get; set; }

        /// <summary>
        /// Core节点数量
        /// </summary>
        [JsonProperty("CoreCount")]
        public long? CoreCount{ get; set; }

        /// <summary>
        /// Core节点配置。
        /// </summary>
        [JsonProperty("CoreResourceSpec")]
        public JobFlowResource CoreResourceSpec{ get; set; }

        /// <summary>
        /// Task节点数量。
        /// </summary>
        [JsonProperty("TaskCount")]
        public long? TaskCount{ get; set; }

        /// <summary>
        /// Common节点数量。
        /// </summary>
        [JsonProperty("CommonCount")]
        public long? CommonCount{ get; set; }

        /// <summary>
        /// Task节点配置。
        /// </summary>
        [JsonProperty("TaskResourceSpec")]
        public JobFlowResource TaskResourceSpec{ get; set; }

        /// <summary>
        /// Common节点配置。
        /// </summary>
        [JsonProperty("CommonResourceSpec")]
        public JobFlowResource CommonResourceSpec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MasterCount", this.MasterCount);
            this.SetParamObj(map, prefix + "MasterResourceSpec.", this.MasterResourceSpec);
            this.SetParamSimple(map, prefix + "CoreCount", this.CoreCount);
            this.SetParamObj(map, prefix + "CoreResourceSpec.", this.CoreResourceSpec);
            this.SetParamSimple(map, prefix + "TaskCount", this.TaskCount);
            this.SetParamSimple(map, prefix + "CommonCount", this.CommonCount);
            this.SetParamObj(map, prefix + "TaskResourceSpec.", this.TaskResourceSpec);
            this.SetParamObj(map, prefix + "CommonResourceSpec.", this.CommonResourceSpec);
        }
    }
}

