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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDedicatedClustersRequest : AbstractModel
    {
        
        /// <summary>
        /// 按照一个或者多个实例ID查询。实例ID形如：`cluster-xxxxxxxx`
        /// </summary>
        [JsonProperty("DedicatedClusterIds")]
        public string[] DedicatedClusterIds{ get; set; }

        /// <summary>
        /// 按照可用区名称过滤
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// 按照站点id过滤
        /// </summary>
        [JsonProperty("SiteIds")]
        public string[] SiteIds{ get; set; }

        /// <summary>
        /// 按照专用集群生命周期过滤
        /// </summary>
        [JsonProperty("LifecycleStatuses")]
        public string[] LifecycleStatuses{ get; set; }

        /// <summary>
        /// 模糊匹配专用集群名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于`Offset`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。关于`Limit`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DedicatedClusterIds.", this.DedicatedClusterIds);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamArraySimple(map, prefix + "SiteIds.", this.SiteIds);
            this.SetParamArraySimple(map, prefix + "LifecycleStatuses.", this.LifecycleStatuses);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

