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

    public class SyncContractDataRequest : AbstractModel
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
        /// 签约使用的渠道
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 业务签约合同协议号
        /// </summary>
        [JsonProperty("OutContractCode")]
        public string OutContractCode{ get; set; }

        /// <summary>
        /// 签约状态，枚举值
        /// CONTRACT_STATUS_INVALID=无效状态
        /// CONTRACT_STATUS_SIGNED=已签约
        /// CONTRACT_STATUS_TERMINATED=已解约
        /// CONTRACT_STATUS_PENDING=签约进行中
        /// </summary>
        [JsonProperty("ContractStatus")]
        public string ContractStatus{ get; set; }

        /// <summary>
        /// 签约同步信息
        /// </summary>
        [JsonProperty("ContractSyncInfo")]
        public ContractSyncInfo ContractSyncInfo{ get; set; }

        /// <summary>
        /// 按照聚鑫安全密钥计算的签名
        /// </summary>
        [JsonProperty("MidasSignature")]
        public string MidasSignature{ get; set; }

        /// <summary>
        /// 聚鑫分配的安全ID
        /// </summary>
        [JsonProperty("MidasSecretId")]
        public string MidasSecretId{ get; set; }

        /// <summary>
        /// 聚鑫计费SubAppId，代表子商户
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 用户类型，枚举值
        /// USER_ID: 用户ID
        /// ANONYMOUS: 匿名类型 USER_ID
        /// 默认值为 USER_ID
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        [JsonProperty("SceneInfo")]
        public SceneInfo SceneInfo{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "OutContractCode", this.OutContractCode);
            this.SetParamSimple(map, prefix + "ContractStatus", this.ContractStatus);
            this.SetParamObj(map, prefix + "ContractSyncInfo.", this.ContractSyncInfo);
            this.SetParamSimple(map, prefix + "MidasSignature", this.MidasSignature);
            this.SetParamSimple(map, prefix + "MidasSecretId", this.MidasSecretId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamObj(map, prefix + "SceneInfo.", this.SceneInfo);
            this.SetParamSimple(map, prefix + "MidasEnvironment", this.MidasEnvironment);
        }
    }
}

