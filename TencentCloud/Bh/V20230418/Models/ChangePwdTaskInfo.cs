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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChangePwdTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>id</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>任务id</p>
        /// </summary>
        [JsonProperty("OperationId")]
        public string OperationId{ get; set; }

        /// <summary>
        /// <p>任务名</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>所属部门信息</p>
        /// </summary>
        [JsonProperty("Department")]
        public Department Department{ get; set; }

        /// <summary>
        /// <p>改密方式。1：使用执行账号。2：修改自身密码</p>
        /// </summary>
        [JsonProperty("ChangeMethod")]
        public ulong? ChangeMethod{ get; set; }

        /// <summary>
        /// <p>执行账号</p>
        /// </summary>
        [JsonProperty("RunAccount")]
        public string RunAccount{ get; set; }

        /// <summary>
        /// <p>密码生成策略</p>
        /// </summary>
        [JsonProperty("AuthGenerationStrategy")]
        public ulong? AuthGenerationStrategy{ get; set; }

        /// <summary>
        /// <p>密码长度</p>
        /// </summary>
        [JsonProperty("PasswordLength")]
        public ulong? PasswordLength{ get; set; }

        /// <summary>
        /// <p>包含小写字母</p>
        /// </summary>
        [JsonProperty("SmallLetter")]
        public ulong? SmallLetter{ get; set; }

        /// <summary>
        /// <p>包含大写字母</p>
        /// </summary>
        [JsonProperty("BigLetter")]
        public ulong? BigLetter{ get; set; }

        /// <summary>
        /// <p>包含数字</p>
        /// </summary>
        [JsonProperty("Digit")]
        public ulong? Digit{ get; set; }

        /// <summary>
        /// <p>包含的特殊字符，入参base64</p>
        /// </summary>
        [JsonProperty("Symbol")]
        public string Symbol{ get; set; }

        /// <summary>
        /// <p>改密完成通知。0-通知，1-不通知</p>
        /// </summary>
        [JsonProperty("CompleteNotify")]
        public ulong? CompleteNotify{ get; set; }

        /// <summary>
        /// <p>通知人邮箱</p>
        /// </summary>
        [JsonProperty("NotifyEmails")]
        public string[] NotifyEmails{ get; set; }

        /// <summary>
        /// <p>加密附件密码</p>
        /// </summary>
        [JsonProperty("FilePassword")]
        public string FilePassword{ get; set; }

        /// <summary>
        /// <p>需要改密的账户</p>
        /// </summary>
        [JsonProperty("AccountSet")]
        public string[] AccountSet{ get; set; }

        /// <summary>
        /// <p>需要改密的主机</p>
        /// </summary>
        [JsonProperty("DeviceSet")]
        public Device[] DeviceSet{ get; set; }

        /// <summary>
        /// <p>任务类型：4手动，5自动</p>
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// <p>周期</p>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// <p>首次执行时间</p>
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// <p>下次执行时间</p>
        /// </summary>
        [JsonProperty("NextTime")]
        public string NextTime{ get; set; }

        /// <summary>
        /// <p>上次执行时间</p>
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// <p>改密任务状态，0-待执行，1-执行完成，2-执行失败，3-执行中，4-执行超时</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>改密任务类别</p><p>枚举值：</p><ul><li>0： Linux 类型改密任务</li><li>1： Windows 类型改密任务</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("Category")]
        public long? Category{ get; set; }

        /// <summary>
        /// <p>改密任务协议类型</p><p>枚举值：</p><ul><li>0： 未定义，Linux 改密任务类型默认值</li><li>1： Windows OpenSSH 协议</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public long? Protocol{ get; set; }

        /// <summary>
        /// <p>改密协议端口号. Linux 改密协议类型端口号值为0</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "OperationId", this.OperationId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamObj(map, prefix + "Department.", this.Department);
            this.SetParamSimple(map, prefix + "ChangeMethod", this.ChangeMethod);
            this.SetParamSimple(map, prefix + "RunAccount", this.RunAccount);
            this.SetParamSimple(map, prefix + "AuthGenerationStrategy", this.AuthGenerationStrategy);
            this.SetParamSimple(map, prefix + "PasswordLength", this.PasswordLength);
            this.SetParamSimple(map, prefix + "SmallLetter", this.SmallLetter);
            this.SetParamSimple(map, prefix + "BigLetter", this.BigLetter);
            this.SetParamSimple(map, prefix + "Digit", this.Digit);
            this.SetParamSimple(map, prefix + "Symbol", this.Symbol);
            this.SetParamSimple(map, prefix + "CompleteNotify", this.CompleteNotify);
            this.SetParamArraySimple(map, prefix + "NotifyEmails.", this.NotifyEmails);
            this.SetParamSimple(map, prefix + "FilePassword", this.FilePassword);
            this.SetParamArraySimple(map, prefix + "AccountSet.", this.AccountSet);
            this.SetParamArrayObj(map, prefix + "DeviceSet.", this.DeviceSet);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "NextTime", this.NextTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
        }
    }
}

