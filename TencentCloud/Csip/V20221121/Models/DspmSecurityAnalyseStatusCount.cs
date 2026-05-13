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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmSecurityAnalyseStatusCount : AbstractModel
    {
        
        /// <summary>
        /// 资产安全分析开启数
        /// </summary>
        [JsonProperty("OpenCount")]
        public long? OpenCount{ get; set; }

        /// <summary>
        /// 资产安全分析开启中数
        /// </summary>
        [JsonProperty("OpeningCount")]
        public long? OpeningCount{ get; set; }

        /// <summary>
        /// 资产安全分析关闭中数
        /// </summary>
        [JsonProperty("ClosingCount")]
        public long? ClosingCount{ get; set; }

        /// <summary>
        /// 资产安全分析未开启数
        /// </summary>
        [JsonProperty("CloseCount")]
        public long? CloseCount{ get; set; }

        /// <summary>
        /// 按照资产类型分组的资产安全分析状态统计数
        /// </summary>
        [JsonProperty("AssetTypeCountSet")]
        public DspmAssetTypeCount[] AssetTypeCountSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpenCount", this.OpenCount);
            this.SetParamSimple(map, prefix + "OpeningCount", this.OpeningCount);
            this.SetParamSimple(map, prefix + "ClosingCount", this.ClosingCount);
            this.SetParamSimple(map, prefix + "CloseCount", this.CloseCount);
            this.SetParamArrayObj(map, prefix + "AssetTypeCountSet.", this.AssetTypeCountSet);
        }
    }
}

