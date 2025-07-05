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

    public class ResponseQueryContract : AbstractModel
    {
        
        /// <summary>
        /// 第三方渠道错误码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnCode")]
        public string ExternalReturnCode{ get; set; }

        /// <summary>
        /// 第三方渠道错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnMessage")]
        public string ExternalReturnMessage{ get; set; }

        /// <summary>
        /// 第三方渠道返回的原始数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnData")]
        public string ExternalReturnData{ get; set; }

        /// <summary>
        /// 米大师内部商户号
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 米大师内部子商户号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelSubMerchantId")]
        public string ChannelSubMerchantId{ get; set; }

        /// <summary>
        /// 米大师内部应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelAppId")]
        public string ChannelAppId{ get; set; }

        /// <summary>
        /// 米大师内部子应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelSubAppId")]
        public string ChannelSubAppId{ get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 返回的合约信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReturnContractInfo")]
        public ReturnContractInfo ReturnContractInfo{ get; set; }

        /// <summary>
        /// 签约通知地址
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExternalReturnCode", this.ExternalReturnCode);
            this.SetParamSimple(map, prefix + "ExternalReturnMessage", this.ExternalReturnMessage);
            this.SetParamSimple(map, prefix + "ExternalReturnData", this.ExternalReturnData);
            this.SetParamSimple(map, prefix + "ChannelMerchantId", this.ChannelMerchantId);
            this.SetParamSimple(map, prefix + "ChannelSubMerchantId", this.ChannelSubMerchantId);
            this.SetParamSimple(map, prefix + "ChannelAppId", this.ChannelAppId);
            this.SetParamSimple(map, prefix + "ChannelSubAppId", this.ChannelSubAppId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamObj(map, prefix + "ReturnContractInfo.", this.ReturnContractInfo);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
        }
    }
}

