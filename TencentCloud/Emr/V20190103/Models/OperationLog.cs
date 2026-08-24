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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OperationLog : AbstractModel
    {
        
        /// <summary>
        /// <p>EMR实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public long? InstanceId{ get; set; }

        /// <summary>
        /// <p>操作名称</p>
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// <p>操作类型</p>
        /// </summary>
        [JsonProperty("OperationType")]
        public long? OperationType{ get; set; }

        /// <summary>
        /// <p>用户类型</p>
        /// </summary>
        [JsonProperty("UserType")]
        public long? UserType{ get; set; }

        /// <summary>
        /// <p>操作者</p>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// <p>操作时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>操作对象</p>
        /// </summary>
        [JsonProperty("Operand")]
        public string Operand{ get; set; }

        /// <summary>
        /// <p>操作详情</p>
        /// </summary>
        [JsonProperty("OperationDesc")]
        public string OperationDesc{ get; set; }

        /// <summary>
        /// <p>安全级别</p>
        /// </summary>
        [JsonProperty("SecurityLevel")]
        public string SecurityLevel{ get; set; }

        /// <summary>
        /// <p>操作者名称</p>
        /// </summary>
        [JsonProperty("OperatorName")]
        public string OperatorName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Operand", this.Operand);
            this.SetParamSimple(map, prefix + "OperationDesc", this.OperationDesc);
            this.SetParamSimple(map, prefix + "SecurityLevel", this.SecurityLevel);
            this.SetParamSimple(map, prefix + "OperatorName", this.OperatorName);
        }
    }
}

