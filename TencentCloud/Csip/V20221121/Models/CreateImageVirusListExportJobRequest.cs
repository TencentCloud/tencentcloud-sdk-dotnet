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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateImageVirusListExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>筛选项</p>
        /// </summary>
        [JsonProperty("Filter")]
        public Filter Filter{ get; set; }

        /// <summary>
        /// <p>是否保存到导出任务中</p><p>枚举值：</p><ul><li>0： 不保存</li><li>1： 保存</li></ul>
        /// </summary>
        [JsonProperty("Save")]
        public ulong? Save{ get; set; }

        /// <summary>
        /// <p>导出文件名</p>
        /// </summary>
        [JsonProperty("ExportName")]
        public string ExportName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamSimple(map, prefix + "Save", this.Save);
            this.SetParamSimple(map, prefix + "ExportName", this.ExportName);
        }
    }
}

