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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppAuxiliaryInfo : AbstractModel
    {
        
        /// <summary>
        /// 申诉信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Appeal")]
        public AppAppeal Appeal{ get; set; }

        /// <summary>
        /// 搜索资源状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SearchResourceStatus")]
        public SearchResourceStatusInfo SearchResourceStatus{ get; set; }

        /// <summary>
        /// 特殊状态信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecialStatusInfo")]
        public SpecialStatusInfo SpecialStatusInfo{ get; set; }

        /// <summary>
        /// 子状态信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubStatus")]
        public AppSubStatusInfo SubStatus{ get; set; }

        /// <summary>
        /// 模版中心同步信息(私有化独有)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplatePublish")]
        public TemplatePublishInfo TemplatePublish{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Appeal.", this.Appeal);
            this.SetParamObj(map, prefix + "SearchResourceStatus.", this.SearchResourceStatus);
            this.SetParamObj(map, prefix + "SpecialStatusInfo.", this.SpecialStatusInfo);
            this.SetParamObj(map, prefix + "SubStatus.", this.SubStatus);
            this.SetParamObj(map, prefix + "TemplatePublish.", this.TemplatePublish);
        }
    }
}

