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

namespace TencentCloud.Eis.V20210601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AbstractRuntimeMC : AbstractModel
    {
        
        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("RuntimeId")]
        public long? RuntimeId{ get; set; }

        /// <summary>
        /// 环境名称，用户输入，同一uin内唯一
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 环境类型：0: sandbox, 1:shared, 2:private
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 环境所在地域，tianjin，beijiing，guangzhou等
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 环境所在地域，tianjin，beijiing，guangzhou等（同Zone）
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 环境应用listener地址后缀
        /// </summary>
        [JsonProperty("Addr")]
        public string Addr{ get; set; }

        /// <summary>
        /// 环境状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 环境过期时间
        /// </summary>
        [JsonProperty("ExpiredAt")]
        public long? ExpiredAt{ get; set; }

        /// <summary>
        /// 环境运行类型：0:运行时类型、1:api类型
        /// </summary>
        [JsonProperty("RuntimeClass")]
        public long? RuntimeClass{ get; set; }

        /// <summary>
        /// 是否已在当前环境发布
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Deployed")]
        public bool? Deployed{ get; set; }

        /// <summary>
        /// 环境扩展组件是否满足应用要求：0=true, 1=false 表示该应用需要扩展组件0(cdc)以及1(java)，但是独立环境有cdc无java，不满足发布要求
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MatchExtensions")]
        public string MatchExtensions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuntimeId", this.RuntimeId);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Addr", this.Addr);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ExpiredAt", this.ExpiredAt);
            this.SetParamSimple(map, prefix + "RuntimeClass", this.RuntimeClass);
            this.SetParamSimple(map, prefix + "Deployed", this.Deployed);
            this.SetParamSimple(map, prefix + "MatchExtensions", this.MatchExtensions);
        }
    }
}

