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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QuotaGroupOverview : AbstractModel
    {
        
        /// <summary>
        /// <p>配额组关联的标签键值</p>
        /// </summary>
        [JsonProperty("Tag")]
        public Tag Tag{ get; set; }

        /// <summary>
        /// <p>配额组名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>配额组各资源维度的配额上限</p>
        /// </summary>
        [JsonProperty("Quota")]
        public QuotaResourceInfo Quota{ get; set; }

        /// <summary>
        /// <p>配额组各资源维度的当前用量</p>
        /// </summary>
        [JsonProperty("Usage")]
        public QuotaResourceInfo Usage{ get; set; }

        /// <summary>
        /// <p>创建时间</p><p>参数格式：RFC3339 格式</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>最后更新时间</p><p>参数格式：RFC3339 格式</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Quota.", this.Quota);
            this.SetParamObj(map, prefix + "Usage.", this.Usage);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

