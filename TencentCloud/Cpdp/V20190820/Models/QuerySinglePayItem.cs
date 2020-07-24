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

    public class QuerySinglePayItem : AbstractModel
    {
        
        /// <summary>
        /// 付款状态（S：支付成功；P：支付处理中；F：支付失败）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayStatus")]
        public string PayStatus{ get; set; }

        /// <summary>
        /// 平台信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlatformMsg")]
        public string PlatformMsg{ get; set; }

        /// <summary>
        /// 银行原始返回码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BankRetCode")]
        public string BankRetCode{ get; set; }

        /// <summary>
        /// 银行原始返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BankRetMsg")]
        public string BankRetMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayStatus", this.PayStatus);
            this.SetParamSimple(map, prefix + "PlatformMsg", this.PlatformMsg);
            this.SetParamSimple(map, prefix + "BankRetCode", this.BankRetCode);
            this.SetParamSimple(map, prefix + "BankRetMsg", this.BankRetMsg);
        }
    }
}

