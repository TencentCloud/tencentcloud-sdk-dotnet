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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportResourcePackageDeductDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要导出的资源包ID
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 使用资源包容量的cynos集群ID
        /// </summary>
        [JsonProperty("ClusterIds")]
        public string[] ClusterIds{ get; set; }

        /// <summary>
        /// 排序字段，目前支持：createTime（资源包被抵扣时间），successDeductSpec（资源包抵扣量）
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 排序类型，支持ASC、DESC、asc、desc
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 单次最大导出数据行数，目前最大支持2000行
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }

        /// <summary>
        /// 偏移量页数
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }

        /// <summary>
        /// 导出数据格式，目前仅支持csv格式，留作扩展
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamArraySimple(map, prefix + "ClusterIds.", this.ClusterIds);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
        }
    }
}

