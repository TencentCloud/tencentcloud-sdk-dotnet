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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeParamTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>指定查询的产品版本与架构。</p><ul><li>6：Redis 4.0 标准架构。</li><li>7：Redis 4.0 集群架构。</li><li>8：Redis 5.0 标准架构。</li><li>9：Redis 5.0 集群架构。</li><li>15：Redis 6.2 标准架构。</li><li>16：Redis 6.2 集群架构。</li><li>17：Redis 7.0 标准架构。</li><li>18：Redis 7.0 集群架构。</li><li>19：ValKey 8.0 标准架构。</li><li>20：ValKey 8.0 集群架构。</li></ul>
        /// </summary>
        [JsonProperty("ProductTypes")]
        public long?[] ProductTypes{ get; set; }

        /// <summary>
        /// <p>指定查询的参数模板名称。</p><ul><li>数据类型：字符串数组，最大长度限制为50。</li><li>获取方式：请通过 <a href="https://console.cloud.tencent.com/redis/templates">Redis 控制台的参数模版</a> 页面复制自定义模板或系统默认模板的模板名称。</li></ul>
        /// </summary>
        [JsonProperty("TemplateNames")]
        public string[] TemplateNames{ get; set; }

        /// <summary>
        /// <p>指定查询的参数模板 ID。</p><ul><li>数据类型：字符串数组，最大长度限制为50。</li><li>获取方式：请通过 <a href="https://console.cloud.tencent.com/redis/templates">Redis 控制台的参数模版</a> 页面复制自定义模板或系统默认模板的模板 ID。</li></ul>
        /// </summary>
        [JsonProperty("TemplateIds")]
        public string[] TemplateIds{ get; set; }

        /// <summary>
        /// <p>指定查询结果的分页大小，即每页返回的记录数量。</p><ul><li>取值范围：0～200。</li><li>默认值：200。</li></ul>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>分页偏移量，用于指定查询结果的起始位置。</p><ul><li>取值：必须为 Limit 的整数倍，默认值为 0。</li><li>计算公式：offset=limit*(页码-1)。</li></ul>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ProductTypes.", this.ProductTypes);
            this.SetParamArraySimple(map, prefix + "TemplateNames.", this.TemplateNames);
            this.SetParamArraySimple(map, prefix + "TemplateIds.", this.TemplateIds);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

