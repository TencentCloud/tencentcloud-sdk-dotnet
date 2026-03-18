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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PasswordUpdateLoginConfig : AbstractModel
    {
        
        /// <summary>
        /// 首次登录强制修改密码开关。开启后，用户首次登录时将强制要求修改密码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstLoginUpdate")]
        public bool? FirstLoginUpdate{ get; set; }

        /// <summary>
        /// 定期强制修改密码开关。开启后，用户需按照 PeriodValue 和 PeriodType 指定的周期定期修改密码，超过周期未修改将在登录时强制要求修改。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PeriodUpdate")]
        public bool? PeriodUpdate{ get; set; }

        /// <summary>
        /// 定期修改密码的周期数值，与 PeriodType 配合使用。例如 PeriodValue 为 6，PeriodType 为 MONTH，表示每 6 个月需修改一次密码。当 PeriodUpdate 为 true 时必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PeriodValue")]
        public long? PeriodValue{ get; set; }

        /// <summary>
        /// 定期修改密码的周期时间单位，与 PeriodValue 配合使用。取值范围：
        /// WEEK：周
        /// MONTH：月
        /// YEAR：年
        /// 当 PeriodUpdate 为 true 时必填。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PeriodType")]
        public string PeriodType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FirstLoginUpdate", this.FirstLoginUpdate);
            this.SetParamSimple(map, prefix + "PeriodUpdate", this.PeriodUpdate);
            this.SetParamSimple(map, prefix + "PeriodValue", this.PeriodValue);
            this.SetParamSimple(map, prefix + "PeriodType", this.PeriodType);
        }
    }
}

