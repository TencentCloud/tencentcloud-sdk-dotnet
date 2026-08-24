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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDisasterRecoveryProtectGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 所属容灾站点对id
        /// </summary>
        [JsonProperty("SitePairId")]
        public string SitePairId{ get; set; }

        /// <summary>
        /// 容灾保护组的产品类型
        /// </summary>
        [JsonProperty("ProtectGroupType")]
        public string ProtectGroupType{ get; set; }

        /// <summary>
        /// 容灾保护组预期rpo, 单位分钟（当前仅支持15分钟）
        /// </summary>
        [JsonProperty("RecoveryPointObjective")]
        public long? RecoveryPointObjective{ get; set; }

        /// <summary>
        /// 容灾保护组的名称，最大长度不能超60个字符。
        /// </summary>
        [JsonProperty("ProtectGroupName")]
        public string ProtectGroupName{ get; set; }

        /// <summary>
        /// 数据复制方向， ['POSITIVE', 'REVERSE']
        /// </summary>
        [JsonProperty("DataDirection")]
        public string DataDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SitePairId", this.SitePairId);
            this.SetParamSimple(map, prefix + "ProtectGroupType", this.ProtectGroupType);
            this.SetParamSimple(map, prefix + "RecoveryPointObjective", this.RecoveryPointObjective);
            this.SetParamSimple(map, prefix + "ProtectGroupName", this.ProtectGroupName);
            this.SetParamSimple(map, prefix + "DataDirection", this.DataDirection);
        }
    }
}

