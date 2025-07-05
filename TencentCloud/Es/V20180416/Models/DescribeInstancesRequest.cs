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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群实例所属可用区，不传则默认所有可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 集群实例ID列表
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 集群实例名称列表
        /// </summary>
        [JsonProperty("InstanceNames")]
        public string[] InstanceNames{ get; set; }

        /// <summary>
        /// 分页起始值, 默认值0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 分页大小，默认值20
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 排序字段<li>1：实例ID</li><li>2：实例名称</li><li>3：可用区</li><li>4：创建时间</li>若orderByKey未传递则按创建时间降序排序
        /// </summary>
        [JsonProperty("OrderByKey")]
        public ulong? OrderByKey{ get; set; }

        /// <summary>
        /// 排序方式<li>0：升序</li><li>1：降序</li>若传递了orderByKey未传递orderByType, 则默认升序
        /// </summary>
        [JsonProperty("OrderByType")]
        public ulong? OrderByType{ get; set; }

        /// <summary>
        /// 节点标签信息列表
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// 私有网络vip列表
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }

        /// <summary>
        /// 可用区列表
        /// </summary>
        [JsonProperty("ZoneList")]
        public string[] ZoneList{ get; set; }

        /// <summary>
        /// 健康状态筛列表:0表示绿色，1表示黄色，2表示红色,-1表示未知
        /// </summary>
        [JsonProperty("HealthStatus")]
        public long?[] HealthStatus{ get; set; }

        /// <summary>
        /// Vpc列表 筛选项
        /// </summary>
        [JsonProperty("VpcIds")]
        public string[] VpcIds{ get; set; }

        /// <summary>
        /// cdc集群id
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "InstanceNames.", this.InstanceNames);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderByKey", this.OrderByKey);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
            this.SetParamArraySimple(map, prefix + "ZoneList.", this.ZoneList);
            this.SetParamArraySimple(map, prefix + "HealthStatus.", this.HealthStatus);
            this.SetParamArraySimple(map, prefix + "VpcIds.", this.VpcIds);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
        }
    }
}

