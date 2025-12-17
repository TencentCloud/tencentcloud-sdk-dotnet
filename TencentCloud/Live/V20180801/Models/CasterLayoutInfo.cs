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

    public class CasterLayoutInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>布局Index。</p>取值范围：[1, 1000]
        /// </summary>
        [JsonProperty("LayoutIndex")]
        public long? LayoutIndex{ get; set; }

        /// <summary>
        /// <p>布局模板Id。有效值[1，20，21，31，32，41]当使用布局模板时，无需LayoutParams参数，导播台将使用模板布局参数。</p>
        /// </summary>
        [JsonProperty("LayoutTemplateId")]
        public long? LayoutTemplateId{ get; set; }

        /// <summary>
        /// <p>布局绑定的输入列表。按布局LayerId从小到大，按顺序排列。已有两个画面的布局为例，输入1对应LayerId为1，输入2对应的LayerId为2，该字段应该填入"1|2"。</p>
        /// </summary>
        [JsonProperty("InputIndexList")]
        public string InputIndexList{ get; set; }

        /// <summary>
        /// <p>详细的布局参数列表。</p>
        /// </summary>
        [JsonProperty("LayoutParams")]
        public CasterLayoutParam[] LayoutParams{ get; set; }

        /// <summary>
        /// <p>布局输出的宽度，单位为像素。默认为1280像素。注：该值仅在画中画布局，且未设置PgmWidth时生效。</p>
        /// </summary>
        [JsonProperty("LayoutWidth")]
        public ulong? LayoutWidth{ get; set; }

        /// <summary>
        /// <p>布局输出的高度，单位为像素。注：该参数仅在画中画布局，且未设置PgmHeight时生效。</p>
        /// </summary>
        [JsonProperty("LayoutHeight")]
        public ulong? LayoutHeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LayoutIndex", this.LayoutIndex);
            this.SetParamSimple(map, prefix + "LayoutTemplateId", this.LayoutTemplateId);
            this.SetParamSimple(map, prefix + "InputIndexList", this.InputIndexList);
            this.SetParamArrayObj(map, prefix + "LayoutParams.", this.LayoutParams);
            this.SetParamSimple(map, prefix + "LayoutWidth", this.LayoutWidth);
            this.SetParamSimple(map, prefix + "LayoutHeight", this.LayoutHeight);
        }
    }
}

