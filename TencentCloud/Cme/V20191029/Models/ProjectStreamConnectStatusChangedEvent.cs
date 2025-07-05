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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProjectStreamConnectStatusChangedEvent : AbstractModel
    {
        
        /// <summary>
        /// 项目 Id。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 项目状态，取值有：
        /// <li>Working：云转推推流开始；</li>
        /// <li>Stopped：云转推推流结束；</li>
        /// <li>InputInterrupted：云转推输入断流；</li>
        /// <li>OutputInterrupted：云转推输出断流。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 云转推输入断流信息，仅当 Status 取值 InputInterrupted 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputInterruptInfo")]
        public StreamConnectInputInterruptInfo InputInterruptInfo{ get; set; }

        /// <summary>
        /// 云转推输出断流信息，仅当 Status 取值 OutputInterrupted 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputInterruptInfo")]
        public StreamConnectOutputInterruptInfo OutputInterruptInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "InputInterruptInfo.", this.InputInterruptInfo);
            this.SetParamObj(map, prefix + "OutputInterruptInfo.", this.OutputInterruptInfo);
        }
    }
}

