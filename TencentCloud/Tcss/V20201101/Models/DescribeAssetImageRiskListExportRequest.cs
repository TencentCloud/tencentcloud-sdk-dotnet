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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAssetImageRiskListExportRequest : AbstractModel
    {
        
        /// <summary>
        /// 导出字段
        /// </summary>
        [JsonProperty("ExportField")]
        public string[] ExportField{ get; set; }

        /// <summary>
        /// 镜像id
        /// </summary>
        [JsonProperty("ImageID")]
        public string ImageID{ get; set; }

        /// <summary>
        /// 过滤条件。
        /// <li>Level- String - 是否必填：否 - 风险级别 1,2,3,4，</li>
        /// <li>Behavior - String - 是否必填：否 - 风险行为 1,2,3,4</li>
        /// <li>Type - String - 是否必填：否 - 风险类型  1,2,</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AssetFilters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ExportField.", this.ExportField);
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

