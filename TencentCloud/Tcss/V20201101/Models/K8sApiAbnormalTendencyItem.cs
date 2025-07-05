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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class K8sApiAbnormalTendencyItem : AbstractModel
    {
        
        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 异常UA请求事件数
        /// </summary>
        [JsonProperty("ExceptionUARequestCount")]
        public ulong? ExceptionUARequestCount{ get; set; }

        /// <summary>
        /// 匿名用户权限事件数
        /// </summary>
        [JsonProperty("AnonymousUserRightCount")]
        public ulong? AnonymousUserRightCount{ get; set; }

        /// <summary>
        /// 凭据信息获取事件数
        /// </summary>
        [JsonProperty("CredentialInformationObtainCount")]
        public ulong? CredentialInformationObtainCount{ get; set; }

        /// <summary>
        /// 敏感数据挂载事件数
        /// </summary>
        [JsonProperty("SensitiveDataMountCount")]
        public ulong? SensitiveDataMountCount{ get; set; }

        /// <summary>
        /// 命令执行事件数
        /// </summary>
        [JsonProperty("CmdExecCount")]
        public ulong? CmdExecCount{ get; set; }

        /// <summary>
        /// 异常定时任务事件数
        /// </summary>
        [JsonProperty("AbnormalScheduledTaskCount")]
        public ulong? AbnormalScheduledTaskCount{ get; set; }

        /// <summary>
        /// 静态Pod创建数
        /// </summary>
        [JsonProperty("StaticsPodCreateCount")]
        public ulong? StaticsPodCreateCount{ get; set; }

        /// <summary>
        /// 可疑容器创建数
        /// </summary>
        [JsonProperty("DoubtfulContainerCreateCount")]
        public ulong? DoubtfulContainerCreateCount{ get; set; }

        /// <summary>
        /// 自定义规则事件数
        /// </summary>
        [JsonProperty("UserDefinedRuleCount")]
        public ulong? UserDefinedRuleCount{ get; set; }

        /// <summary>
        /// 匿名访问事件数
        /// </summary>
        [JsonProperty("AnonymousAccessCount")]
        public ulong? AnonymousAccessCount{ get; set; }

        /// <summary>
        /// 特权容器事件数
        /// </summary>
        [JsonProperty("PrivilegeContainerCount")]
        public ulong? PrivilegeContainerCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "ExceptionUARequestCount", this.ExceptionUARequestCount);
            this.SetParamSimple(map, prefix + "AnonymousUserRightCount", this.AnonymousUserRightCount);
            this.SetParamSimple(map, prefix + "CredentialInformationObtainCount", this.CredentialInformationObtainCount);
            this.SetParamSimple(map, prefix + "SensitiveDataMountCount", this.SensitiveDataMountCount);
            this.SetParamSimple(map, prefix + "CmdExecCount", this.CmdExecCount);
            this.SetParamSimple(map, prefix + "AbnormalScheduledTaskCount", this.AbnormalScheduledTaskCount);
            this.SetParamSimple(map, prefix + "StaticsPodCreateCount", this.StaticsPodCreateCount);
            this.SetParamSimple(map, prefix + "DoubtfulContainerCreateCount", this.DoubtfulContainerCreateCount);
            this.SetParamSimple(map, prefix + "UserDefinedRuleCount", this.UserDefinedRuleCount);
            this.SetParamSimple(map, prefix + "AnonymousAccessCount", this.AnonymousAccessCount);
            this.SetParamSimple(map, prefix + "PrivilegeContainerCount", this.PrivilegeContainerCount);
        }
    }
}

