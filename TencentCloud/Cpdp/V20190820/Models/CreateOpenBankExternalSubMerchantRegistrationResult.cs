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

    public class CreateOpenBankExternalSubMerchantRegistrationResult : AbstractModel
    {
        
        /// <summary>
        /// 进件状态。
        /// __SUCCESS__: 进件成功
        /// __FAILED__: 进件失败
        /// __PROCESSING__: 进件中
        /// 注意：若返回进件中，需要再次调用进件结果查询接口，查询结果。
        /// </summary>
        [JsonProperty("RegistrationStatus")]
        public string RegistrationStatus{ get; set; }

        /// <summary>
        /// 进件返回描述, 例如失败原因等。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegistrationMessage")]
        public string RegistrationMessage{ get; set; }

        /// <summary>
        /// 渠道进件序列号。
        /// </summary>
        [JsonProperty("ChannelRegistrationNo")]
        public string ChannelRegistrationNo{ get; set; }

        /// <summary>
        /// 渠道子商户ID。
        /// </summary>
        [JsonProperty("ChannelSubMerchantId")]
        public string ChannelSubMerchantId{ get; set; }

        /// <summary>
        /// 第三方渠道返回信息, 为JSON格式字符串。详情见附录-复杂类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnData")]
        public string ExternalReturnData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistrationStatus", this.RegistrationStatus);
            this.SetParamSimple(map, prefix + "RegistrationMessage", this.RegistrationMessage);
            this.SetParamSimple(map, prefix + "ChannelRegistrationNo", this.ChannelRegistrationNo);
            this.SetParamSimple(map, prefix + "ChannelSubMerchantId", this.ChannelSubMerchantId);
            this.SetParamSimple(map, prefix + "ExternalReturnData", this.ExternalReturnData);
        }
    }
}

