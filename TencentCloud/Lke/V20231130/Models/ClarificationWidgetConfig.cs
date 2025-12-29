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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClarificationWidgetConfig : AbstractModel
    {
        
        /// <summary>
        /// widget id
        /// </summary>
        [JsonProperty("WidgetId")]
        public string WidgetId{ get; set; }

        /// <summary>
        /// 澄清widget类型
        /// </summary>
        [JsonProperty("ClarificationWidgetType")]
        public long? ClarificationWidgetType{ get; set; }

        /// <summary>
        /// Widget名称
        /// </summary>
        [JsonProperty("WidgetName")]
        public string WidgetName{ get; set; }

        /// <summary>
        /// Widget预览
        /// </summary>
        [JsonProperty("WidgetPreview")]
        public string WidgetPreview{ get; set; }

        /// <summary>
        /// 是否启用该Widget作为澄清样式
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WidgetId", this.WidgetId);
            this.SetParamSimple(map, prefix + "ClarificationWidgetType", this.ClarificationWidgetType);
            this.SetParamSimple(map, prefix + "WidgetName", this.WidgetName);
            this.SetParamSimple(map, prefix + "WidgetPreview", this.WidgetPreview);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

