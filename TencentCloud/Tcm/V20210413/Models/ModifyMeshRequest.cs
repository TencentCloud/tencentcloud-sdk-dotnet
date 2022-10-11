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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyMeshRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要修改的网格Id
        /// </summary>
        [JsonProperty("MeshId")]
        public string MeshId{ get; set; }

        /// <summary>
        /// 修改的网格名称
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 修改的网格配置
        /// </summary>
        [JsonProperty("Config")]
        public MeshConfig Config{ get; set; }

        /// <summary>
        /// 修改的集群配置
        /// </summary>
        [JsonProperty("ClusterList")]
        public Cluster[] ClusterList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MeshId", this.MeshId);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamArrayObj(map, prefix + "ClusterList.", this.ClusterList);
        }
    }
}

