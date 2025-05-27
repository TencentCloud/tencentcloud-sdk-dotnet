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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyServerlessStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// serverless集群id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群是否自动暂停，可选范围
        /// <li>yes</li>
        /// <li>no</li>
        /// </summary>
        [JsonProperty("AutoPause")]
        public string AutoPause{ get; set; }

        /// <summary>
        /// 集群自动暂停的延迟，单位秒，可选范围[600,691200]，默认600
        /// </summary>
        [JsonProperty("AutoPauseDelay")]
        public long? AutoPauseDelay{ get; set; }

        /// <summary>
        /// 该参数暂时无效
        /// </summary>
        [JsonProperty("AutoScaleUpDelay")]
        public long? AutoScaleUpDelay{ get; set; }

        /// <summary>
        /// 该参数暂时无效
        /// </summary>
        [JsonProperty("AutoScaleDownDelay")]
        public long? AutoScaleDownDelay{ get; set; }

        /// <summary>
        /// cpu最小值，可选范围参考DescribeServerlessInstanceSpecs接口返回
        /// </summary>
        [JsonProperty("MinCpu")]
        public float? MinCpu{ get; set; }

        /// <summary>
        /// cpu最大值，可选范围参考DescribeServerlessInstanceSpecs接口返回
        /// </summary>
        [JsonProperty("MaxCpu")]
        public float? MaxCpu{ get; set; }

        /// <summary>
        /// 只读实例cpu最小值，可选范围参考DescribeServerlessInstanceSpecs接口返回
        /// </summary>
        [JsonProperty("MinRoCpu")]
        public float? MinRoCpu{ get; set; }

        /// <summary>
        /// 只读cpu最大值，可选范围参考DescribeServerlessInstanceSpecs接口返回
        /// </summary>
        [JsonProperty("MaxRoCpu")]
        public float? MaxRoCpu{ get; set; }

        /// <summary>
        /// 只读节点最小个数
        /// </summary>
        [JsonProperty("MinRoCount")]
        public long? MinRoCount{ get; set; }

        /// <summary>
        /// 只读节点最大个数
        /// </summary>
        [JsonProperty("MaxRoCount")]
        public long? MaxRoCount{ get; set; }

        /// <summary>
        /// 是否开启归档，可选范围<li>yes</li><li>no</li>默认值:yes
        /// </summary>
        [JsonProperty("AutoArchive")]
        public string AutoArchive{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "AutoPause", this.AutoPause);
            this.SetParamSimple(map, prefix + "AutoPauseDelay", this.AutoPauseDelay);
            this.SetParamSimple(map, prefix + "AutoScaleUpDelay", this.AutoScaleUpDelay);
            this.SetParamSimple(map, prefix + "AutoScaleDownDelay", this.AutoScaleDownDelay);
            this.SetParamSimple(map, prefix + "MinCpu", this.MinCpu);
            this.SetParamSimple(map, prefix + "MaxCpu", this.MaxCpu);
            this.SetParamSimple(map, prefix + "MinRoCpu", this.MinRoCpu);
            this.SetParamSimple(map, prefix + "MaxRoCpu", this.MaxRoCpu);
            this.SetParamSimple(map, prefix + "MinRoCount", this.MinRoCount);
            this.SetParamSimple(map, prefix + "MaxRoCount", this.MaxRoCount);
            this.SetParamSimple(map, prefix + "AutoArchive", this.AutoArchive);
        }
    }
}

