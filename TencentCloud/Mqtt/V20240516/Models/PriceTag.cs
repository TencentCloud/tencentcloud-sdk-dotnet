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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PriceTag : AbstractModel
    {
        
        /// <summary>
        /// 计价名称，表示规格的计费项项目分类，具体规格的计价名称可参考  [获取MQTT产品售卖规格](https://cloud.tencent.com/document/product/1778/116232) 接口的返回结果。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 计价类别，计价名称子类，具体规格的计价类别可参考  [获取MQTT产品售卖规格](https://cloud.tencent.com/document/product/1778/116232) 的返回结果。
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 计费项标签，为计价名称（Name）下计价类别（Category）的子项目，表示一个具体的收费项。规格的计费项标签可参考 
        ///  [获取MQTT产品售卖规格](https://cloud.tencent.com/document/product/1778/116232) 接口的返回结果。
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 计费步长，表示该规格在 计价名称（Name）下的计价类别（Category）的计费项标签（Code）计费数量。具体规格该字段取值参考 [获取MQTT产品售卖规格](https://cloud.tencent.com/document/product/1778/116232)
        /// </summary>
        [JsonProperty("Step")]
        public long? Step{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Step", this.Step);
        }
    }
}

