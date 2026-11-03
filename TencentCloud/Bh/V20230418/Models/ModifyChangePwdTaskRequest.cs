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

    public class ModifyChangePwdTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>改密任务id</p>
        /// </summary>
        [JsonProperty("OperationId")]
        public string OperationId{ get; set; }

        /// <summary>
        /// <p>改密资产id列表</p>
        /// </summary>
        [JsonProperty("DeviceIdSet")]
        public ulong?[] DeviceIdSet{ get; set; }

        /// <summary>
        /// <p>改密资产的账号列表</p>
        /// </summary>
        [JsonProperty("AccountSet")]
        public string[] AccountSet{ get; set; }

        /// <summary>
        /// <p>修改类型：1：修改任务信息  2：关联任务资产账号</p>
        /// </summary>
        [JsonProperty("ModifyType")]
        public ulong? ModifyType{ get; set; }

        /// <summary>
        /// <p>改密方式。1：使用执行账号修改密码；2：修改自身密码</p>
        /// </summary>
        [JsonProperty("ChangeMethod")]
        public long? ChangeMethod{ get; set; }

        /// <summary>
        /// <p>密码生成方式。 1:自动生成相同密码 2:自动生成不同密码 3:手动指定相同密码</p>
        /// </summary>
        [JsonProperty("AuthGenerationStrategy")]
        public long? AuthGenerationStrategy{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>所属部门ID，&quot;1,2,3&quot;</p>
        /// </summary>
        [JsonProperty("DepartmentId")]
        public string DepartmentId{ get; set; }

        /// <summary>
        /// <p>任务的执行账号</p>
        /// </summary>
        [JsonProperty("RunAccount")]
        public string RunAccount{ get; set; }

        /// <summary>
        /// <p>密码，手动指定密码时必传。</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>密码限制长度，自动生成密码必传。</p>
        /// </summary>
        [JsonProperty("PasswordLength")]
        public long? PasswordLength{ get; set; }

        /// <summary>
        /// <p>密码包含小写字母，0：否，1：是。</p>
        /// </summary>
        [JsonProperty("SmallLetter")]
        public long? SmallLetter{ get; set; }

        /// <summary>
        /// <p>密码包含大写字母，0：否，1：是。</p>
        /// </summary>
        [JsonProperty("BigLetter")]
        public long? BigLetter{ get; set; }

        /// <summary>
        /// <p>密码包含数字，0：否，1：是。</p>
        /// </summary>
        [JsonProperty("Digit")]
        public long? Digit{ get; set; }

        /// <summary>
        /// <p>密码包含的特殊字符（base64编码），包含：^[-_#();%~!+=]*$</p>
        /// </summary>
        [JsonProperty("Symbol")]
        public string Symbol{ get; set; }

        /// <summary>
        /// <p>改密完成通知。0：不通知 1：通知</p>
        /// </summary>
        [JsonProperty("CompleteNotify")]
        public long? CompleteNotify{ get; set; }

        /// <summary>
        /// <p>通知邮箱</p>
        /// </summary>
        [JsonProperty("NotifyEmails")]
        public string[] NotifyEmails{ get; set; }

        /// <summary>
        /// <p>加密压缩文件密码</p>
        /// </summary>
        [JsonProperty("FilePassword")]
        public string FilePassword{ get; set; }

        /// <summary>
        /// <p>任务类型， 4：手工执行  5：周期自动执行</p>
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// <p>周期任务周期，单位天（大于等于 1，小于等于 365）</p>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// <p>周期任务首次执行时间</p>
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

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
        /// <p>改密协议端口号，Linux 改密类型协议端口号需设置为0</p><p>取值范围：[0, 65535]</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OperationId", this.OperationId);
            this.SetParamArraySimple(map, prefix + "DeviceIdSet.", this.DeviceIdSet);
            this.SetParamArraySimple(map, prefix + "AccountSet.", this.AccountSet);
            this.SetParamSimple(map, prefix + "ModifyType", this.ModifyType);
            this.SetParamSimple(map, prefix + "ChangeMethod", this.ChangeMethod);
            this.SetParamSimple(map, prefix + "AuthGenerationStrategy", this.AuthGenerationStrategy);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "DepartmentId", this.DepartmentId);
            this.SetParamSimple(map, prefix + "RunAccount", this.RunAccount);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "PasswordLength", this.PasswordLength);
            this.SetParamSimple(map, prefix + "SmallLetter", this.SmallLetter);
            this.SetParamSimple(map, prefix + "BigLetter", this.BigLetter);
            this.SetParamSimple(map, prefix + "Digit", this.Digit);
            this.SetParamSimple(map, prefix + "Symbol", this.Symbol);
            this.SetParamSimple(map, prefix + "CompleteNotify", this.CompleteNotify);
            this.SetParamArraySimple(map, prefix + "NotifyEmails.", this.NotifyEmails);
            this.SetParamSimple(map, prefix + "FilePassword", this.FilePassword);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
        }
    }
}

