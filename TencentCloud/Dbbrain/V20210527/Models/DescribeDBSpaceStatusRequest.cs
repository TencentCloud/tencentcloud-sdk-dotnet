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

    public class DescribeDBSpaceStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID。可通过 <a href="https://cloud.tencent.com/document/api/1130/57798">DescribeDiagDBInstances</a> 接口获取。(备注，dcdb的InstanceId 要求使用 <code>ClusterId&amp;InstanceId</code>代替)</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>时间段天数，截止日期为当日，默认为7天。</p>
        /// </summary>
        [JsonProperty("RangeDays")]
        public long? RangeDays{ get; set; }

        /// <summary>
        /// <p>服务产品类型，支持值包括： &quot;mysql&quot; - 云数据库 MySQL， &quot;cynosdb&quot; - 云数据库 CynosDB  for MySQL，&quot;mongodb&quot; - 云数据库 MongoDB，&quot;dcdb&quot; -（TDSQL MySQL 版）、&quot;mariadb&quot; -（TDSQL MariaDB 版）、&quot;tdstore&quot; - 云数据库TDSQL Boundless，默认为&quot;mysql&quot;。</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RangeDays", this.RangeDays);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

