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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeTask : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 组件名称
        /// </summary>
        [JsonProperty("Component")]
        public string Component{ get; set; }

        /// <summary>
        /// 关联资源
        /// </summary>
        [JsonProperty("RelatedResources")]
        public string[] RelatedResources{ get; set; }

        /// <summary>
        /// 升级影响
        /// </summary>
        [JsonProperty("UpgradeImpact")]
        public string UpgradeImpact{ get; set; }

        /// <summary>
        /// 预计开始时间
        /// </summary>
        [JsonProperty("PlanedStartAt")]
        public string PlanedStartAt{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamArraySimple(map, prefix + "RelatedResources.", this.RelatedResources);
            this.SetParamSimple(map, prefix + "UpgradeImpact", this.UpgradeImpact);
            this.SetParamSimple(map, prefix + "PlanedStartAt", this.PlanedStartAt);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
        }
    }
}

