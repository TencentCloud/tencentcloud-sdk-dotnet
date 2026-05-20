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

    public class CreateDBDiagReportTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID。可通过 <a href="https://cloud.tencent.com/document/api/1130/57798">DescribeDiagDBInstances</a> 接口获取。TDSQL MySQL数据库类型，实例ID应填写为“实例ID&amp;分片ID”的格式。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>开始时间，如“2020-11-08T14:00:00+08:00”。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间，如“2020-11-09T14:00:00+08:00”。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>是否发送邮件: 0 - 否，1 - 是。</p>
        /// </summary>
        [JsonProperty("SendMailFlag")]
        public long? SendMailFlag{ get; set; }

        /// <summary>
        /// <p>接收邮件的联系人ID数组。</p>
        /// </summary>
        [JsonProperty("ContactPerson")]
        public long?[] ContactPerson{ get; set; }

        /// <summary>
        /// <p>接收邮件的联系组ID数组。</p>
        /// </summary>
        [JsonProperty("ContactGroup")]
        public long?[] ContactGroup{ get; set; }

        /// <summary>
        /// <p>服务产品类型，支持值：&quot;mysql&quot; - 云数据库 MySQL；&quot;cynosdb&quot; - 云数据库 TDSQL-C for MySQL，&quot;redis&quot; - 云数据库 Redis，&quot;mongodb&quot; - 云数据库 MongoDB，&quot;mariadb&quot; - 云数据库 MariaDB，&quot;dcdb&quot; - 云数据库 TDSQL MySQL，默认为&quot;mysql&quot;。</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SendMailFlag", this.SendMailFlag);
            this.SetParamArraySimple(map, prefix + "ContactPerson.", this.ContactPerson);
            this.SetParamArraySimple(map, prefix + "ContactGroup.", this.ContactGroup);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

