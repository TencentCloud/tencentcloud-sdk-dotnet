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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeServerlessStrategyResponse : AbstractModel
    {
        
        /// <summary>
        /// cpu负载为 0 时持续多久（秒）发起自动暂停
        /// </summary>
        [JsonProperty("AutoPauseDelay")]
        public long? AutoPauseDelay{ get; set; }

        /// <summary>
        /// cpu负载超过当前规格核数时，持续多久（秒）发起自动扩容
        /// </summary>
        [JsonProperty("AutoScaleUpDelay")]
        public long? AutoScaleUpDelay{ get; set; }

        /// <summary>
        /// cpu 负载低于低一级规格核数时，持续多久（秒）发起自动缩容
        /// </summary>
        [JsonProperty("AutoScaleDownDelay")]
        public long? AutoScaleDownDelay{ get; set; }

        /// <summary>
        /// 是否自动暂停，可能值：
        /// yes
        /// no
        /// </summary>
        [JsonProperty("AutoPause")]
        public string AutoPause{ get; set; }

        /// <summary>
        /// 集群是否允许向上扩容，可选范围<li>yes</li><li>no</li>
        /// </summary>
        [JsonProperty("AutoScaleUp")]
        public string AutoScaleUp{ get; set; }

        /// <summary>
        /// 集群是否允许向下缩容，可选范围<li>yes</li><li>no</li>
        /// </summary>
        [JsonProperty("AutoScaleDown")]
        public string AutoScaleDown{ get; set; }

        /// <summary>
        /// 是否开启归档，可选范围<li>yes</li><li>no</li>默认值:yes
        /// </summary>
        [JsonProperty("AutoArchive")]
        public string AutoArchive{ get; set; }

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
            this.SetParamSimple(map, prefix + "AutoPauseDelay", this.AutoPauseDelay);
            this.SetParamSimple(map, prefix + "AutoScaleUpDelay", this.AutoScaleUpDelay);
            this.SetParamSimple(map, prefix + "AutoScaleDownDelay", this.AutoScaleDownDelay);
            this.SetParamSimple(map, prefix + "AutoPause", this.AutoPause);
            this.SetParamSimple(map, prefix + "AutoScaleUp", this.AutoScaleUp);
            this.SetParamSimple(map, prefix + "AutoScaleDown", this.AutoScaleDown);
            this.SetParamSimple(map, prefix + "AutoArchive", this.AutoArchive);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

