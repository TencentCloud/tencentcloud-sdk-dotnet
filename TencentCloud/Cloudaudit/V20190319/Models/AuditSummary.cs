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

    public class AuditSummary : AbstractModel
    {
        
        /// <summary>
        /// 跟踪集名称
        /// </summary>
        [JsonProperty("AuditName")]
        public string AuditName{ get; set; }

        /// <summary>
        /// 跟踪集状态，1：开启，0：关闭
        /// </summary>
        [JsonProperty("AuditStatus")]
        public long? AuditStatus{ get; set; }

        /// <summary>
        /// COS存储桶名称
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// 日志前缀
        /// </summary>
        [JsonProperty("LogFilePrefix")]
        public string LogFilePrefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuditName", this.AuditName);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "LogFilePrefix", this.LogFilePrefix);
        }
    }
}

