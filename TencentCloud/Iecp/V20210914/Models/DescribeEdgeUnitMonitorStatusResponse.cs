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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEdgeUnitMonitorStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 监控状态描述：
        /// "running" 单元监控正常运行
        /// "deploying" 单元监控部署中
        /// "norsc" 单元需要可用节点以部署监控
        /// "abnormal" 单元监控异常
        /// "none" 单元监控不可用
        /// </summary>
        [JsonProperty("MonitorStatus")]
        public string MonitorStatus{ get; set; }

        /// <summary>
        /// 监控是否就绪
        /// </summary>
        [JsonProperty("IsAvailable")]
        public bool? IsAvailable{ get; set; }

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
            this.SetParamSimple(map, prefix + "MonitorStatus", this.MonitorStatus);
            this.SetParamSimple(map, prefix + "IsAvailable", this.IsAvailable);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

