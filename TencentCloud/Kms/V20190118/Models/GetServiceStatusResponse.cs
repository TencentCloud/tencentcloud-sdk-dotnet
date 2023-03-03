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
        /// 注意：此字段可能返回 null，表示取不到有效值。
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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProExpireTime")]
        public ulong? ProExpireTime{ get; set; }

        /// <summary>
        /// 旗舰版是否自动续费：0-不自动续费，1-自动续费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProRenewFlag")]
        public ulong? ProRenewFlag{ get; set; }

        /// <summary>
        /// 旗舰版购买记录的唯一性标识。如果为开通旗舰版，则返回值为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProResourceId")]
        public string ProResourceId{ get; set; }

        /// <summary>
        /// 是否开通 KMS 托管版
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExclusiveVSMEnabled")]
        public bool? ExclusiveVSMEnabled{ get; set; }

        /// <summary>
        /// 是否开通 KMS 独享版
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExclusiveHSMEnabled")]
        public bool? ExclusiveHSMEnabled{ get; set; }

        /// <summary>
        /// KMS 订阅信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubscriptionInfo")]
        public string SubscriptionInfo{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

