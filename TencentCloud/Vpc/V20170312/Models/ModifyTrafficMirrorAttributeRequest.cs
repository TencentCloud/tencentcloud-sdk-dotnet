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

    public class ModifyTrafficMirrorAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 流量镜像实例ID
        /// </summary>
        [JsonProperty("TrafficMirrorId")]
        public string TrafficMirrorId{ get; set; }

        /// <summary>
        /// 流量镜像实例名称
        /// </summary>
        [JsonProperty("TrafficMirrorName")]
        public string TrafficMirrorName{ get; set; }

        /// <summary>
        /// 流量镜像实例描述信息
        /// </summary>
        [JsonProperty("TrafficMirrorDescription")]
        public string TrafficMirrorDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrafficMirrorId", this.TrafficMirrorId);
            this.SetParamSimple(map, prefix + "TrafficMirrorName", this.TrafficMirrorName);
            this.SetParamSimple(map, prefix + "TrafficMirrorDescription", this.TrafficMirrorDescription);
        }
    }
}

