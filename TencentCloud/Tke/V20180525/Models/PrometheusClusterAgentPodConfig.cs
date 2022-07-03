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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrometheusClusterAgentPodConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否使用HostNetWork
        /// </summary>
        [JsonProperty("HostNet")]
        public bool? HostNet{ get; set; }

        /// <summary>
        /// 指定pod运行节点
        /// </summary>
        [JsonProperty("NodeSelector")]
        public Label[] NodeSelector{ get; set; }

        /// <summary>
        /// 容忍污点
        /// </summary>
        [JsonProperty("Tolerations")]
        public Toleration[] Tolerations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostNet", this.HostNet);
            this.SetParamArrayObj(map, prefix + "NodeSelector.", this.NodeSelector);
            this.SetParamArrayObj(map, prefix + "Tolerations.", this.Tolerations);
        }
    }
}

