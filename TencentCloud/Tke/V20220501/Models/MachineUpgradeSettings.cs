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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MachineUpgradeSettings : AbstractModel
    {
        
        /// <summary>
        /// 是否开启自动升级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoUpgrade")]
        public bool? AutoUpgrade{ get; set; }

        /// <summary>
        /// 运维窗口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpgradeOptions")]
        public AutoUpgradeOptions UpgradeOptions{ get; set; }

        /// <summary>
        /// 升级项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Components")]
        public string[] Components{ get; set; }

        /// <summary>
        /// 升级时，最大不可升级的节点数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxUnavailable")]
        public IntOrString MaxUnavailable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoUpgrade", this.AutoUpgrade);
            this.SetParamObj(map, prefix + "UpgradeOptions.", this.UpgradeOptions);
            this.SetParamArraySimple(map, prefix + "Components.", this.Components);
            this.SetParamObj(map, prefix + "MaxUnavailable.", this.MaxUnavailable);
        }
    }
}

