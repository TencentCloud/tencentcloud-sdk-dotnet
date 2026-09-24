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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSlowLogUserHostStatsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID。可通过 <a href="https://cloud.tencent.com/document/api/1130/57798">DescribeDiagDBInstances</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>查询范围的开始时间，格式: &quot;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&quot;。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>查询范围的结束时间，格式: &quot;yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX&quot;。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>服务产品类型，支持值：&quot;mysql&quot; - 云数据库 MySQL；&quot;cynosdb&quot; - 云数据库 TDSQL-C for MySQL，&quot;sqlserver&quot; - 云数据库 SQL Server，默认为&quot;mysql&quot;。</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// <p>SQL模板的MD5值</p>
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }

        /// <summary>
        /// <p>仅Redis产品使用；实例Proxy ID。</p>
        /// </summary>
        [JsonProperty("InstanceProxyId")]
        public string InstanceProxyId{ get; set; }

        /// <summary>
        /// <p>仅Redis产品使用；命令。</p>
        /// </summary>
        [JsonProperty("Cmd")]
        public string Cmd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "Md5", this.Md5);
            this.SetParamSimple(map, prefix + "InstanceProxyId", this.InstanceProxyId);
            this.SetParamSimple(map, prefix + "Cmd", this.Cmd);
        }
    }
}

