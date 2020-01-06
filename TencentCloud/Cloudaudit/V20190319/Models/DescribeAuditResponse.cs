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

namespace TencentCloud.Cloudaudit.V20190319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAuditResponse : AbstractModel
    {
        
        /// <summary>
        /// 跟踪集名称。
        /// </summary>
        [JsonProperty("AuditName")]
        public string AuditName{ get; set; }

        /// <summary>
        /// 跟踪集状态，1：开启，0：停止。
        /// </summary>
        [JsonProperty("AuditStatus")]
        public long? AuditStatus{ get; set; }

        /// <summary>
        /// 队列名称。
        /// </summary>
        [JsonProperty("CmqQueueName")]
        public string CmqQueueName{ get; set; }

        /// <summary>
        /// 队列所在地域。
        /// </summary>
        [JsonProperty("CmqRegion")]
        public string CmqRegion{ get; set; }

        /// <summary>
        /// cos存储桶名称。
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// cos存储桶所在地域。
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// 是否开启cmq消息通知。1：是，0：否。
        /// </summary>
        [JsonProperty("IsEnableCmqNotify")]
        public long? IsEnableCmqNotify{ get; set; }

        /// <summary>
        /// 日志前缀。
        /// </summary>
        [JsonProperty("LogFilePrefix")]
        public string LogFilePrefix{ get; set; }

        /// <summary>
        /// 管理事件读写属性，1：只读，2：只写，3：全部
        /// </summary>
        [JsonProperty("ReadWriteAttribute")]
        public long? ReadWriteAttribute{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuditName", this.AuditName);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "CmqQueueName", this.CmqQueueName);
            this.SetParamSimple(map, prefix + "CmqRegion", this.CmqRegion);
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "IsEnableCmqNotify", this.IsEnableCmqNotify);
            this.SetParamSimple(map, prefix + "LogFilePrefix", this.LogFilePrefix);
            this.SetParamSimple(map, prefix + "ReadWriteAttribute", this.ReadWriteAttribute);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

