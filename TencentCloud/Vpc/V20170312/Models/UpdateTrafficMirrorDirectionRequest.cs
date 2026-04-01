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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateTrafficMirrorDirectionRequest : AbstractModel
    {
        
        /// <summary>
        /// 流量镜像实例ID
        /// </summary>
        [JsonProperty("TrafficMirrorId")]
        public string TrafficMirrorId{ get; set; }

        /// <summary>
        /// 流量镜像采集方向。取值范围：
        /// 
        /// - EGRESS - 出方向采集
        /// 
        /// - INGRESS - 入方向采集
        /// 
        /// - ALL - 出入双向采集
        /// 
        /// - NO-DIRECTION - 不区分采集方向（新模式）。切换为该模式后将不再支持按方向采集，需通过 CreateTrafficMirrorFilterRules 接口创建带方向的过滤规则，过滤规则支持设置优先级和单独编辑。
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrafficMirrorId", this.TrafficMirrorId);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
        }
    }
}

