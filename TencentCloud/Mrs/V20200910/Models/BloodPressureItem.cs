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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BloodPressureItem : AbstractModel
    {
        
        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 项目原文
        /// </summary>
        [JsonProperty("Item")]
        public PhysicalBaseItem Item{ get; set; }

        /// <summary>
        /// 数值
        /// </summary>
        [JsonProperty("Result")]
        public PhysicalBaseItem Result{ get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("Unit")]
        public PhysicalBaseItem Unit{ get; set; }

        /// <summary>
        /// 第几次
        /// </summary>
        [JsonProperty("Times")]
        public PhysicalBaseItem Times{ get; set; }

        /// <summary>
        /// 左右手臂
        /// </summary>
        [JsonProperty("Location")]
        public PhysicalBaseItem Location{ get; set; }

        /// <summary>
        /// 数据在原PDF文件中的第几页
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Item.", this.Item);
            this.SetParamObj(map, prefix + "Result.", this.Result);
            this.SetParamObj(map, prefix + "Unit.", this.Unit);
            this.SetParamObj(map, prefix + "Times.", this.Times);
            this.SetParamObj(map, prefix + "Location.", this.Location);
            this.SetParamSimple(map, prefix + "Page", this.Page);
        }
    }
}

