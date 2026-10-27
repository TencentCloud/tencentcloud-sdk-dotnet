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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Invocation : AbstractModel
    {
        
        /// <summary>
        /// <p>脚本执行ID。</p>
        /// </summary>
        [JsonProperty("InvokeId")]
        public string InvokeId{ get; set; }

        /// <summary>
        /// <p>运行状态。<li> Running：正在执行</li> <li>Finished：已经完成</li> <li>Failed：失败</li>  <li> Stopped：已停止</li></p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>任务输出。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Output")]
        public InvocationOutput Output{ get; set; }

        /// <summary>
        /// <p>任务失败时的错误码。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorCode")]
        public string ErrorCode{ get; set; }

        /// <summary>
        /// <p>任务失败时的错误信息描述。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public string ErrorInfo{ get; set; }

        /// <summary>
        /// <p>任务退出状态码</p>
        /// </summary>
        [JsonProperty("ExitCode")]
        public long? ExitCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvokeId", this.InvokeId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorInfo", this.ErrorInfo);
            this.SetParamSimple(map, prefix + "ExitCode", this.ExitCode);
        }
    }
}

