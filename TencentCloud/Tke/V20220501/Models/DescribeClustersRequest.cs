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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClustersRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID列表(为空时，
        /// 表示获取账号下所有集群)
        /// </summary>
        [JsonProperty("ClusterIds")]
        public string[] ClusterIds{ get; set; }

        /// <summary>
        /// 偏移量,默认0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 最大输出条数，默认20，最大为100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// ·  ClusterName
        ///     按照【集群名】进行过滤。
        ///     类型：String
        ///     必选：否
        /// 
        /// ·  ClusterType
        ///     按照【集群类型】进行过滤。
        ///     类型：String
        ///     必选：否
        /// 
        /// ·  ClusterStatus
        ///     按照【集群状态】进行过滤。
        ///     类型：String
        ///     必选：否
        /// 
        /// ·  Tags
        ///     按照【标签键值对】进行过滤。
        ///     类型：String
        ///     必选：否
        /// 
        /// ·  vpc-id
        ///     按照【VPC】进行过滤。
        ///     类型：String
        ///     必选：否
        /// 
        /// ·  tag-key
        ///     按照【标签键】进行过滤。
        ///     类型：String
        ///     必选：否
        /// 
        /// ·  tag-value
        ///     按照【标签值】进行过滤。
        ///     类型：String
        ///     必选：否
        /// 
        /// ·  tag:tag-key
        ///     按照【标签键值对】进行过滤。
        ///     类型：String
        ///     必选：否
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 集群类型，例如：MANAGED_CLUSTER
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ClusterIds.", this.ClusterIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
        }
    }
}

