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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportLicenseDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 多个条件筛选时 LicenseStatus,DeadlineStatus,ResourceId,Keywords 取交集
        /// <li> LicenseType  授权类型, 0 专业版-按量计费, 1专业版-包年包月 , 2 旗舰版-包年包月</li>
        /// <li>ResourceId 资源ID</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// 是否导出全部授权详情
        /// </summary>
        [JsonProperty("IsHistory")]
        public bool? IsHistory{ get; set; }

        /// <summary>
        /// 标签筛选,平台标签能力,这里传入 标签键,标签值作为一个对象
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// 导出月份, 该参数仅在IsHistory 时可选.
        /// </summary>
        [JsonProperty("ExportMonth")]
        public string ExportMonth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "IsHistory", this.IsHistory);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ExportMonth", this.ExportMonth);
        }
    }
}

