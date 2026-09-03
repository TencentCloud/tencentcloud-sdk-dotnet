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

    public class DescribeMlFlowConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>MLflow 的实验 ID，对应训练作业配置</p>
        /// </summary>
        [JsonProperty("ExperimentID")]
        public string ExperimentID{ get; set; }

        /// <summary>
        /// <p>MLflow 的 RunID，对应训练作业实例 ID</p>
        /// </summary>
        [JsonProperty("RunID")]
        public string RunID{ get; set; }

        /// <summary>
        /// <p>实例级 MLflow 模式：local / remote / none。云上一般为 Remote</p><p>枚举值：</p><ul><li>remote： 使用远程 MLflow </li><li>local： 使用本地启动的 MLflow</li><li>none： 不启用 MLflow</li></ul>
        /// </summary>
        [JsonProperty("MlFlowMode")]
        public string MlFlowMode{ get; set; }

        /// <summary>
        /// <p>实例级 MLflow 访问 URL</p>
        /// </summary>
        [JsonProperty("MlFlowUrl")]
        public string MlFlowUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "ExperimentID", this.ExperimentID);
            this.SetParamSimple(map, prefix + "RunID", this.RunID);
            this.SetParamSimple(map, prefix + "MlFlowMode", this.MlFlowMode);
            this.SetParamSimple(map, prefix + "MlFlowUrl", this.MlFlowUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

