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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLivePackageInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 套餐包信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LivePackageInfoList")]
        public LivePackageInfo[] LivePackageInfoList{ get; set; }

        /// <summary>
        /// 套餐包当前计费方式:
        /// -1: 无计费方式或获取失败
        /// 0: 无计费方式
        /// 201: 月结带宽
        /// 202: 月结流量
        /// 203: 日结带宽
        /// 204: 日结流量
        /// 205: 日结时长
        /// 206: 月结时长
        /// 304: 日结流量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageBillMode")]
        public long? PackageBillMode{ get; set; }

        /// <summary>
        /// 总页数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalPage")]
        public long? TotalPage{ get; set; }

        /// <summary>
        /// 数据总条数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalNum")]
        public long? TotalNum{ get; set; }

        /// <summary>
        /// 当前页数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PageNum")]
        public long? PageNum{ get; set; }

        /// <summary>
        /// 当前每页数量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 当请求参数 PackageType = 0 时生效，逗号分隔，从第一个到最后一个分别表示：
        /// 标准直播，中国大陆（境内全地区）计费方式。
        /// 标准直播，国际/港澳台（境外多地区）计费方式。
        /// 快直播，中国大陆（境内全地区）计费方式。
        /// 快直播，国际/港澳台（境外多地区）计费方式。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FluxPackageBillMode")]
        public string FluxPackageBillMode{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "LivePackageInfoList.", this.LivePackageInfoList);
            this.SetParamSimple(map, prefix + "PackageBillMode", this.PackageBillMode);
            this.SetParamSimple(map, prefix + "TotalPage", this.TotalPage);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "FluxPackageBillMode", this.FluxPackageBillMode);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

