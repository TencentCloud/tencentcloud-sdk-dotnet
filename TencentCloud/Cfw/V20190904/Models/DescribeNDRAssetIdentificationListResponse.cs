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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNDRAssetIdentificationListResponse : AbstractModel
    {
        
        /// <summary>
        /// 符合查询条件的总条数
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// 查询结果列表
        /// </summary>
        [JsonProperty("Data")]
        public NDRAssetServiceInfo[] Data{ get; set; }

        /// <summary>
        /// 服务类型统计结果
        /// </summary>
        [JsonProperty("AssetCategoryStats")]
        public NDRAssetCategoryStats[] AssetCategoryStats{ get; set; }

        /// <summary>
        /// 地域可选项
        /// </summary>
        [JsonProperty("RegionOptions")]
        public FieldOption[] RegionOptions{ get; set; }

        /// <summary>
        /// IP版本可选项
        /// </summary>
        [JsonProperty("IpVersionOptions")]
        public FieldOption[] IpVersionOptions{ get; set; }

        /// <summary>
        /// IP类型可选项
        /// </summary>
        [JsonProperty("IpTypeOptions")]
        public FieldOption[] IpTypeOptions{ get; set; }

        /// <summary>
        /// 服务类型可选项
        /// </summary>
        [JsonProperty("AssetCategoryOptions")]
        public FieldOption[] AssetCategoryOptions{ get; set; }

        /// <summary>
        /// 识别来源可选项
        /// </summary>
        [JsonProperty("IdentificationSourceOptions")]
        public FieldOption[] IdentificationSourceOptions{ get; set; }

        /// <summary>
        /// 协议可选项
        /// </summary>
        [JsonProperty("ProtocolOptions")]
        public FieldOption[] ProtocolOptions{ get; set; }

        /// <summary>
        /// 实例类型可选项
        /// </summary>
        [JsonProperty("InstanceTypeOptions")]
        public FieldOption[] InstanceTypeOptions{ get; set; }

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
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamArrayObj(map, prefix + "AssetCategoryStats.", this.AssetCategoryStats);
            this.SetParamArrayObj(map, prefix + "RegionOptions.", this.RegionOptions);
            this.SetParamArrayObj(map, prefix + "IpVersionOptions.", this.IpVersionOptions);
            this.SetParamArrayObj(map, prefix + "IpTypeOptions.", this.IpTypeOptions);
            this.SetParamArrayObj(map, prefix + "AssetCategoryOptions.", this.AssetCategoryOptions);
            this.SetParamArrayObj(map, prefix + "IdentificationSourceOptions.", this.IdentificationSourceOptions);
            this.SetParamArrayObj(map, prefix + "ProtocolOptions.", this.ProtocolOptions);
            this.SetParamArrayObj(map, prefix + "InstanceTypeOptions.", this.InstanceTypeOptions);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

