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

    public class ContractInfo : AbstractModel
    {
        
        /// <summary>
        /// 米大师内部签约商户号
        /// </summary>
        [JsonProperty("ChannelContractMerchantId")]
        public string ChannelContractMerchantId{ get; set; }

        /// <summary>
        /// 米大师内部签约子商户号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelContractSubMerchantId")]
        public string ChannelContractSubMerchantId{ get; set; }

        /// <summary>
        /// 米大师内部签约应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelContractAppId")]
        public string ChannelContractAppId{ get; set; }

        /// <summary>
        /// 米大师内部签约子应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelContractSubAppId")]
        public string ChannelContractSubAppId{ get; set; }

        /// <summary>
        /// 业务合约协议号
        /// </summary>
        [JsonProperty("OutContractCode")]
        public string OutContractCode{ get; set; }

        /// <summary>
        /// 第三方渠道用户信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalContractUserInfoList")]
        public ExternalContractUserInfo[] ExternalContractUserInfoList{ get; set; }

        /// <summary>
        /// 签约方式，如 wechat_app ，使用app方式下的微信签
        /// </summary>
        [JsonProperty("ContractMethod")]
        public string ContractMethod{ get; set; }

        /// <summary>
        /// 合约场景id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContractSceneId")]
        public string ContractSceneId{ get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [JsonProperty("UserInfo")]
        public ContractUserInfo UserInfo{ get; set; }

        /// <summary>
        /// 第三方渠道签约数据
        /// </summary>
        [JsonProperty("ExternalContractData")]
        public string ExternalContractData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelContractMerchantId", this.ChannelContractMerchantId);
            this.SetParamSimple(map, prefix + "ChannelContractSubMerchantId", this.ChannelContractSubMerchantId);
            this.SetParamSimple(map, prefix + "ChannelContractAppId", this.ChannelContractAppId);
            this.SetParamSimple(map, prefix + "ChannelContractSubAppId", this.ChannelContractSubAppId);
            this.SetParamSimple(map, prefix + "OutContractCode", this.OutContractCode);
            this.SetParamArrayObj(map, prefix + "ExternalContractUserInfoList.", this.ExternalContractUserInfoList);
            this.SetParamSimple(map, prefix + "ContractMethod", this.ContractMethod);
            this.SetParamSimple(map, prefix + "ContractSceneId", this.ContractSceneId);
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamSimple(map, prefix + "ExternalContractData", this.ExternalContractData);
        }
    }
}

