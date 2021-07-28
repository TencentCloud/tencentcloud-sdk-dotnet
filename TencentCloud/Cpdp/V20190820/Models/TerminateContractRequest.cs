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

    public class TerminateContractRequest : AbstractModel
    {
        
        /// <summary>
        /// 聚鑫分配的支付主MidasAppId
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 用户ID，长度不小于5位，仅支持字母和数字的组合
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 指定渠道：  wechat：微信支付  qqwallet：QQ钱包 
        ///  bank：网银支付  只有一个渠道时需要指定
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 枚举值：
        /// CONTRACT_TERMINATION_MODE_BY_OUT_CONTRACT_CODE: 按OutContractCode+ContractSceneId解约
        /// CONTRACT_TERMINATION_MODE_BY_CHANNEL_CONTRACT_CODE：按ChannelContractCode解约
        /// </summary>
        [JsonProperty("TerminateMode")]
        public string TerminateMode{ get; set; }

        /// <summary>
        /// 聚鑫分配的安全ID
        /// </summary>
        [JsonProperty("MidasSecretId")]
        public string MidasSecretId{ get; set; }

        /// <summary>
        /// 按照聚鑫安全密钥计算的签名
        /// </summary>
        [JsonProperty("MidasSignature")]
        public string MidasSignature{ get; set; }

        /// <summary>
        /// 聚鑫计费SubAppId，代表子商户
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 业务签约合同协议号 当TerminateMode=CONTRACT_TERMINATION_MODE_BY_OUT_CONTRACT_CODE 时 必填
        /// </summary>
        [JsonProperty("OutContractCode")]
        public string OutContractCode{ get; set; }

        /// <summary>
        /// 签约场景ID，当 TerminateMode=CONTRACT_TERMINATION_MODE_BY_OUT_CONTRACT_CODE 时 必填，在米大师侧托管后生成
        /// </summary>
        [JsonProperty("ContractSceneId")]
        public string ContractSceneId{ get; set; }

        /// <summary>
        /// 米大师生成的协议号 当 TerminateMode=CONTRACT_TERMINATION_MODE_BY_CHANNEL_CONTRACT_CODE 时 必填
        /// </summary>
        [JsonProperty("ChannelContractCode")]
        public string ChannelContractCode{ get; set; }

        /// <summary>
        /// 第三方渠道合约数据，json字符串，与特定渠道有关
        /// </summary>
        [JsonProperty("ExternalContractData")]
        public string ExternalContractData{ get; set; }

        /// <summary>
        /// 终止合约原因
        /// </summary>
        [JsonProperty("TerminationReason")]
        public string TerminationReason{ get; set; }

        /// <summary>
        /// 环境名:
        /// release: 现网环境
        /// sandbox: 沙箱环境
        /// development: 开发环境
        /// 缺省: release
        /// </summary>
        [JsonProperty("MidasEnvironment")]
        public string MidasEnvironment{ get; set; }

        /// <summary>
        /// USER_ID: 用户ID
        /// ANONYMOUS: 匿名类型 USER_ID
        /// 默认值为 USER_ID
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// 签约方式
        /// </summary>
        [JsonProperty("ContractMethod")]
        public string ContractMethod{ get; set; }

        /// <summary>
        /// 签约代扣穿透查询存量数据迁移模式
        /// </summary>
        [JsonProperty("MigrateMode")]
        public string MigrateMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "TerminateMode", this.TerminateMode);
            this.SetParamSimple(map, prefix + "MidasSecretId", this.MidasSecretId);
            this.SetParamSimple(map, prefix + "MidasSignature", this.MidasSignature);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "OutContractCode", this.OutContractCode);
            this.SetParamSimple(map, prefix + "ContractSceneId", this.ContractSceneId);
            this.SetParamSimple(map, prefix + "ChannelContractCode", this.ChannelContractCode);
            this.SetParamSimple(map, prefix + "ExternalContractData", this.ExternalContractData);
            this.SetParamSimple(map, prefix + "TerminationReason", this.TerminationReason);
            this.SetParamSimple(map, prefix + "MidasEnvironment", this.MidasEnvironment);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "ContractMethod", this.ContractMethod);
            this.SetParamSimple(map, prefix + "MigrateMode", this.MigrateMode);
        }
    }
}

