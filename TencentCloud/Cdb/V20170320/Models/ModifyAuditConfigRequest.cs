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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAuditConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。可通过 [DescribeDBInstances](https://cloud.tencent.com/document/product/236/15872) 接口获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 审计日志保存时长。支持值包括：
        /// 7 - 一周
        /// 30 - 一个月；
        /// 180 - 六个月；
        /// 365 - 一年；
        /// 1095 - 三年；
        /// 1825 - 五年；
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public long? LogExpireDay{ get; set; }

        /// <summary>
        /// 是否关闭审计服务。可选值：true - 关闭审计服务；false - 不关闭审计服务。默认值为 false。
        /// 说明：
        /// 1. 当关闭审计服务时，会删除用户的审计日志和文件，并删除该实例的所有审计策略。
        /// 2. CloseAudit、LogExpireDay 必须至少提供一个，如果两个都提供则按照 CloseAudit 优先的逻辑处理。
        /// 3. 可通过设置此参数来关闭审计服务，已关闭后不能通过此接口来开启审计服务。
        /// </summary>
        [JsonProperty("CloseAudit")]
        public bool? CloseAudit{ get; set; }

        /// <summary>
        /// 高频审计日志保存时长。支持值包括：
        /// 7 - 一周
        /// 30 - 一个月；
        /// 180 - 六个月；
        /// 365 - 一年；
        /// 1095 - 三年；
        /// 1825 - 五年；
        /// </summary>
        [JsonProperty("HighLogExpireDay")]
        public long? HighLogExpireDay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "CloseAudit", this.CloseAudit);
            this.SetParamSimple(map, prefix + "HighLogExpireDay", this.HighLogExpireDay);
        }
    }
}

