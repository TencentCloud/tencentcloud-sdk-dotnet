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

    public class DescribePublicConfigSummaryRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询关键字，模糊查询：配置项名称，不传入时查询全量。
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为50。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 排序字段。
        /// - creation_time：按时间排序
        /// - config_name：按名称排序
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 排序顺序。
        /// - 0：升序
        /// - 1：降序
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// TAG标签资源值。
        /// </summary>
        [JsonProperty("ConfigTagList")]
        public string[] ConfigTagList{ get; set; }

        /// <summary>
        /// 忽略传参，业务预留字段。
        /// </summary>
        [JsonProperty("DisableProgramAuthCheck")]
        public bool? DisableProgramAuthCheck{ get; set; }

        /// <summary>
        /// 配置ID。该参数可以通过调用 [DescribePublicConfigs](https://cloud.tencent.com/document/product/649/38335) 的返回值中的 ConfigId 字段来获取或通过登录[控制台](https://console.cloud.tencent.com/tse/tsf-consul?subTab=public)配置详情-配置版本页查看；也可以调用[CreatePublicConfig](https://cloud.tencent.com/document/product/649/38347)创建新的配置。
        /// </summary>
        [JsonProperty("ConfigIdList")]
        public string[] ConfigIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamArraySimple(map, prefix + "ConfigTagList.", this.ConfigTagList);
            this.SetParamSimple(map, prefix + "DisableProgramAuthCheck", this.DisableProgramAuthCheck);
            this.SetParamArraySimple(map, prefix + "ConfigIdList.", this.ConfigIdList);
        }
    }
}

