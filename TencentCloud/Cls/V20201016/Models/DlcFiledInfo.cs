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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DlcFiledInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>cls日志中的字段名</p>
        /// </summary>
        [JsonProperty("ClsField")]
        public string ClsField{ get; set; }

        /// <summary>
        /// <p>数据湖计算服务表的列名</p>
        /// </summary>
        [JsonProperty("DlcField")]
        public string DlcField{ get; set; }

        /// <summary>
        /// <p>数据湖计算服务字段类型</p><p>枚举值：</p><ul><li>int|string|struct等： 参考 <a href="https://cloud.tencent.com/document/product/1342/53778#Column">DLC  cloumn中的Type 定义 </a></li></ul>
        /// </summary>
        [JsonProperty("DlcFieldType")]
        public string DlcFieldType{ get; set; }

        /// <summary>
        /// <p>解析失败填充字段</p>
        /// </summary>
        [JsonProperty("FillField")]
        public string FillField{ get; set; }

        /// <summary>
        /// <p>是否禁用</p>
        /// </summary>
        [JsonProperty("Disable")]
        public bool? Disable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClsField", this.ClsField);
            this.SetParamSimple(map, prefix + "DlcField", this.DlcField);
            this.SetParamSimple(map, prefix + "DlcFieldType", this.DlcFieldType);
            this.SetParamSimple(map, prefix + "FillField", this.FillField);
            this.SetParamSimple(map, prefix + "Disable", this.Disable);
        }
    }
}

