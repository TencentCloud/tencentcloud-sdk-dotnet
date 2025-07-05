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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SupportBankInfo : AbstractModel
    {
        
        /// <summary>
        /// 银行简称。
        /// </summary>
        [JsonProperty("BankCode")]
        public string BankCode{ get; set; }

        /// <summary>
        /// 银行名称。
        /// </summary>
        [JsonProperty("BankName")]
        public string BankName{ get; set; }

        /// <summary>
        /// 状态。
        /// __MAINTAINING__: 维护中
        /// __WORKING__: 正常工作
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaintainStatus")]
        public string MaintainStatus{ get; set; }

        /// <summary>
        /// 银行渠道维护公告。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BankNotice")]
        public string BankNotice{ get; set; }

        /// <summary>
        /// 支持银行代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BankId")]
        public string BankId{ get; set; }

        /// <summary>
        /// 卡类型。
        /// D：借记卡，C：信用卡，Z：借贷合一卡。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CardType")]
        public string CardType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BankCode", this.BankCode);
            this.SetParamSimple(map, prefix + "BankName", this.BankName);
            this.SetParamSimple(map, prefix + "MaintainStatus", this.MaintainStatus);
            this.SetParamSimple(map, prefix + "BankNotice", this.BankNotice);
            this.SetParamSimple(map, prefix + "BankId", this.BankId);
            this.SetParamSimple(map, prefix + "CardType", this.CardType);
        }
    }
}

