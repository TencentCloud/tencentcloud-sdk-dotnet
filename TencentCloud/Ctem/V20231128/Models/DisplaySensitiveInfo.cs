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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisplaySensitiveInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>主键Id</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>类型</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>来源</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>值</p>
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// <p>公共字段</p>
        /// </summary>
        [JsonProperty("DisplayToolCommon")]
        public DisplayToolCommon DisplayToolCommon{ get; set; }

        /// <summary>
        /// <p>是否为云资产：0-非云资产 1-是云资产</p>
        /// </summary>
        [JsonProperty("IsCloudAsset")]
        public long? IsCloudAsset{ get; set; }

        /// <summary>
        /// <p>云资产是否下线：-1-已下线 0-正常</p>
        /// </summary>
        [JsonProperty("CloudAssetStatus")]
        public long? CloudAssetStatus{ get; set; }

        /// <summary>
        /// <p>聚合视角下该组真实子项总数；非聚合视角为 0</p>
        /// </summary>
        [JsonProperty("AggregationCount")]
        public long? AggregationCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamObj(map, prefix + "DisplayToolCommon.", this.DisplayToolCommon);
            this.SetParamSimple(map, prefix + "IsCloudAsset", this.IsCloudAsset);
            this.SetParamSimple(map, prefix + "CloudAssetStatus", this.CloudAssetStatus);
            this.SetParamSimple(map, prefix + "AggregationCount", this.AggregationCount);
        }
    }
}

