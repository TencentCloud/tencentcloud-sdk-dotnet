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

    public class BindOpenBankExternalSubMerchantBankAccountResult : AbstractModel
    {
        
        /// <summary>
        /// 渠道申请编号。
        /// </summary>
        [JsonProperty("ChannelApplyId")]
        public string ChannelApplyId{ get; set; }

        /// <summary>
        /// 绑定状态。
        /// __SUCCESS__: 绑定成功
        /// __FAILED__: 绑定失败
        /// __PROCESSING__: 绑定中。
        /// 注意：若返回绑定中，需要再次调用绑定结果查询接口,查询结果。
        /// </summary>
        [JsonProperty("BindStatus")]
        public string BindStatus{ get; set; }

        /// <summary>
        /// 绑定返回描述, 例如失败原因等。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BindMessage")]
        public string BindMessage{ get; set; }

        /// <summary>
        /// 渠道子商户银行账户信息, 为JSON格式字符串（绑定成功状态下返回）。详情见附录-复杂类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalSubMerchantBankAccountReturnData")]
        public string ExternalSubMerchantBankAccountReturnData{ get; set; }

        /// <summary>
        /// 绑卡序列号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BindSerialNo")]
        public string BindSerialNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelApplyId", this.ChannelApplyId);
            this.SetParamSimple(map, prefix + "BindStatus", this.BindStatus);
            this.SetParamSimple(map, prefix + "BindMessage", this.BindMessage);
            this.SetParamSimple(map, prefix + "ExternalSubMerchantBankAccountReturnData", this.ExternalSubMerchantBankAccountReturnData);
            this.SetParamSimple(map, prefix + "BindSerialNo", this.BindSerialNo);
        }
    }
}

