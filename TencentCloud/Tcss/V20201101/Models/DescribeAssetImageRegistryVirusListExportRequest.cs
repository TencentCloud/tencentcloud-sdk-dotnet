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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAssetImageRegistryVirusListExportRequest : AbstractModel
    {
        
        /// <summary>
        /// 导出字段
        /// </summary>
        [JsonProperty("ExportField")]
        public string[] ExportField{ get; set; }

        /// <summary>
        /// 需要返回的数量，默认为10，最大值为100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 过滤条件。
        /// <li>Level- String - 是否必填：否 - 漏洞级别筛选，</li>
        /// <li>Name - String - 是否必填：否 - 漏洞名称</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AssetFilters[] Filters{ get; set; }

        /// <summary>
        /// 镜像信息
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// 镜像标识Id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ExportField.", this.ExportField);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

