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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Concurrency : AbstractModel
    {
        
        /// <summary>
        /// 多阶段配置数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Stages")]
        public Stage[] Stages{ get; set; }

        /// <summary>
        /// 运行次数
        /// </summary>
        [JsonProperty("IterationCount")]
        public long? IterationCount{ get; set; }

        /// <summary>
        /// 最大RPS
        /// </summary>
        [JsonProperty("MaxRequestsPerSecond")]
        public long? MaxRequestsPerSecond{ get; set; }

        /// <summary>
        /// 优雅终止任务的等待时间
        /// </summary>
        [JsonProperty("GracefulStopSeconds")]
        public long? GracefulStopSeconds{ get; set; }

        /// <summary>
        /// 资源数
        /// </summary>
        [JsonProperty("Resources")]
        public long? Resources{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Stages.", this.Stages);
            this.SetParamSimple(map, prefix + "IterationCount", this.IterationCount);
            this.SetParamSimple(map, prefix + "MaxRequestsPerSecond", this.MaxRequestsPerSecond);
            this.SetParamSimple(map, prefix + "GracefulStopSeconds", this.GracefulStopSeconds);
            this.SetParamSimple(map, prefix + "Resources", this.Resources);
        }
    }
}

