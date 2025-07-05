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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCorpResponse : AbstractModel
    {
        
        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CorpBizId")]
        public string CorpBizId{ get; set; }

        /// <summary>
        /// 应用配额
        /// </summary>
        [JsonProperty("RobotQuota")]
        public ulong? RobotQuota{ get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        [JsonProperty("FullName")]
        public string FullName{ get; set; }

        /// <summary>
        /// 是否试用
        /// </summary>
        [JsonProperty("IsTrial")]
        public bool? IsTrial{ get; set; }

        /// <summary>
        /// 是否试用过期
        /// </summary>
        [JsonProperty("IsTrialExpired")]
        public bool? IsTrialExpired{ get; set; }

        /// <summary>
        /// 可用应用数量
        /// </summary>
        [JsonProperty("AvailableAppQuota")]
        public ulong? AvailableAppQuota{ get; set; }

        /// <summary>
        /// 是否支持自定义模型配置
        /// </summary>
        [JsonProperty("IsSupportCustomModel")]
        public bool? IsSupportCustomModel{ get; set; }

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
            this.SetParamSimple(map, prefix + "CorpBizId", this.CorpBizId);
            this.SetParamSimple(map, prefix + "RobotQuota", this.RobotQuota);
            this.SetParamSimple(map, prefix + "FullName", this.FullName);
            this.SetParamSimple(map, prefix + "IsTrial", this.IsTrial);
            this.SetParamSimple(map, prefix + "IsTrialExpired", this.IsTrialExpired);
            this.SetParamSimple(map, prefix + "AvailableAppQuota", this.AvailableAppQuota);
            this.SetParamSimple(map, prefix + "IsSupportCustomModel", this.IsSupportCustomModel);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

