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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UsageRecords : AbstractModel
    {
        
        /// <summary>
        /// 使用金额（微分）
        /// </summary>
        [JsonProperty("UsedAmount")]
        public long? UsedAmount{ get; set; }

        /// <summary>
        /// 使用时间
        /// </summary>
        [JsonProperty("UsedTime")]
        public string UsedTime{ get; set; }

        /// <summary>
        /// 使用记录细节
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsageDetails")]
        public UsageDetails[] UsageDetails{ get; set; }

        /// <summary>
        /// 付费模式
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 查询的券id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VoucherId")]
        public string VoucherId{ get; set; }

        /// <summary>
        /// 交易场景：（adjust：调账、common：正常交易场景）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayScene")]
        public string PayScene{ get; set; }

        /// <summary>
        /// 唯一id,对应交易:预付费的dealName,调账/后付费的outTradeNo
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SeqId")]
        public string SeqId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UsedAmount", this.UsedAmount);
            this.SetParamSimple(map, prefix + "UsedTime", this.UsedTime);
            this.SetParamArrayObj(map, prefix + "UsageDetails.", this.UsageDetails);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "VoucherId", this.VoucherId);
            this.SetParamSimple(map, prefix + "PayScene", this.PayScene);
            this.SetParamSimple(map, prefix + "SeqId", this.SeqId);
        }
    }
}

