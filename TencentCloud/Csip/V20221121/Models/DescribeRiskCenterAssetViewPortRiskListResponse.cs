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

    public class DescribeRiskCenterAssetViewPortRiskListResponse : AbstractModel
    {
        
        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 资产视角的配置风险列表
        /// </summary>
        [JsonProperty("Data")]
        public AssetViewPortRisk[] Data{ get; set; }

        /// <summary>
        /// 状态列表
        /// </summary>
        [JsonProperty("StatusLists")]
        public FilterDataObject[] StatusLists{ get; set; }

        /// <summary>
        /// 危险等级列表
        /// </summary>
        [JsonProperty("LevelLists")]
        public FilterDataObject[] LevelLists{ get; set; }

        /// <summary>
        /// 建议列表
        /// </summary>
        [JsonProperty("SuggestionLists")]
        public FilterDataObject[] SuggestionLists{ get; set; }

        /// <summary>
        /// 资产类型列表
        /// </summary>
        [JsonProperty("InstanceTypeLists")]
        public FilterDataObject[] InstanceTypeLists{ get; set; }

        /// <summary>
        /// 来源列表
        /// </summary>
        [JsonProperty("FromLists")]
        public FilterDataObject[] FromLists{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamArrayObj(map, prefix + "StatusLists.", this.StatusLists);
            this.SetParamArrayObj(map, prefix + "LevelLists.", this.LevelLists);
            this.SetParamArrayObj(map, prefix + "SuggestionLists.", this.SuggestionLists);
            this.SetParamArrayObj(map, prefix + "InstanceTypeLists.", this.InstanceTypeLists);
            this.SetParamArrayObj(map, prefix + "FromLists.", this.FromLists);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

