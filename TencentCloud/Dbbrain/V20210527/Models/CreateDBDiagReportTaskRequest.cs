/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 开始时间，如“2020-11-08T14:00:00+08:00”。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间，如“2020-11-09T14:00:00+08:00”。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 是否发送邮件: 0 - 否，1 - 是。
        /// </summary>
        [JsonProperty("SendMailFlag")]
        public long? SendMailFlag{ get; set; }

        /// <summary>
        /// 接收邮件的联系人ID数组。
        /// </summary>
        [JsonProperty("ContactPerson")]
        public long?[] ContactPerson{ get; set; }

        /// <summary>
        /// 接收邮件的联系组ID数组。
        /// </summary>
        [JsonProperty("ContactGroup")]
        public long?[] ContactGroup{ get; set; }

        /// <summary>
        /// 服务产品类型，支持值包括： "mysql" - 云数据库 MySQL， "cynosdb" - 云数据库 CynosDB  for MySQL，默认值为"mysql"。
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

