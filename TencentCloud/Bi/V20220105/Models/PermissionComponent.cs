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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PermissionComponent : AbstractModel
    {
        
        /// <summary>
        /// 权限值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModuleId")]
        public string ModuleId{ get; set; }

        /// <summary>
        /// 可见/可用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncludeType")]
        public string IncludeType{ get; set; }

        /// <summary>
        /// 目标升级版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpgradeVersionType")]
        public string UpgradeVersionType{ get; set; }

        /// <summary>
        /// 补充信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tips")]
        public string Tips{ get; set; }

        /// <summary>
        /// 补充信息的key值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TipsKey")]
        public string TipsKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModuleId", this.ModuleId);
            this.SetParamSimple(map, prefix + "IncludeType", this.IncludeType);
            this.SetParamSimple(map, prefix + "UpgradeVersionType", this.UpgradeVersionType);
            this.SetParamSimple(map, prefix + "Tips", this.Tips);
            this.SetParamSimple(map, prefix + "TipsKey", this.TipsKey);
        }
    }
}

