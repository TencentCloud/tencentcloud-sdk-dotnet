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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentProcedureDebugging : AbstractModel
    {
        
        /// <summary>
        /// 模型思考内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 展示的具体文本内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisplayContent")]
        public string DisplayContent{ get; set; }

        /// <summary>
        /// 展示类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisplayType")]
        public ulong? DisplayType{ get; set; }

        /// <summary>
        /// 搜索引擎展示的索引
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QuoteInfos")]
        public QuoteInfo[] QuoteInfos{ get; set; }

        /// <summary>
        /// 具体的参考来源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("References")]
        public AgentReference[] References{ get; set; }

        /// <summary>
        /// 展示正在执行的状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisplayStatus")]
        public string DisplayStatus{ get; set; }

        /// <summary>
        /// 云桌面的URL地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SandboxUrl")]
        public string SandboxUrl{ get; set; }

        /// <summary>
        /// 云桌面里面通过浏览器打开的URL地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisplayUrl")]
        public string DisplayUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "DisplayContent", this.DisplayContent);
            this.SetParamSimple(map, prefix + "DisplayType", this.DisplayType);
            this.SetParamArrayObj(map, prefix + "QuoteInfos.", this.QuoteInfos);
            this.SetParamArrayObj(map, prefix + "References.", this.References);
            this.SetParamSimple(map, prefix + "DisplayStatus", this.DisplayStatus);
            this.SetParamSimple(map, prefix + "SandboxUrl", this.SandboxUrl);
            this.SetParamSimple(map, prefix + "DisplayUrl", this.DisplayUrl);
        }
    }
}

