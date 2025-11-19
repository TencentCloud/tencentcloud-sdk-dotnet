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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAuditServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID，格式如：cmgo-xfts****，与云数据库控制台页面中显示的实例 ID 相同。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 审计日志保存时长。单位为：天。当前支持的取值包括： 7： 一周。 30： 一个月。 90： 三个月。 180 ： 六个月。 365 ： 一年。 1095 ： 三年。 1825 ： 五年。
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public long? LogExpireDay{ get; set; }

        /// <summary>
        /// true-全审计，false-规则审计，注意：AuditAll=true 时，RuleFilters 无需填参
        /// </summary>
        [JsonProperty("AuditAll")]
        public bool? AuditAll{ get; set; }

        /// <summary>
        /// 审计过滤规则，Type的范围【SrcIp、DB、Collection、User、SqlType】，注意：Type=SqlType时，Value必须在这个范围 ["query", "insert", "update", "delete", "command"]
        /// </summary>
        [JsonProperty("RuleFilters")]
        public LogFilter[] RuleFilters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "AuditAll", this.AuditAll);
            this.SetParamArrayObj(map, prefix + "RuleFilters.", this.RuleFilters);
        }
    }
}

