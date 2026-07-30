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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBlueprintBundlesRequest : AbstractModel
    {
        
        /// <summary>
        /// 镜像ID。可以通过[DescribeBlueprints](https://cloud.tencent.com/document/product/1207/47689)接口返回的BlueprintId获取。当前仅支持传入镜像类型为游戏专区(“GAME_PORTAL”)的镜像Id。
        /// </summary>
        [JsonProperty("BlueprintId")]
        public string BlueprintId{ get; set; }

        /// <summary>
        /// 套餐ID列表。可以通过DescribeBlueprintBundles接口返回的BundleId获取。
        /// </summary>
        [JsonProperty("BundleIds")]
        public string[] BundleIds{ get; set; }

        /// <summary>
        /// 返回数量，默认为 20，最大值为 100。关于Limit的更进一步介绍请参考 API 简介中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为 0。关于Offset的更进一步介绍请参考 API 简介中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlueprintId", this.BlueprintId);
            this.SetParamArraySimple(map, prefix + "BundleIds.", this.BundleIds);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

