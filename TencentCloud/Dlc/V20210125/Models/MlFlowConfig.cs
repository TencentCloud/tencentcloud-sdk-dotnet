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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MlFlowConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>MlFlow 追踪模式：local=MlFlow Sidecar / remote=已有 MlFlow Server / none=不启用</p>
        /// </summary>
        [JsonProperty("MlFlowMode")]
        public string MlFlowMode{ get; set; }

        /// <summary>
        /// <p>已有MlFlow Server 的 ID（仅 mlFlowMode=remote 时填写，前端下拉选择后传入）</p>
        /// </summary>
        [JsonProperty("MlFlowServerId")]
        public string MlFlowServerId{ get; set; }

        /// <summary>
        /// <p>MlFlow Sidecar 持久化存储的 COS 路径（仅 mlFlowMode=local 时填写）</p>
        /// </summary>
        [JsonProperty("MlFlowCosPath")]
        public string MlFlowCosPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MlFlowMode", this.MlFlowMode);
            this.SetParamSimple(map, prefix + "MlFlowServerId", this.MlFlowServerId);
            this.SetParamSimple(map, prefix + "MlFlowCosPath", this.MlFlowCosPath);
        }
    }
}

