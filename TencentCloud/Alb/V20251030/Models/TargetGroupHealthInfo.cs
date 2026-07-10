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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TargetGroupHealthInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否开启健康检查。
        /// </summary>
        [JsonProperty("HealthCheckEnabled")]
        public bool? HealthCheckEnabled{ get; set; }

        /// <summary>
        /// 目标组 ID，格式为 lbtg- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// 服务健康检查状态列表。
        /// </summary>
        [JsonProperty("TargetHealthStatusInfos")]
        public TargetHealthStatusInfo[] TargetHealthStatusInfos{ get; set; }

        /// <summary>
        /// 转发动作类型。取值：
        /// TargetGroup：转发至目标组。
        /// Redirect：重定向。
        /// FixedResponse：返回固定内容。
        /// Rewrite：重写。
        /// InsertHeader：写入HTTP Header。
        /// RemoveHeader：删除HTTP Header。
        /// 转发动作必选包含TargetGroup,Redirect,FixedResponse其中一个，并且执行顺序放在最后。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthCheckEnabled", this.HealthCheckEnabled);
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamArrayObj(map, prefix + "TargetHealthStatusInfos.", this.TargetHealthStatusInfos);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

