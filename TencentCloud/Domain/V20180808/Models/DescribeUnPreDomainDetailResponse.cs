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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUnPreDomainDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 预约人数
        /// </summary>
        [JsonProperty("PreCount")]
        public long? PreCount{ get; set; }

        /// <summary>
        /// 域名注册时间 
        /// 格式:YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("RegTime")]
        public string RegTime{ get; set; }

        /// <summary>
        /// 域名删除时间 
        /// 格式:YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("DeleteTime")]
        public string DeleteTime{ get; set; }

        /// <summary>
        /// 到期时间 
        /// 格式:YYYY-MM-DD HH:mm:ss
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 域名状态
        ///  bid：出价
        /// noAction：无法操作
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 域名价格 单位元
        /// </summary>
        [JsonProperty("CurrentPrice")]
        public float? CurrentPrice{ get; set; }

        /// <summary>
        /// 域名保证金 单位元
        /// </summary>
        [JsonProperty("AppointBondPrice")]
        public float? AppointBondPrice{ get; set; }

        /// <summary>
        /// 是否已经预约
        /// </summary>
        [JsonProperty("IsAppoint")]
        public bool? IsAppoint{ get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 是否为原持有者域名
        /// </summary>
        [JsonProperty("IsDomainUser")]
        public bool? IsDomainUser{ get; set; }

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
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "PreCount", this.PreCount);
            this.SetParamSimple(map, prefix + "RegTime", this.RegTime);
            this.SetParamSimple(map, prefix + "DeleteTime", this.DeleteTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CurrentPrice", this.CurrentPrice);
            this.SetParamSimple(map, prefix + "AppointBondPrice", this.AppointBondPrice);
            this.SetParamSimple(map, prefix + "IsAppoint", this.IsAppoint);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "IsDomainUser", this.IsDomainUser);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

