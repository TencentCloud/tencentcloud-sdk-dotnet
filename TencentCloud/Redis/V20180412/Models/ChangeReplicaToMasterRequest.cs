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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChangeReplicaToMasterRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>指定实例 ID。例如：crs-xjhsdj****。请登录<a href="https://console.cloud.tencent.com/redis">Redis控制台</a>在实例列表复制实例 ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>副本节点组 ID，请通过接口<a href="https://cloud.tencent.com/document/product/239/50312">DescribeInstanceZoneInfo</a>获取多 AZ备节点组的 ID 信息。单 AZ，则无需配置该参数。</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// <p>紧急模式。</p><p>枚举值：</p><ul><li>false： 标准模式（安全推荐）</li><li>true： 极速模式：（高危加速）跳过校验、极速提主。高位操作，极易在异常情况下产生单主节点。</li></ul><p>默认值：false</p>
        /// </summary>
        [JsonProperty("Emergency")]
        public bool? Emergency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Emergency", this.Emergency);
        }
    }
}

