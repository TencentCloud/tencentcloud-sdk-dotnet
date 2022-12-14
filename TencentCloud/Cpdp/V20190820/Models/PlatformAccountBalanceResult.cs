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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PlatformAccountBalanceResult : AbstractModel
    {
        
        /// <summary>
        /// 收入类型
        /// LABOR:劳务所得
        /// OCCASION:偶然所得
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncomeType")]
        public string IncomeType{ get; set; }

        /// <summary>
        /// 总余额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Balance")]
        public string Balance{ get; set; }

        /// <summary>
        /// 系统冻结余额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SystemFreezeBalance")]
        public string SystemFreezeBalance{ get; set; }

        /// <summary>
        /// 人工冻结余额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ManualFreezeBalance")]
        public string ManualFreezeBalance{ get; set; }

        /// <summary>
        /// 可提现余额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayableBalance")]
        public string PayableBalance{ get; set; }

        /// <summary>
        /// 提现中余额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InPayBalance")]
        public string InPayBalance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IncomeType", this.IncomeType);
            this.SetParamSimple(map, prefix + "Balance", this.Balance);
            this.SetParamSimple(map, prefix + "SystemFreezeBalance", this.SystemFreezeBalance);
            this.SetParamSimple(map, prefix + "ManualFreezeBalance", this.ManualFreezeBalance);
            this.SetParamSimple(map, prefix + "PayableBalance", this.PayableBalance);
            this.SetParamSimple(map, prefix + "InPayBalance", this.InPayBalance);
        }
    }
}

