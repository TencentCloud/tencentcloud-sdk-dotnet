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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScalableRule : AbstractModel
    {
        
        /// <summary>
        /// RuleId值
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Name值
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// ExpandVmCountLimit值
        /// </summary>
        [JsonProperty("ExpandVmCountLimit")]
        public long? ExpandVmCountLimit{ get; set; }

        /// <summary>
        /// ShrinkVmCountLimit值
        /// </summary>
        [JsonProperty("ShrinkVmCountLimit")]
        public long? ShrinkVmCountLimit{ get; set; }

        /// <summary>
        /// GroupCount值
        /// </summary>
        [JsonProperty("GroupCount")]
        public long? GroupCount{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 是否关闭指标伸缩, 默认0, 0:打开指标伸缩 1:关闭指标伸缩
        /// </summary>
        [JsonProperty("DisableMetricAS")]
        public ulong? DisableMetricAS{ get; set; }

        /// <summary>
        /// 开启定时伸缩规则, 默认0, 0:关闭定时伸缩 1:开启定时伸缩
        /// </summary>
        [JsonProperty("EnableCronAS")]
        public ulong? EnableCronAS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ExpandVmCountLimit", this.ExpandVmCountLimit);
            this.SetParamSimple(map, prefix + "ShrinkVmCountLimit", this.ShrinkVmCountLimit);
            this.SetParamSimple(map, prefix + "GroupCount", this.GroupCount);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DisableMetricAS", this.DisableMetricAS);
            this.SetParamSimple(map, prefix + "EnableCronAS", this.EnableCronAS);
        }
    }
}

