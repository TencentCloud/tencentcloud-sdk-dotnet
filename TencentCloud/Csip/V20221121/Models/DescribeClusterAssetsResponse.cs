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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterAssetsResponse : AbstractModel
    {
        
        /// <summary>
        /// 列表
        /// </summary>
        [JsonProperty("Data")]
        public AssetCluster[] Data{ get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 集群类型枚举
        /// </summary>
        [JsonProperty("ClusterTypeList")]
        public FilterDataObject[] ClusterTypeList{ get; set; }

        /// <summary>
        /// 集群状态枚举
        /// </summary>
        [JsonProperty("ClusterStatusList")]
        public FilterDataObject[] ClusterStatusList{ get; set; }

        /// <summary>
        /// 组件状态枚举
        /// </summary>
        [JsonProperty("ComponentStatusList")]
        public FilterDataObject[] ComponentStatusList{ get; set; }

        /// <summary>
        /// 私有网络枚举
        /// </summary>
        [JsonProperty("VpcList")]
        public FilterDataObject[] VpcList{ get; set; }

        /// <summary>
        /// 地域枚举
        /// </summary>
        [JsonProperty("RegionList")]
        public FilterDataObject[] RegionList{ get; set; }

        /// <summary>
        /// 租户枚举
        /// </summary>
        [JsonProperty("AppIdList")]
        public FilterDataObject[] AppIdList{ get; set; }

        /// <summary>
        /// 集群防护状态枚举
        /// </summary>
        [JsonProperty("ProtectStatusList")]
        public FilterDataObject[] ProtectStatusList{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "ClusterTypeList.", this.ClusterTypeList);
            this.SetParamArrayObj(map, prefix + "ClusterStatusList.", this.ClusterStatusList);
            this.SetParamArrayObj(map, prefix + "ComponentStatusList.", this.ComponentStatusList);
            this.SetParamArrayObj(map, prefix + "VpcList.", this.VpcList);
            this.SetParamArrayObj(map, prefix + "RegionList.", this.RegionList);
            this.SetParamArrayObj(map, prefix + "AppIdList.", this.AppIdList);
            this.SetParamArrayObj(map, prefix + "ProtectStatusList.", this.ProtectStatusList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

