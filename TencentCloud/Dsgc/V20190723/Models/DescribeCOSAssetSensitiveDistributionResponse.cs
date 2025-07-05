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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCOSAssetSensitiveDistributionResponse : AbstractModel
    {
        
        /// <summary>
        /// cos的涉敏资产
        /// </summary>
        [JsonProperty("CosAsset")]
        public CosAsset CosAsset{ get; set; }

        /// <summary>
        /// 涉敏top
        /// </summary>
        [JsonProperty("TopAsset")]
        public TopAsset[] TopAsset{ get; set; }

        /// <summary>
        /// cos资产详情列表
        /// </summary>
        [JsonProperty("CosDetail")]
        public AssetCosDetail[] CosDetail{ get; set; }

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
            this.SetParamObj(map, prefix + "CosAsset.", this.CosAsset);
            this.SetParamArrayObj(map, prefix + "TopAsset.", this.TopAsset);
            this.SetParamArrayObj(map, prefix + "CosDetail.", this.CosDetail);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

