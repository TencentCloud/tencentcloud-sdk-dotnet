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

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetServiceStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// KMS服务是否开通， true 表示已开通
        /// </summary>
        [JsonProperty("ServiceEnabled")]
        public bool? ServiceEnabled{ get; set; }

        /// <summary>
        /// 服务不可用类型： 0-未购买，1-正常， 2-欠费停服， 3-资源释放
        /// </summary>
        [JsonProperty("InvalidType")]
        public long? InvalidType{ get; set; }

        /// <summary>
        /// 0-普通版，1-旗舰版
        /// </summary>
        [JsonProperty("UserLevel")]
        public ulong? UserLevel{ get; set; }

        /// <summary>
        /// 旗舰版到期时间（Epoch Unix Timestamp）。
        /// </summary>
        [JsonProperty("ProExpireTime")]
        public ulong? ProExpireTime{ get; set; }

        /// <summary>
        /// 旗舰版是否自动续费：0-不自动续费，1-自动续费
        /// </summary>
        [JsonProperty("ProRenewFlag")]
        public ulong? ProRenewFlag{ get; set; }

        /// <summary>
        /// 旗舰版购买记录的唯一性标识。如果为开通旗舰版，则返回值为空
        /// </summary>
        [JsonProperty("ProResourceId")]
        public string ProResourceId{ get; set; }

        /// <summary>
        /// 是否开通 KMS 托管版
        /// </summary>
        [JsonProperty("ExclusiveVSMEnabled")]
        public bool? ExclusiveVSMEnabled{ get; set; }

        /// <summary>
        /// 是否开通 KMS 独享版
        /// </summary>
        [JsonProperty("ExclusiveHSMEnabled")]
        public bool? ExclusiveHSMEnabled{ get; set; }

        /// <summary>
        /// KMS 订阅信息。
        /// </summary>
        [JsonProperty("SubscriptionInfo")]
        public string SubscriptionInfo{ get; set; }

        /// <summary>
        /// 返回KMS用户密钥使用数量
        /// </summary>
        [JsonProperty("CmkUserCount")]
        public ulong? CmkUserCount{ get; set; }

        /// <summary>
        /// 返回KMS用户密钥规格数量
        /// </summary>
        [JsonProperty("CmkLimit")]
        public ulong? CmkLimit{ get; set; }

        /// <summary>
        /// 返回独享集群组
        /// </summary>
        [JsonProperty("ExclusiveHSMList")]
        public ExclusiveHSM[] ExclusiveHSMList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceEnabled", this.ServiceEnabled);
            this.SetParamSimple(map, prefix + "InvalidType", this.InvalidType);
            this.SetParamSimple(map, prefix + "UserLevel", this.UserLevel);
            this.SetParamSimple(map, prefix + "ProExpireTime", this.ProExpireTime);
            this.SetParamSimple(map, prefix + "ProRenewFlag", this.ProRenewFlag);
            this.SetParamSimple(map, prefix + "ProResourceId", this.ProResourceId);
            this.SetParamSimple(map, prefix + "ExclusiveVSMEnabled", this.ExclusiveVSMEnabled);
            this.SetParamSimple(map, prefix + "ExclusiveHSMEnabled", this.ExclusiveHSMEnabled);
            this.SetParamSimple(map, prefix + "SubscriptionInfo", this.SubscriptionInfo);
            this.SetParamSimple(map, prefix + "CmkUserCount", this.CmkUserCount);
            this.SetParamSimple(map, prefix + "CmkLimit", this.CmkLimit);
            this.SetParamArrayObj(map, prefix + "ExclusiveHSMList.", this.ExclusiveHSMList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

