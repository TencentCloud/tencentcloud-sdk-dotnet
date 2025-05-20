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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHpcClustersRequest : AbstractModel
    {
        
        /// <summary>
        /// 一个或多个待操作的高性能计算集群ID。集群ID信息可通过 [查询高性能集群信息](https://cloud.tencent.com/document/api/213/83220) 接口获取。每次请求高性能计算集群信息的批量上限为100，默认配合Limit传参数，不能超过Limit值，Limit默认20。
        /// </summary>
        [JsonProperty("HpcClusterIds")]
        public string[] HpcClusterIds{ get; set; }

        /// <summary>
        /// 高性能计算集群名称，长度限制[1-60]。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 可用区信息。可用区信息可通过 [查询可用区信息](https://cloud.tencent.com/document/api/213/15707) 接口获取。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 偏移量, 默认值0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 本次请求量, 默认值20，范围限制为[1-100]。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 高性能计算集群类型，当前有三个取值：分别是CDC/CHC/STANDARD，其中STANDARD是默认的标准模式。
        /// </summary>
        [JsonProperty("HpcClusterType")]
        public string HpcClusterType{ get; set; }

        /// <summary>
        /// 高性能计算集群对应的业务场景标识，当前只支持CDC场景类型。	
        /// </summary>
        [JsonProperty("HpcClusterBusinessId")]
        public string HpcClusterBusinessId{ get; set; }

        /// <summary>
        /// 高性能计算集群实例类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <li><strong>tag-key</strong></li> <p style="padding-left: 30px;">按照【<strong>标签键</strong>】进行过滤。</p><p style="padding-left: 30px;">类型：String</p><p style="padding-left: 30px;">必选：否</p> <li><strong>tag-value</strong></li> <p style="padding-left: 30px;">按照【<strong>标签值</strong>】进行过滤。</p><p style="padding-left: 30px;">类型：String</p><p style="padding-left: 30px;">必选：否</p> <li><strong>tag:tag-key</strong></li> <p style="padding-left: 30px;">按照【<strong>标签键值对</strong>】进行过滤。tag-key使用具体的标签键进行替换。</p><p style="padding-left: 30px;">类型：String</p><p style="padding-left: 30px;">必选：否</p> 每次请求的`Filters`的上限为10，`Filter.Values`的上限为5。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "HpcClusterIds.", this.HpcClusterIds);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "HpcClusterType", this.HpcClusterType);
            this.SetParamSimple(map, prefix + "HpcClusterBusinessId", this.HpcClusterBusinessId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

