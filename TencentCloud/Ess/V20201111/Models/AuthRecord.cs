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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuthRecord : AbstractModel
    {
        
        /// <summary>
        /// 经办人姓名。
        /// </summary>
        [JsonProperty("OperatorName")]
        public string OperatorName{ get; set; }

        /// <summary>
        /// 经办人手机号。
        /// </summary>
        [JsonProperty("OperatorMobile")]
        public string OperatorMobile{ get; set; }

        /// <summary>
        /// 认证授权方式：
        /// <ul><li> **0**：未选择授权方式（默认值）</li>
        /// <li> **1**：上传授权书</li>
        /// <li> **2**：法人授权</li>
        /// <li> **3**：法人认证</li></ul>
        /// </summary>
        [JsonProperty("AuthType")]
        public long? AuthType{ get; set; }

        /// <summary>
        /// 企业认证授权书审核状态：
        /// <ul><li> **0**：未提交授权书（默认值）</li>
        /// <li> **1**：审核通过</li>
        /// <li> **2**：审核驳回</li>
        /// <li> **3**：审核中</li>
        /// <li> **4**：AI识别中</li>
        /// <li> **5**：客户确认AI信息</li></ul>
        /// </summary>
        [JsonProperty("AuditStatus")]
        public long? AuditStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OperatorName", this.OperatorName);
            this.SetParamSimple(map, prefix + "OperatorMobile", this.OperatorMobile);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
        }
    }
}

