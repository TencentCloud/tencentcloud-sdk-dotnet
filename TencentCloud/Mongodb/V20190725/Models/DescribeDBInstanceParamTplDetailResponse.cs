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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstanceParamTplDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 枚举类参数详情列表。
        /// </summary>
        [JsonProperty("InstanceEnumParams")]
        public InstanceEnumParam[] InstanceEnumParams{ get; set; }

        /// <summary>
        /// 整形参数详情列表。
        /// </summary>
        [JsonProperty("InstanceIntegerParams")]
        public InstanceIntegerParam[] InstanceIntegerParams{ get; set; }

        /// <summary>
        /// 文本参数详情列表。
        /// </summary>
        [JsonProperty("InstanceTextParams")]
        public InstanceTextParam[] InstanceTextParams{ get; set; }

        /// <summary>
        /// 多值参数详情列表。
        /// </summary>
        [JsonProperty("InstanceMultiParams")]
        public InstanceMultiParam[] InstanceMultiParams{ get; set; }

        /// <summary>
        /// 参数总个数。
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 模板适配的实例版本。
        /// - MONGO_36_WT：MongoDB 3.6 WiredTiger存储引擎版本，
        /// - MONGO_40_WT：MongoDB 4.0 WiredTiger存储引擎版本，
        /// - MONGO_42_WT：MongoDB 4.2 WiredTiger存储引擎版本。
        /// - MONGO_44_WT：MongoDB 4.4 WiredTiger存储引擎版本。
        /// - MONGO_50_WT：MongoDB 5.0 WiredTiger存储引擎版本。
        /// - MONGO_60_WT：MongoDB 6.0 WiredTiger存储引擎版本。
        /// - MONGO_70_WT：MongoDB 7.0 WiredTiger存储引擎版本。
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// 模板适配集群类型。
        /// - REPLSET：副本集实例。
        /// - SHARD：分片实例。
        /// - STANDALONE：单节点实例。
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 参数模板名称。
        /// </summary>
        [JsonProperty("TplName")]
        public string TplName{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "InstanceEnumParams.", this.InstanceEnumParams);
            this.SetParamArrayObj(map, prefix + "InstanceIntegerParams.", this.InstanceIntegerParams);
            this.SetParamArrayObj(map, prefix + "InstanceTextParams.", this.InstanceTextParams);
            this.SetParamArrayObj(map, prefix + "InstanceMultiParams.", this.InstanceMultiParams);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "MongoVersion", this.MongoVersion);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "TplName", this.TplName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

