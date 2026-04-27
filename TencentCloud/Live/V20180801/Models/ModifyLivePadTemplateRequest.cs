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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLivePadTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模板id。</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public ulong? TemplateId{ get; set; }

        /// <summary>
        /// <p>垫片内容。</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>断流等待时间。<br>取值范围：0-30000。<br>单位：ms。</p>
        /// </summary>
        [JsonProperty("WaitDuration")]
        public ulong? WaitDuration{ get; set; }

        /// <summary>
        /// <p>最大垫片时长。<br>取值范围：0 - 正无穷。<br>单位：ms。</p>
        /// </summary>
        [JsonProperty("MaxDuration")]
        public ulong? MaxDuration{ get; set; }

        /// <summary>
        /// <p>模板名称。<br>长度上限：255字节。<br>仅支持中文、英文、数字、_、-。</p>
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// <p>描述信息。<br>长度上限：1024字节。<br>仅支持中文、英文、数字、_、-。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>垫片内容类型： 1：图片，2：视频。 默认值：1。</p>
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// <p>断流垫片触发条件</p><p>枚举值：</p><ul><li>0： 主动及异常断流</li><li>1： 异常断流</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("TriggerCondition")]
        public ulong? TriggerCondition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "WaitDuration", this.WaitDuration);
            this.SetParamSimple(map, prefix + "MaxDuration", this.MaxDuration);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TriggerCondition", this.TriggerCondition);
        }
    }
}

