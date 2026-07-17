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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceResourceConfigForModify : AbstractModel
    {
        
        /// <summary>
        /// 扩容缩容的方式。取值有：<li>Auto：根据请求量自动调整实例数量；</li><li>Manual：人工设置固定的实例数量。</li>
        /// </summary>
        [JsonProperty("ScalingMode")]
        public string ScalingMode{ get; set; }

        /// <summary>
        /// 推理服务自动伸缩配置。当 ScalingMode 为 Auto 时必填。
        /// </summary>
        [JsonProperty("AutoScalingConfig")]
        public InferenceAutoScalingConfig AutoScalingConfig{ get; set; }

        /// <summary>
        /// 推理服务人工设置实例配置。当 ScalingMode 为 Manual 时必填。
        /// </summary>
        [JsonProperty("ManualInstanceConfig")]
        public InferenceManualInstanceConfig ManualInstanceConfig{ get; set; }

        /// <summary>
        /// 单实例的并发数。默认值为 1。
        /// </summary>
        [JsonProperty("Concurrency")]
        public long? Concurrency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScalingMode", this.ScalingMode);
            this.SetParamObj(map, prefix + "AutoScalingConfig.", this.AutoScalingConfig);
            this.SetParamObj(map, prefix + "ManualInstanceConfig.", this.ManualInstanceConfig);
            this.SetParamSimple(map, prefix + "Concurrency", this.Concurrency);
        }
    }
}

