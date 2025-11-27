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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescModifyType : AbstractModel
    {
        
        /// <summary>
        /// 变配类型
        /// </summary>
        [JsonProperty("ModifyType")]
        public long? ModifyType{ get; set; }

        /// <summary>
        /// 是否迁移标志
        /// </summary>
        [JsonProperty("MigrateFlag")]
        public bool? MigrateFlag{ get; set; }

        /// <summary>
        /// 迁移预计耗时(稳定模式)秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MigrateCostTime")]
        public long? MigrateCostTime{ get; set; }

        /// <summary>
        /// 升配模式(1:稳定模式，2:高速模式)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpgradeStrategy")]
        public long? UpgradeStrategy{ get; set; }

        /// <summary>
        /// 迁移预计耗时(高速模式)秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MigrateCostTimeHighSpeed")]
        public long? MigrateCostTimeHighSpeed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModifyType", this.ModifyType);
            this.SetParamSimple(map, prefix + "MigrateFlag", this.MigrateFlag);
            this.SetParamSimple(map, prefix + "MigrateCostTime", this.MigrateCostTime);
            this.SetParamSimple(map, prefix + "UpgradeStrategy", this.UpgradeStrategy);
            this.SetParamSimple(map, prefix + "MigrateCostTimeHighSpeed", this.MigrateCostTimeHighSpeed);
        }
    }
}

