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

    public class CreateSinglePayResult : AbstractModel
    {
        
        /// <summary>
        /// 受理状态（S：处理成功；F：处理失败）
        /// </summary>
        [JsonProperty("HandleStatus")]
        public string HandleStatus{ get; set; }

        /// <summary>
        /// 受理状态描述
        /// </summary>
        [JsonProperty("HandleMsg")]
        public string HandleMsg{ get; set; }

        /// <summary>
        /// 业务流水号，历史唯一
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SerialNo")]
        public string SerialNo{ get; set; }

        /// <summary>
        /// 银行指令流水
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BankSerialNo")]
        public string BankSerialNo{ get; set; }

        /// <summary>
        /// 付款状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayStatus")]
        public string PayStatus{ get; set; }

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
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HandleStatus", this.HandleStatus);
            this.SetParamSimple(map, prefix + "HandleMsg", this.HandleMsg);
            this.SetParamSimple(map, prefix + "SerialNo", this.SerialNo);
            this.SetParamSimple(map, prefix + "BankSerialNo", this.BankSerialNo);
            this.SetParamSimple(map, prefix + "PayStatus", this.PayStatus);
            this.SetParamSimple(map, prefix + "BankRetCode", this.BankRetCode);
            this.SetParamSimple(map, prefix + "BankRetMsg", this.BankRetMsg);
        }
    }
}

