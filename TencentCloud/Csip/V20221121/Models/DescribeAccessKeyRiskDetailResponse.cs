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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccessKeyRiskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 风险列表
        /// </summary>
        [JsonProperty("RiskInfo")]
        public AccessKeyRisk RiskInfo{ get; set; }

        /// <summary>
        /// CAM策略总数
        /// </summary>
        [JsonProperty("CamCount")]
        public long? CamCount{ get; set; }

        /// <summary>
        /// 账号关联告警数量
        /// </summary>
        [JsonProperty("AlarmCount")]
        public long? AlarmCount{ get; set; }

        /// <summary>
        /// 访问方式 0 API 1 控制台与API
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }

        /// <summary>
        /// 访问密钥告警数量列表
        /// </summary>
        [JsonProperty("AccessKeyAlarmCount")]
        public AccessKeyAlarmCount[] AccessKeyAlarmCount{ get; set; }

        /// <summary>
        /// 操作保护是否开启 0 未开启 1 已开启
        /// </summary>
        [JsonProperty("ActionFlag")]
        public long? ActionFlag{ get; set; }

        /// <summary>
        /// 登录保护是否开启 0 未开启 1 已开启
        /// </summary>
        [JsonProperty("LoginFlag")]
        public long? LoginFlag{ get; set; }

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
            this.SetParamObj(map, prefix + "RiskInfo.", this.RiskInfo);
            this.SetParamSimple(map, prefix + "CamCount", this.CamCount);
            this.SetParamSimple(map, prefix + "AlarmCount", this.AlarmCount);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamArrayObj(map, prefix + "AccessKeyAlarmCount.", this.AccessKeyAlarmCount);
            this.SetParamSimple(map, prefix + "ActionFlag", this.ActionFlag);
            this.SetParamSimple(map, prefix + "LoginFlag", this.LoginFlag);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

