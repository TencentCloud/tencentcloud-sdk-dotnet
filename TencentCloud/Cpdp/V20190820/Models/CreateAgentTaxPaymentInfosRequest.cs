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

    public class CreateAgentTaxPaymentInfosRequest : AbstractModel
    {
        
        /// <summary>
        /// 代理商ID
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// 平台渠道
        /// </summary>
        [JsonProperty("Channel")]
        public long? Channel{ get; set; }

        /// <summary>
        /// 类型。0-视同，1-个体工商户
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 源电子凭证下载地址
        /// </summary>
        [JsonProperty("RawElectronicCertUrl")]
        public string RawElectronicCertUrl{ get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 完税信息
        /// </summary>
        [JsonProperty("AgentTaxPaymentInfos")]
        public AgentTaxPayment[] AgentTaxPaymentInfos{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填sandbox
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RawElectronicCertUrl", this.RawElectronicCertUrl);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamArrayObj(map, prefix + "AgentTaxPaymentInfos.", this.AgentTaxPaymentInfos);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

