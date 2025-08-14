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

    public class DescribeDeliveryConfigsRequest : AbstractModel
    {
        
        /// <summary>
        /// 关键字
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 偏移
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 搜索条数
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 数据集ID列表
        /// 可通过调用[DescribePrograms](https://cloud.tencent.com/document/product/649/73477)查询已创建的数据集列表或登录[控制台](https://console.cloud.tencent.com/tsf/privilege?rid=1&tab=program&roleId=role-a22gwdwa)进行查看
        /// </summary>
        [JsonProperty("ProgramIdList")]
        public string[] ProgramIdList{ get; set; }

        /// <summary>
        /// 日志配置项ID列表
        /// 可通过调用[DescribeBusinessLogConfigs](https://cloud.tencent.com/document/product/649/75777)查询已创建的日志配置项列表或登录[控制台](https://console.cloud.tencent.com/tsf/observable/log?rid=1)进行查看
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
            this.SetParamArraySimple(map, prefix + "ProgramIdList.", this.ProgramIdList);
            this.SetParamArraySimple(map, prefix + "ConfigIdList.", this.ConfigIdList);
        }
    }
}

