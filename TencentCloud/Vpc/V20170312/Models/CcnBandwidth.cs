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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CcnBandwidth : AbstractModel
    {
        
        /// <summary>
        /// 带宽所属的云联网ID。
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// 实例的创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 实例的过期时间
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// 带宽实例的唯一ID。
        /// </summary>
        [JsonProperty("RegionFlowControlId")]
        public string RegionFlowControlId{ get; set; }

        /// <summary>
        /// 带宽是否自动续费的标记。
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 描述带宽的地域和限速上限信息。在地域间限速的情况下才会返回参数，出口限速模式不返回。
        /// </summary>
        [JsonProperty("CcnRegionBandwidthLimit")]
        public CcnRegionBandwidthLimitInfo CcnRegionBandwidthLimit{ get; set; }

        /// <summary>
        /// 云市场实例ID。
        /// </summary>
        [JsonProperty("MarketId")]
        public string MarketId{ get; set; }

        /// <summary>
        /// 实例所属用户主账号ID。
        /// </summary>
        [JsonProperty("UserAccountID")]
        public string UserAccountID{ get; set; }

        /// <summary>
        /// 是否跨境，`true`表示跨境，反之不跨境。
        /// </summary>
        [JsonProperty("IsCrossBorder")]
        public bool? IsCrossBorder{ get; set; }

        /// <summary>
        /// `true`表示封禁，地域间流量不通，`false`解禁，地域间流量正常
        /// </summary>
        [JsonProperty("IsSecurityLock")]
        public bool? IsSecurityLock{ get; set; }

        /// <summary>
        /// `POSTPAID`表示后付费，`PREPAID`表示预付费。
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 实例更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "RegionFlowControlId", this.RegionFlowControlId);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamObj(map, prefix + "CcnRegionBandwidthLimit.", this.CcnRegionBandwidthLimit);
            this.SetParamSimple(map, prefix + "MarketId", this.MarketId);
            this.SetParamSimple(map, prefix + "UserAccountID", this.UserAccountID);
            this.SetParamSimple(map, prefix + "IsCrossBorder", this.IsCrossBorder);
            this.SetParamSimple(map, prefix + "IsSecurityLock", this.IsSecurityLock);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

