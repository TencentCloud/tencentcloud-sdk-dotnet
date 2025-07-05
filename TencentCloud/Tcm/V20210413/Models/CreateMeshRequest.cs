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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMeshRequest : AbstractModel
    {
        
        /// <summary>
        /// Mesh名称
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// Mesh版本
        /// </summary>
        [JsonProperty("MeshVersion")]
        public string MeshVersion{ get; set; }

        /// <summary>
        /// Mesh类型，取值范围：
        /// - HOSTED：托管网格
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Mesh配置
        /// </summary>
        [JsonProperty("Config")]
        public MeshConfig Config{ get; set; }

        /// <summary>
        /// 关联集群
        /// </summary>
        [JsonProperty("ClusterList")]
        public Cluster[] ClusterList{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "MeshVersion", this.MeshVersion);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamArrayObj(map, prefix + "ClusterList.", this.ClusterList);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
        }
    }
}

