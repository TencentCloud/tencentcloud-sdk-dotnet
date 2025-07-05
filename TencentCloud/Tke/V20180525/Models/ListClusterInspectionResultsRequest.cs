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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListClusterInspectionResultsRequest : AbstractModel
    {
        
        /// <summary>
        /// 目标集群列表，为空查询用户所有集群
        /// </summary>
        [JsonProperty("ClusterIds")]
        public string[] ClusterIds{ get; set; }

        /// <summary>
        /// 隐藏的字段信息，为了减少无效的字段返回，隐藏字段不会在返回值中返回。可选值：results
        /// </summary>
        [JsonProperty("Hide")]
        public string[] Hide{ get; set; }

        /// <summary>
        /// 指定查询结果的报告名称，默认查询最新的每个集群只查询最新的一条
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ClusterIds.", this.ClusterIds);
            this.SetParamArraySimple(map, prefix + "Hide.", this.Hide);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

