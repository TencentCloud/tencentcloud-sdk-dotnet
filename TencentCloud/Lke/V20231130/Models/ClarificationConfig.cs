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

    public class ClarificationConfig : AbstractModel
    {
        
        /// <summary>
        /// 输出类型，1-文本 3-widget
        /// </summary>
        [JsonProperty("OutputType")]
        public long? OutputType{ get; set; }

        /// <summary>
        /// 澄清widget配置
        /// </summary>
        [JsonProperty("WidgetConfigs")]
        public ClarificationWidgetConfig[] WidgetConfigs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputType", this.OutputType);
            this.SetParamArrayObj(map, prefix + "WidgetConfigs.", this.WidgetConfigs);
        }
    }
}

