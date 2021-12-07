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

    public class CreateExportComplianceStatusListJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 要导出信息的资产类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 按照检测项导出，还是按照资产导出。true: 按照资产导出；false: 按照检测项导出。
        /// </summary>
        [JsonProperty("ExportByAsset")]
        public bool? ExportByAsset{ get; set; }

        /// <summary>
        /// true, 全部导出；false, 根据IdList来导出数据。
        /// </summary>
        [JsonProperty("ExportAll")]
        public bool? ExportAll{ get; set; }

        /// <summary>
        /// 要导出的资产ID列表或检测项ID列表，由ExportByAsset的取值决定。
        /// </summary>
        [JsonProperty("IdList")]
        public ulong?[] IdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "ExportByAsset", this.ExportByAsset);
            this.SetParamSimple(map, prefix + "ExportAll", this.ExportAll);
            this.SetParamArraySimple(map, prefix + "IdList.", this.IdList);
        }
    }
}

