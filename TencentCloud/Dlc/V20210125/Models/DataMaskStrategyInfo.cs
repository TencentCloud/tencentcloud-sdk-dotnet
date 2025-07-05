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

    public class DataMaskStrategyInfo : AbstractModel
    {
        
        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// MASK_SHOW_FIRST_4; MASK_SHOW_LAST_4;MASK_HASH; MASK_DATE_SHOW_YEAR; MASK_NULL; MASK_DEFAULT 等
        /// </summary>
        [JsonProperty("StrategyType")]
        public string StrategyType{ get; set; }

        /// <summary>
        /// 策略描述
        /// </summary>
        [JsonProperty("StrategyDesc")]
        public string StrategyDesc{ get; set; }

        /// <summary>
        /// 用户组策略列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Groups")]
        public GroupInfo[] Groups{ get; set; }

        /// <summary>
        /// 用户子账号uin列表，按;拼接
        /// </summary>
        [JsonProperty("Users")]
        public string Users{ get; set; }

        /// <summary>
        /// 策略Id
        /// </summary>
        [JsonProperty("StrategyId")]
        public string StrategyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamSimple(map, prefix + "StrategyDesc", this.StrategyDesc);
            this.SetParamArrayObj(map, prefix + "Groups.", this.Groups);
            this.SetParamSimple(map, prefix + "Users", this.Users);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
        }
    }
}

