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

    public class DescribeNetAttackSettingResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>0 关闭网络攻击检测，1开启网络攻击检测</p>
        /// </summary>
        [JsonProperty("NetAttackEnable")]
        public long? NetAttackEnable{ get; set; }

        /// <summary>
        /// <p>0 新增告警事件默认待处理，1新增告警事件默认已处理，3新增告警事件默认忽略</p>
        /// </summary>
        [JsonProperty("NetAttackAlarmStatus")]
        public long? NetAttackAlarmStatus{ get; set; }

        /// <summary>
        /// <p>新增资产自动包含 0 不包含 1包含</p>
        /// </summary>
        [JsonProperty("AutoInclude")]
        public long? AutoInclude{ get; set; }

        /// <summary>
        /// <p>主机范围</p>
        /// </summary>
        [JsonProperty("CWPScope")]
        public long? CWPScope{ get; set; }

        /// <summary>
        /// <p>指定主机instance_id列表</p>
        /// </summary>
        [JsonProperty("InstanceIDs")]
        public string[] InstanceIDs{ get; set; }

        /// <summary>
        /// <p>排除主机instance_id列表</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIDs")]
        public string[] ExcludeInstanceIDs{ get; set; }

        /// <summary>
        /// <p>标签ID列表</p>
        /// </summary>
        [JsonProperty("TagIDs")]
        public string[] TagIDs{ get; set; }

        /// <summary>
        /// <p>容器范围</p>
        /// </summary>
        [JsonProperty("TCSSScope")]
        public long? TCSSScope{ get; set; }

        /// <summary>
        /// <p>指定集群ID列表</p>
        /// </summary>
        [JsonProperty("ClusterIDs")]
        public string[] ClusterIDs{ get; set; }

        /// <summary>
        /// <p>排除集群ID列表</p>
        /// </summary>
        [JsonProperty("ExcludeClusterIDs")]
        public string[] ExcludeClusterIDs{ get; set; }

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
            this.SetParamSimple(map, prefix + "NetAttackEnable", this.NetAttackEnable);
            this.SetParamSimple(map, prefix + "NetAttackAlarmStatus", this.NetAttackAlarmStatus);
            this.SetParamSimple(map, prefix + "AutoInclude", this.AutoInclude);
            this.SetParamSimple(map, prefix + "CWPScope", this.CWPScope);
            this.SetParamArraySimple(map, prefix + "InstanceIDs.", this.InstanceIDs);
            this.SetParamArraySimple(map, prefix + "ExcludeInstanceIDs.", this.ExcludeInstanceIDs);
            this.SetParamArraySimple(map, prefix + "TagIDs.", this.TagIDs);
            this.SetParamSimple(map, prefix + "TCSSScope", this.TCSSScope);
            this.SetParamArraySimple(map, prefix + "ClusterIDs.", this.ClusterIDs);
            this.SetParamArraySimple(map, prefix + "ExcludeClusterIDs.", this.ExcludeClusterIDs);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

